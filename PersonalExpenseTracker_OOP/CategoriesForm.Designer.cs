namespace PersonalExpenseTracker_OOP
{
    partial class CategoriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesForm));
            lblBalance = new Label();
            label1 = new Label();
            textCName = new TextBox();
            cmbType = new ComboBox();
            dgvCategories = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(30, 33);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(108, 19);
            lblBalance.TabIndex = 14;
            lblBalance.Text = "Category Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 70);
            label1.Name = "label1";
            label1.Size = new Size(40, 19);
            label1.TabIndex = 15;
            label1.Text = "Type:";
            // 
            // textCName
            // 
            textCName.Location = new Point(161, 33);
            textCName.Margin = new Padding(3, 2, 3, 2);
            textCName.Name = "textCName";
            textCName.Size = new Size(206, 23);
            textCName.TabIndex = 16;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(88, 70);
            cmbType.Margin = new Padding(3, 2, 3, 2);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(279, 23);
            cmbType.TabIndex = 17;
            // 
            // dgvCategories
            // 
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(229, 106);
            dgvCategories.Margin = new Padding(3, 2, 3, 2);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.Size = new Size(364, 250);
            dgvCategories.TabIndex = 18;
            dgvCategories.CellClick += dgvCategories_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Maroon;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.Location = new Point(88, 124);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(83, 26);
            btnAdd.TabIndex = 33;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Maroon;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(88, 176);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(83, 26);
            btnUpdate.TabIndex = 34;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Maroon;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(88, 231);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(83, 26);
            btnDelete.TabIndex = 35;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Maroon;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnClear.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ControlLightLight;
            btnClear.Location = new Point(88, 291);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(83, 26);
            btnClear.TabIndex = 36;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // CategoriesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(623, 383);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvCategories);
            Controls.Add(cmbType);
            Controls.Add(textCName);
            Controls.Add(label1);
            Controls.Add(lblBalance);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CategoriesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoriesForm";
            Load += CategoriesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBalance;
        private Label label1;
        private TextBox textCName;
        private ComboBox cmbType;
        private DataGridView dgvCategories;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
    }
}