namespace MusicPlayer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.playListView = new MusicPlayer.Classes.NoDoubleClickAutoCheckListview();
            this.plSong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.plFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editTagsForTrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.populate_bw = new System.ComponentModel.BackgroundWorker();
            this.updateTrackBar_bw = new System.ComponentModel.BackgroundWorker();
            this.timerSong = new System.Windows.Forms.Timer(this.components);
            this.notifierIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCurTime = new System.Windows.Forms.Label();
            this.labelTotalTime = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.albumArt = new System.Windows.Forms.PictureBox();
            this.artistPlayingLabel = new System.Windows.Forms.Label();
            this.albumTitleLabel = new System.Windows.Forms.Label();
            this.songTitleLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewContext = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.previousButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.listViewContextStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumArt)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1029, 549);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1021, 523);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All Music";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1015, 517);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Artist";
            this.columnHeader1.Width = 147;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Album";
            this.columnHeader2.Width = 183;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Song Title";
            this.columnHeader3.Width = 306;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Genre";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "File Name";
            this.columnHeader5.Width = 289;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.playListView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1021, 523);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Playlist";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // playListView
            // 
            this.playListView.CheckBoxes = true;
            this.playListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.plSong,
            this.plFile});
            this.playListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playListView.FullRowSelect = true;
            this.playListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.playListView.Location = new System.Drawing.Point(3, 3);
            this.playListView.MultiSelect = false;
            this.playListView.Name = "playListView";
            this.playListView.Size = new System.Drawing.Size(1015, 517);
            this.playListView.TabIndex = 0;
            this.playListView.UseCompatibleStateImageBehavior = false;
            this.playListView.View = System.Windows.Forms.View.Details;
            // 
            // plSong
            // 
            this.plSong.Text = "Song";
            this.plSong.Width = 272;
            // 
            // plFile
            // 
            this.plFile.Text = "File Name";
            this.plFile.Width = 737;
            // 
            // listViewContextStrip
            // 
            this.listViewContextStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTagsForTrackToolStripMenuItem});
            this.listViewContextStrip.Name = "listViewContextStrip";
            this.listViewContextStrip.Size = new System.Drawing.Size(173, 26);
            // 
            // editTagsForTrackToolStripMenuItem
            // 
            this.editTagsForTrackToolStripMenuItem.Name = "editTagsForTrackToolStripMenuItem";
            this.editTagsForTrackToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.editTagsForTrackToolStripMenuItem.Text = "Edit Tags for Track";
            this.editTagsForTrackToolStripMenuItem.Click += new System.EventHandler(this.editTagsForTrackToolStripMenuItem_Click);
            // 
            // populate_bw
            // 
            this.populate_bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // timerSong
            // 
            this.timerSong.Interval = 10;
            // 
            // notifierIcon
            // 
            this.notifierIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifierIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifierIcon.Icon")));
            this.notifierIcon.Text = "Music Player";
            this.notifierIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifierIcon_MouseClick);
            this.notifierIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifierIcon_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.forwardButton);
            this.panel1.Controls.Add(this.previousButton);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelCurTime);
            this.panel1.Controls.Add(this.labelTotalTime);
            this.panel1.Controls.Add(this.trackBar);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.albumArt);
            this.panel1.Controls.Add(this.artistPlayingLabel);
            this.panel1.Controls.Add(this.albumTitleLabel);
            this.panel1.Controls.Add(this.songTitleLabel);
            this.panel1.Controls.Add(this.playButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 548);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 84);
            this.panel1.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(868, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Pop from xml";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(721, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "/";
            // 
            // labelCurTime
            // 
            this.labelCurTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurTime.AutoSize = true;
            this.labelCurTime.Location = new System.Drawing.Point(683, 13);
            this.labelCurTime.Name = "labelCurTime";
            this.labelCurTime.Size = new System.Drawing.Size(34, 13);
            this.labelCurTime.TabIndex = 11;
            this.labelCurTime.Text = "00:00";
            // 
            // labelTotalTime
            // 
            this.labelTotalTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalTime.AutoSize = true;
            this.labelTotalTime.Location = new System.Drawing.Point(735, 13);
            this.labelTotalTime.Name = "labelTotalTime";
            this.labelTotalTime.Size = new System.Drawing.Size(34, 13);
            this.labelTotalTime.TabIndex = 10;
            this.labelTotalTime.Text = "00:00";
            // 
            // trackBar
            // 
            this.trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar.LargeChange = 10;
            this.trackBar.Location = new System.Drawing.Point(546, 29);
            this.trackBar.Maximum = 100;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(316, 45);
            this.trackBar.TabIndex = 9;
            this.trackBar.TickFrequency = 5;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(868, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Test Save";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(949, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Pop from dir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // albumArt
            // 
            this.albumArt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.albumArt.Location = new System.Drawing.Point(459, 1);
            this.albumArt.Name = "albumArt";
            this.albumArt.Size = new System.Drawing.Size(80, 80);
            this.albumArt.TabIndex = 6;
            this.albumArt.TabStop = false;
            // 
            // artistPlayingLabel
            // 
            this.artistPlayingLabel.AutoSize = true;
            this.artistPlayingLabel.Location = new System.Drawing.Point(211, 29);
            this.artistPlayingLabel.Name = "artistPlayingLabel";
            this.artistPlayingLabel.Size = new System.Drawing.Size(19, 13);
            this.artistPlayingLabel.TabIndex = 4;
            this.artistPlayingLabel.Text = "ap";
            // 
            // albumTitleLabel
            // 
            this.albumTitleLabel.AutoSize = true;
            this.albumTitleLabel.Location = new System.Drawing.Point(211, 42);
            this.albumTitleLabel.Name = "albumTitleLabel";
            this.albumTitleLabel.Size = new System.Drawing.Size(19, 13);
            this.albumTitleLabel.TabIndex = 3;
            this.albumTitleLabel.Text = "ap";
            // 
            // songTitleLabel
            // 
            this.songTitleLabel.AutoSize = true;
            this.songTitleLabel.Location = new System.Drawing.Point(211, 16);
            this.songTitleLabel.Name = "songTitleLabel";
            this.songTitleLabel.Size = new System.Drawing.Size(19, 13);
            this.songTitleLabel.TabIndex = 2;
            this.songTitleLabel.Text = "ap";
            // 
            // playButton
            // 
            this.playButton.Enabled = false;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(69, 29);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(77, 42);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Pause";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(949, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Choose File";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listViewContext
            // 
            this.listViewContext.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Edit Tags for Selected Track";
            this.menuItem1.Click += new System.EventHandler(this.editTagsForTrackToolStripMenuItem_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2});
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3});
            this.menuItem2.Text = "File";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.Text = "Exit";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(12, 40);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(51, 23);
            this.previousButton.TabIndex = 14;
            this.previousButton.Text = "<-";
            this.previousButton.UseVisualStyleBackColor = true;
            // 
            // forwardButton
            // 
            this.forwardButton.Location = new System.Drawing.Point(152, 40);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(51, 23);
            this.forwardButton.TabIndex = 15;
            this.forwardButton.Text = "->";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 632);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Menu = this.mainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.listViewContextStrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumArt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.ComponentModel.BackgroundWorker populate_bw;
        private System.ComponentModel.BackgroundWorker updateTrackBar_bw;
        private System.Windows.Forms.Timer timerSong;
        private System.Windows.Forms.ContextMenuStrip listViewContextStrip;
        private System.Windows.Forms.ToolStripMenuItem editTagsForTrackToolStripMenuItem;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.NotifyIcon notifierIcon;
        //private System.Windows.Forms.ListView playListView;
        private Classes.NoDoubleClickAutoCheckListview playListView;
        private System.Windows.Forms.ColumnHeader plSong;
        private System.Windows.Forms.ColumnHeader plFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCurTime;
        private System.Windows.Forms.Label labelTotalTime;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox albumArt;
        private System.Windows.Forms.Label artistPlayingLabel;
        private System.Windows.Forms.Label albumTitleLabel;
        private System.Windows.Forms.Label songTitleLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenu listViewContext;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button previousButton;
    }
}

