namespace Mobile_Shop_Management_System {
    partial class Bill_Generation {
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
            this.Btn_Bill = new System.Windows.Forms.Button();
            this.ComBox_Party = new System.Windows.Forms.ComboBox();
            this.ListBox_Bills = new System.Windows.Forms.ListBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.ComBox_Type.Location = new System.Drawing.Point(70, 97);
            this.ComBox_Type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComBox_Type.Name = "ComBox_Type";
            this.ComBox_Type.Size = new System.Drawing.Size(140, 25);
            this.ComBox_Type.TabIndex = 0;
            this.ComBox_Type.SelectedIndexChanged += new System.EventHandler(this.ComBox_Type_SelectedIndexChanged);
            // 
            // Btn_Bill
            // 
            this.Btn_Bill.Location = new System.Drawing.Point(70, 163);
            this.Btn_Bill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Bill.Name = "Btn_Bill";
            this.Btn_Bill.Size = new System.Drawing.Size(140, 30);
            this.Btn_Bill.TabIndex = 1;
            this.Btn_Bill.Text = "Generate";
            this.Btn_Bill.UseVisualStyleBackColor = true;
            this.Btn_Bill.Click += new System.EventHandler(this.Btn_Bill_Click);
            // 
            // ComBox_Party
            // 
            this.ComBox_Party.Enabled = false;
            this.ComBox_Party.FormattingEnabled = true;
            this.ComBox_Party.Location = new System.Drawing.Point(70, 130);
            this.ComBox_Party.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComBox_Party.Name = "ComBox_Party";
            this.ComBox_Party.Size = new System.Drawing.Size(140, 25);
            this.ComBox_Party.TabIndex = 2;
            this.ComBox_Party.SelectedIndexChanged += new System.EventHandler(this.ComBox_Party_SelectedIndexChanged);
            // 
            // ListBox_Bills
            // 
            this.ListBox_Bills.FormattingEnabled = true;
            this.ListBox_Bills.ItemHeight = 17;
            this.ListBox_Bills.Location = new System.Drawing.Point(11, 200);
            this.ListBox_Bills.Name = "ListBox_Bills";
            this.ListBox_Bills.Size = new System.Drawing.Size(310, 72);
            this.ListBox_Bills.TabIndex = 3;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.EnableDrillDown = false;
            this.crystalReportViewer1.EnableRefresh = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(325, 78);
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
            this.crystalReportViewer1.Size = new System.Drawing.Size(763, 610);
            this.crystalReportViewer1.TabIndex = 4;
            this.crystalReportViewer1.ToolPanelWidth = 0;
            this.crystalReportViewer1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Party";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 71);
            this.panel1.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 36F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 65);
            this.label4.TabIndex = 0;
            this.label4.Text = "Generate Bill";
            // 
            // Bill_Generation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.ListBox_Bills);
            this.Controls.Add(this.ComBox_Party);
            this.Controls.Add(this.Btn_Bill);
            this.Controls.Add(this.ComBox_Type);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Bill_Generation";
            this.Text = "Bill_Generation";
            this.Load += new System.EventHandler(this.Bill_Generation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComBox_Type;
        private System.Windows.Forms.Button Btn_Bill;
        private System.Windows.Forms.ComboBox ComBox_Party;
        private System.Windows.Forms.ListBox ListBox_Bills;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}