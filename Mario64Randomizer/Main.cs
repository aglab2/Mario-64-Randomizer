﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using Mario64Randomizer.SM64;
using Mario64Randomizer.Parsers;
using System.IO;

namespace Mario64Randomizer
{
    public partial class Main : Form
    {
        private Random s = new Random();
        public int seed = 0;
        ROM rm;
        private string romName;

        //
        private Color colorMarioOveralls;
        private Color colorMarioGloves;
        private Color colorMarioShoes;
        private Color colorMarioCap;
        private Color colorMarioFace;
        private Color colorMarioHair;
        //
        
        public List<int> groundedBehaviours;
        public List<int> nonGroundedBehaviours;
        public List<int> warpingBehaviours;

        private List<string> first = new List<string>()
        {
            "BOB1: Big Bob-omb on the Summit", "BOB2: Footrace with Koopa the Quick", "BOB3: Shoot to the Island in the Sky", "BOB4: Find the 8 Red Coins", "BOB5: Mario Wings to the Sky", "BOB6: Behind Chain Chomp's Gate", "BOB7: 100 Coin Star",
            "WF1: Chip Off Whomp's Block", "WF2: To the Top of the Fortress", "WF3: Shoot into the Wild Blue", "WF4: Red Coins on the Floating Isle", "WF5: Fall onto the Caged Island", "WF6: Blast Away the Wall", "WF7: 100 Coin Star",
            "JRB1: Plunder in the Sunken Ship", "JRB2: Can the Eel Come Out to Play?", "JRB3: Treasure of the Ocean Cave", "JRB4: Red Coins on the Ship Afloat", "JRB5: Blast to the Stone Pillar", "JRB6: Through the Jet Stream", "JRB7: 100 Coin Star",
            "CCM1: Slip Slidin' Away", "CCM2: Li'l Penguin Lost", "CCM3: Big Penguin Race", "CCM4: Frosty Slide for 8 Red Coins", "CCM5: Snowman's Lost His Head", "CCM6: Wall Kicks Will Work", "CCM7: 100 Coin Star",
            "BBH1: Go on a Ghost Hunt", "BBH2: Ride Big Boo's Merry-Go-Round", "BBH3: Secret of the Haunted Books", "BBH4: Seek the 8 Red Coins", "BBH5: Big Boo's Balcony", "BBH6: Eye to Eye in the Secret Room", "BBH7: 100 Coin Star"
        };
        private List<string> downstairs = new List<string>()
        {
            "HMC1: Swimming Beast in the Cavern", "HMC2: Elevate for 8 Red Coins", "HMC3: Metal-Head Mario Can Move!", "HMC4: Navigating the Toxic Maze", "HMC5: A-Maze-Ing Emergency Exit", "HMC6: Watch for Rolling Rocks","HMC7: 100 Coin Star",
            "SSL1: In the Talons of the Big Bird", "SSL2: Shining Atop the Pyramid", "SSL3: Inside the Ancient Pyramid", "SSL4: Stand Tall on the Four Pillars", "SSL5: Free Flying for 8 Red Coins", "SSL6: Pyramid Puzzle", "SSL7: 100 Coin Star",
            "LLL1: Boil the Big Bully", "LLL2: Bully the Bullies", "LLL3: 8-Coin Puzzle with 15 Pieces", "LLL4: Red-Hot Log Rolling", "LLL5: Hot-Foot-It into the Volcano", "LLL6: Elevator Tour in the Volcano", "LLL7: 100 Coin Star",
            "DDD1: Board Bowser's Sub", "DDD2: Chests in the Current", "DDD3: Pole-Jumping for Red Coins", "DDD4: Through the Jet Stream", "DDD5: The Manta Ray's Reward", "DDD6: Collect the Caps...", "DDD7: 100 Coin Star"
        };
        private List<string> upstairs = new List<string>()
        {
            "SL1: Snowman's Big Head", "SL2: Chill with the Bully", "SL3: In the Deep Freeze", "SL4: Whirl from the Freezing Pond", "SL5: Shell Shreddin' for Red Coins", "SL6: Into the Igloo", "SL7: 100 Coin Star",
            "WDW1: Shocking Arrow Lifts!", "WDW2: Top o' the Town", "WDW3: Secrets in the Shallows & Sky", "WDW4: Express Elevator--Hurry Up!", "WDW5: Go to Town for Red Coins", "WDW6: Quick Race Through Downtown!", "WDW7: 100 Coin Star",
            "TTM1: Scale the Mountain", "TTM2: Mystery of the Monkey Cage", "TTM3: Scary 'Shrooms, Red Coins", "TTM4: Mysterious Mountainside", "TTM5: Breathtaking View from Bridge", "TTM6: Blast to the Lonely Mushroom", "TTM7: 100 Coin Star",
            "THI1: Pluck the Piranha Flower", "THI2: The Tip Top of the Huge Island", "THI3: Rematch with Koopa the Quick", "THI4: Five Itty Bitty Secrets", "THI5: Wiggler's Red Coins", "THI6: Make Wiggler Squirm", "THI7: 100 Coin Star"
        };
        private List<string> top = new List<string>()
        {
            "TTC1: Roll into the Cage", "TTC2: The Pit and the Pendulums", "TTC3: Get a Hand", "TTC4: Stomp on the Thwomp", "TTC5: Timed Jumps on Moving Bars", "TTC6: Stop Time for Red Coins", "TTC7: 100 Coin Star",
            "RR1: Cruiser Crossing the Rainbow", "RR2: The Big House in the Sky", "RR3: Coins Amassed in a Maze", "RR4: Swingin' in the Breeze", "RR5: Tricky Triangles!", "RR6: Somewhere Over the Rainbow", "RR7: 100 Coin Star"
        };

