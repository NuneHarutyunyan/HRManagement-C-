namespace HRManagement
{
    partial class Salary
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
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EmpSalary = new System.Windows.Forms.TextBox();
            this.EmpindentNum1 = new System.Windows.Forms.Label();
            this.EmpLName1 = new System.Windows.Forms.Label();
            this.EmpFName1 = new System.Windows.Forms.Label();
            this.EmpIdCombo = new System.Windows.Forms.ComboBox();
            this.HRIdCombo = new System.Windows.Forms.ComboBox();
            this.Del = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.ForeColor = System.Drawing.Color.Black;
            this.DeleteBtn.Location = new System.Drawing.Point(586, 141);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(196, 36);
            this.DeleteBtn.TabIndex = 44;
            this.DeleteBtn.Text = "Ջնջել";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditBtn.ForeColor = System.Drawing.Color.Black;
            this.EditBtn.Location = new System.Drawing.Point(409, 141);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(112, 36);
            this.EditBtn.TabIndex = 43;
            this.EditBtn.Text = "Ավելացնել";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveBtn.ForeColor = System.Drawing.Color.Black;
            this.SaveBtn.Location = new System.Drawing.Point(231, 141);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(112, 36);
            this.SaveBtn.TabIndex = 42;
            this.SaveBtn.Text = "Պահպանել";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LawnGreen;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(-3, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 291);
            this.panel1.TabIndex = 40;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LawnGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(906, 262);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // EmpSalary
            // 
            this.EmpSalary.Location = new System.Drawing.Point(168, 66);
            this.EmpSalary.Name = "EmpSalary";
            this.EmpSalary.Size = new System.Drawing.Size(131, 23);
            this.EmpSalary.TabIndex = 38;
            // 
            // EmpindentNum1
            // 
            this.EmpindentNum1.AutoSize = true;
            this.EmpindentNum1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmpindentNum1.Location = new System.Drawing.Point(360, 34);
            this.EmpindentNum1.Name = "EmpindentNum1";
            this.EmpindentNum1.Size = new System.Drawing.Size(55, 17);
            this.EmpindentNum1.TabIndex = 32;
            this.EmpindentNum1.Text = "HR-ի Id";
            // 
            // EmpLName1
            // 
            this.EmpLName1.AutoSize = true;
            this.EmpLName1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmpLName1.Location = new System.Drawing.Point(14, 72);
            this.EmpLName1.Name = "EmpLName1";
            this.EmpLName1.Size = new System.Drawing.Size(107, 17);
            this.EmpLName1.TabIndex = 33;
            this.EmpLName1.Text = "Աշխատավարձ";
            this.EmpLName1.Click += new System.EventHandler(this.EmpLName1_Click);
            // 
            // EmpFName1
            // 
            this.EmpFName1.AutoSize = true;
            this.EmpFName1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmpFName1.Location = new System.Drawing.Point(14, 12);
            this.EmpFName1.Name = "EmpFName1";
            this.EmpFName1.Size = new System.Drawing.Size(112, 17);
            this.EmpFName1.TabIndex = 34;
            this.EmpFName1.Text = "Աշխատակցի Id";
            // 
            // EmpIdCombo
            // 
            this.EmpIdCombo.FormattingEnabled = true;
            this.EmpIdCombo.Location = new System.Drawing.Point(168, 6);
            this.EmpIdCombo.Name = "EmpIdCombo";
            this.EmpIdCombo.Size = new System.Drawing.Size(121, 23);
            this.EmpIdCombo.TabIndex = 45;
            // 
            // HRIdCombo
            // 
            this.HRIdCombo.FormattingEnabled = true;
            this.HRIdCombo.Location = new System.Drawing.Point(443, 28);
            this.HRIdCombo.Name = "HRIdCombo";
            this.HRIdCombo.Size = new System.Drawing.Size(121, 23);
            this.HRIdCombo.TabIndex = 46;
            // 
            // Del
            // 
            this.Del.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Del.ForeColor = System.Drawing.Color.Black;
            this.Del.Location = new System.Drawing.Point(671, 44);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(191, 36);
            this.Del.TabIndex = 47;
            this.Del.Text = "Մաքրել դաշտերը";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(932, 492);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.HRIdCombo);
            this.Controls.Add(this.EmpIdCombo);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EmpSalary);
            this.Controls.Add(this.EmpindentNum1);
            this.Controls.Add(this.EmpLName1);
            this.Controls.Add(this.EmpFName1);
            this.Name = "Salary";
            this.Text = "Salary";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox EmpSalary;
        private System.Windows.Forms.Label EmpindentNum1;
        private System.Windows.Forms.Label EmpLName1;
        private System.Windows.Forms.Label EmpFName1;
        private System.Windows.Forms.ComboBox EmpIdCombo;
        private System.Windows.Forms.ComboBox HRIdCombo;
        private System.Windows.Forms.Button Del;
    }
}