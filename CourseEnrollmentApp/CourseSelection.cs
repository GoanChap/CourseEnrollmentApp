using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseEnrollmentApp
{
    public partial class CourseSelection : Form
    {
        private DataTable dtCourses = new DataTable();
        private DataTable dtselectedCourses = new DataTable();
        public CourseSelection()
        {
            InitializeComponent();
        }

        private void CourseSelection_Load(object sender, EventArgs e)
        {
            fillCoursesTable();
            SelectedCourseTable();

            availableCoursesListBox.DataSource = dtCourses;
            availableCoursesListBox.DisplayMember = "CourseName";

            selectedCoursesListBox.DataSource = dtselectedCourses;
            selectedCoursesListBox.DisplayMember = "CourseName";
        }

        private void SelectedCourseTable()
        {
            dtselectedCourses.Columns.Add("CourseID", typeof(int));
            dtselectedCourses.Columns.Add("CourseName");
            dtselectedCourses.Columns.Add("CourseDuration");
        }

        private void fillCoursesTable()
        {
            dtCourses.Columns.Add("CourseID", typeof(int));
            dtCourses.Columns.Add("CourseName");
            dtCourses.Columns.Add("CourseDuration");

            dtCourses.Rows.Add(1, "Database Management Systems", "9 months");
            dtCourses.Rows.Add(2, "Artificial Intelligence", "9 months");
            dtCourses.Rows.Add(3, "Computer Graphics", "4 months ");
            dtCourses.Rows.Add(4, "Multi-media Imaging Systems", "4 months");
            dtCourses.Rows.Add(5, "Network/Global-data measurements", "4 months");
            dtCourses.Rows.Add(6, "Electrical and Electronic devices.", "4 months");
            dtCourses.Rows.Add(7, "Security in Software and Mobile devices", "4 months");
            dtCourses.Rows.Add(8, "Operating Systems", "4 months ");
            dtCourses.Rows.Add(9, "Project Management", "4 months");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(availableCoursesListBox.Items.Count > 1)
            {
                dtselectedCourses.ImportRow(dtCourses.Rows[availableCoursesListBox.SelectedIndex]);
                dtCourses.Rows[availableCoursesListBox.SelectedIndex].Delete();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if(selectedCoursesListBox.Items.Count > 1)
            {
                dtCourses.ImportRow(dtselectedCourses.Rows[selectedCoursesListBox.SelectedIndex]);
                dtselectedCourses.Rows[selectedCoursesListBox.SelectedIndex].Delete();
            }
        }

        private void addAllutton_Click(object sender, EventArgs e)
        {
            if(availableCoursesListBox.Items.Count > 1)
            {
                int count = availableCoursesListBox.Items.Count;
                for (int i = 0; i < count; i++)
                {
                    dtselectedCourses.ImportRow(dtCourses.Rows[availableCoursesListBox.SelectedIndex]);
                    dtCourses.Rows[availableCoursesListBox.SelectedIndex].Delete();
                }
            }
        }

        private void removeAllButton_Click(object sender, EventArgs e)
        {
            if (selectedCoursesListBox.Items.Count > 1)
            {
                int count = selectedCoursesListBox.Items.Count;
                for (int i = 0; i < count; i++)
                {
                    dtCourses.ImportRow(dtselectedCourses.Rows[selectedCoursesListBox.SelectedIndex]);
                    dtselectedCourses.Rows[selectedCoursesListBox.SelectedIndex].Delete();
                }
            }
        }

        private void finalizeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to confirm the selected courses?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                courseSummaryDataGridView.DataSource = dtselectedCourses;

                courseSummaryDataGridView.Enabled = false;
                courseSummaryDataGridView.Columns[0].Visible = false;
                courseSummaryDataGridView.RowHeadersVisible = false;

                courseSummaryDataGridView.Columns[1].Width = 350;
                courseSummaryDataGridView.Columns[2].Width = 500;
            }
            else
            {
                MessageBox.Show("Please select atleast one course.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
