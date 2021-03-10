﻿using System;
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
        private string PlayerName;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DrawApi();
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

        private void button1_Click(object sender, EventArgs e)
        {
            PlayerName = textBox1.Text;
            ReDrawPlayer();
        }
    }
}