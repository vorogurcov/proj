namespace GrowingGuys_game
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            buttonOnePlayer = new Button();
            buttonTwoPlayers = new Button();
            buttonOK = new Button();
            diceCube = new PictureBox();
            buttonPlay = new Button();
            picturePlayerTwo = new PictureBox();
            picturePlayerOne = new PictureBox();
            pictureRuler = new PictureBox();
            playerText = new Button();
            playerTwoSc = new Button();
            playerOneSc = new Button();
            ((System.ComponentModel.ISupportInitialize)diceCube).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picturePlayerTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picturePlayerOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureRuler).BeginInit();
            SuspendLayout();
            // 
            // buttonOnePlayer
            // 
            buttonOnePlayer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonOnePlayer.BackColor = Color.FromArgb(255, 224, 192);
            buttonOnePlayer.BackgroundImage = (Image)resources.GetObject("buttonOnePlayer.BackgroundImage");
            buttonOnePlayer.BackgroundImageLayout = ImageLayout.Zoom;
            buttonOnePlayer.Font = new Font("Showcard Gothic", 20F, FontStyle.Bold);
            buttonOnePlayer.Location = new Point(103, 165);
            buttonOnePlayer.Name = "buttonOnePlayer";
            buttonOnePlayer.Size = new Size(250, 330);
            buttonOnePlayer.TabIndex = 0;
            buttonOnePlayer.Text = "Один игрок";
            buttonOnePlayer.TextAlign = ContentAlignment.BottomCenter;
            buttonOnePlayer.TextImageRelation = TextImageRelation.TextAboveImage;
            buttonOnePlayer.UseVisualStyleBackColor = false;
            buttonOnePlayer.Click += buttonOnePlayer_Click;
            // 
            // buttonTwoPlayers
            // 
            buttonTwoPlayers.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonTwoPlayers.BackColor = Color.FromArgb(255, 224, 192);
            buttonTwoPlayers.BackgroundImage = (Image)resources.GetObject("buttonTwoPlayers.BackgroundImage");
            buttonTwoPlayers.BackgroundImageLayout = ImageLayout.Zoom;
            buttonTwoPlayers.Font = new Font("Showcard Gothic", 20F, FontStyle.Bold);
            buttonTwoPlayers.Location = new Point(698, 165);
            buttonTwoPlayers.Name = "buttonTwoPlayers";
            buttonTwoPlayers.Size = new Size(250, 330);
            buttonTwoPlayers.TabIndex = 1;
            buttonTwoPlayers.Text = "Два игрока";
            buttonTwoPlayers.TextAlign = ContentAlignment.BottomCenter;
            buttonTwoPlayers.TextImageRelation = TextImageRelation.TextAboveImage;
            buttonTwoPlayers.UseVisualStyleBackColor = false;
            buttonTwoPlayers.Click += buttonTwoPlayers_Click;
            // 
            // buttonOK
            // 
            buttonOK.BackColor = Color.Red;
            buttonOK.Enabled = false;
            buttonOK.Font = new Font("Showcard Gothic", 20F, FontStyle.Bold);
            buttonOK.Location = new Point(466, 336);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(131, 52);
            buttonOK.TabIndex = 4;
            buttonOK.Text = "УРА!";
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.Visible = false;
            buttonOK.Click += buttonOK_Click;
            // 
            // diceCube
            // 
            diceCube.BackColor = Color.FromArgb(255, 192, 192);
            diceCube.BackgroundImage = (Image)resources.GetObject("diceCube.BackgroundImage");
            diceCube.Enabled = false;
            diceCube.Image = (Image)resources.GetObject("diceCube.Image");
            diceCube.InitialImage = (Image)resources.GetObject("diceCube.InitialImage");
            diceCube.Location = new Point(390, 124);
            diceCube.Name = "diceCube";
            diceCube.Size = new Size(284, 207);
            diceCube.SizeMode = PictureBoxSizeMode.Zoom;
            diceCube.TabIndex = 5;
            diceCube.TabStop = false;
            diceCube.Visible = false;
            // 
            // buttonPlay
            // 
            buttonPlay.BackgroundImage = (Image)resources.GetObject("buttonPlay.BackgroundImage");
            buttonPlay.BackgroundImageLayout = ImageLayout.Stretch;
            buttonPlay.Enabled = false;
            buttonPlay.FlatAppearance.BorderSize = 0;
            buttonPlay.Font = new Font("Showcard Gothic", 20F, FontStyle.Bold);
            buttonPlay.Location = new Point(307, 385);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(439, 130);
            buttonPlay.TabIndex = 2;
            buttonPlay.UseVisualStyleBackColor = true;
            buttonPlay.Visible = false;
            buttonPlay.Click += buttonPlay_Click;
            // 
            // picturePlayerTwo
            // 
            picturePlayerTwo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            picturePlayerTwo.BackgroundImageLayout = ImageLayout.Stretch;
            picturePlayerTwo.Enabled = false;
            picturePlayerTwo.Location = new Point(829, 307);
            picturePlayerTwo.Name = "picturePlayerTwo";
            picturePlayerTwo.Size = new Size(119, 230);
            picturePlayerTwo.SizeMode = PictureBoxSizeMode.StretchImage;
            picturePlayerTwo.TabIndex = 6;
            picturePlayerTwo.TabStop = false;
            picturePlayerTwo.Visible = false;
            // 
            // picturePlayerOne
            // 
            picturePlayerOne.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            picturePlayerOne.BackgroundImageLayout = ImageLayout.Stretch;
            picturePlayerOne.Enabled = false;
            picturePlayerOne.Location = new Point(114, 307);
            picturePlayerOne.Name = "picturePlayerOne";
            picturePlayerOne.Size = new Size(119, 230);
            picturePlayerOne.SizeMode = PictureBoxSizeMode.StretchImage;
            picturePlayerOne.TabIndex = 7;
            picturePlayerOne.TabStop = false;
            picturePlayerOne.Visible = false;
            // 
            // pictureRuler
            // 
            pictureRuler.BackColor = SystemColors.AppWorkspace;
            pictureRuler.BackgroundImage = (Image)resources.GetObject("pictureRuler.BackgroundImage");
            pictureRuler.Enabled = false;
            pictureRuler.Image = (Image)resources.GetObject("pictureRuler.Image");
            pictureRuler.Location = new Point(6, 94);
            pictureRuler.Name = "pictureRuler";
            pictureRuler.Size = new Size(178, 443);
            pictureRuler.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureRuler.TabIndex = 8;
            pictureRuler.TabStop = false;
            pictureRuler.Visible = false;
            // 
            // playerText
            // 
            playerText.BackgroundImage = (Image)resources.GetObject("playerText.BackgroundImage");
            playerText.Enabled = false;
            playerText.FlatAppearance.BorderSize = 0;
            playerText.FlatStyle = FlatStyle.Flat;
            playerText.Font = new Font("Showcard Gothic", 16F, FontStyle.Bold);
            playerText.ForeColor = Color.Black;
            playerText.Location = new Point(390, 35);
            playerText.Name = "playerText";
            playerText.Size = new Size(286, 80);
            playerText.TabIndex = 9;
            playerText.UseVisualStyleBackColor = true;
            playerText.Click += playerText_Click;
            // 
            // playerTwoSc
            // 
            playerTwoSc.BackColor = SystemColors.Control;
            playerTwoSc.BackgroundImage = (Image)resources.GetObject("playerTwoSc.BackgroundImage");
            playerTwoSc.Enabled = false;
            playerTwoSc.FlatAppearance.BorderSize = 0;
            playerTwoSc.FlatStyle = FlatStyle.Flat;
            playerTwoSc.Font = new Font("Showcard Gothic", 20F, FontStyle.Bold);
            playerTwoSc.Location = new Point(671, 46);
            playerTwoSc.Name = "playerTwoSc";
            playerTwoSc.Size = new Size(121, 59);
            playerTwoSc.TabIndex = 11;
            playerTwoSc.UseVisualStyleBackColor = false;
            playerTwoSc.Visible = false;
            // 
            // playerOneSc
            // 
            playerOneSc.BackgroundImage = (Image)resources.GetObject("playerOneSc.BackgroundImage");
            playerOneSc.Enabled = false;
            playerOneSc.FlatAppearance.BorderSize = 0;
            playerOneSc.FlatStyle = FlatStyle.Flat;
            playerOneSc.Font = new Font("Showcard Gothic", 20F, FontStyle.Bold);
            playerOneSc.Location = new Point(272, 43);
            playerOneSc.Name = "playerOneSc";
            playerOneSc.Size = new Size(121, 59);
            playerOneSc.TabIndex = 10;
            playerOneSc.UseVisualStyleBackColor = true;
            playerOneSc.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1047, 553);
            Controls.Add(playerTwoSc);
            Controls.Add(playerOneSc);
            Controls.Add(playerText);
            Controls.Add(picturePlayerOne);
            Controls.Add(picturePlayerTwo);
            Controls.Add(pictureRuler);
            Controls.Add(diceCube);
            Controls.Add(buttonOK);
            Controls.Add(buttonPlay);
            Controls.Add(buttonTwoPlayers);
            Controls.Add(buttonOnePlayer);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MinimumSize = new Size(1000, 600);
            Name = "MainForm";
            Text = "MainForm";
            Resize += MainForm_Resize;
            ((System.ComponentModel.ISupportInitialize)diceCube).EndInit();
            ((System.ComponentModel.ISupportInitialize)picturePlayerTwo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picturePlayerOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureRuler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOnePlayer;
        private Button buttonTwoPlayers;
        private Button buttonOK;
        private PictureBox diceCube;
        private Button buttonPlay;
        private PictureBox picturePlayerTwo;
        private PictureBox picturePlayerOne;
        private PictureBox pictureRuler;
        private Button playerText;
        private Button playerTwoSc;
        private Button playerOneSc;
    }
}
