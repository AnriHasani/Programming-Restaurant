namespace Restaurant
{
    partial class Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Details));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btn_Save = new Button();
            label_table = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            label_table_number = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(131, 79);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(106, 123);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 1;
            label2.Text = "Surname:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(205, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(205, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 3;
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.RosyBrown;
            btn_Save.Font = new Font("Segoe UI", 15F);
            btn_Save.Location = new Point(315, 364);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(147, 42);
            btn_Save.TabIndex = 4;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // label_table
            // 
            label_table.AutoSize = true;
            label_table.BackColor = Color.Transparent;
            label_table.Font = new Font("Segoe UI", 16F);
            label_table.ForeColor = Color.DarkRed;
            label_table.Location = new Point(296, 267);
            label_table.Name = "label_table";
            label_table.Size = new Size(183, 37);
            label_table.TabIndex = 5;
            label_table.Text = "Table Number";
            label_table.Click += label_table_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(35, 165);
            label3.Name = "label3";
            label3.Size = new Size(164, 28);
            label3.TabIndex = 6;
            label3.Text = "Reservation Time:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(22, 211);
            label4.Name = "label4";
            label4.Size = new Size(177, 28);
            label4.TabIndex = 8;
            label4.Text = "Number of people:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(205, 167);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4" });
            comboBox1.Location = new Point(205, 215);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(55, 28);
            comboBox1.TabIndex = 11;
            // 
            // label_table_number
            // 
            label_table_number.AutoSize = true;
            label_table_number.Location = new Point(385, 323);
            label_table_number.Name = "label_table_number";
            label_table_number.Size = new Size(0, 20);
            label_table_number.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 22F);
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(355, 9);
            label5.Name = "label5";
            label5.Size = new Size(133, 50);
            label5.TabIndex = 17;
            label5.Text = "Details";
            // 
            // button1
            // 
            button1.Location = new Point(22, 22);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 18;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            // 
            // Details
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label_table_number);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label_table);
            Controls.Add(btn_Save);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Details";
            Text = "Form1";
            Load += Details_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btn_Save;
        private Label label_table;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label_table_number;
        private Label label5;
        private Button button1;
    }
}