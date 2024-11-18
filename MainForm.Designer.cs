namespace Agile201_Group_Project2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            createCourseButton = new Button();
            modifyCourseButton = new Button();
            viewCourseButton = new Button();
            addStudentButton = new Button();
            viewStudentButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(105, 77);
            label1.Name = "label1";
            label1.Size = new Size(595, 52);
            label1.TabIndex = 0;
            label1.Text = "Tiny College Student Registration";
            // 
            // createCourseButton
            // 
            createCourseButton.Location = new Point(44, 184);
            createCourseButton.Name = "createCourseButton";
            createCourseButton.Size = new Size(98, 41);
            createCourseButton.TabIndex = 1;
            createCourseButton.Text = "Create &New Course";
            createCourseButton.UseVisualStyleBackColor = true;
            createCourseButton.Click += createCourseButton_Click;
            // 
            // modifyCourseButton
            // 
            modifyCourseButton.Location = new Point(193, 184);
            modifyCourseButton.Name = "modifyCourseButton";
            modifyCourseButton.Size = new Size(98, 41);
            modifyCourseButton.TabIndex = 2;
            modifyCourseButton.Text = "&Modify Course";
            modifyCourseButton.UseVisualStyleBackColor = true;
            modifyCourseButton.Click += modifyCourseButton_Click;
            // 
            // viewCourseButton
            // 
            viewCourseButton.Location = new Point(347, 184);
            viewCourseButton.Name = "viewCourseButton";
            viewCourseButton.Size = new Size(98, 41);
            viewCourseButton.TabIndex = 3;
            viewCourseButton.Text = "&View Course";
            viewCourseButton.UseVisualStyleBackColor = true;
            viewCourseButton.Click += viewCourseButton_Click;
            // 
            // addStudentButton
            // 
            addStudentButton.Location = new Point(503, 184);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(98, 41);
            addStudentButton.TabIndex = 4;
            addStudentButton.Text = "Add &Student to Course";
            addStudentButton.UseVisualStyleBackColor = true;
            addStudentButton.Click += addStudentButton_Click;
            // 
            // viewStudentButton
            // 
            viewStudentButton.Location = new Point(651, 184);
            viewStudentButton.Name = "viewStudentButton";
            viewStudentButton.Size = new Size(98, 41);
            viewStudentButton.TabIndex = 5;
            viewStudentButton.Text = "Vie&w Student";
            viewStudentButton.UseVisualStyleBackColor = true;
            viewStudentButton.Click += viewStudentButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(44, 293);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(705, 41);
            exitButton.TabIndex = 6;
            exitButton.Text = "E&xit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 375);
            Controls.Add(exitButton);
            Controls.Add(viewStudentButton);
            Controls.Add(addStudentButton);
            Controls.Add(viewCourseButton);
            Controls.Add(modifyCourseButton);
            Controls.Add(createCourseButton);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Main Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button createCourseButton;
        private Button modifyCourseButton;
        private Button viewCourseButton;
        private Button addStudentButton;
        private Button viewStudentButton;
        private Button exitButton;
    }
}