        private List<string> bowserStars = new List<string>() { "Bowser in the Dark World", "Bowser in the Fire Sea", "Bowser in the Sky" };
        private List<string> secretStars = new List<string>() { "The Secret Aquarium", "Princess's Secret Slide: ! Box", "Princess's Secret Slide: Timed Race", "Wing Cap", "Vanish Cap", "Metal Cap", "Over the Rainbows" };

        private List<string> toads = new List<string>() { "Downstairs Toad", "Upstairs Toad", "Top Toad"};
        private List<string> mips = new List<string>() { "Mips", "Mips" };

        private List<string> randomList = new List<string>();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, System.EventArgs e)
        {
            
            this.btnNewSeed.PerformClick();
            
            groundedBehaviours = File.ReadAllLines("resources/groundedBehaviours.txt").Select(x => Convert.ToInt32(x.Split(new char[] { ':' })[0].Trim(), 16)).ToList();
            nonGroundedBehaviours = File.ReadAllLines("resources/notGrounded.txt").Select(x => Convert.ToInt32(x.Split(new char[] { ':' })[0].Trim(), 16)).ToList();
            warpingBehaviours = File.ReadAllLines("resources/warpBehaviours.txt").Select(x => Convert.ToInt32(x.Split(new char[] { ':' })[0].Trim(), 16)).ToList();
        }

