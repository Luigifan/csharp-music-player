namespace MusicPlayer
{
    partial class notifyIcon_widget
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.songTitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updatePlayPause = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pause";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // songTitleLabel
            // 
            this.songTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.songTitleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.songTitleLabel.Location = new System.Drawing.Point(0, -1);
            this.songTitleLabel.Name = "songTitleLabel";
            this.songTitleLabel.Size = new System.Drawing.Size(302, 23);
            this.songTitleLabel.TabIndex = 1;
            this.songTitleLabel.Text = "song";
            this.songTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "artist";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updatePlayPause
            // 
            this.updatePlayPause.Enabled = true;
            this.updatePlayPause.Interval = 1000;
            this.updatePlayPause.Tick += new System.EventHandler(this.updatePlayPause_Tick);
            // 
            // notifyIcon_widget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MusicPlayer.Properties.Resources.chelsea_grin_desolation_eden_12494881;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(298, 81);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.songTitleLabel);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "notifyIcon_widget";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.notifyIcon_widget_Deactivate);
            this.Load += new System.EventHandler(this.notifyIcon_widget_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label songTitleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer updatePlayPause;
        public System.Windows.Forms.Button button1;
    }
}