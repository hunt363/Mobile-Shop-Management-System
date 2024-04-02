namespace Mobile_Shop_Management_System {
    partial class Add_Customer {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.Txt_Address = new System.Windows.Forms.TextBox();
            this.Txt_Phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Add_Customer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_Name
            // 
            this.Txt_Name.BackColor = System.Drawing.SystemColors.Window;
            this.Txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Name.Location = new System.Drawing.Point(124, 108);
            this.Txt_Name.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(172, 25);
            this.Txt_Name.TabIndex = 23;
            // 
            // Txt_Address
            // 
            this.Txt_Address.BackColor = System.Drawing.SystemColors.Window;
            this.Txt_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Address.Location = new System.Drawing.Point(124, 155);
            this.Txt_Address.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.Size = new System.Drawing.Size(172, 25);
            this.Txt_Address.TabIndex = 24;
            // 
            // Txt_Phone
            // 
            this.Txt_Phone.BackColor = System.Drawing.SystemColors.Window;
            this.Txt_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Phone.Location = new System.Drawing.Point(124, 201);
            this.Txt_Phone.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_Phone.Name = "Txt_Phone";
            this.Txt_Phone.Size = new System.Drawing.Size(172, 25);
            this.Txt_Phone.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Phone No.";
            // 
            // Btn_Add_Customer
            // 
            this.Btn_Add_Customer.Location = new System.Drawing.Point(49, 252);
            this.Btn_Add_Customer.Name = "Btn_Add_Customer";
            this.Btn_Add_Customer.Size = new System.Drawing.Size(247, 29);
            this.Btn_Add_Customer.TabIndex = 29;
            this.Btn_Add_Customer.Text = "Add";
            this.Btn_Add_Customer.UseVisualStyleBackColor = true;
            this.Btn_Add_Customer.Click += new System.EventHandler(this.Btn_Add_Customer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 76);
            this.panel1.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 36F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(423, 65);
            this.label4.TabIndex = 0;
            this.label4.Text = "Add New Customer";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Add_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Add_Customer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Phone);
            this.Controls.Add(this.Txt_Address);
            this.Controls.Add(this.Txt_Name);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Add_Customer";
            this.Text = "Add_Customer";
            this.Load += new System.EventHandler(this.Add_Customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.TextBox Txt_Address;
        private System.Windows.Forms.TextBox Txt_Phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Add_Customer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}