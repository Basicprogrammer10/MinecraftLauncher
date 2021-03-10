
namespace Minecraft
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.api_label = new System.Windows.Forms.Label();
            this.session_label = new System.Windows.Forms.Label();
            this.session_dot = new System.Windows.Forms.PictureBox();
            this.api_dot = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.player_name = new System.Windows.Forms.Label();
            this.player_face = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sigma_logo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.version_box = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.session_dot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.api_dot)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player_face)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sigma_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(59)))), ((int)(((byte)(73)))));
            this.panel4.Controls.Add(this.api_label);
            this.panel4.Controls.Add(this.session_label);
            this.panel4.Controls.Add(this.session_dot);
            this.panel4.Controls.Add(this.api_dot);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 375);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 75);
            this.panel4.TabIndex = 2;
            // 
            // api_label
            // 
            this.api_label.AutoSize = true;
            this.api_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.api_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.api_label.Location = new System.Drawing.Point(34, 15);
            this.api_label.Name = "api_label";
            this.api_label.Size = new System.Drawing.Size(35, 20);
            this.api_label.TabIndex = 1;
            this.api_label.Text = "API";
            // 
            // session_label
            // 
            this.session_label.AutoSize = true;
            this.session_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.session_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.session_label.Location = new System.Drawing.Point(33, 46);
            this.session_label.Name = "session_label";
            this.session_label.Size = new System.Drawing.Size(66, 20);
            this.session_label.TabIndex = 1;
            this.session_label.Text = "Session";
            // 
            // session_dot
            // 
            this.session_dot.Image = global::Minecraft.Properties.Resources.red;
            this.session_dot.Location = new System.Drawing.Point(12, 48);
            this.session_dot.Name = "session_dot";
            this.session_dot.Size = new System.Drawing.Size(15, 15);
            this.session_dot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.session_dot.TabIndex = 0;
            this.session_dot.TabStop = false;
            // 
            // api_dot
            // 
            this.api_dot.Image = global::Minecraft.Properties.Resources.red;
            this.api_dot.Location = new System.Drawing.Point(12, 17);
            this.api_dot.Name = "api_dot";
            this.api_dot.Size = new System.Drawing.Size(15, 15);
            this.api_dot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.api_dot.TabIndex = 0;
            this.api_dot.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.player_name);
            this.panel2.Controls.Add(this.player_face);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 75);
            this.panel2.TabIndex = 1;
            // 
            // player_name
            // 
            this.player_name.AutoSize = true;
            this.player_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.player_name.Location = new System.Drawing.Point(69, 25);
            this.player_name.Name = "player_name";
            this.player_name.Size = new System.Drawing.Size(0, 25);
            this.player_name.TabIndex = 1;
            // 
            // player_face
            // 
            this.player_face.Image = global::Minecraft.Properties.Resources.blank_avatar_icon_15;
            this.player_face.Location = new System.Drawing.Point(12, 12);
            this.player_face.Name = "player_face";
            this.player_face.Size = new System.Drawing.Size(50, 50);
            this.player_face.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player_face.TabIndex = 0;
            this.player_face.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel3.Controls.Add(this.version_box);
            this.panel3.Controls.Add(this.sigma_logo);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(225, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(575, 450);
            this.panel3.TabIndex = 2;
            // 
            // sigma_logo
            // 
            this.sigma_logo.Image = global::Minecraft.Properties.Resources.SigmaLogo;
            this.sigma_logo.Location = new System.Drawing.Point(513, 388);
            this.sigma_logo.Name = "sigma_logo";
            this.sigma_logo.Size = new System.Drawing.Size(50, 50);
            this.sigma_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sigma_logo.TabIndex = 2;
            this.sigma_logo.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 240);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // version_box
            // 
            this.version_box.FormattingEnabled = true;
            this.version_box.Location = new System.Drawing.Point(319, 240);
            this.version_box.Name = "version_box";
            this.version_box.Size = new System.Drawing.Size(121, 21);
            this.version_box.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sigma\'s Minecraft Lancher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.session_dot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.api_dot)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player_face)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sigma_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox player_face;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label player_name;
        private System.Windows.Forms.PictureBox sigma_logo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox api_dot;
        private System.Windows.Forms.PictureBox session_dot;
        private System.Windows.Forms.Label session_label;
        private System.Windows.Forms.Label api_label;
        private System.Windows.Forms.ComboBox version_box;
    }
}

