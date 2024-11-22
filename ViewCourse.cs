using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agile201_Group_Project2
{
    public partial class ViewCourse : Form
    {
        private List<Course> courses;
        public ViewCourse(List<Course> courses)
        {
            InitializeComponent();
            this.courses = courses;
        }

        private void ViewCourse_Load(object sender, EventArgs e)
        {

        }

        private void purgeButton_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void printButton_Click(object sender, EventArgs e)
        {

        }

        private void findButton_Click(object sender, EventArgs e)
        {
            string courseID = courseIDTextBox.Text.Trim();
            if (string.IsNullOrEmpty(courseID))
            {
                MessageBox.Show("Please enter a course ID.");
                return;
            }
            var course = courses.FirstOrDefault(c => string.Equals(c.CourseID, courseID, StringComparison.OrdinalIgnoreCase));
            if (course == null)
            {
                MessageBox.Show("Course not found.");
                return;
            }
            courseListBox.Items.Clear();

            //courseDetailsLabel.Text = course.ToString();

            foreach (var student in course.RegisteredStudents)
            {
                courseListBox.Items.Add(student);
            }


        }
    }
}
