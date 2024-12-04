namespace Agile201_Group_Project2
{
    partial class ModifyCourse
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
            groupBox1 = new GroupBox();
            newSeatsTextBox = new TextBox();
            registeredTextBox = new TextBox();
            seatsTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            courseNameTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            courseIDTextBox = new TextBox();
            findButton = new Button();
            saveButton = new Button();
            closeButton = new Button();
            deleteButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(newSeatsTextBox);
            groupBox1.Controls.Add(registeredTextBox);
            groupBox1.Controls.Add(seatsTextBox);
            groupBox1.Controls.Add(descriptionTextBox);
            groupBox1.Controls.Add(courseNameTextBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(70, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(281, 226);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Course Information";
            // 
            // newSeatsTextBox
            // 
            newSeatsTextBox.Location = new Point(160, 191);
            newSeatsTextBox.Name = "newSeatsTextBox";
            newSeatsTextBox.Size = new Size(100, 23);
            newSeatsTextBox.TabIndex = 7;
            // 
            // registeredTextBox
            // 
            registeredTextBox.Location = new Point(160, 158);
            registeredTextBox.Name = "registeredTextBox";
            registeredTextBox.ReadOnly = true;
            registeredTextBox.Size = new Size(100, 23);
            registeredTextBox.TabIndex = 6;
            // 
            // seatsTextBox
            // 
            seatsTextBox.Location = new Point(160, 121);
            seatsTextBox.Name = "seatsTextBox";
            seatsTextBox.ReadOnly = true;
            seatsTextBox.Size = new Size(100, 23);
            seatsTextBox.TabIndex = 5;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(160, 64);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(100, 42);
            descriptionTextBox.TabIndex = 4;
            // 
            // courseNameTextBox
            // 
            courseNameTextBox.Location = new Point(160, 27);
            courseNameTextBox.Name = "courseNameTextBox";
            courseNameTextBox.Size = new Size(100, 23);
            courseNameTextBox.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 194);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 4;
            label6.Text = "New Seats:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 161);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 3;
            label5.Text = "Seats Available:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 124);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 2;
            label4.Text = "Seats:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 67);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 1;
            label3.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 30);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 0;
            label2.Text = "Course Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 45);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Course ID:";
            // 
            // courseIDTextBox
            // 
            courseIDTextBox.Location = new Point(230, 42);
            courseIDTextBox.Name = "courseIDTextBox";
            courseIDTextBox.Size = new Size(65, 23);
            courseIDTextBox.TabIndex = 0;
            // 
            // findButton
            // 
            findButton.Location = new Point(323, 41);
            findButton.Name = "findButton";
            findButton.Size = new Size(75, 23);
            findButton.TabIndex = 1;
            findButton.Text = "Find";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(70, 352);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 40);
            saveButton.TabIndex = 8;
            saveButton.Text = "&Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(171, 352);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 40);
            closeButton.TabIndex = 9;
            closeButton.Text = "&Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(276, 352);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 40);
            deleteButton.TabIndex = 11;
            deleteButton.Text = "Delete Course";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // ModifyCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 422);
            Controls.Add(deleteButton);
            Controls.Add(closeButton);
            Controls.Add(saveButton);
            Controls.Add(findButton);
            Controls.Add(courseIDTextBox);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "ModifyCourse";
            Text = "Modify Course";
            Load += ModifyCourse_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox newSeatsTextBox;
        private TextBox registeredTextBox;
        private TextBox seatsTextBox;
        private TextBox descriptionTextBox;
        private TextBox courseNameTextBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox courseIDTextBox;
        private Button findButton;
        private Button saveButton;
        private Button closeButton;
        private Button deleteButton;
    }
}