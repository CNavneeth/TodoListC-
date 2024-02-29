namespace ToDoList
{
    partial class ToDoList
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
            label2 = new Label();
            titleTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            newButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            saveButton = new Button();
            toDoListView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)toDoListView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 55);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Leelawadee UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(798, 81);
            label2.TabIndex = 1;
            label2.Text = "TO DO LIST";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(35, 108);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(773, 27);
            titleTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(36, 175);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(773, 27);
            descriptionTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(35, 147);
            label3.Name = "label3";
            label3.Size = new Size(181, 25);
            label3.TabIndex = 4;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(35, 80);
            label4.Name = "label4";
            label4.Size = new Size(181, 25);
            label4.TabIndex = 5;
            label4.Text = "Title";
            // 
            // newButton
            // 
            newButton.Location = new Point(35, 218);
            newButton.Name = "newButton";
            newButton.Size = new Size(181, 29);
            newButton.TabIndex = 6;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += newButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(232, 218);
            editButton.Name = "editButton";
            editButton.Size = new Size(181, 29);
            editButton.TabIndex = 7;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(429, 218);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(181, 29);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(627, 218);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(181, 29);
            saveButton.TabIndex = 9;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // toDoListView
            // 
            toDoListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            toDoListView.BackgroundColor = SystemColors.Info;
            toDoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            toDoListView.Location = new Point(36, 269);
            toDoListView.Name = "toDoListView";
            toDoListView.RowHeadersWidth = 51;
            toDoListView.Size = new Size(772, 381);
            toDoListView.TabIndex = 10;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(842, 662);
            Controls.Add(toDoListView);
            Controls.Add(saveButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(newButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(descriptionTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ToDoList";
            Text = "To Do List";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)toDoListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox titleTextBox;
        private TextBox descriptionTextBox;
        private Label label3;
        private Label label4;
        private Button newButton;
        private Button editButton;
        private Button deleteButton;
        private Button saveButton;
        private DataGridView toDoListView;
    }
}
