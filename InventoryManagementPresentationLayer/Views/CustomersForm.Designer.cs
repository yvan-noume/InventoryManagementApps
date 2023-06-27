namespace InventoryManagementPresentationLayer.Views
{
    partial class CustomersForm
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
            txtPhoneNumber = new TextBox();
            txtAddress = new TextBox();
            txtFirstName = new TextBox();
            txtEmail = new TextBox();
            btnHome = new Button();
            button4 = new Button();
            button3 = new Button();
            btnCreate = new Button();
            customersDataGridView = new DataGridView();
            label2 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            label7 = new Label();
            label4 = new Label();
            panel5 = new Panel();
            label8 = new Label();
            label5 = new Label();
            txtLastName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)customersDataGridView).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(30, 247);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(165, 23);
            txtPhoneNumber.TabIndex = 20;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(30, 294);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(165, 23);
            txtAddress.TabIndex = 19;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(30, 156);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(77, 23);
            txtFirstName.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(30, 203);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(165, 23);
            txtEmail.TabIndex = 17;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.White;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.ForeColor = Color.FromArgb(52, 152, 219);
            btnHome.Location = new Point(92, 397);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(74, 46);
            btnHome.TabIndex = 24;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.FromArgb(52, 152, 219);
            button4.Location = new Point(172, 345);
            button4.Name = "button4";
            button4.Size = new Size(74, 46);
            button4.TabIndex = 23;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(52, 152, 219);
            button3.Location = new Point(92, 345);
            button3.Name = "button3";
            button3.Size = new Size(74, 46);
            button3.TabIndex = 22;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.White;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.ForeColor = Color.FromArgb(52, 152, 219);
            btnCreate.Location = new Point(12, 345);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(74, 46);
            btnCreate.TabIndex = 21;
            btnCreate.Text = "Add";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // customersDataGridView
            // 
            customersDataGridView.BackgroundColor = Color.White;
            customersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customersDataGridView.GridColor = Color.White;
            customersDataGridView.Location = new Point(265, 178);
            customersDataGridView.MultiSelect = false;
            customersDataGridView.Name = "customersDataGridView";
            customersDataGridView.ReadOnly = true;
            customersDataGridView.RowTemplate.Height = 25;
            customersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customersDataGridView.Size = new Size(473, 290);
            customersDataGridView.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(52, 152, 219);
            label2.Location = new Point(384, 113);
            label2.Name = "label2";
            label2.Size = new Size(219, 30);
            label2.TabIndex = 26;
            label2.Text = "Manage  Customers";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(241, 196, 15);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(48, 487);
            panel3.Name = "panel3";
            panel3.Size = new Size(158, 80);
            panel3.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 41);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 1;
            label6.Text = "label6";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 0;
            label3.Text = "Orders Count";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(231, 76, 60);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(291, 487);
            panel4.Name = "panel4";
            panel4.Size = new Size(158, 80);
            panel4.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(63, 41);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 2;
            label7.Text = "label7";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 0;
            label4.Text = "Orders Amount";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(142, 68, 173);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(537, 487);
            panel5.Name = "panel5";
            panel5.Size = new Size(158, 80);
            panel5.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(62, 41);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 3;
            label8.Text = "label8";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 0;
            label5.Text = "Last Order Date";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(113, 156);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(82, 23);
            txtLastName.TabIndex = 30;
            // 
            // CustomersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 600);
            Controls.Add(txtLastName);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(customersDataGridView);
            Controls.Add(btnHome);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnCreate);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtAddress);
            Controls.Add(txtFirstName);
            Controls.Add(txtEmail);
            Name = "CustomersForm";
            Text = "CustomersForm";
            Controls.SetChildIndex(txtEmail, 0);
            Controls.SetChildIndex(txtFirstName, 0);
            Controls.SetChildIndex(txtAddress, 0);
            Controls.SetChildIndex(txtPhoneNumber, 0);
            Controls.SetChildIndex(btnCreate, 0);
            Controls.SetChildIndex(button3, 0);
            Controls.SetChildIndex(button4, 0);
            Controls.SetChildIndex(btnHome, 0);
            Controls.SetChildIndex(customersDataGridView, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(panel3, 0);
            Controls.SetChildIndex(panel4, 0);
            Controls.SetChildIndex(panel5, 0);
            Controls.SetChildIndex(txtLastName, 0);
            ((System.ComponentModel.ISupportInitialize)customersDataGridView).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPhoneNumber;
        private TextBox txtAddress;
        private TextBox txtFirstName;
        private TextBox txtEmail;
        private Button btnHome;
        private Button button4;
        private Button button3;
        private Button btnCreate;
        private DataGridView customersDataGridView;
        private Label label2;
        private Panel panel3;
        private Label label6;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private Panel panel5;
        private Label label5;
        private Label label7;
        private Label label8;
        private TextBox txtLastName;
    }
}