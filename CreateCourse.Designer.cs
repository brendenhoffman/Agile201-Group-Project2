﻿namespace Agile201_Group_Project2
{
    partial class CreateCourse
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
            seatsTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            courseNameTextBox = new TextBox();
            courseIDTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            saveButton = new Button();
            closeButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(seatsTextBox);
            groupBox1.Controls.Add(descriptionTextBox);
            groupBox1.Controls.Add(courseNameTextBox);
            groupBox1.Controls.Add(courseIDTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(55, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 275);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Course Information";
            // 
            // seatsTextBox
            // 
            seatsTextBox.Location = new Point(155, 178);
            seatsTextBox.Name = "seatsTextBox";
            seatsTextBox.Size = new Size(100, 23);
            seatsTextBox.TabIndex = 7;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(155, 116);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(100, 40);
            descriptionTextBox.TabIndex = 6;
            // 
            // courseNameTextBox
            // 
            courseNameTextBox.Location = new Point(155, 73);
            courseNameTextBox.Name = "courseNameTextBox";
            courseNameTextBox.Size = new Size(100, 23);
            courseNameTextBox.TabIndex = 5;
            // 
            // courseIDTextBox
            // 
            courseIDTextBox.Location = new Point(155, 34);
            courseIDTextBox.Name = "courseIDTextBox";
            courseIDTextBox.Size = new Size(100, 23);
            courseIDTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 181);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 3;
            label4.Text = "Seats:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 119);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 76);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Course Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 37);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Course ID:";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(55, 353);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 1;
            saveButton.Text = "&Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(330, 353);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 2;
            closeButton.Text = "&Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // CreateCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 421);
            Controls.Add(closeButton);
            Controls.Add(saveButton);
            Controls.Add(groupBox1);
            Name = "CreateCourse";
            Text = "Create New Course";
            Load += CreateCourse_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox seatsTextBox;
        private TextBox descriptionTextBox;
        private TextBox courseNameTextBox;
        private TextBox courseIDTextBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button saveButton;
        private Button closeButton;
    }
}