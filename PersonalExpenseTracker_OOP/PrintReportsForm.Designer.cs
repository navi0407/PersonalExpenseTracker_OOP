namespace PersonalExpenseTracker_OOP
{
    partial class PrintReportsForm
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
            lblBalance = new Label();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnAdd = new Button();
            button1 = new Button();
            button2 = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            SuspendLayout();
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(49, 45);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(125, 31);
            lblBalance.TabIndex = 15;
            lblBalance.Text = "From Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 103);
            label1.Name = "label1";
            label1.Size = new Size(96, 31);
            label1.TabIndex = 16;
            label1.Text = "To Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 169);
            label2.Name = "label2";
            label2.Size = new Size(111, 31);
            label2.TabIndex = 17;
            label2.Text = "Category:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(49, 229);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(358, 34);
            dateTimePicker1.TabIndex = 18;
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
            btnAdd.Location = new Point(69, 288);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(140, 35);
            btnAdd.TabIndex = 34;
            btnAdd.Text = "Generate report";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Maroon;
            button1.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(477, 288);
            button1.Name = "button1";
            button1.Size = new Size(140, 35);
            button1.TabIndex = 35;
            button1.Text = "Print review";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Maroon;
            button2.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(267, 288);
            button2.Name = "button2";
            button2.Size = new Size(140, 35);
            button2.TabIndex = 36;
            button2.Text = "Print";
            button2.UseVisualStyleBackColor = false;
            // 
            // PrintReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 511);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnAdd);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblBalance);
            Name = "PrintReportsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrintReportsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBalance;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Button btnAdd;
        private Button button1;
        private Button button2;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}