using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utility.ModifyRegistry;

namespace MusicPlayer
{
    public partial class InitialMusicPicking : Form
    {
        Classes.TagHandling tg = new Classes.TagHandling();
        ModifyRegistry mr = new ModifyRegistry();
        string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic).ToString();


        public InitialMusicPicking()
        {
            InitializeComponent();
        }

        private void InitialMusicPicking_Load(object sender, EventArgs e)
        {
           
            dir.Text = directory;
            //populateListView(directory);
        }
        public void populateListView(string directoryToSearch)
        {

            string artistTitle = null;
            string albumTitle = null;
            string songTitle = null;
            string genre = null;
            string fileNameConverted = null;

            DirectoryInfo dinfo = new DirectoryInfo(directoryToSearch);

            FileInfo[] Files = dinfo.GetFiles("*.mp3", SearchOption.AllDirectories);

            ListViewItem lvi = new ListViewItem();

            foreach (FileInfo file in Files)
            {
                string s = file.Name.ToString();
                char[] arr = s.ToCharArray();

                fileNameConverted = file.FullName.ToString();

                try
                {
                    artistTitle = tg.getArtistTitle(fileNameConverted.ToString()).ToString();

                    albumTitle = tg.getAlbumTitle(fileNameConverted.ToString()).ToString();

                    songTitle = tg.getSongTitle(fileNameConverted.ToString()).ToString();

                    genre = tg.getGenreString(fileNameConverted.ToString()).ToString();
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine(ex.Message + "when trying to get " + fileNameConverted);
                }



                lvi = new ListViewItem();

                lvi.Text = artistTitle;
                lvi.SubItems.Add(albumTitle);
                lvi.SubItems.Add(songTitle);
                lvi.SubItems.Add(genre);
                lvi.SubItems.Add(fileNameConverted);


                this.listView1.Items.Add(lvi);
            }
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].Checked = true;
            }

        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Set the ListViewItemSorter property to a new ListViewItemComparer
            // object.
            this.listView1.ListViewItemSorter = new ListViewItemComparer(e.Column);
            // Call the sort method to manually sort.
            listView1.Sort();
        }

        class ListViewItemComparer : IComparer
        {
            private int col;
            public ListViewItemComparer()
            {
                col = 0;
            }
            public ListViewItemComparer(int column)
            {
                col = column;
            }
            public int Compare(object x, object y)
            {
                int returnVal = -1;
                returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
                ((ListViewItem)y).SubItems[col].Text);
                return returnVal;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            
            if(fb.ShowDialog() == DialogResult.OK)
            {
                directory = fb.SelectedPath;
                dir.Text = directory;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            populateListView(directory);
        }

        public MainForm MainForm
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            foreach(ListViewItem item in this.listView1.Items)
            {
                if (item.Checked == true)
                {
                    mf.listView1.Items.Add((ListViewItem)item.Clone());
                }
            }
            mr.Write("HASSETUP", "true");


            mf.Show();
            this.Hide();
        }
    }
}
