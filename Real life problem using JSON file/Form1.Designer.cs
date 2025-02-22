namespace Real_life_problem_using_JSON_file
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
            txtName = new TextBox();
            txtPhone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            dgvContacts = new DataGridView();
            label3 = new Label();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvContacts).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(216, 23);
            txtName.TabIndex = 0;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 133);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(216, 23);
            txtPhone.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 105);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 3;
            label2.Text = "Phone:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 173);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 40);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(124, 173);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 40);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvContacts
            // 
            dgvContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContacts.Location = new Point(319, 48);
            dgvContacts.Name = "dgvContacts";
            dgvContacts.Size = new Size(344, 275);
            dgvContacts.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 304);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 8;
            label3.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 332);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(216, 23);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(txtSearch);
            Controls.Add(dgvContacts);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvContacts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtPhone;
        private Label label1;
        private Label label2;
        private Button btnAdd;
        private Button btnDelete;
        private DataGridView dgvContacts;
        private Label label3;
        private TextBox txtSearch;
    }
}
