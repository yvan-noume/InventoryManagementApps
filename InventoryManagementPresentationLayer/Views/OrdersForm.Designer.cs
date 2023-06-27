namespace InventoryManagementPresentationLayer.Views
{
    partial class OrdersForm
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
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            button3 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            btnHome = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(21, 216);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(164, 23);
            comboBox1.TabIndex = 19;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(22, 164);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(163, 23);
            textBox4.TabIndex = 18;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(22, 260);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(163, 23);
            comboBox2.TabIndex = 20;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(22, 309);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(163, 23);
            comboBox3.TabIndex = 21;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(52, 152, 219);
            button3.Location = new Point(111, 361);
            button3.Name = "button3";
            button3.Size = new Size(74, 46);
            button3.TabIndex = 24;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(52, 152, 219);
            button2.Location = new Point(22, 361);
            button2.Name = "button2";
            button2.Size = new Size(74, 46);
            button2.TabIndex = 23;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(237, 164);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(501, 350);
            dataGridView1.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(52, 152, 219);
            label2.Location = new Point(389, 113);
            label2.Name = "label2";
            label2.Size = new Size(166, 30);
            label2.TabIndex = 27;
            label2.Text = "Display Orders";
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.White;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.ForeColor = Color.FromArgb(52, 152, 219);
            btnHome.Location = new Point(63, 413);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(74, 46);
            btnHome.TabIndex = 28;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // OrdersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 600);
            Controls.Add(btnHome);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Name = "OrdersForm";
            Text = "OrdersForm";
            Controls.SetChildIndex(textBox4, 0);
            Controls.SetChildIndex(comboBox1, 0);
            Controls.SetChildIndex(comboBox2, 0);
            Controls.SetChildIndex(comboBox3, 0);
            Controls.SetChildIndex(button2, 0);
            Controls.SetChildIndex(button3, 0);
            Controls.SetChildIndex(dataGridView1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(btnHome, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox4;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Button button3;
        private Button button2;
        private DataGridView dataGridView1;
        private Label label2;
        private Button btnHome;
    }
}