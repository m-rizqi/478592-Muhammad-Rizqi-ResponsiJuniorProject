namespace Responsi_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbName = new TextBox();
            tbDepartemen = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Logo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama Karyawan :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 76);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 2;
            label3.Text = "Dep. Karyawan :";
            // 
            // tbName
            // 
            tbName.Location = new Point(117, 39);
            tbName.Name = "tbName";
            tbName.Size = new Size(218, 23);
            tbName.TabIndex = 3;
            // 
            // tbDepartemen
            // 
            tbDepartemen.Location = new Point(117, 73);
            tbDepartemen.Name = "tbDepartemen";
            tbDepartemen.Size = new Size(218, 23);
            tbDepartemen.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(620, 39);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 5;
            label4.Text = "ID Departemen:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(620, 64);
            label5.Name = "label5";
            label5.Size = new Size(123, 15);
            label5.TabIndex = 6;
            label5.Text = "HR : Human Resource";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(620, 81);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 7;
            label6.Text = "ENG : Engineer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(620, 96);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 8;
            label7.Text = "DEV : Developer";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(620, 111);
            label8.Name = "label8";
            label8.Size = new Size(126, 15);
            label8.TabIndex = 9;
            label8.Text = "PM : Product Manager";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(620, 126);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 10;
            label9.Text = "FIN: Finance";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(12, 118);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 11;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(158, 118);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(308, 118);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvList
            // 
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(12, 180);
            dgvList.Name = "dgvList";
            dgvList.RowTemplate.Height = 25;
            dgvList.Size = new Size(776, 258);
            dgvList.TabIndex = 14;
            dgvList.CellContentClick += dgvList_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvList);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbDepartemen);
            Controls.Add(tbName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbName;
        private TextBox tbDepartemen;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvList;
    }
}
