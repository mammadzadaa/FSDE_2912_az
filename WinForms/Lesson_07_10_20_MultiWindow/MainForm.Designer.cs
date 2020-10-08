namespace Lesson_07_10_20_MultiWindow
{
    partial class MainForm
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
            this.peopleListBox = new System.Windows.Forms.ListBox();
            this.viewButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peopleListBox
            // 
            this.peopleListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.peopleListBox.FormattingEnabled = true;
            this.peopleListBox.ItemHeight = 29;
            this.peopleListBox.Location = new System.Drawing.Point(12, 21);
            this.peopleListBox.Name = "peopleListBox";
            this.peopleListBox.Size = new System.Drawing.Size(455, 323);
            this.peopleListBox.TabIndex = 0;
            this.peopleListBox.DoubleClick += new System.EventHandler(this.peopleListBox_DoubleClick);
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(12, 363);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(455, 58);
            this.viewButton.TabIndex = 1;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 442);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(175, 58);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(292, 442);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(175, 58);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 534);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.peopleListBox);
            this.Name = "MainForm";
            this.Text = "My App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox peopleListBox;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
    }
}

