namespace ToDo_App
{
    partial class Form1
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
            this.addTaskButton = new System.Windows.Forms.Button();
            this.textBoxAddTask = new System.Windows.Forms.TextBox();
            this.toDoList = new System.Windows.Forms.GroupBox();
            this.confirmButtonTask2 = new System.Windows.Forms.Button();
            this.confirmButtonTask3 = new System.Windows.Forms.Button();
            this.textBoxTask3 = new System.Windows.Forms.TextBox();
            this.textBoxTask2 = new System.Windows.Forms.TextBox();
            this.editTask2 = new System.Windows.Forms.Label();
            this.editTask3 = new System.Windows.Forms.Label();
            this.confirmButtonTask1 = new System.Windows.Forms.Button();
            this.textBoxTask1 = new System.Windows.Forms.TextBox();
            this.editTask1 = new System.Windows.Forms.Label();
            this.removeTask3 = new System.Windows.Forms.Label();
            this.removeTask2 = new System.Windows.Forms.Label();
            this.removeTask1 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.task3 = new System.Windows.Forms.Label();
            this.task2 = new System.Windows.Forms.Label();
            this.task1 = new System.Windows.Forms.Label();
            this.errorMessageTask1 = new System.Windows.Forms.Label();
            this.errorMessageTask3 = new System.Windows.Forms.Label();
            this.errorMessageTask2 = new System.Windows.Forms.Label();
            this.errorMessageAddTask = new System.Windows.Forms.Label();
            this.toDoList.SuspendLayout();
            this.SuspendLayout();
            // 
            // addTaskButton
            // 
            this.addTaskButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addTaskButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTaskButton.Location = new System.Drawing.Point(907, 12);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(86, 29);
            this.addTaskButton.TabIndex = 0;
            this.addTaskButton.Text = "Add task";
            this.addTaskButton.UseVisualStyleBackColor = false;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // textBoxAddTask
            // 
            this.textBoxAddTask.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxAddTask.Location = new System.Drawing.Point(596, 17);
            this.textBoxAddTask.MaxLength = 30;
            this.textBoxAddTask.Name = "textBoxAddTask";
            this.textBoxAddTask.Size = new System.Drawing.Size(305, 20);
            this.textBoxAddTask.TabIndex = 2;
            // 
            // toDoList
            // 
            this.toDoList.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toDoList.Controls.Add(this.errorMessageTask2);
            this.toDoList.Controls.Add(this.errorMessageTask3);
            this.toDoList.Controls.Add(this.errorMessageTask1);
            this.toDoList.Controls.Add(this.confirmButtonTask2);
            this.toDoList.Controls.Add(this.confirmButtonTask3);
            this.toDoList.Controls.Add(this.textBoxTask3);
            this.toDoList.Controls.Add(this.textBoxTask2);
            this.toDoList.Controls.Add(this.editTask2);
            this.toDoList.Controls.Add(this.editTask3);
            this.toDoList.Controls.Add(this.confirmButtonTask1);
            this.toDoList.Controls.Add(this.textBoxTask1);
            this.toDoList.Controls.Add(this.editTask1);
            this.toDoList.Controls.Add(this.removeTask3);
            this.toDoList.Controls.Add(this.removeTask2);
            this.toDoList.Controls.Add(this.removeTask1);
            this.toDoList.Controls.Add(this.checkBox3);
            this.toDoList.Controls.Add(this.checkBox2);
            this.toDoList.Controls.Add(this.checkBox1);
            this.toDoList.Controls.Add(this.task3);
            this.toDoList.Controls.Add(this.task2);
            this.toDoList.Controls.Add(this.task1);
            this.toDoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDoList.Location = new System.Drawing.Point(12, 12);
            this.toDoList.Name = "toDoList";
            this.toDoList.Size = new System.Drawing.Size(578, 324);
            this.toDoList.TabIndex = 4;
            this.toDoList.TabStop = false;
            this.toDoList.Text = "To Do List";
            // 
            // confirmButtonTask2
            // 
            this.confirmButtonTask2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButtonTask2.Location = new System.Drawing.Point(350, 161);
            this.confirmButtonTask2.Name = "confirmButtonTask2";
            this.confirmButtonTask2.Size = new System.Drawing.Size(75, 24);
            this.confirmButtonTask2.TabIndex = 18;
            this.confirmButtonTask2.Text = "Confirm";
            this.confirmButtonTask2.UseVisualStyleBackColor = true;
            this.confirmButtonTask2.Visible = false;
            this.confirmButtonTask2.Click += new System.EventHandler(this.confirmButtonTask2_Click);
            // 
            // confirmButtonTask3
            // 
            this.confirmButtonTask3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButtonTask3.Location = new System.Drawing.Point(350, 252);
            this.confirmButtonTask3.Name = "confirmButtonTask3";
            this.confirmButtonTask3.Size = new System.Drawing.Size(75, 24);
            this.confirmButtonTask3.TabIndex = 17;
            this.confirmButtonTask3.Text = "Confirm";
            this.confirmButtonTask3.UseVisualStyleBackColor = true;
            this.confirmButtonTask3.Visible = false;
            this.confirmButtonTask3.Click += new System.EventHandler(this.confirmButtonTask3_Click);
            // 
            // textBoxTask3
            // 
            this.textBoxTask3.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTask3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTask3.Location = new System.Drawing.Point(39, 254);
            this.textBoxTask3.MaxLength = 30;
            this.textBoxTask3.Name = "textBoxTask3";
            this.textBoxTask3.Size = new System.Drawing.Size(305, 20);
            this.textBoxTask3.TabIndex = 16;
            this.textBoxTask3.Visible = false;
            // 
            // textBoxTask2
            // 
            this.textBoxTask2.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTask2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTask2.Location = new System.Drawing.Point(39, 163);
            this.textBoxTask2.MaxLength = 30;
            this.textBoxTask2.Name = "textBoxTask2";
            this.textBoxTask2.Size = new System.Drawing.Size(305, 20);
            this.textBoxTask2.TabIndex = 15;
            this.textBoxTask2.Visible = false;
            // 
            // editTask2
            // 
            this.editTask2.AutoSize = true;
            this.editTask2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editTask2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTask2.Location = new System.Drawing.Point(502, 166);
            this.editTask2.Name = "editTask2";
            this.editTask2.Size = new System.Drawing.Size(28, 15);
            this.editTask2.TabIndex = 14;
            this.editTask2.Text = "Edit";
            this.editTask2.Visible = false;
            this.editTask2.Click += new System.EventHandler(this.editTask2_Click);
            // 
            // editTask3
            // 
            this.editTask3.AutoSize = true;
            this.editTask3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editTask3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTask3.Location = new System.Drawing.Point(502, 259);
            this.editTask3.Name = "editTask3";
            this.editTask3.Size = new System.Drawing.Size(28, 15);
            this.editTask3.TabIndex = 13;
            this.editTask3.Text = "Edit";
            this.editTask3.Visible = false;
            this.editTask3.Click += new System.EventHandler(this.editTask3_Click);
            // 
            // confirmButtonTask1
            // 
            this.confirmButtonTask1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButtonTask1.Location = new System.Drawing.Point(350, 71);
            this.confirmButtonTask1.Name = "confirmButtonTask1";
            this.confirmButtonTask1.Size = new System.Drawing.Size(75, 24);
            this.confirmButtonTask1.TabIndex = 12;
            this.confirmButtonTask1.Text = "Confirm";
            this.confirmButtonTask1.UseVisualStyleBackColor = true;
            this.confirmButtonTask1.Visible = false;
            this.confirmButtonTask1.Click += new System.EventHandler(this.confirmButtonTask1_Click);
            // 
            // textBoxTask1
            // 
            this.textBoxTask1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTask1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTask1.Location = new System.Drawing.Point(39, 73);
            this.textBoxTask1.MaxLength = 30;
            this.textBoxTask1.Name = "textBoxTask1";
            this.textBoxTask1.Size = new System.Drawing.Size(305, 20);
            this.textBoxTask1.TabIndex = 5;
            this.textBoxTask1.Visible = false;
            // 
            // editTask1
            // 
            this.editTask1.AutoSize = true;
            this.editTask1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editTask1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTask1.Location = new System.Drawing.Point(502, 75);
            this.editTask1.Name = "editTask1";
            this.editTask1.Size = new System.Drawing.Size(28, 15);
            this.editTask1.TabIndex = 11;
            this.editTask1.Text = "Edit";
            this.editTask1.Visible = false;
            this.editTask1.Click += new System.EventHandler(this.editTask1_Click);
            // 
            // removeTask3
            // 
            this.removeTask3.AutoSize = true;
            this.removeTask3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeTask3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeTask3.ForeColor = System.Drawing.Color.Red;
            this.removeTask3.Location = new System.Drawing.Point(548, 256);
            this.removeTask3.Name = "removeTask3";
            this.removeTask3.Size = new System.Drawing.Size(15, 18);
            this.removeTask3.TabIndex = 10;
            this.removeTask3.Text = "x";
            this.removeTask3.Visible = false;
            this.removeTask3.Click += new System.EventHandler(this.removeTask3_Click);
            // 
            // removeTask2
            // 
            this.removeTask2.AutoSize = true;
            this.removeTask2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeTask2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeTask2.ForeColor = System.Drawing.Color.Red;
            this.removeTask2.Location = new System.Drawing.Point(548, 162);
            this.removeTask2.Name = "removeTask2";
            this.removeTask2.Size = new System.Drawing.Size(15, 18);
            this.removeTask2.TabIndex = 9;
            this.removeTask2.Text = "x";
            this.removeTask2.Visible = false;
            this.removeTask2.Click += new System.EventHandler(this.removeTask2_Click);
            // 
            // removeTask1
            // 
            this.removeTask1.AutoSize = true;
            this.removeTask1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeTask1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeTask1.ForeColor = System.Drawing.Color.Red;
            this.removeTask1.Location = new System.Drawing.Point(548, 73);
            this.removeTask1.Name = "removeTask1";
            this.removeTask1.Size = new System.Drawing.Size(15, 18);
            this.removeTask1.TabIndex = 5;
            this.removeTask1.Text = "x";
            this.removeTask1.Visible = false;
            this.removeTask1.Click += new System.EventHandler(this.removeTask1_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(18, 255);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Visible = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(18, 165);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Location = new System.Drawing.Point(18, 76);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // task3
            // 
            this.task3.AutoSize = true;
            this.task3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task3.Location = new System.Drawing.Point(48, 254);
            this.task3.Name = "task3";
            this.task3.Size = new System.Drawing.Size(48, 20);
            this.task3.TabIndex = 5;
            this.task3.Text = "task3";
            this.task3.Visible = false;
            // 
            // task2
            // 
            this.task2.AutoSize = true;
            this.task2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task2.Location = new System.Drawing.Point(48, 161);
            this.task2.Name = "task2";
            this.task2.Size = new System.Drawing.Size(48, 20);
            this.task2.TabIndex = 4;
            this.task2.Text = "task2";
            this.task2.Visible = false;
            // 
            // task1
            // 
            this.task1.AutoSize = true;
            this.task1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task1.Location = new System.Drawing.Point(48, 71);
            this.task1.Name = "task1";
            this.task1.Size = new System.Drawing.Size(48, 20);
            this.task1.TabIndex = 3;
            this.task1.Text = "task1";
            this.task1.Visible = false;
            // 
            // errorMessageTask1
            // 
            this.errorMessageTask1.AutoSize = true;
            this.errorMessageTask1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageTask1.ForeColor = System.Drawing.Color.Black;
            this.errorMessageTask1.Location = new System.Drawing.Point(36, 96);
            this.errorMessageTask1.Name = "errorMessageTask1";
            this.errorMessageTask1.Size = new System.Drawing.Size(214, 15);
            this.errorMessageTask1.TabIndex = 19;
            this.errorMessageTask1.Text = "Please enter input here, field is empty.";
            this.errorMessageTask1.Visible = false;
            // 
            // errorMessageTask3
            // 
            this.errorMessageTask3.AutoSize = true;
            this.errorMessageTask3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageTask3.ForeColor = System.Drawing.Color.Black;
            this.errorMessageTask3.Location = new System.Drawing.Point(36, 277);
            this.errorMessageTask3.Name = "errorMessageTask3";
            this.errorMessageTask3.Size = new System.Drawing.Size(214, 15);
            this.errorMessageTask3.TabIndex = 20;
            this.errorMessageTask3.Text = "Please enter input here, field is empty.";
            this.errorMessageTask3.Visible = false;
            // 
            // errorMessageTask2
            // 
            this.errorMessageTask2.AutoSize = true;
            this.errorMessageTask2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageTask2.ForeColor = System.Drawing.Color.Black;
            this.errorMessageTask2.Location = new System.Drawing.Point(36, 186);
            this.errorMessageTask2.Name = "errorMessageTask2";
            this.errorMessageTask2.Size = new System.Drawing.Size(214, 15);
            this.errorMessageTask2.TabIndex = 21;
            this.errorMessageTask2.Text = "Please enter input here, field is empty.";
            this.errorMessageTask2.Visible = false;
            // 
            // errorMessageAddTask
            // 
            this.errorMessageAddTask.AutoSize = true;
            this.errorMessageAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageAddTask.ForeColor = System.Drawing.Color.White;
            this.errorMessageAddTask.Location = new System.Drawing.Point(596, 40);
            this.errorMessageAddTask.Name = "errorMessageAddTask";
            this.errorMessageAddTask.Size = new System.Drawing.Size(197, 16);
            this.errorMessageAddTask.TabIndex = 5;
            this.errorMessageAddTask.Text = "Couldn\'t add task, field is empty.";
            this.errorMessageAddTask.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1005, 357);
            this.Controls.Add(this.errorMessageAddTask);
            this.Controls.Add(this.toDoList);
            this.Controls.Add(this.textBoxAddTask);
            this.Controls.Add(this.addTaskButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.toDoList.ResumeLayout(false);
            this.toDoList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.TextBox textBoxAddTask;
        private System.Windows.Forms.GroupBox toDoList;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label task3;
        private System.Windows.Forms.Label task2;
        private System.Windows.Forms.Label task1;
        private System.Windows.Forms.Label removeTask3;
        private System.Windows.Forms.Label removeTask2;
        private System.Windows.Forms.Label removeTask1;
        private System.Windows.Forms.Label editTask1;
        private System.Windows.Forms.TextBox textBoxTask1;
        private System.Windows.Forms.Button confirmButtonTask1;
        private System.Windows.Forms.Button confirmButtonTask2;
        private System.Windows.Forms.Button confirmButtonTask3;
        private System.Windows.Forms.TextBox textBoxTask3;
        private System.Windows.Forms.TextBox textBoxTask2;
        private System.Windows.Forms.Label editTask2;
        private System.Windows.Forms.Label editTask3;
        private System.Windows.Forms.Label errorMessageTask1;
        private System.Windows.Forms.Label errorMessageTask2;
        private System.Windows.Forms.Label errorMessageTask3;
        private System.Windows.Forms.Label errorMessageAddTask;
    }
}

