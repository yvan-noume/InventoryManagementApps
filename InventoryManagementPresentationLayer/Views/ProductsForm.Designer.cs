namespace InventoryManagementPresentationLayer.Views
{
    partial class ProductsForm
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
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            btnHome = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            comboBox2 = new ComboBox();
            button6 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(37, 156);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(165, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(37, 203);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 23);
            textBox2.TabIndex = 9;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.White;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.ForeColor = Color.FromArgb(52, 152, 219);
            btnHome.Location = new Point(93, 449);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(74, 46);
            btnHome.TabIndex = 14;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.FromArgb(52, 152, 219);
            button4.Location = new Point(173, 397);
            button4.Name = "button4";
            button4.Size = new Size(74, 46);
            button4.TabIndex = 13;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(52, 152, 219);
            button3.Location = new Point(93, 397);
            button3.Name = "button3";
            button3.Size = new Size(74, 46);
            button3.TabIndex = 12;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(52, 152, 219);
            button2.Location = new Point(13, 397);
            button2.Name = "button2";
            button2.Size = new Size(74, 46);
            button2.TabIndex = 11;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 247);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 16;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(37, 294);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(165, 23);
            textBox4.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(36, 346);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(166, 23);
            comboBox1.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(52, 152, 219);
            label2.Location = new Point(383, 113);
            label2.Name = "label2";
            label2.Size = new Size(202, 30);
            label2.TabIndex = 18;
            label2.Text = "Manage  Products";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(265, 189);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(473, 306);
            dataGridView1.TabIndex = 19;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(442, 156);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(132, 23);
            comboBox2.TabIndex = 20;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.FromArgb(52, 152, 219);
            button6.Location = new Point(593, 156);
            button6.Name = "button6";
            button6.Size = new Size(65, 23);
            button6.TabIndex = 21;
            button6.Text = "Search";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.FromArgb(52, 152, 219);
            button7.Location = new Point(673, 155);
            button7.Name = "button7";
            button7.Size = new Size(65, 23);
            button7.TabIndex = 22;
            button7.Text = "Refresh";
            button7.UseVisualStyleBackColor = false;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 600);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(comboBox2);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(textBox4);
            Controls.Add(btnHome);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Name = "ProductsForm";
            Text = "ProductsForm";
            Controls.SetChildIndex(textBox2, 0);
            Controls.SetChildIndex(textBox3, 0);
            Controls.SetChildIndex(button2, 0);
            Controls.SetChildIndex(button3, 0);
            Controls.SetChildIndex(button4, 0);
            Controls.SetChildIndex(btnHome, 0);
            Controls.SetChildIndex(textBox4, 0);
            Controls.SetChildIndex(textBox1, 0);
            Controls.SetChildIndex(comboBox1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(dataGridView1, 0);
            Controls.SetChildIndex(comboBox2, 0);
            Controls.SetChildIndex(button6, 0);
            Controls.SetChildIndex(button7, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private TextBox textBox2;
        private Button btnHome;
        private Button button4;
        private Button button3;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private Label label2;
        private DataGridView dataGridView1;
        private ComboBox comboBox2;
        private Button button6;
        private Button button7;
    }
}