namespace Agile201_Group_Project2
{
    partial class ViewStudent
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
            label1 = new Label();
            findButton = new Button();
            studentIDTextBox = new TextBox();
            courseListBox = new ListBox();
            printButton = new Button();
            closeButton = new Button();
            removeCourseButton = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 44);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Student ID:";
            // 
            // findButton
            // 
            findButton.Location = new Point(395, 40);
            findButton.Name = "findButton";
            findButton.Size = new Size(75, 23);
            findButton.TabIndex = 1;
            findButton.Text = "Find";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // studentIDTextBox
            // 
            studentIDTextBox.Location = new Point(217, 41);
            studentIDTextBox.Name = "studentIDTextBox";
            studentIDTextBox.Size = new Size(100, 23);
            studentIDTextBox.TabIndex = 2;
            // 
            // courseListBox
            // 
            courseListBox.FormattingEnabled = true;
            courseListBox.HorizontalScrollbar = true;
            courseListBox.ItemHeight = 15;
            courseListBox.Location = new Point(63, 91);
            courseListBox.Name = "courseListBox";
            courseListBox.Size = new Size(507, 244);
            courseListBox.TabIndex = 3;
            // 
            // printButton
            // 
            printButton.Location = new Point(73, 366);
            printButton.Name = "printButton";
            printButton.Size = new Size(75, 38);
            printButton.TabIndex = 4;
            printButton.Text = "&Print";
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += printButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(274, 366);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 38);
            closeButton.TabIndex = 5;
            closeButton.Text = "&Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // removeCourseButton
            // 
            removeCourseButton.Location = new Point(483, 366);
            removeCourseButton.Name = "removeCourseButton";
            removeCourseButton.Size = new Size(75, 38);
            removeCourseButton.TabIndex = 6;
            removeCourseButton.Text = "Remove Course";
            removeCourseButton.UseVisualStyleBackColor = true;
            removeCourseButton.Click += removeCourseButton_Click;
            // 
            // ViewStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 432);
            Controls.Add(removeCourseButton);
            Controls.Add(closeButton);
            Controls.Add(printButton);
            Controls.Add(courseListBox);
            Controls.Add(studentIDTextBox);
            Controls.Add(findButton);
            Controls.Add(label1);
            Name = "ViewStudent";
            Text = "View Student Course Load";
            Load += ViewStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button findButton;
        private TextBox studentIDTextBox;
        private ListBox courseListBox;
        private Button printButton;
        private Button closeButton;
        private Button removeCourseButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}