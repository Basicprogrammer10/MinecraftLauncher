using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Minecraft.Properties;

namespace Minecraft
{
    public partial class MainWindow : Form
    {
        private readonly IniFile Config = new IniFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\connorcode\Minecraft\settings.ini");
        //private readonly IniFile Cache = new IniFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\connorcode\Minecraft\Cache");
        private string PlayerName;

        public MainWindow()
        {
            InitializeComponent();
            if (!Config.KeyExists("setup"))
                IniFile.SetDefaultConfig(Config);
            else
                UpdateVars();
        }

        private void UpdateVars()
        {
            try
            {
                PlayerName = Config.Read("user");
            }
            catch
            {
                MessageBox.Show(@"ERR reading Config File...");
                IniFile.SetDefaultConfig(Config);
            }

            textBox1.Text = PlayerName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DrawApi();
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer(@"V:\Programming\C#\MinecraftLauncher\src\Resources\Intro.wav");
            Player.Play();
        }

        private void ReDrawPlayer()
        {
            var Json = new WebClient().DownloadString("https://api.mojang.com/users/profiles/minecraft/" + PlayerName);

            if (Json == "")
            {
                MessageBox.Show(@"Not a Valid PlayerName :/");
                return;
            }

            var Uuid = JsonParse(Json)[7];
            var Player = JsonParse(Json)[3];

            var Request = WebRequest.Create("https://sessionserver.mojang.com/session/minecraft/profile/" + Uuid);
            var Reader = new StreamReader(Request.GetResponse().GetResponseStream() ?? throw new InvalidOperationException());
            var Data = Reader.ReadToEnd();
            var SkinUri = JsonParse(Base64Decode(JsonParse(Data)[17]))[17];

            Request = WebRequest.Create(SkinUri);

            using (var Response = Request.GetResponse())
            using (var Stream = Response.GetResponseStream())
            {
                player_name.Text = Player;
                player_face.Image = Image.ResizeImage(Image.cropImage(System.Drawing.Image.FromStream(Stream ?? throw new InvalidOperationException()), new Rectangle(8, 8, 8, 8)), 64, 64);
            }
        }

        private void DrawApi()
        {
            var Json = new WebClient().DownloadString("https://status.mojang.com/check");
            if (Json == "")
                return;
            var JsonParsed = JsonParse(Json);

            SetDotColor(JsonParsed, 23, api_dot);
            SetDotColor(JsonParsed, 7, session_dot);
        }

        private static void SetDotColor(IList<string> jsonParsed, int index, PictureBox image)
        {
            switch (jsonParsed[index])
            {
                case "green":
                    image.Image = Resources.green;
                    break;
                case "yellow":
                    image.Image = Resources.yellow;
                    break;
                case "red":
                    image.Image = Resources.red;
                    break;
            }
        }

        private static string[] JsonParse(string json)
        {
            var Split = json.Split('"');

            return Split;
        }

        private static string Base64Decode(string base64EncodedData)
        {
            var Base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(Base64EncodedBytes);
        }

        private void DoClick()
        {
            new System.Media.SoundPlayer(@"V:\Programming\C#\MinecraftLauncher\src\Resources\Click.wav").Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoClick();
            PlayerName = textBox1.Text;
            ReDrawPlayer();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Config.Write("user", PlayerName);
        }
    }
}