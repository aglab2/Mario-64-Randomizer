using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mario64Randomizer
{
    public partial class EditSequence : Form
    {
        List<string> areas;
        List<string> courses;
        List<string> courseList;
        List<string> courseInAreas;

        public EditSequence(List<string> courses)
        {
            InitializeComponent();
            courseList = courses;
            if(courses.Count > 0)
            lbCourseList.Items.AddRange(courses.ToArray());
            courses = courseList;
            areas = new List<string>();
            courseInAreas = new List<string>();
            cmbAreas.Items.Clear();
        }

        private void btnSetArea_Click(object sender, EventArgs e)
        {
            cmbAreas.Items.Add(lbCourseList.SelectedItem);
            areas.Add(lbCourseList.SelectedItem.ToString());
            cmbAreas.SelectedItem = lbCourseList.SelectedItem;
        }

        private void btnAddToArea_Click(object sender, EventArgs e)
        {
            if(areas.Count > 0)
            {
                if(!courseInAreas.Contains(cmbAreas.SelectedItem.ToString() + ";" + lbCourseList.SelectedItem.ToString()))
                courseInAreas.Add(cmbAreas.SelectedItem.ToString() + ";" + lbCourseList.SelectedItem.ToString());
                cmbAreas_SelectedIndexChanged(sender, e);
            }
            else
            {
                MessageBox.Show("Add an area first!");
            }
        }

        private void cmbAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbCoursesInArea.DataSource = null;
            List<string> levels = courseInAreas.Where(x => x.Split(new char[] { ';' })[0] == cmbAreas.SelectedItem.ToString()).ToList().Select(x => x.Split(new char[] { ';' })[1]).ToList();
            lbCoursesInArea.DataSource = levels;
        }

        private void btnUnsetArea_Click(object sender, EventArgs e)
        {
            if (areas.Count > 0)
            {
                courseInAreas.RemoveAll(x => x.Split(new char[] { ';' })[0] == cmbAreas.SelectedItem.ToString());
                cmbAreas.Items.Remove(lbCourseList.SelectedItem);
            }
            else
            {
                MessageBox.Show("No areas left!");
            }
        }

        private void btnRemoveFromArea_Click(object sender, EventArgs e)
        {
            if (areas.Count > 0)
            {
                if (!courseInAreas.Contains(cmbAreas.SelectedItem.ToString() + ";" + lbCourseList.SelectedItem.ToString()))
                    courseInAreas.Remove(cmbAreas.SelectedItem.ToString() + ";" + lbCourseList.SelectedItem.ToString());
                cmbAreas_SelectedIndexChanged(sender, e);
            }
            else
            {
                MessageBox.Show("Add an area first!");
            }
        }

        public List<string> getCourseInAreas()
        {
            return courseInAreas;
        }

        public List<string> getAreas()
        {
            return areas;
        }
    }
}
