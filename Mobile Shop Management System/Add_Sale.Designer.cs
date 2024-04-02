namespace Mobile_Shop_Management_System {
    partial class Add_Sale {
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
            this.Picker_Date = new System.Windows.Forms.DateTimePicker();
            this.Qty_Accessories = new System.Windows.Forms.NumericUpDown();
            this.ComBox_Accessories = new System.Windows.Forms.ComboBox();
            this.ComBox_Phones = new System.Windows.Forms.ComboBox();
            this.ComBox_Customers = new System.Windows.Forms.ComboBox();
            this.Btn_Phone_Rem = new System.Windows.Forms.Button();
            this.Picker_Time = new System.Windows.Forms.DateTimePicker();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.Qty_Phone = new System.Windows.Forms.NumericUpDown();
            this.TxtBox_Total = new System.Windows.Forms.TextBox();
            this.Btn_Calc = new System.Windows.Forms.Button();
            this.Btn_Bill = new System.Windows.Forms.Button();
            this.billGen1 = new Mobile_Shop_Management_System.BillGen();
            this.tempBill1 = new Mobile_Shop_Management_System.TempBill();
            this.bill_TempTableAdapter1 = new Mobile_Shop_Management_System.BillGenTableAdapters.Bill_TempTableAdapter();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Qty_Accessories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Qty_Phone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billGen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempBill1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Picker_Date
            // 
            this.Picker_Date.Location = new System.Drawing.Point(100, 114);
            this.Picker_Date.Name = "Picker_Date";
            this.Picker_Date.Size = new System.Drawing.Size(158, 25);
            this.Picker_Date.TabIndex = 0;
            // 
            // Qty_Accessories
            // 
            this.Qty_Accessories.Location = new System.Drawing.Point(264, 209);
            this.Qty_Accessories.Name = "Qty_Accessories";
            this.Qty_Accessories.Size = new System.Drawing.Size(58, 25);
            this.Qty_Accessories.TabIndex = 27;
            // 
            // ComBox_Accessories
            // 
            this.ComBox_Accessories.FormattingEnabled = true;
            this.ComBox_Accessories.Location = new System.Drawing.Point(100, 209);
            this.ComBox_Accessories.Name = "ComBox_Accessories";
            this.ComBox_Accessories.Size = new System.Drawing.Size(158, 25);
            this.ComBox_Accessories.TabIndex = 25;
            // 
            // ComBox_Phones
            // 
            this.ComBox_Phones.FormattingEnabled = true;
            this.ComBox_Phones.Location = new System.Drawing.Point(100, 177);
            this.ComBox_Phones.Name = "ComBox_Phones";
            this.ComBox_Phones.Size = new System.Drawing.Size(158, 25);
            this.ComBox_Phones.TabIndex = 24;
            // 
            // ComBox_Customers
            // 
            this.ComBox_Customers.FormattingEnabled = true;
            this.ComBox_Customers.Location = new System.Drawing.Point(100, 240);
            this.ComBox_Customers.Name = "ComBox_Customers";
            this.ComBox_Customers.Size = new System.Drawing.Size(158, 25);
            this.ComBox_Customers.TabIndex = 22;
            // 
            // Btn_Phone_Rem
            // 
            this.Btn_Phone_Rem.Location = new System.Drawing.Point(100, 304);
            this.Btn_Phone_Rem.Name = "Btn_Phone_Rem";
            this.Btn_Phone_Rem.Size = new System.Drawing.Size(158, 30);
            this.Btn_Phone_Rem.TabIndex = 21;
            this.Btn_Phone_Rem.Text = "Clear";
            this.Btn_Phone_Rem.UseVisualStyleBackColor = true;
            this.Btn_Phone_Rem.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Picker_Time
            // 
            this.Picker_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Picker_Time.Location = new System.Drawing.Point(100, 147);
            this.Picker_Time.Name = "Picker_Time";
            this.Picker_Time.Size = new System.Drawing.Size(158, 25);
            this.Picker_Time.TabIndex = 17;
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.Enabled = false;
            this.Btn_Submit.Location = new System.Drawing.Point(100, 375);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(158, 30);
            this.Btn_Submit.TabIndex = 16;
            this.Btn_Submit.Text = "Submit";
            this.Btn_Submit.UseVisualStyleBackColor = true;
            this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // Qty_Phone
            // 
            this.Qty_Phone.Location = new System.Drawing.Point(264, 178);
            this.Qty_Phone.Name = "Qty_Phone";
            this.Qty_Phone.Size = new System.Drawing.Size(58, 25);
            this.Qty_Phone.TabIndex = 6;
            // 
            // TxtBox_Total
            // 
            this.TxtBox_Total.Location = new System.Drawing.Point(100, 272);
            this.TxtBox_Total.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBox_Total.Name = "TxtBox_Total";
            this.TxtBox_Total.ReadOnly = true;
            this.TxtBox_Total.Size = new System.Drawing.Size(158, 25);
            this.TxtBox_Total.TabIndex = 38;
            // 
            // Btn_Calc
            // 
            this.Btn_Calc.Location = new System.Drawing.Point(19, 272);
            this.Btn_Calc.Name = "Btn_Calc";
            this.Btn_Calc.Size = new System.Drawing.Size(75, 25);
            this.Btn_Calc.TabIndex = 40;
            this.Btn_Calc.Text = "Calculate";
            this.Btn_Calc.UseVisualStyleBackColor = true;
            this.Btn_Calc.Click += new System.EventHandler(this.Btn_Calc_Click);
            // 
            // Btn_Bill
            // 
            this.Btn_Bill.Location = new System.Drawing.Point(100, 340);
            this.Btn_Bill.Name = "Btn_Bill";
            this.Btn_Bill.Size = new System.Drawing.Size(158, 29);
            this.Btn_Bill.TabIndex = 56;
            this.Btn_Bill.Text = "Generate Bill";
            this.Btn_Bill.UseVisualStyleBackColor = true;
            this.Btn_Bill.Click += new System.EventHandler(this.Btn_Bill_Click);
            // 
            // billGen1
            // 
            this.billGen1.DataSetName = "BillGen";
            this.billGen1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tempBill1
            // 
            this.tempBill1.DataSetName = "TempBill";
            this.tempBill1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bill_TempTableAdapter1
            // 
            this.bill_TempTableAdapter1.ClearBeforeFill = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.EnableDrillDown = false;
            this.crystalReportViewer1.EnableRefresh = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(328, 82);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCopyButton = false;
            this.crystalReportViewer1.ShowGotoPageButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowPageNavigateButtons = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.ShowTextSearchButton = false;
            this.crystalReportViewer1.ShowZoomButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(778, 606);
            this.crystalReportViewer1.TabIndex = 57;
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 76);
            this.panel1.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 36F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 65);
            this.label3.TabIndex = 0;
            this.label3.Text = "Add Sale";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(56, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 19);
            this.label7.TabIndex = 59;
            this.label7.Text = "Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.Location = new System.Drawing.Point(56, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 19);
            this.label9.TabIndex = 60;
            this.label9.Text = "Time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 19);
            this.label10.TabIndex = 61;
            this.label10.Text = "Phone";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 19);
            this.label11.TabIndex = 62;
            this.label11.Text = "Accessory";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 243);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 19);
            this.label12.TabIndex = 63;
            this.label12.Text = "Customer";
            // 
            // Add_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1118, 730);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.Btn_Bill);
            this.Controls.Add(this.Btn_Calc);
            this.Controls.Add(this.TxtBox_Total);
            this.Controls.Add(this.Qty_Accessories);
            this.Controls.Add(this.ComBox_Accessories);
            this.Controls.Add(this.ComBox_Phones);
            this.Controls.Add(this.ComBox_Customers);
            this.Controls.Add(this.Btn_Phone_Rem);
            this.Controls.Add(this.Picker_Time);
            this.Controls.Add(this.Btn_Submit);
            this.Controls.Add(this.Qty_Phone);
            this.Controls.Add(this.Picker_Date);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Add_Sale";
            this.Text = "Add_Transactions";
            this.Load += new System.EventHandler(this.Add_Transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Qty_Accessories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Qty_Phone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billGen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempBill1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Picker_Date;
        private System.Windows.Forms.NumericUpDown Qty_Accessories;
        private System.Windows.Forms.ComboBox ComBox_Accessories;
        private System.Windows.Forms.ComboBox ComBox_Phones;
        private System.Windows.Forms.ComboBox ComBox_Customers;
        private System.Windows.Forms.Button Btn_Phone_Rem;
        private System.Windows.Forms.DateTimePicker Picker_Time;
        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.NumericUpDown Qty_Phone;
        private System.Windows.Forms.TextBox TxtBox_Total;
        private System.Windows.Forms.Button Btn_Calc;
        private System.Windows.Forms.Button Btn_Bill;
        private BillGen billGen1;
        private TempBill tempBill1;
        private BillGenTableAdapters.Bill_TempTableAdapter bill_TempTableAdapter1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}