using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mario64Randomizer.SM64;
using Mario64Randomizer.Parsers;
using System.IO;

namespace Mario64Randomizer
{
    public partial class BehaviourForm : Form
    {
        private int type = 0;
        ROM rm;
        private string romName;
        public List<int> warpingBehaviours;
        public List<int> targetWarpBehaviours;
        public List<string> behavioursWithNames;
        public List<string> groundedBehavioursWithNames;
        public List<string> warpBehavioursWithNames;
        public List<string> removeAddresses;

        public BehaviourForm()
        {
            InitializeComponent();
        }

        public BehaviourForm(int type, List<string> list)
        {
            InitializeComponent();
            this.type = type;
            btnRestoreBehaviours.PerformClick();
            switch (this.type)
            {
                case 0:
                    this.Text = "Edit Non Grounded Behaviours";
                    behavioursWithNames = list;
                    lBehaviours.DataSource = behavioursWithNames;
                break;
                case 1:
                    this.Text = "Edit Grounded Behaviours";
                    groundedBehavioursWithNames = list;
                    lBehaviours.DataSource = groundedBehavioursWithNames;
                break;
                case 2:
                    this.Text = "Edit Warp Behaviours";
                    warpBehavioursWithNames = list;
                    lBehaviours.DataSource = warpBehavioursWithNames;
                break;
                case 3:
                    this.Text = "Remove Object Address";
                    if(list.Count > 0)
                    {
                        removeAddresses = list;
                        lBehaviours.DataSource = removeAddresses;
                    }
                    else
                    {
                        removeAddresses = new List<string>();
                    }
                break;
            }
        }

        private void btnRestoreBehaviours_Click(object sender, EventArgs e)
        {
            switch(type)
            {
                case 0:
                    behavioursWithNames = Properties.Resources.notGrounded.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    SM64.Object.SetNonGroundedBehaviours(behavioursWithNames);
                    lBehaviours.DataSource = behavioursWithNames;
                break;
                case 1:
                    groundedBehavioursWithNames = Properties.Resources.groundedBehaviours.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    SM64.Object.SetNonGroundedBehaviours(groundedBehavioursWithNames);
                    lBehaviours.DataSource = groundedBehavioursWithNames;
                break;
                case 2:
                    warpBehavioursWithNames = Properties.Resources.warpBehaviours.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    SM64.Object.SetNonGroundedBehaviours(warpBehavioursWithNames);
                    lBehaviours.DataSource = warpBehavioursWithNames;
                break;
                case 3:
                    removeAddresses = new List<string>();
                break;
            }
        }

        private void btnRemoveBehaviour_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case 0:
                    if (lBehaviours.Items.Count > 0)
                    {
                        behavioursWithNames.RemoveAt(lBehaviours.SelectedIndex);
                        lBehaviours.DataSource = null;
                        lBehaviours.DataSource = behavioursWithNames;
                        lBehaviours.SelectedIndex = 0;
                    }
                break;
                case 1:
                    if (lBehaviours.Items.Count > 0)
                    {
                        groundedBehavioursWithNames.RemoveAt(lBehaviours.SelectedIndex);
                        lBehaviours.DataSource = null;
                        lBehaviours.DataSource = groundedBehavioursWithNames;
                        lBehaviours.SelectedIndex = 0;
                    }
                    break;
                case 2:
                    if (lBehaviours.Items.Count > 0)
                    {
                        warpBehavioursWithNames.RemoveAt(lBehaviours.SelectedIndex);
                        lBehaviours.DataSource = null;
                        lBehaviours.DataSource = warpBehavioursWithNames;
                        lBehaviours.SelectedIndex = 0;
                    }
                break;
                case 3:
                    if (lBehaviours.Items.Count > 0)
                    {
                        removeAddresses.RemoveAt(lBehaviours.SelectedIndex);
                        lBehaviours.DataSource = null;
                        lBehaviours.DataSource = removeAddresses;
                        lBehaviours.SelectedIndex = 0;
                    }
               break;
            }
        }

        private void btnAddBehaviour_Click(object sender, EventArgs e)
        {
            if(txtNewBehaviour.Text != string.Empty)
            {
                switch (type)
                {
                    case 0:
                        behavioursWithNames.Add(txtNewBehaviour.Text);
                        lBehaviours.DataSource = null;
                        lBehaviours.DataSource = behavioursWithNames;
                    break;
                    case 1:
                        groundedBehavioursWithNames.Add(txtNewBehaviour.Text);
                        lBehaviours.DataSource = null;
                        lBehaviours.DataSource = groundedBehavioursWithNames;
                    break;
                    case 2:
                        warpBehavioursWithNames.Add(txtNewBehaviour.Text);
                        lBehaviours.DataSource = null;
                        lBehaviours.DataSource = warpBehavioursWithNames;
                    break;
                    case 3:
                        removeAddresses.Add(txtNewBehaviour.Text);
                        lBehaviours.DataSource = null;
                        lBehaviours.DataSource = removeAddresses;
                    break;
                }
            }            
        }

        private void btnSaveBehaviours_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (rm != null)
            {
                saveFileDialog.FileName = romName + " - Behaviours";
            }

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllLines(saveFileDialog.FileName, behavioursWithNames);
                    MessageBox.Show("Behaviours saved!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (IOException)
                {
                    MessageBox.Show("Failed to load!", "-_-", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnLoadBehaviours_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    behavioursWithNames = File.ReadAllLines(openFileDialog.FileName).ToList();
                    lBehaviours.DataSource = null;
                    lBehaviours.DataSource = behavioursWithNames;
                    SM64.Object.SetNonGroundedBehaviours(behavioursWithNames);
                    MessageBox.Show("Behaviours loaded!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (IOException)
                {
                    MessageBox.Show("Failed to load!", "-_-", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        public List<string> getNonGrounded()
        {
            return behavioursWithNames;
        }

        public List<string> getGrounded()
        {
            return groundedBehavioursWithNames;
        }

        public List<string> getWarps()
        {
            return warpBehavioursWithNames;
        }

        public List<string> getRemoved()
        {
            return removeAddresses;
        }
    }
}
