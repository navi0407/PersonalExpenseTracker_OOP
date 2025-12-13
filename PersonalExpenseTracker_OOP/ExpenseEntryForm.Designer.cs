namespace PersonalExpenseTracker_OOP
{
    partial class ExpenseEntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseEntryForm));
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvExpense = new DataGridView();
            dtpDate = new DateTimePicker();
            cmbCategory = new ComboBox();
            lblDescription = new Label();
            lblCategory = new Label();
            lblDate = new Label();
            lblAmount = new Label();
            txtAmount = new TextBox();
            txtDescription = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvExpense).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnClear.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ControlLightLight;
            btnClear.Location = new Point(506, 20);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(83, 26);
            btnClear.TabIndex = 35;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Gray;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(385, 21);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(83, 26);
            btnDelete.TabIndex = 34;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Gray;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(244, 20);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(83, 26);
            btnUpdate.TabIndex = 33;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gray;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.Location = new Point(117, 21);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(83, 26);
            btnAdd.TabIndex = 32;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvExpense
            // 
            dgvExpense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpense.Location = new Point(274, 68);
            dgvExpense.Margin = new Padding(3, 2, 3, 2);
            dgvExpense.Name = "dgvExpense";
            dgvExpense.RowHeadersWidth = 51;
            dgvExpense.Size = new Size(338, 275);
            dgvExpense.TabIndex = 31;
            dgvExpense.CellClick += dgvExpense_CellClick;
            dgvExpense.CellContentClick += dgvExpense_CellContentClick;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(49, 170);
            dtpDate.Margin = new Padding(3, 2, 3, 2);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(219, 23);
            dtpDate.TabIndex = 30;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(104, 214);
            cmbCategory.Margin = new Padding(3, 2, 3, 2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(147, 23);
            cmbCategory.TabIndex = 29;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(17, 252);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(81, 19);
            lblDescription.TabIndex = 28;
            lblDescription.Text = "Description:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(36, 214);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(68, 19);
            lblCategory.TabIndex = 27;
            lblCategory.Text = "Category:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(9, 170);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(41, 19);
            lblDate.TabIndex = 26;
            lblDate.Text = "Date:";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAmount.Location = new Point(36, 129);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(62, 19);
            lblAmount.TabIndex = 25;
            lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(104, 129);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(147, 23);
            txtAmount.TabIndex = 36;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(104, 252);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(147, 23);
            txtDescription.TabIndex = 37;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Maroon;
            pictureBox1.Location = new Point(-9, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(632, 66);
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(3, -5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(69, 68);
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 322);
            label1.Name = "label1";
            label1.Size = new Size(230, 21);
            label1.TabIndex = 40;
            label1.Text = "Current Balance ng user dito:";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(104, 21);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(28, 27);
            pictureBox3.TabIndex = 41;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(368, 21);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(28, 27);
            pictureBox4.TabIndex = 42;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(223, 20);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(28, 27);
            pictureBox5.TabIndex = 43;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(-51, 54);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(706, 370);
            pictureBox6.TabIndex = 44;
            pictureBox6.TabStop = false;
            // 
            // ExpenseEntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 383);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(txtDescription);
            Controls.Add(txtAmount);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvExpense);
            Controls.Add(dtpDate);
            Controls.Add(cmbCategory);
            Controls.Add(lblDescription);
            Controls.Add(lblCategory);
            Controls.Add(lblDate);
            Controls.Add(lblAmount);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox6);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ExpenseEntryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExpenseEntryForm";
            Load += ExpenseEntryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExpense).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgvExpense;
        private DateTimePicker dtpDate;
        private ComboBox cmbCategory;
        private Label lblDescription;
        private Label lblCategory;
        private Label lblDate;
        private Label lblAmount;
        private TextBox txtAmount;
        private TextBox txtDescription;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}