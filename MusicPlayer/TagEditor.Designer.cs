namespace MusicPlayer
{
    partial class TagEditor
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
            this.artPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackTitleTextBox = new System.Windows.Forms.TextBox();
            this.artistTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.albumTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.trackNumberTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.genreTextBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.artPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // artPictureBox
            // 
            this.artPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.artPictureBox.Location = new System.Drawing.Point(13, 13);
            this.artPictureBox.Name = "artPictureBox";
            this.artPictureBox.Size = new System.Drawing.Size(200, 200);
            this.artPictureBox.TabIndex = 0;
            this.artPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Track Title: ";
            // 
            // trackTitleTextBox
            // 
            this.trackTitleTextBox.Location = new System.Drawing.Point(290, 34);
            this.trackTitleTextBox.Name = "trackTitleTextBox";
            this.trackTitleTextBox.Size = new System.Drawing.Size(359, 20);
            this.trackTitleTextBox.TabIndex = 1;
            // 
            // artistTextBox
            // 
            this.artistTextBox.Location = new System.Drawing.Point(290, 60);
            this.artistTextBox.Name = "artistTextBox";
            this.artistTextBox.Size = new System.Drawing.Size(359, 20);
            this.artistTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Artist: ";
            // 
            // albumTextBox
            // 
            this.albumTextBox.Location = new System.Drawing.Point(290, 86);
            this.albumTextBox.Name = "albumTextBox";
            this.albumTextBox.Size = new System.Drawing.Size(359, 20);
            this.albumTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Album: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Genre: ";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(290, 138);
            this.yearTextBox.MaxLength = 4;
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(71, 20);
            this.yearTextBox.TabIndex = 5;
            this.yearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Year: ";
            // 
            // trackNumberTextBox
            // 
            this.trackNumberTextBox.Location = new System.Drawing.Point(290, 164);
            this.trackNumberTextBox.MaxLength = 5;
            this.trackNumberTextBox.Name = "trackNumberTextBox";
            this.trackNumberTextBox.Size = new System.Drawing.Size(71, 20);
            this.trackNumberTextBox.TabIndex = 6;
            this.trackNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.trackNumberTextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Track #:";
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(13, 367);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.ReadOnly = true;
            this.filePathTextBox.Size = new System.Drawing.Size(636, 20);
            this.filePathTextBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "File:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MusicPlayer.Properties.Resources.surroundingArt;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 204);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Choose Album Art";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Save Tags";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // genreTextBox
            // 
            this.genreTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.genreTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.genreTextBox.FormattingEnabled = true;
            this.genreTextBox.Items.AddRange(new object[] {
            "Metal",
            "Metalcore",
            "Melodic Death Metal",
            "Death Metal",
            "Deathcore",
            "Black Metal",
            "Djent",
            "Rock",
            "Alternative",
            "Blues",
            "Classical",
            "Country",
            "Dance",
            "Easy Listening",
            "Electronic",
            "Hip Hop",
            "Rap",
            "Pop",
            "Jazz",
            "Latino",
            "New Age",
            "Opera",
            "R&B",
            "Soul",
            "Reggae",
            "Progressive",
            "Progressive Rock",
            "Progressive Metal",
            "Pop Punk",
            "Emo",
            "Post Hardcore",
            "Hardcore/Hardcore Punk",
            "Punk"});
            this.genreTextBox.Location = new System.Drawing.Point(290, 112);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(359, 21);
            this.genreTextBox.TabIndex = 17;
            // 
            // TagEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 399);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.trackNumberTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.albumTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.artistTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackTitleTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.artPictureBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TagEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Tag Editor";
            this.Load += new System.EventHandler(this.TagEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.artPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox artPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox trackTitleTextBox;
        private System.Windows.Forms.TextBox artistTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox albumTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox trackNumberTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox genreTextBox;
    }
}