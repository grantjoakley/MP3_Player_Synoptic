namespace MP3Player
{
    partial class InterfaceForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeApplicationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearPlaylistButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.playlist = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.albumLabel = new System.Windows.Forms.Label();
            this.openMusic = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.shuffleButton = new System.Windows.Forms.Button();
            this.skipBackwardsButton = new System.Windows.Forms.Button();
            this.skipForwardButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.closeApplicationButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 103);
            this.panel1.TabIndex = 0;
            // 
            // closeApplicationButton
            // 
            this.closeApplicationButton.FlatAppearance.BorderSize = 0;
            this.closeApplicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeApplicationButton.Location = new System.Drawing.Point(527, 0);
            this.closeApplicationButton.Name = "closeApplicationButton";
            this.closeApplicationButton.Size = new System.Drawing.Size(124, 103);
            this.closeApplicationButton.TabIndex = 18;
            this.closeApplicationButton.Text = "X";
            this.closeApplicationButton.UseVisualStyleBackColor = true;
            this.closeApplicationButton.Click += new System.EventHandler(this.closeApplicationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "MP3 Player";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.shuffleButton);
            this.groupBox1.Controls.Add(this.skipBackwardsButton);
            this.groupBox1.Controls.Add(this.skipForwardButton);
            this.groupBox1.Controls.Add(this.pauseButton);
            this.groupBox1.Location = new System.Drawing.Point(0, 388);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 198);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.saveButton);
            this.groupBox2.Controls.Add(this.clearPlaylistButton);
            this.groupBox2.Controls.Add(this.loadButton);
            this.groupBox2.Controls.Add(this.openMusic);
            this.groupBox2.Location = new System.Drawing.Point(405, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 240);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Playlist";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveButton.Location = new System.Drawing.Point(107, 118);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(112, 35);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearPlaylistButton
            // 
            this.clearPlaylistButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clearPlaylistButton.Location = new System.Drawing.Point(107, 163);
            this.clearPlaylistButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearPlaylistButton.Name = "clearPlaylistButton";
            this.clearPlaylistButton.Size = new System.Drawing.Size(112, 35);
            this.clearPlaylistButton.TabIndex = 16;
            this.clearPlaylistButton.Text = "Clear";
            this.clearPlaylistButton.UseVisualStyleBackColor = false;
            this.clearPlaylistButton.Click += new System.EventHandler(this.clearPlaylistButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loadButton.Location = new System.Drawing.Point(107, 73);
            this.loadButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(112, 35);
            this.loadButton.TabIndex = 14;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // playlist
            // 
            this.playlist.FormattingEnabled = true;
            this.playlist.HorizontalScrollbar = true;
            this.playlist.ItemHeight = 28;
            this.playlist.Location = new System.Drawing.Point(282, 371);
            this.playlist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playlist.Name = "playlist";
            this.playlist.Size = new System.Drawing.Size(342, 200);
            this.playlist.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "label";
            this.label2.Visible = false;
            // 
            // albumLabel
            // 
            this.albumLabel.AutoSize = true;
            this.albumLabel.Location = new System.Drawing.Point(17, 196);
            this.albumLabel.Name = "albumLabel";
            this.albumLabel.Size = new System.Drawing.Size(0, 28);
            this.albumLabel.TabIndex = 19;
            // 
            // openMusic
            // 
            this.openMusic.FlatAppearance.BorderSize = 0;
            this.openMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openMusic.Image = global::MP3Player.Properties.Resources.opened_folder_40px;
            this.openMusic.Location = new System.Drawing.Point(18, 108);
            this.openMusic.Name = "openMusic";
            this.openMusic.Size = new System.Drawing.Size(46, 45);
            this.openMusic.TabIndex = 13;
            this.openMusic.UseVisualStyleBackColor = true;
            this.openMusic.Click += new System.EventHandler(this.openMusic_Click);
            // 
            // playButton
            // 
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Image = global::MP3Player.Properties.Resources.play_40px;
            this.playButton.Location = new System.Drawing.Point(29, 452);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(46, 45);
            this.playButton.TabIndex = 7;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Image = global::MP3Player.Properties.Resources.stop_40px;
            this.stopButton.Location = new System.Drawing.Point(133, 452);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(46, 45);
            this.stopButton.TabIndex = 6;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // shuffleButton
            // 
            this.shuffleButton.FlatAppearance.BorderSize = 0;
            this.shuffleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shuffleButton.Image = global::MP3Player.Properties.Resources.shuffle_40px;
            this.shuffleButton.Location = new System.Drawing.Point(133, 115);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(46, 45);
            this.shuffleButton.TabIndex = 11;
            this.shuffleButton.UseVisualStyleBackColor = true;
            this.shuffleButton.Click += new System.EventHandler(this.shuffleButton_Click);
            // 
            // skipBackwardsButton
            // 
            this.skipBackwardsButton.FlatAppearance.BorderSize = 0;
            this.skipBackwardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skipBackwardsButton.Image = global::MP3Player.Properties.Resources.skip_to_start_40px;
            this.skipBackwardsButton.Location = new System.Drawing.Point(29, 115);
            this.skipBackwardsButton.Name = "skipBackwardsButton";
            this.skipBackwardsButton.Size = new System.Drawing.Size(46, 45);
            this.skipBackwardsButton.TabIndex = 10;
            this.skipBackwardsButton.UseVisualStyleBackColor = true;
            this.skipBackwardsButton.Click += new System.EventHandler(this.skipBackwardsButton_Click);
            // 
            // skipForwardButton
            // 
            this.skipForwardButton.FlatAppearance.BorderSize = 0;
            this.skipForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skipForwardButton.Image = global::MP3Player.Properties.Resources.end_40px;
            this.skipForwardButton.Location = new System.Drawing.Point(81, 115);
            this.skipForwardButton.Name = "skipForwardButton";
            this.skipForwardButton.Size = new System.Drawing.Size(46, 45);
            this.skipForwardButton.TabIndex = 9;
            this.skipForwardButton.UseVisualStyleBackColor = true;
            this.skipForwardButton.Click += new System.EventHandler(this.skipForwardButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.FlatAppearance.BorderSize = 0;
            this.pauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseButton.Image = global::MP3Player.Properties.Resources.pause_40px;
            this.pauseButton.Location = new System.Drawing.Point(81, 64);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(46, 45);
            this.pauseButton.TabIndex = 8;
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // InterfaceForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(651, 585);
            this.Controls.Add(this.albumLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playlist);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterfaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button skipForwardButton;
        private System.Windows.Forms.Button skipBackwardsButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button clearPlaylistButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button openMusic;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListBox playlist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label albumLabel;
        private System.Windows.Forms.Button closeApplicationButton;
        private System.Windows.Forms.Button shuffleButton;
    }
}

