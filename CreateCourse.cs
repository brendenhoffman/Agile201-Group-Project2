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
    public partial class CreateCourse : Form
    {
        List<Course> courses = new List<Course>();
        public CreateCourse()
        {
            InitializeComponent();
        }

        private void CreateCourse_Load(object sender, EventArgs e)
        {
            if (File.Exists("course.txt"))
            {
                foreach (var line in File.ReadAllLines("course.txt"))
                {
                    var data = line.Split('|'); // Adjust this format based on your saved structure
                    if (data.Length >= 4)
                    {
                        courses.Add(new Course(data[0], data[1], data[2], int.Parse(data[3])));
                    }
                }
            }

            // Display loaded courses in a message box (optional)
            if (courses.Count > 0)
            {
                string savedCourses = string.Join(Environment.NewLine, courses);
                MessageBox.Show($"Loaded Courses:\n{savedCourses}", "Loaded Courses");
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using StreamWriter sw = File.AppendText("course.txt");
            int courseCapacity = 0;

            // Check for empty or duplicate CourseID
            if (string.IsNullOrEmpty(courseIDTextBox.Text) || (courses.Find(x => x.CourseID == courseIDTextBox.Text) != null))
            {
                MessageBox.Show("Course ID is already used or empty.");
                courseIDTextBox.Focus();
                courseIDTextBox.SelectAll();
            }
            // Check for empty or duplicate CourseName
            else if (string.IsNullOrEmpty(courseNameTextBox.Text) || (courses.Find(x => x.CourseName == courseNameTextBox.Text) != null))
            {
                MessageBox.Show("Course name is already in use or empty.");
                courseNameTextBox.Focus();
                courseNameTextBox.SelectAll();
            }
            else if (string.IsNullOrEmpty(descriptionTextBox.Text))
            {
                MessageBox.Show("Description cannot be empty.");
                descriptionTextBox.Focus();
            }
            else if (!int.TryParse(seatsTextBox.Text, out courseCapacity) || courseCapacity <= 0)
            {
                MessageBox.Show("Capacity must be a valid number greater than 0.");
                seatsTextBox.Focus();
                seatsTextBox.SelectAll();
            }
            else
            {
                // Create a new Course object and save it to the file
                Course newCourse = new Course(courseIDTextBox.Text, courseNameTextBox.Text, descriptionTextBox.Text, courseCapacity);
                sw.WriteLine($"{newCourse.CourseID}|{newCourse.CourseName}|{newCourse.CourseDescription}|{newCourse.CourseCapacity}");
                // Save the course info as a string

                // Add the new course to the list
                courses.Add(newCourse);

                // Display success message and clear the fields
                MessageBox.Show("Course record saved.");
                courseIDTextBox.Clear();
                courseNameTextBox.Clear();
                descriptionTextBox.Clear();
                seatsTextBox.Clear();
            }

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
