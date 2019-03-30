using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mario64Randomizer
{
    public partial class randomizeForm : Form
    {
        ROMManager rm;
        int seed = 0;

        public randomizeForm()
        {
            InitializeComponent();
        }

        public randomizeForm(int seed)
        {
            InitializeComponent();
            this.seed = seed;
        }

        public void Shuffle<T>(IList<T> list, int seed)
        {
            var rng = new Random(seed);
            int n = list.Count;

            for (int i = n; i > 1; i--)
            {
                int pos = rng.Next(i);
                var x = list[i - 1];
                list[i - 1] = list[pos];
                list[pos] = x;
            }
        }

        private void btnOpenRom_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "ROM Files (*.z64)|*.z64";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    rm = new ROMManager(openFileDialog.FileName, "behaviour.txt");
                    MessageBox.Show("Your ROM was loaded!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (IOException)
                {
                    MessageBox.Show("Failed to load!", "-_-", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            if (chkRandomizeMusic.Checked)
            {
                rm.randomizeMusic();
                MessageBox.Show("Music Randomized", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if (chkRandomizeWarps.Checked)
            {
                List<byte[]> warps = rm.getDestinations();
                this.Shuffle(warps, seed);
                rm.writeDestinations(warps);
                MessageBox.Show("Warps Randomized", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }            
        }
    }
}
