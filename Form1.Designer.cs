namespace TeleDiary
{
    partial class PhoneDiary
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
            this.newBtn = new System.Windows.Forms.Button();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.firstNameTxtBox = new System.Windows.Forms.TextBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.lastNameTxtBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.phoneNumberLbl = new System.Windows.Forms.Label();
            this.phoneNumberTxtBox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.emailLbl = new System.Windows.Forms.Label();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.contactDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // newBtn
            // 
            this.newBtn.Location = new System.Drawing.Point(689, 36);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(140, 33);
            this.newBtn.TabIndex = 0;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLbl.Location = new System.Drawing.Point(22, 36);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(112, 22);
            this.firstNameLbl.TabIndex = 1;
            this.firstNameLbl.Text = "First Name : ";
            this.firstNameLbl.Click += new System.EventHandler(this.firstNameLbl_Click);
            // 
            // firstNameTxtBox
            // 
            this.firstNameTxtBox.Location = new System.Drawing.Point(173, 36);
            this.firstNameTxtBox.Name = "firstNameTxtBox";
            this.firstNameTxtBox.Size = new System.Drawing.Size(498, 26);
            this.firstNameTxtBox.TabIndex = 2;
            this.firstNameTxtBox.TextChanged += new System.EventHandler(this.firstNameTxtBox_TextChanged);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(689, 80);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(140, 33);
            this.loadBtn.TabIndex = 0;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLbl.Location = new System.Drawing.Point(22, 80);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(106, 22);
            this.lastNameLbl.TabIndex = 1;
            this.lastNameLbl.Text = "Last Name :";
            this.lastNameLbl.Click += new System.EventHandler(this.firstNameLbl_Click);
            // 
            // lastNameTxtBox
            // 
            this.lastNameTxtBox.Location = new System.Drawing.Point(173, 80);
            this.lastNameTxtBox.Name = "lastNameTxtBox";
            this.lastNameTxtBox.Size = new System.Drawing.Size(498, 26);
            this.lastNameTxtBox.TabIndex = 2;
            this.lastNameTxtBox.TextChanged += new System.EventHandler(this.firstNameTxtBox_TextChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(689, 126);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(140, 33);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // phoneNumberLbl
            // 
            this.phoneNumberLbl.AutoSize = true;
            this.phoneNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLbl.Location = new System.Drawing.Point(22, 126);
            this.phoneNumberLbl.Name = "phoneNumberLbl";
            this.phoneNumberLbl.Size = new System.Drawing.Size(145, 22);
            this.phoneNumberLbl.TabIndex = 1;
            this.phoneNumberLbl.Text = "Phone Number : ";
            this.phoneNumberLbl.Click += new System.EventHandler(this.firstNameLbl_Click);
            // 
            // phoneNumberTxtBox
            // 
            this.phoneNumberTxtBox.Location = new System.Drawing.Point(173, 126);
            this.phoneNumberTxtBox.Name = "phoneNumberTxtBox";
            this.phoneNumberTxtBox.Size = new System.Drawing.Size(498, 26);
            this.phoneNumberTxtBox.TabIndex = 2;
            this.phoneNumberTxtBox.TextChanged += new System.EventHandler(this.firstNameTxtBox_TextChanged);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(689, 173);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(140, 33);
            this.deleteBtn.TabIndex = 0;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(22, 173);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(64, 22);
            this.emailLbl.TabIndex = 1;
            this.emailLbl.Text = "Email :";
            this.emailLbl.Click += new System.EventHandler(this.firstNameLbl_Click);
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Location = new System.Drawing.Point(173, 173);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(498, 26);
            this.emailTxtBox.TabIndex = 2;
            this.emailTxtBox.TextChanged += new System.EventHandler(this.firstNameTxtBox_TextChanged);
            // 
            // contactDataGridView
            // 
            this.contactDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contactDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactDataGridView.Location = new System.Drawing.Point(26, 219);
            this.contactDataGridView.Name = "contactDataGridView";
            this.contactDataGridView.RowHeadersWidth = 62;
            this.contactDataGridView.RowTemplate.Height = 28;
            this.contactDataGridView.Size = new System.Drawing.Size(803, 291);
            this.contactDataGridView.TabIndex = 3;
            this.contactDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contactDataGridView_CellContentClick);
            this.contactDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contactDataGridView_CellDoubleClick);
            // 
            // PhoneDiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 522);
            this.Controls.Add(this.contactDataGridView);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.phoneNumberTxtBox);
            this.Controls.Add(this.phoneNumberLbl);
            this.Controls.Add(this.lastNameTxtBox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.firstNameTxtBox);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.newBtn);
            this.Name = "PhoneDiary";
            this.Text = "PhoneDiary";
            this.Load += new System.EventHandler(this.PhoneDiary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.TextBox firstNameTxtBox;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.TextBox lastNameTxtBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label phoneNumberLbl;
        private System.Windows.Forms.TextBox phoneNumberTxtBox;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.DataGridView contactDataGridView;
    }
}

