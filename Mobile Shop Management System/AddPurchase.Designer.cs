namespace Mobile_Shop_Management_System {
    partial class AddPurchase {
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
            this.Qty_Accessories = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.ComBox_Accessories = new System.Windows.Forms.ComboBox();
            this.ComBox_Phones = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ComBox_Suppliers = new System.Windows.Forms.ComboBox();
            this.Btn_Phone_Rem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Picker_Time = new System.Windows.Forms.DateTimePicker();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBox_Total = new System.Windows.Forms.TextBox();
            this.Qty_Phone = new System.Windows.Forms.NumericUpDown();
            this.Picker_Date = new System.Windows.Forms.DateTimePicker();
            this.Btn_Calc = new System.Windows.Forms.Button();
            this.Btn_Bill = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Qty_Accessories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Qty_Phone)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Qty_Accessories
            // 
            this.Qty_Accessories.Location = new System.Drawing.Point(283, 233);
            this.Qty_Accessories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Qty_Accessories.Name = "Qty_Accessories";
            this.Qty_Accessories.Size = new System.Drawing.Size(68, 25);
            this.Qty_Accessories.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 50;
            this.label5.Text = "Accessories";
            // 
            // ComBox_Accessories
            // 
            this.ComBox_Accessories.FormattingEnabled = true;
            this.ComBox_Accessories.Location = new System.Drawing.Point(93, 233);
            this.ComBox_Accessories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComBox_Accessories.Name = "ComBox_Accessories";
            this.ComBox_Accessories.Size = new System.Drawing.Size(184, 25);
            this.ComBox_Accessories.TabIndex = 49;
            // 
            // ComBox_Phones
            // 
            this.ComBox_Phones.FormattingEnabled = true;
            this.ComBox_Phones.Location = new System.Drawing.Point(93, 191);
            this.ComBox_Phones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComBox_Phones.Name = "ComBox_Phones";
            this.ComBox_Phones.Size = new System.Drawing.Size(184, 25);
            this.ComBox_Phones.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 47;
            this.label8.Text = "Supplier";
            // 
            // ComBox_Suppliers
            // 
            this.ComBox_Suppliers.FormattingEnabled = true;
            this.ComBox_Suppliers.Location = new System.Drawing.Point(93, 275);
            this.ComBox_Suppliers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComBox_Suppliers.Name = "ComBox_Suppliers";
            this.ComBox_Suppliers.Size = new System.Drawing.Size(184, 25);
            this.ComBox_Suppliers.TabIndex = 46;
            // 
            // Btn_Phone_Rem
            // 
            this.Btn_Phone_Rem.Location = new System.Drawing.Point(93, 341);
            this.Btn_Phone_Rem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Phone_Rem.Name = "Btn_Phone_Rem";
            this.Btn_Phone_Rem.Size = new System.Drawing.Size(184, 39);
            this.Btn_Phone_Rem.TabIndex = 45;
            this.Btn_Phone_Rem.Text = "Clear";
            this.Btn_Phone_Rem.UseVisualStyleBackColor = true;
            this.Btn_Phone_Rem.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 19);
            this.label6.TabIndex = 42;
            this.label6.Text = "Time";
            // 
            // Picker_Time
            // 
            this.Picker_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Picker_Time.Location = new System.Drawing.Point(93, 149);
            this.Picker_Time.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Picker_Time.Name = "Picker_Time";
            this.Picker_Time.Size = new System.Drawing.Size(184, 25);
            this.Picker_Time.TabIndex = 41;
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.Enabled = false;
            this.Btn_Submit.Location = new System.Drawing.Point(93, 435);
            this.Btn_Submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(184, 39);
            this.Btn_Submit.TabIndex = 40;
            this.Btn_Submit.Text = "Submit";
            this.Btn_Submit.UseVisualStyleBackColor = true;
            this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 39;
            this.label4.Text = "Phones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "Amount";
            // 
            // TxtBox_Total
            // 
            this.TxtBox_Total.Location = new System.Drawing.Point(93, 308);
            this.TxtBox_Total.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBox_Total.Name = "TxtBox_Total";
            this.TxtBox_Total.ReadOnly = true;
            this.TxtBox_Total.Size = new System.Drawing.Size(184, 25);
            this.TxtBox_Total.TabIndex = 36;
            // 
            // Qty_Phone
            // 
            this.Qty_Phone.Location = new System.Drawing.Point(283, 191);
            this.Qty_Phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Qty_Phone.Name = "Qty_Phone";
            this.Qty_Phone.Size = new System.Drawing.Size(68, 25);
            this.Qty_Phone.TabIndex = 33;
            // 
            // Picker_Date
            // 
            this.Picker_Date.Location = new System.Drawing.Point(93, 113);
            this.Picker_Date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Picker_Date.Name = "Picker_Date";
            this.Picker_Date.Size = new System.Drawing.Size(184, 25);
            this.Picker_Date.TabIndex = 32;
            // 
            // Btn_Calc
            // 
            this.Btn_Calc.Location = new System.Drawing.Point(283, 308);
            this.Btn_Calc.Name = "Btn_Calc";
            this.Btn_Calc.Size = new System.Drawing.Size(79, 25);
            this.Btn_Calc.TabIndex = 52;
            this.Btn_Calc.Text = "Calculate";
            this.Btn_Calc.UseVisualStyleBackColor = true;
            this.Btn_Calc.Click += new System.EventHandler(this.Btn_Calc_Click);
            // 
            // Btn_Bill
            // 
            this.Btn_Bill.Location = new System.Drawing.Point(93, 387);
            this.Btn_Bill.Name = "Btn_Bill";
            this.Btn_Bill.Size = new System.Drawing.Size(184, 41);
            this.Btn_Bill.TabIndex = 53;
            this.Btn_Bill.Text = "Generate Bill";
            this.Btn_Bill.UseVisualStyleBackColor = true;
            this.Btn_Bill.Click += new System.EventHandler(this.Btn_Bill_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.EnableDrillDown = false;
            this.crystalReportViewer1.EnableRefresh = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(368, 78);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowCopyButton = false;
            this.crystalReportViewer1.ShowGotoPageButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowPageNavigateButtons = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.ShowTextSearchButton = false;
            this.crystalReportViewer1.ShowZoomButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(738, 610);
            this.crystalReportViewer1.TabIndex = 55;
            this.crystalReportViewer1.ToolPanelWidth = 0;
            this.crystalReportViewer1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 71);
            this.panel1.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 36F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 65);
            this.label3.TabIndex = 0;
            this.label3.Text = "Add Purchase";
            // 
            // AddPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.Btn_Bill);
            this.Controls.Add(this.Btn_Calc);
            this.Controls.Add(this.Qty_Accessories);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComBox_Accessories);
            this.Controls.Add(this.ComBox_Phones);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ComBox_Suppliers);
            this.Controls.Add(this.Btn_Phone_Rem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Picker_Time);
            this.Controls.Add(this.Btn_Submit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBox_Total);
            this.Controls.Add(this.Qty_Phone);
            this.Controls.Add(this.Picker_Date);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddPurchase";
            this.Text = "AddPurchase";
            this.Load += new System.EventHandler(this.AddPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Qty_Accessories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Qty_Phone)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown Qty_Accessories;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComBox_Accessories;
        private System.Windows.Forms.ComboBox ComBox_Phones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ComBox_Suppliers;
        private System.Windows.Forms.Button Btn_Phone_Rem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Picker_Time;
        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBox_Total;
        private System.Windows.Forms.NumericUpDown Qty_Phone;
        private System.Windows.Forms.DateTimePicker Picker_Date;
        private System.Windows.Forms.Button Btn_Calc;
        private System.Windows.Forms.Button Btn_Bill;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}