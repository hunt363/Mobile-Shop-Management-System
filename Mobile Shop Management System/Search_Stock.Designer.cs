namespace Mobile_Shop_Management_System {
    partial class Search_Stock {
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
            this.ComBox_Model = new System.Windows.Forms.ComboBox();
            this.ListBox_Specs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            "Phones",
            "Accessories"});
            this.ComBox_Type.Location = new System.Drawing.Point(82, 103);
            this.ComBox_Type.Name = "ComBox_Type";
            this.ComBox_Type.Size = new System.Drawing.Size(229, 25);
            this.ComBox_Type.TabIndex = 0;
            this.ComBox_Type.SelectedIndexChanged += new System.EventHandler(this.ComBox_Type_SelectedIndexChanged);
            // 
            // ComBox_Model
            // 
            this.ComBox_Model.Enabled = false;
            this.ComBox_Model.FormattingEnabled = true;
            this.ComBox_Model.Location = new System.Drawing.Point(82, 134);
            this.ComBox_Model.Name = "ComBox_Model";
            this.ComBox_Model.Size = new System.Drawing.Size(229, 25);
            this.ComBox_Model.TabIndex = 1;
            this.ComBox_Model.SelectedIndexChanged += new System.EventHandler(this.ComBox_Model_SelectedIndexChanged);
            // 
            // ListBox_Specs
            // 
            this.ListBox_Specs.FormattingEnabled = true;
            this.ListBox_Specs.ItemHeight = 17;
            this.ListBox_Specs.Location = new System.Drawing.Point(82, 165);
            this.ListBox_Specs.Name = "ListBox_Specs";
            this.ListBox_Specs.Size = new System.Drawing.Size(229, 208);
            this.ListBox_Specs.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Details";
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
            this.label4.Size = new System.Drawing.Size(282, 65);
            this.label4.TabIndex = 0;
            this.label4.Text = "Search Stock";
            // 
            // Search_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBox_Specs);
            this.Controls.Add(this.ComBox_Model);
            this.Controls.Add(this.ComBox_Type);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Search_Stock";
            this.Text = "Search_Stock";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComBox_Type;
        private System.Windows.Forms.ComboBox ComBox_Model;
        private System.Windows.Forms.ListBox ListBox_Specs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}