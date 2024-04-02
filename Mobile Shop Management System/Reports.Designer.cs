namespace Mobile_Shop_Management_System {
    partial class Reports {
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Btn_Sales_Report = new System.Windows.Forms.Button();
            this.Btn_Purchase_Report = new System.Windows.Forms.Button();
            this.Btn_Phone_Report = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(254, 83);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowGotoPageButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowPageNavigateButtons = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.ShowTextSearchButton = false;
            this.crystalReportViewer1.ShowZoomButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(852, 604);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Visible = false;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // Btn_Sales_Report
            // 
            this.Btn_Sales_Report.Location = new System.Drawing.Point(12, 126);
            this.Btn_Sales_Report.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Sales_Report.Name = "Btn_Sales_Report";
            this.Btn_Sales_Report.Size = new System.Drawing.Size(236, 30);
            this.Btn_Sales_Report.TabIndex = 1;
            this.Btn_Sales_Report.Text = "Generate Sales Report";
            this.Btn_Sales_Report.UseVisualStyleBackColor = true;
            this.Btn_Sales_Report.Click += new System.EventHandler(this.Btn_Sales_Report_Click);
            // 
            // Btn_Purchase_Report
            // 
            this.Btn_Purchase_Report.Location = new System.Drawing.Point(12, 88);
            this.Btn_Purchase_Report.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Purchase_Report.Name = "Btn_Purchase_Report";
            this.Btn_Purchase_Report.Size = new System.Drawing.Size(236, 30);
            this.Btn_Purchase_Report.TabIndex = 2;
            this.Btn_Purchase_Report.Text = "Generate Purchase Report";
            this.Btn_Purchase_Report.UseVisualStyleBackColor = true;
            this.Btn_Purchase_Report.Click += new System.EventHandler(this.Btn_Purchase_Report_Click);
            // 
            // Btn_Phone_Report
            // 
            this.Btn_Phone_Report.Location = new System.Drawing.Point(12, 199);
            this.Btn_Phone_Report.Name = "Btn_Phone_Report";
            this.Btn_Phone_Report.Size = new System.Drawing.Size(236, 30);
            this.Btn_Phone_Report.TabIndex = 3;
            this.Btn_Phone_Report.Text = "Generate Phone Stock Report";
            this.Btn_Phone_Report.UseVisualStyleBackColor = true;
            this.Btn_Phone_Report.Click += new System.EventHandler(this.Btn_Phone_Report_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generate Accessory Stock Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn_Accessory_Report_Click);
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
            this.panel1.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 36F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 65);
            this.label3.TabIndex = 0;
            this.label3.Text = "Generate Reports";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Phone_Report);
            this.Controls.Add(this.Btn_Purchase_Report);
            this.Controls.Add(this.Btn_Sales_Report);
            this.Controls.Add(this.crystalReportViewer1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Reports";
            this.Text = "Reports";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button Btn_Sales_Report;
        private System.Windows.Forms.Button Btn_Purchase_Report;
        private System.Windows.Forms.Button Btn_Phone_Report;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}