        private void btnNewSeed_Click(object sender, EventArgs e)
        {
            combineLists();
            if (nudStarAmount.Value <= randomList.Count)
            {
                seed = s.Next(0, 160000);
                nudSeed.Value = seed;

                Shuffle(randomList, seed);
                randomList = randomList.GetRange(0, Convert.ToInt32(nudStarAmount.Value));
                refreshCheckList();
            }
            else
            {
                MessageBox.Show("Error: The Star Amount is higher than the Selected Star Set", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void Shuffle<T>(IList<T> list, int seed)
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

        public void refreshCheckList()
        {            
            lvStars.Items.Clear();
            ImageList list = new ImageList();
            list.ImageSize = new Size(24, 24);
            list.ColorDepth = ColorDepth.Depth32Bit;
            list.Images.Add("blue", Mario64Randomizer.Properties.Resources.blueStar);
            list.Images.Add("gold", Mario64Randomizer.Properties.Resources.star);
            lvStars.LargeImageList = list;

            for (int i = 0; i < randomList.Count; i++)
            {
                ListViewItem l = new ListViewItem();
                l.Text = randomList[i].ToString();
                l.ImageIndex = 0;
                lvStars.Items.Add(l);                
            }
        }

        public void combineLists()
        {
            randomList = new List<string>();
            if (chkFirst.Checked)
            {
                if (chk100CS.Checked)
                {
                    randomList.AddRange(first);
                }
                else
                {
                    randomList.AddRange(first.Except(first.Where((t, i) => ((i + 1) % 7) == 0).ToList()));
                }
            }
            if (chkDownstairs.Checked)
            {
                if (chk100CS.Checked)
                {
                    randomList.AddRange(downstairs);
                }
                else
                {
                    randomList.AddRange(downstairs.Except(downstairs.Where((t, i) => ((i + 1) % 7) == 0).ToList()));
                }
                
            }
            if (chkUpstairs.Checked)
            {
                if (chk100CS.Checked)
                {
                    randomList.AddRange(upstairs);
                }
                else
                {
                    randomList.AddRange(upstairs.Except(upstairs.Where((t, i) => ((i + 1) % 7) == 0).ToList()));
                }
            }
            if (chkTop.Checked)
            {
                if (chk100CS.Checked)
                {
                    randomList.AddRange(top);
                }
                else
                {
                    randomList.AddRange(top.Except(top.Where((t, i) => ((i + 1) % 7) == 0).ToList()));
                }                
            }
            if (chkBowserStars.Checked)
            {
                randomList.AddRange(bowserStars);
            }
            if (chkSecretStars.Checked)
            {
                randomList.AddRange(secretStars);
            }
            if (chkToads.Checked)
            {
                randomList.AddRange(toads);
            }
            if (chkMips.Checked)
            {
                randomList.AddRange(mips);
            }
        }

        private void btnEnterSeed_Click(object sender, EventArgs e)
        {

            combineLists();
            if (nudStarAmount.Value <= randomList.Count)
            {
                seed = Convert.ToInt32(nudSeed.Value);
                Shuffle(randomList, seed);
                randomList = randomList.GetRange(0, Convert.ToInt32(nudStarAmount.Value));
                refreshCheckList();
            }
            else
            {
                MessageBox.Show("Error: The Number of Stars amount is higher than the Selected Star Set", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void lvStars_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.Item.Selected)
            {
                if (e.Item.ImageKey == "gold")
                {
                    e.Item.ImageKey = "blue";
                    e.Item.Selected = false;
                }
                else
                {
                    e.Item.ImageKey = "gold";
                    e.Item.Selected = false;
                }
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
                    rm = new ROM(File.ReadAllBytes(openFileDialog.FileName));
                    romName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
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
            if(rm != null)
            {
                if (chkRandomizeMusic.Checked)
                {
                    List<Song> allSongs = new List<Song>();

                    for (int addr = 0x2AC094; addr <= 0x2AC2EC; addr += 20)
                    {
                        try
                        {
                            List<Song> levelSongs = FindSongsParser.FindSongs(rm, addr);
                            allSongs.AddRange(levelSongs);
                        }
                        catch (Exception) { }
                    }

                    IEnumerable<Song> songList = allSongs;

                    IList<byte> seqList = songList.Select(x => x.seqNumber).ToList();

                    Shuffle(seqList, seed);

                    IEnumerable<Song> shuffledSongs = songList.Zip(seqList, (song, seqNumber) => new Song(seqNumber, song.addr, song.musicOffset));

                    foreach (Song song in shuffledSongs)
                    {
                        song.Write(rm);
                    }

                    MessageBox.Show("Music Randomized", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                if (chkRandomizeWarps.Checked)
                {
                    List<Warp> allWarps = new List<Warp>();

                    for (int addr = 0x2AC094; addr <= 0x2AC2EC; addr += 20)
                    {
                        List<Warp> levelWarps = FindWarpsParser.FindWarps(rm, addr);
                        IEnumerable<Warp> whiteListedWarps = levelWarps.Where(x => x.area == 0xFF);
                        allWarps.AddRange(whiteListedWarps);

                        List<SM64.Object> levelObjects = FindObjectsParser.FindObjects(rm, addr);
                        List<SM64.Object> warpingObjects = levelObjects.Where(x => warpingBehaviours.Contains(x.behaviour)).ToList();

                        // Check if warp object exists
                        for (int area = 0; area < 7; area++)
                        {
                            List<Warp> areaWarps = levelWarps.Where(x => x.area == area).ToList();
                            if (areaWarps.Count == 0)
                                continue;

                            List<SM64.Object> areaObjects = warpingObjects.Where(x => x.area == area).ToList();
                            List<Warp> presentedWarps = areaWarps.Where(a => areaObjects.Find(w => w.BParam2 == a.from.id) != null).ToList();
                            allWarps.AddRange(presentedWarps);
                        }

                        allWarps.AddRange(levelWarps);
                    }

                    IEnumerable<Warp> warps = allWarps.Where(x => (x.from.id < 0xF0) & (x.to.course != 0x0));
                    IList<WarpTo> warpsTo = warps.Select(x => x.to).ToList();
                    Shuffle(warpsTo, seed);


                    IEnumerable<Warp> shuffledWarps = warps.Zip(warpsTo, (warp, to) => new Warp(warp.area, warp.from, to, warp.addr));

                    foreach (Warp warp in shuffledWarps)
                        warp.Write(rm);

                    MessageBox.Show("Warps Randomized", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    if (chkWarpFile.Checked)
                    {
                        string path = System.AppContext.BaseDirectory + romName + " - " + seed.ToString() + ".txt";

                        using (StreamWriter sw = File.CreateText(path))
                        {
                            foreach (Warp warp in shuffledWarps)
                                sw.WriteLine("*Warp Address: " + warp.addr.ToString() + "*  [ From Id: " + warp.from.id.ToString() + " -> To Id: " + warp.to.id.ToString() + " - Course: " + warp.to.course.ToString() + ", Area: " + warp.to.area.ToString() + " ]");
                        }
                    }
                }
                if (chkRandomizeEnemies.Checked)
                {
                    for (int addr = 0x2AC094; addr <= 0x2AC2EC; addr += 20)
                    {
                        try
                        {
                            List<SM64.Object> allObjects = FindObjectsParser.FindObjects(rm, addr);

                            IEnumerable<SM64.Object> groundedObjects = allObjects.Where(x => groundedBehaviours.Contains(x.behaviour));
                            IList<ObjectPosition> groundedList = groundedObjects.Select(x => x.position).ToList();

                            IEnumerable<SM64.Object> nonGroundedObjects = allObjects.Where(x => nonGroundedBehaviours.Contains(x.behaviour));
                            IList<ObjectPosition> nonGroundedList = nonGroundedObjects.Select(x => x.position).ToList();

                            Shuffle(groundedList, seed);
                            Shuffle(nonGroundedList, seed);

                            IEnumerable<SM64.Object> shuffledGroundedObjects = groundedObjects.Zip(groundedList,
                                (obj, pos) => new SM64.Object(obj.area, obj.act, obj.model, obj.bparams, obj.behaviour, pos, obj.rotation, obj.addr));
                            IEnumerable<SM64.Object> shuffledNonGroundedObjects = nonGroundedObjects.Zip(nonGroundedList,
                                (obj, pos) => new SM64.Object(obj.area, obj.act, obj.model, obj.bparams, obj.behaviour, pos, obj.rotation, obj.addr));

                            foreach (SM64.Object obj in shuffledGroundedObjects)
                                obj.Write(rm);
                            foreach (SM64.Object obj in shuffledNonGroundedObjects)
                                obj.Write(rm);
                        }
                        catch (Exception) { }
                    }

                    MessageBox.Show("Enemies Randomized", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                if (chkRandomizeMarioClothes.Checked)
                {
                    Random colorRandom = new Random(seed);
                    if (colorMarioOveralls != Color.Empty)
                    {
                        colorMarioOveralls = Color.FromArgb(colorRandom.Next(256), colorRandom.Next(256), colorRandom.Next(256));
                    }
                    else
                    {
                        colorMarioOveralls = pColorOveralls.BackColor;
                    }

                    if (colorMarioCap != Color.Empty)
                    {
                        colorMarioCap = Color.FromArgb(colorRandom.Next(256), colorRandom.Next(256), colorRandom.Next(256));
                    }
                    else
                    {
                        colorMarioCap = pColorArms.BackColor;
                    }

                    if (colorMarioFace != Color.Empty)
                    {
                        colorMarioFace = Color.FromArgb(colorRandom.Next(256), colorRandom.Next(256), colorRandom.Next(256));
                    }
                    else
                    {
                        colorMarioFace = pColorFace.BackColor;
                    }

                    if (colorMarioGloves != Color.Empty)
                    {
                        colorMarioGloves = Color.FromArgb(colorRandom.Next(256), colorRandom.Next(256), colorRandom.Next(256));
                    }
                    else
                    {
                        colorMarioGloves = pColorGloves.BackColor;
                    }

                    if (colorMarioShoes != Color.Empty)
                    {
                        colorMarioShoes = Color.FromArgb(colorRandom.Next(256), colorRandom.Next(256), colorRandom.Next(256));
                    }
                    else
                    {
                        colorMarioShoes = pColorShoes.BackColor;
                    }

                    Console.WriteLine("Overalls: " + colorMarioOveralls.R.ToString("X2") + " " + colorMarioOveralls.B.ToString("X2") + "/n" + colorMarioOveralls.G.ToString("X2") + " 00");
                    Console.WriteLine("Cap: " + colorMarioCap.R.ToString("X2") + " " + colorMarioCap.B.ToString("X2") + "/n" + colorMarioCap.G.ToString("X2") + " 00");
                    Console.WriteLine("Shoes: " + colorMarioShoes.R.ToString("X2") + " " + colorMarioShoes.B.ToString("X2") + "/n" + colorMarioShoes.G.ToString("X2") + " 00");
                    MessageBox.Show("Mario's Clothes Randomized", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                if (!chkRandomizeBowser.Checked)
                {
                    for (int addr = 0x2AC094; addr <= 0x2AC2EC; addr += 20)
                    {
                        List<SM64.Object> allObjects = FindObjectsParser.FindObjects(rm, addr);

                        for (int area = 0; area < 8; area++)
                        {
                            List<SM64.Object> areaObjects = allObjects.Where(x => x.area == area).ToList();
                            if (areaObjects.Count == 0)
                                continue;

                            IEnumerable<SM64.Object> groundedObjects = areaObjects.Where(x => groundedBehaviours.Contains(x.behaviour));
                            IList<ObjectPosition> groundedList = groundedObjects.Select(x => x.position).ToList();

                            IEnumerable<SM64.Object> nonGroundedObjects = areaObjects.Where(x => nonGroundedBehaviours.Contains(x.behaviour));
                            IList<ObjectPosition> nonGroundedList = nonGroundedObjects.Select(x => x.position).ToList();

                            Shuffle(groundedList, seed);
                            Shuffle(nonGroundedList, seed);

                            IEnumerable<SM64.Object> shuffledGroundedObjects = groundedObjects.Zip(groundedList,
                                (obj, pos) => new SM64.Object(obj.area, obj.act, obj.model, obj.bparams, obj.behaviour, pos, obj.rotation, obj.addr));
                            IEnumerable<SM64.Object> shuffledNonGroundedObjects = nonGroundedObjects.Zip(nonGroundedList,
                                (obj, pos) => new SM64.Object(obj.area, obj.act, obj.model, obj.bparams, obj.behaviour, pos, obj.rotation, obj.addr));

                            foreach (SM64.Object obj in shuffledGroundedObjects)
                                obj.Write(rm);
                            foreach (SM64.Object obj in shuffledNonGroundedObjects)
                                obj.Write(rm);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Open a ROM File First!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveRom_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "ROM Files (*.z64)|*.z64";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = romName + " - " + seed.ToString();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllBytes(saveFileDialog.FileName, rm.rom);
                    MessageBox.Show("Your ROM was saved!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (IOException)
                {
                    MessageBox.Show("Failed to load!", "-_-", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnColorOveralls_Click(object sender, EventArgs e)
        {
            DialogResult result = cdClothes.ShowDialog();
            if (result == DialogResult.OK)
            {
                colorMarioOveralls = cdClothes.Color;
                pColorOveralls.BackColor = cdClothes.Color;
            }
        }

        private void btnColorCapArms_Click(object sender, EventArgs e)
        {
            DialogResult result = cdClothes.ShowDialog();
            if (result == DialogResult.OK)
            {
                colorMarioCap = cdClothes.Color;
                pColorArms.BackColor = cdClothes.Color;
            }
        }

        private void btnColorGloves_Click(object sender, EventArgs e)
        {
            DialogResult result = cdClothes.ShowDialog();
            if (result == DialogResult.OK)
            {
                colorMarioGloves = cdClothes.Color;
                pColorGloves.BackColor = cdClothes.Color;
            }
        }

        private void btnColorShoes_Click(object sender, EventArgs e)
        {
            DialogResult result = cdClothes.ShowDialog();
            if (result == DialogResult.OK)
            {
                colorMarioShoes = cdClothes.Color;
                pColorShoes.BackColor = cdClothes.Color;
            }
        }

        private void btnColorFace_Click(object sender, EventArgs e)
        {
            DialogResult result = cdClothes.ShowDialog();
            if (result == DialogResult.OK)
            {
                colorMarioFace = cdClothes.Color;
                pColorFace.BackColor = cdClothes.Color;
            }
        }

        private void btnColorHair_Click(object sender, EventArgs e)
        {
            DialogResult result = cdClothes.ShowDialog();
            if (result == DialogResult.OK)
            {
                colorMarioHair = cdClothes.Color;
                pColorHair.BackColor = cdClothes.Color;
            }
        }

        private void btnColorRestore_Click(object sender, EventArgs e)
        {
            colorMarioCap = Color.Empty;
            pColorArms.BackColor = Color.White;

            colorMarioFace = Color.Empty;
            pColorFace.BackColor = Color.White;

            colorMarioGloves = Color.Empty;
            pColorGloves.BackColor = Color.White;

            colorMarioHair = Color.Empty;
            pColorHair.BackColor = Color.White;

            colorMarioOveralls = Color.Empty;
            pColorOveralls.BackColor = Color.White;

            colorMarioShoes = Color.Empty;
            pColorShoes.BackColor = Color.White;
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            combineLists();
            if (nudStarAmount.Value <= randomList.Count)
            {
                Shuffle(randomList, seed);
                randomList = randomList.GetRange(0, Convert.ToInt32(nudStarAmount.Value));
                refreshCheckList();
            }
            else
            {
                MessageBox.Show("Error: The Number of Stars amount is higher than the Selected Star Set", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
