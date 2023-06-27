namespace InventoryManagementPresentationLayer.Views
{
    partial class HomeForm
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
            pictureBox1 = new PictureBox();
            btnCustomers = new Button();
            btnCategories = new Button();
            pictureBox2 = new PictureBox();
            btnProducts = new Button();
            pictureBox3 = new PictureBox();
            btnOrder = new Button();
            pictureBox4 = new PictureBox();
            btnNewOrder = new Button();
            pictureBox5 = new PictureBox();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.registration1;
            pictureBox1.Location = new Point(127, 175);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 50);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.White;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.ForeColor = Color.FromArgb(52, 152, 219);
            btnCustomers.Location = new Point(104, 231);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(91, 31);
            btnCustomers.TabIndex = 3;
            btnCustomers.Text = "Customer";
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.White;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.ForeColor = Color.FromArgb(52, 152, 219);
            btnCategories.Location = new Point(104, 401);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(91, 31);
            btnCategories.TabIndex = 5;
            btnCategories.Text = "Categories";
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += btnCategories_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.registration1;
            pictureBox2.Location = new Point(127, 345);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 50);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.White;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.ForeColor = Color.FromArgb(52, 152, 219);
            btnProducts.Location = new Point(571, 231);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(91, 31);
            btnProducts.TabIndex = 7;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.registration1;
            pictureBox3.Location = new Point(594, 175);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(49, 50);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.White;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.ForeColor = Color.FromArgb(52, 152, 219);
            btnOrder.Location = new Point(571, 401);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(91, 31);
            btnOrder.TabIndex = 9;
            btnOrder.Text = "Orders";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.registration1;
            pictureBox4.Location = new Point(594, 345);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(49, 50);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // btnNewOrder
            // 
            btnNewOrder.BackColor = Color.White;
            btnNewOrder.FlatStyle = FlatStyle.Flat;
            btnNewOrder.ForeColor = Color.FromArgb(52, 152, 219);
            btnNewOrder.Location = new Point(331, 313);
            btnNewOrder.Name = "btnNewOrder";
            btnNewOrder.Size = new Size(91, 31);
            btnNewOrder.TabIndex = 11;
            btnNewOrder.Text = "New Order";
            btnNewOrder.UseVisualStyleBackColor = false;
            btnNewOrder.Click += btnNewOrder_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.registration1;
            pictureBox5.Location = new Point(354, 257);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(49, 50);
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.FromArgb(52, 152, 219);
            btnLogout.Location = new Point(321, 503);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(119, 53);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 600);
            Controls.Add(btnLogout);
            Controls.Add(btnNewOrder);
            Controls.Add(pictureBox5);
            Controls.Add(btnOrder);
            Controls.Add(pictureBox4);
            Controls.Add(btnProducts);
            Controls.Add(pictureBox3);
            Controls.Add(btnCategories);
            Controls.Add(pictureBox2);
            Controls.Add(btnCustomers);
            Controls.Add(pictureBox1);
            Name = "HomeForm";
            Text = "HomeForm";
            Controls.SetChildIndex(pictureBox1, 0);
            Controls.SetChildIndex(btnCustomers, 0);
            Controls.SetChildIndex(pictureBox2, 0);
            Controls.SetChildIndex(btnCategories, 0);
            Controls.SetChildIndex(pictureBox3, 0);
            Controls.SetChildIndex(btnProducts, 0);
            Controls.SetChildIndex(pictureBox4, 0);
            Controls.SetChildIndex(btnOrder, 0);
            Controls.SetChildIndex(pictureBox5, 0);
            Controls.SetChildIndex(btnNewOrder, 0);
            Controls.SetChildIndex(btnLogout, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnCustomers;
        private Button btnCategories;
        private PictureBox pictureBox2;
        private Button btnProducts;
        private PictureBox pictureBox3;
        private Button btnOrder;
        private PictureBox pictureBox4;
        private Button btnNewOrder;
        private PictureBox pictureBox5;
        private Button btnLogout;
    }
}