namespace Agile201_Group_Project2
{
    partial class AddStudent
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
            courseIDTextBox = new TextBox();
            findButton = new Button();
            label2 = new Label();
            seatsTextBox = new TextBox();
            studentIDTextBox = new TextBox();
            label3 = new Label();
            addButton = new Button();
            addLabel = new Label();
            closeButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 49);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Course ID:";
            // 
            // courseIDTextBox
            // 
            courseIDTextBox.Location = new Point(166, 47);
            courseIDTextBox.Name = "courseIDTextBox";
            courseIDTextBox.Size = new Size(100, 23);
            courseIDTextBox.TabIndex = 1;
            // 
            // findButton
            // 
            findButton.Location = new Point(332, 52);
            findButton.Name = "findButton";
            findButton.Size = new Size(75, 23);
            findButton.TabIndex = 2;
            findButton.Text = "Find";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 116);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 3;
            label2.Text = "Seats Available:";
            // 
            // seatsTextBox
            // 
            seatsTextBox.Location = new Point(173, 115);
            seatsTextBox.Name = "seatsTextBox";
            seatsTextBox.ReadOnly = true;
            seatsTextBox.Size = new Size(100, 23);
            seatsTextBox.TabIndex = 4;
            // 
            // studentIDTextBox
            // 
            studentIDTextBox.Location = new Point(182, 178);
            studentIDTextBox.Name = "studentIDTextBox";
            studentIDTextBox.Size = new Size(100, 23);
            studentIDTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 183);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 6;
            label3.Text = "Student ID:";
            // 
            // addButton
            // 
            addButton.Location = new Point(340, 180);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 7;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // addLabel
            // 
            addLabel.AutoSize = true;
            addLabel.Location = new Point(77, 229);
            addLabel.Name = "addLabel";
            addLabel.Size = new Size(55, 15);
            addLabel.TabIndex = 8;
            addLabel.Text = "addLabel";
            // 
            // closeButton
            // 
            closeButton.Location = new Point(69, 347);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 9;
            closeButton.Text = "&Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(closeButton);
            Controls.Add(addLabel);
            Controls.Add(addButton);
            Controls.Add(label3);
            Controls.Add(studentIDTextBox);
            Controls.Add(seatsTextBox);
            Controls.Add(label2);
            Controls.Add(findButton);
            Controls.Add(courseIDTextBox);
            Controls.Add(label1);
            Name = "AddStudent";
            Text = "Add Student to Course";
            Load += AddStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox courseIDTextBox;
        private Button findButton;
        private Label label2;
        private TextBox seatsTextBox;
        private TextBox studentIDTextBox;
        private Label label3;
        private Button addButton;
        private Label addLabel;
        private Button closeButton;
    }
}