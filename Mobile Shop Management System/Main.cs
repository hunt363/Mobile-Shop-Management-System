using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Mobile_Shop_Management_System {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Login login = new Login();
            login.Dock = DockStyle.Fill;
            login.ShowDialog();
            if(login.DialogResult == DialogResult.OK) {
                Panel_Main.Visible = true;
                login.Close();
                WindowState = FormWindowState.Maximized;
            }
            if(login.DialogResult==DialogResult.Abort) {
                this.Close();
            }
        }

        private void Btn_Stock_Form_CheckedChanged(object sender, EventArgs e) {
            Search_Stock Form_Stock = new Search_Stock();
            Panel_Main.Controls.Clear();
            Form_Stock.TopLevel = false;
            Form_Stock.Dock = DockStyle.Fill;
            Panel_Main.Controls.Add(Form_Stock);
            Panel_Side.Visible = true;
            Form_Stock.Show();
        }

        private void Btn_Settings_Form_CheckedChanged(object sender, EventArgs e) {

        }

        private void Btn_Add_Phone_Form_CheckedChanged(object sender, EventArgs e) {
            Add_Phone Form_Add_Phone = new Add_Phone();
            Panel_Main.Controls.Clear();
            Form_Add_Phone.TopLevel = false;
            Form_Add_Phone.Dock = DockStyle.Fill;
            Panel_Main.Controls.Add(Form_Add_Phone);
            Panel_Side.Visible = true;
            Form_Add_Phone.Show();
        }
        
        private void Btn_Add_Accessories_Form_CheckedChanged(object sender, EventArgs e){
            Add_Accessories Form_Add_Headphones = new Add_Accessories();
            Panel_Main.Controls.Clear();
            Form_Add_Headphones.TopLevel = false;
            Form_Add_Headphones.Dock = DockStyle.Fill;
            Panel_Main.Controls.Add(Form_Add_Headphones);
            Panel_Side.Visible = true;
            Form_Add_Headphones.Show();
        }

        private void Panel_Side_Paint(object sender, PaintEventArgs e) {

        }

        private void Panel_Main_Paint(object sender, PaintEventArgs e) {

        }

        private void Btn_Add_Sale_CheckedChanged(object sender, EventArgs e) {
            Add_Sale form = new Add_Sale();
            Panel_Main.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            Panel_Main.Controls.Add(form);
            Panel_Side.Visible = true;
            form.Show();
        }

        private void Btn_Home_Form_CheckedChanged(object sender, EventArgs e) {
            Panel_Main.Controls.Clear();
            Panel_Side.Visible = false;
            Panel_Main.Controls.Add(tableLayoutPanel1);
            foreach(RadioButton button in tableLayoutPanel1.Controls) {
                button.Checked = false;
            }
        }

        private void Btn_Add_Customers_CheckedChanged(object sender, EventArgs e) {
            Add_Customer Form_Add_Customer = new Add_Customer();
            Panel_Main.Controls.Clear();
            Form_Add_Customer.TopLevel = false;
            Form_Add_Customer.Dock = DockStyle.Fill;
            Panel_Main.Controls.Add(Form_Add_Customer);
            Panel_Side.Visible = true;
            Form_Add_Customer.Show();
        }

        private void Btn_View_Parties_CheckedChanged(object sender, EventArgs e) {
            View_Parties form = new View_Parties();
            Panel_Main.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            Panel_Main.Controls.Add(form);
            Panel_Side.Visible = true;
            form.Show();
        }

        private void Btn_Add_Supplier_CheckedChanged(object sender, EventArgs e){
            Add_Supplier Form_Add_Supplier = new Add_Supplier();
            Panel_Main.Controls.Clear();
            Form_Add_Supplier.TopLevel = false;
            Form_Add_Supplier.Dock = DockStyle.Fill;
            Panel_Main.Controls.Add(Form_Add_Supplier);
            Form_Add_Supplier.Show();
        }

        private void Btn_Add_Purchase_CheckedChanged(object sender, EventArgs e) {
            AddPurchase form = new AddPurchase();
            Panel_Main.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            Panel_Main.Controls.Add(form);
            Panel_Side.Visible = true;
            form.Show();
        }

        private void Btn_Bill_CheckedChanged(object sender, EventArgs e) {
            Bill_Generation form = new Bill_Generation();
            Panel_Main.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            Panel_Main.Controls.Add(form);
            Panel_Side.Visible = true;
            form.Show();
        }

        private void Btn_Reports_CheckedChanged(object sender, EventArgs e) {
            Reports form = new Reports();
            Panel_Main.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            Panel_Main.Controls.Add(form);
            Panel_Side.Visible = true;
            form.Show();
        }

        private void Btn_Sale_CheckedChanged(object sender, EventArgs e) {
            Btn_Add_Sale.Checked = true;
        }

        private void panelTop_Paint(object sender, PaintEventArgs e) {
            
        }

        private void Btn_Purchase_CheckedChanged(object sender, EventArgs e) {
            Btn_Add_Purchase_Form.Checked = true;
        }

        private void Btn_Phone_CheckedChanged(object sender, EventArgs e) {
            Btn_Add_Phone_Form.Checked = true;
        }

        private void Btn_Acc_CheckedChanged(object sender, EventArgs e) {
            Btn_Add_Accessories_Form.Checked = true;
        }

        private void Btn_Search_CheckedChanged(object sender, EventArgs e) {
            Btn_Stock_Form.Checked = true;
        }

        private void Btn_Sup_CheckedChanged(object sender, EventArgs e) {
            Btn_Add_Suppliers.Checked = true;
        }

        private void Btn_Cus_CheckedChanged(object sender, EventArgs e) {
            Btn_Add_Customers.Checked = true;
        }

        private void Btn_Part_CheckedChanged(object sender, EventArgs e) {
            Btn_View_Parties.Checked = true;
        }

        private void Btn_Gen_CheckedChanged(object sender, EventArgs e) {
            Btn_Bill.Checked = true;
        }

        private void Btn_Rep_CheckedChanged(object sender, EventArgs e) {
            Btn_Reports.Checked = true;
        }
    }
}
