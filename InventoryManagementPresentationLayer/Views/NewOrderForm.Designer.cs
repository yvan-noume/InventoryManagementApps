namespace InventoryManagementPresentationLayer.Views
{
    partial class NewOrderForm
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
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            textBox2 = new TextBox();
            button5 = new Button();
            btnHome = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 189);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(329, 183);
            dataGridView1.TabIndex = 27;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(398, 189);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(329, 183);
            dataGridView2.TabIndex = 28;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(37, 416);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(690, 88);
            dataGridView3.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(52, 152, 219);
            label2.Location = new Point(296, 114);
            label2.Name = "label2";
            label2.Size = new Size(148, 30);
            label2.TabIndex = 30;
            label2.Text = "Create Order";
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(52, 152, 219);
            button3.Location = new Point(354, 521);
            button3.Name = "button3";
            button3.Size = new Size(74, 46);
            button3.TabIndex = 33;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.FromArgb(52, 152, 219);
            button4.Location = new Point(265, 521);
            button4.Name = "button4";
            button4.Size = new Size(74, 46);
            button4.TabIndex = 32;
            button4.Text = "Create";
            button4.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.FromArgb(52, 152, 219);
            button6.Location = new Point(301, 159);
            button6.Name = "button6";
            button6.Size = new Size(65, 23);
            button6.TabIndex = 35;
            button6.Text = "Search";
            button6.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(145, 159);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(132, 23);
            textBox3.TabIndex = 37;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(506, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 23);
            textBox1.TabIndex = 39;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(52, 152, 219);
            button2.Location = new Point(662, 159);
            button2.Name = "button2";
            button2.Size = new Size(65, 23);
            button2.TabIndex = 38;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(261, 387);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(132, 23);
            textBox2.TabIndex = 41;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.FromArgb(52, 152, 219);
            button5.Location = new Point(417, 387);
            button5.Name = "button5";
            button5.Size = new Size(92, 23);
            button5.TabIndex = 40;
            button5.Text = "Quantity";
            button5.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.White;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.ForeColor = Color.FromArgb(52, 152, 219);
            btnHome.Location = new Point(443, 521);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(74, 46);
            btnHome.TabIndex = 42;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // NewOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 600);
            Controls.Add(btnHome);
            Controls.Add(textBox2);
            Controls.Add(button5);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "NewOrderForm";
            Text = "NewOrderForm";
            Controls.SetChildIndex(dataGridView1, 0);
            Controls.SetChildIndex(dataGridView2, 0);
            Controls.SetChildIndex(dataGridView3, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(button4, 0);
            Controls.SetChildIndex(button3, 0);
            Controls.SetChildIndex(button6, 0);
            Controls.SetChildIndex(textBox3, 0);
            Controls.SetChildIndex(button2, 0);
            Controls.SetChildIndex(textBox1, 0);
            Controls.SetChildIndex(button5, 0);
            Controls.SetChildIndex(textBox2, 0);
            Controls.SetChildIndex(btnHome, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Label label2;
        private Button button3;
        private Button button4;
        private Button button6;
        private TextBox textBox3;
        private TextBox textBox1;
        private Button button2;
        private TextBox textBox2;
        private Button button5;
        private Button btnHome;
    }
}