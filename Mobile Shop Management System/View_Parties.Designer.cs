namespace Mobile_Shop_Management_System {
    partial class View_Parties {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            this.ComBox_Type = new System.Windows.Forms.ComboBox();
            this.label0 = new System.Windows.Forms.Label();
            this.ComBox_Party = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_Phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_Address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComBox_Type
            // 
            this.ComBox_Type.FormattingEnabled = true;
            this.ComBox_Type.Items.AddRange(new object[] {
            "Customer",
            "Supplier"});
            this.ComBox_Type.Location = new System.Drawing.Point(81, 96);
            this.ComBox_Type.Name = "ComBox_Type";
            this.ComBox_Type.Size = new System.Drawing.Size(121, 25);
            this.ComBox_Type.TabIndex = 0;
            this.ComBox_Type.SelectedIndexChanged += new System.EventHandler(this.ComBox_Type_SelectedIndexChanged);
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(38, 96);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(37, 19);
            this.label0.TabIndex = 1;
            this.label0.Text = "Type";
            // 
            // ComBox_Party
            // 
            this.ComBox_Party.Enabled = false;
            this.ComBox_Party.FormattingEnabled = true;
            this.ComBox_Party.Location = new System.Drawing.Point(81, 143);
            this.ComBox_Party.Name = "ComBox_Party";
            this.ComBox_Party.Size = new System.Drawing.Size(121, 25);
            this.ComBox_Party.TabIndex = 2;
            this.ComBox_Party.SelectedIndexChanged += new System.EventHandler(this.ComBox_Party_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Party";
            // 
            // TextBox_Phone
            // 
            this.TextBox_Phone.Location = new System.Drawing.Point(81, 239);
            this.TextBox_Phone.Name = "TextBox_Phone";
            this.TextBox_Phone.Size = new System.Drawing.Size(121, 25);
            this.TextBox_Phone.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phone";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TextBox_Address
            // 
            this.TextBox_Address.Location = new System.Drawing.Point(81, 190);
            this.TextBox_Address.Name = "TextBox_Address";
            this.TextBox_Address.Size = new System.Drawing.Size(121, 25);
            this.TextBox_Address.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Address";
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
            this.panel1.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 36F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 65);
            this.label4.TabIndex = 0;
            this.label4.Text = "View Parties";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // View_Parties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBox_Address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox_Phone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComBox_Party);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.ComBox_Type);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "View_Parties";
            this.Text = "View_Parties";
            this.Load += new System.EventHandler(this.View_Parties_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComBox_Type;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.ComboBox ComBox_Party;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_Phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_Address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}