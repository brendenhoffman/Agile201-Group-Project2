namespace Agile201_Group_Project2
{
    partial class ViewCourse
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
            courseListBox = new ListBox();
            closeButton = new Button();
            purgeButton = new Button();
            printButton = new Button();
            enabledCheckBox = new CheckBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 50);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Course ID:";
            // 
            // courseIDTextBox
            // 
            courseIDTextBox.Location = new Point(190, 46);
            courseIDTextBox.Name = "courseIDTextBox";
            courseIDTextBox.Size = new Size(100, 23);
            courseIDTextBox.TabIndex = 1;
            // 
            // findButton
            // 
            findButton.Location = new Point(382, 46);
            findButton.Name = "findButton";
            findButton.Size = new Size(75, 23);
            findButton.TabIndex = 2;
            findButton.Text = "Find";
            findButton.UseVisualStyleBackColor = true;
            // 
            // courseListBox
            // 
            courseListBox.FormattingEnabled = true;
            courseListBox.HorizontalScrollbar = true;
            courseListBox.ItemHeight = 15;
            courseListBox.Location = new Point(60, 97);
            courseListBox.Name = "courseListBox";
            courseListBox.Size = new Size(509, 259);
            courseListBox.TabIndex = 3;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(264, 386);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(98, 39);
            closeButton.TabIndex = 4;
            closeButton.Text = "&Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // purgeButton
            // 
            purgeButton.Location = new Point(471, 386);
            purgeButton.Name = "purgeButton";
            purgeButton.Size = new Size(98, 39);
            purgeButton.TabIndex = 5;
            purgeButton.Text = "Purge Student Registration";
            purgeButton.UseVisualStyleBackColor = true;
            purgeButton.Click += purgeButton_Click;
            // 
            // printButton
            // 
            printButton.Location = new Point(60, 386);
            printButton.Name = "printButton";
            printButton.Size = new Size(98, 39);
            printButton.TabIndex = 6;
            printButton.Text = "&Print";
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += printButton_Click;
            // 
            // enabledCheckBox
            // 
            enabledCheckBox.AutoSize = true;
            enabledCheckBox.Location = new Point(467, 362);
            enabledCheckBox.Name = "enabledCheckBox";
            enabledCheckBox.Size = new Size(102, 19);
            enabledCheckBox.TabIndex = 7;
            enabledCheckBox.Text = "Purge Enabled";
            enabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // ViewCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 450);
            Controls.Add(enabledCheckBox);
            Controls.Add(printButton);
            Controls.Add(purgeButton);
            Controls.Add(closeButton);
            Controls.Add(courseListBox);
            Controls.Add(findButton);
            Controls.Add(courseIDTextBox);
            Controls.Add(label1);
            Name = "ViewCourse";
            Text = "View Course";
            Load += ViewCourse_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox courseIDTextBox;
        private Button findButton;
        private ListBox courseListBox;
        private Button closeButton;
        private Button purgeButton;
        private Button printButton;
        private CheckBox enabledCheckBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}