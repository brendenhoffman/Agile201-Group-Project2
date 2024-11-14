namespace Agile201_Group_Project2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void createCourseButton_Click(object sender, EventArgs e)
        {
            CreateCourse createCourse = new CreateCourse();
            createCourse.ShowDialog();
        }

        private void modifyCourseButton_Click(object sender, EventArgs e)
        {
            ModifyCourse modifyCourse = new ModifyCourse();
            modifyCourse.ShowDialog();
        }

        private void viewCourseButton_Click(object sender, EventArgs e)
        {
            ViewCourse viewCourse = new ViewCourse();
            viewCourse.ShowDialog();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();
        }

        private void viewStudentButton_Click(object sender, EventArgs e)
        {
            ViewStudent viewStudent = new ViewStudent();
            viewStudent.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
