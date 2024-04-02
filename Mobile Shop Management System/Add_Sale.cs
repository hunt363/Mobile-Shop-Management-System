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
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;

namespace Mobile_Shop_Management_System {
    public partial class Add_Sale : Form {
        private int amount = 0;
        private int p_amount = 0;
        private int a_amount = 0;
        public Add_Sale() {
            InitializeComponent();
        }

        private void Add_Transactions_Load(object sender, EventArgs e) {
            OleDbConnection con = new OleDbConnection(Program.ConnectionString);
            con.Open();
            string sql = "select Model from Phones";
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbDataReader reader = cmd.ExecuteReader();
            while(reader.Read()) {
                ComBox_Phones.Items.Add(reader[0]);
            }
            reader.Close();

            sql = "select Model from Accessories";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();
            while(reader.Read()) {
                ComBox_Accessories.Items.Add(reader[0]);
            }
            reader.Close();

            sql = "select CName from Customers";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();
            while(reader.Read()) {
                ComBox_Customers.Items.Add(reader[0]);
            }
            cmd.Dispose();
            con.Close();
        }

        private void Btn_Submit_Click(object sender, EventArgs e) {
            if((ComBox_Phones.SelectedItem != null||ComBox_Accessories.SelectedItem!=null)&&ComBox_Customers.SelectedItem!=null) {
                Btn_Submit.Text = "Processing...";
                int p_id = 0, a_id = 0, c_id = 0, b_id = 0, s_id=0, p_qty=0, a_qty=0; string sql = "";
                OleDbConnection con = new OleDbConnection(Program.ConnectionString);
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataReader reader;
                cmd.Connection = con;
                if(ComBox_Phones.SelectedItem != null){
                    sql = "select PhoneID from Phones where Model=@model";
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@model", ComBox_Phones.SelectedItem.ToString());
                    reader = cmd.ExecuteReader();
                    while(reader.Read()){
                        p_id = reader.GetInt32(0);
                    }reader.Close();
                    sql = "select Quantity from Phones where Model=@model";
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@model", ComBox_Phones.SelectedItem.ToString());
                    reader = cmd.ExecuteReader();
                    while(reader.Read()) {
                        p_qty = reader.GetInt32(0);
                    }reader.Close();
                    cmd.Parameters.Clear();
                    p_qty -= (int)Qty_Phone.Value;
                    sql = "update Phones set Quantity = @p_qty where Model=@model";
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@p_qty", p_qty);
                    cmd.Parameters.AddWithValue("@model", ComBox_Phones.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }

                if(ComBox_Accessories.SelectedItem != null) {
                    sql = "select AccessoryID from Accessories where Model=@model";
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@model", ComBox_Accessories.SelectedItem.ToString());
                    reader = cmd.ExecuteReader();
                    while(reader.Read()) {
                        a_id = reader.GetInt32(0);
                    }reader.Close();
                    sql = "select Quantity from Accessories where Model=@model";
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@model", ComBox_Accessories.SelectedItem.ToString());
                    reader = cmd.ExecuteReader();
                    while(reader.Read()) {
                        a_qty = reader.GetInt32(0);
                    }reader.Close();
                    cmd.Parameters.Clear();
                    a_qty -= (int)Qty_Accessories.Value;
                    sql = "update Accessories set Quantity = @a_qty where Model=@model";
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@a_qty", a_qty);
                    cmd.Parameters.AddWithValue("@model", ComBox_Accessories.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }

                if(ComBox_Customers.SelectedItem != null) {
                    sql = "select CustomerID from Customers where Name=@name";
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@name", ComBox_Customers.SelectedItem.ToString());
                    reader = cmd.ExecuteReader();
                    while(reader.Read()) {
                        c_id = reader.GetInt32(0);
                    }reader.Close();
                }

                sql = "select max(Bill_ID) from Bills";
                cmd.CommandText = sql;
                reader = cmd.ExecuteReader();
                while(reader.Read()) {
                    if(!reader.IsDBNull(0)) {
                        b_id = reader.GetInt32(0);
                    } else {
                        b_id = 1;
                    }
                }reader.Close();
                b_id++;
                string type = "Sale";
                p_qty = int.Parse(Qty_Phone.Value.ToString());
                a_qty = int.Parse(Qty_Accessories.Value.ToString());
                DateTime date = Picker_Date.Value.Date;
                TimeSpan time = Picker_Time.Value.TimeOfDay;

                sql = "insert into Bills(Bill_ID, Type, BDate, BTime, CustomerID, SupplierID, PhoneID, PQuantity, AccessoryID, AQuantity, Amount) values(@b_id, @type, @date, @time, @c_id, @s_id, @p_id, @p_qty, @a_id, @a_qty, @amount)";
                cmd.Parameters.Clear();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@b_id", b_id);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.Add("@date", OleDbType.Date).Value = date;
                cmd.Parameters.Add("@time", OleDbType.DBTime).Value = time;
                cmd.Parameters.AddWithValue("@c_id", c_id);
                cmd.Parameters.AddWithValue("@s_id", s_id);
                cmd.Parameters.AddWithValue("@p_id", p_id);
                cmd.Parameters.AddWithValue("@p_qty", p_qty);
                cmd.Parameters.AddWithValue("@a_id", a_id);
                cmd.Parameters.AddWithValue("@a_qty", a_qty);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                Btn_Submit.Text = "Submit";
                MessageBox.Show("Added Successfully", "Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e) {
            Qty_Phone.Value = 0;
            Qty_Accessories.Value = 0;
            ComBox_Customers.SelectedItem = null;
            ComBox_Accessories.SelectedItem = null;
            ComBox_Phones.SelectedItem = null;
            TxtBox_Total.Text = "";
            Btn_Submit.Enabled = false;
            OleDbConnection con = new OleDbConnection(Program.ConnectionString);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("delete * from Bill_Temp;", con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        private void Btn_Calc_Click(object sender, EventArgs e) {
            amount = 0;
            OleDbConnection con = new OleDbConnection(Program.ConnectionString);
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader reader;
            cmd.Connection = con;
            string sql;
            if(ComBox_Phones.SelectedItem != null && Qty_Phone.Value!=0) {
                sql = "select Price from Phones where Model=@model";
                cmd.CommandText = sql;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@model", ComBox_Phones.SelectedItem.ToString());
                reader = cmd.ExecuteReader();
                while(reader.Read()) {
                    p_amount += reader.GetInt32(0) * (int)Qty_Phone.Value;
                    amount += p_amount;
                }
                reader.Close();
            }

            if(ComBox_Accessories.SelectedItem != null && Qty_Accessories.Value != 0) {
                sql = "select Price from Accessories where Model=@model";
                cmd.CommandText = sql;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@model", ComBox_Accessories.SelectedItem.ToString());
                reader = cmd.ExecuteReader();
                while(reader.Read()) {
                    a_amount += reader.GetInt32(0) * (int)Qty_Accessories.Value;
                    amount += a_amount;
                    
                }
                reader.Close();
            }

            TxtBox_Total.Text = amount.ToString();
            Btn_Submit.Enabled = true;
        }

        private void Btn_Bill_Click(object sender, EventArgs e) {
            OleDbConnection con0 = new OleDbConnection(Program.ConnectionString);
            con0.Open();
            string sql0 = "delete * from Bill_Temp";
            OleDbCommand cmd0 = new OleDbCommand(sql0, con0);
            cmd0.ExecuteNonQuery();
            cmd0.Dispose();
            con0.Close();
            if(ComBox_Phones.SelectedItem != null) {
                OleDbConnection con = new OleDbConnection(Program.ConnectionString);
                con.Open();
                int no = 0;
                string sql = "select count(*) from Bill_Temp";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while(reader.Read()) {
                    no = reader.GetInt32(0) + 1;
                }
                reader.Close();
                string product = ComBox_Phones.SelectedItem.ToString();
                int qty = int.Parse(Qty_Phone.Value.ToString());
                int rate = 0;
                sql = "select Price from Phones where Model = @model";
                cmd.CommandText = sql;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@model", ComBox_Phones.SelectedItem.ToString());
                reader = cmd.ExecuteReader();
                while(reader.Read()) {
                    rate = reader.GetInt32(0);
                }
                reader.Close();
                int amounts = rate * qty;
                cmd.Parameters.Clear();
                sql = "insert into Bill_Temp(SrNo, Product, Rate, Quantity, Amount) values(@no,@product,@rate,@qty,@amount)";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@no", no);
                cmd.Parameters.AddWithValue("@product", product);
                cmd.Parameters.AddWithValue("@rate", rate);
                cmd.Parameters.AddWithValue("@qty", qty);
                cmd.Parameters.AddWithValue("@amount", amounts);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            if(ComBox_Accessories.SelectedItem != null) {
                OleDbConnection con = new OleDbConnection(Program.ConnectionString);
                con.Open();
                int no = 0;
                string sql = "select count(*) from Bill_Temp";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while(reader.Read()) {
                    no = reader.GetInt32(0) + 1;
                }
                reader.Close();
                string product = ComBox_Accessories.SelectedItem.ToString();
                int qty = int.Parse(Qty_Accessories.Value.ToString());
                int rate = 0;
                sql = "select Price from Accessories where Model = @model";
                cmd = new OleDbCommand(sql, con);
                cmd.Parameters.AddWithValue("@model", ComBox_Accessories.SelectedItem.ToString());
                reader = cmd.ExecuteReader();
                while(reader.Read()) {
                    rate = reader.GetInt32(0);
                }
                reader.Close();
                int amounts = rate * qty;
                cmd.Parameters.Clear();
                sql = "insert into Bill_Temp(SrNo, Product, Rate, Quantity, Amount) values(@no,@product,@rate,@qty,@amount)";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@no", no);
                cmd.Parameters.AddWithValue("@product", product);
                cmd.Parameters.AddWithValue("@rate", rate);
                cmd.Parameters.AddWithValue("@qty", qty);
                cmd.Parameters.AddWithValue("@amount", amounts);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            if(ComBox_Phones.SelectedItem != null || ComBox_Accessories.SelectedItem != null) {
                Bill bill = new Bill();
                TextObject txt = (TextObject)bill.ReportDefinition.Sections["Section4"].ReportObjects["Txt_Party"];
                txt.Text = "To " + ComBox_Customers.Text;
                crystalReportViewer1.ReportSource = bill;
                crystalReportViewer1.Visible = true;
                //OleDbConnection con = new OleDbConnection(Program.ConnectionString);
                //con.Open();
                //OleDbCommand cmd = new OleDbCommand("delete * from Bill_Temp", con);
                //cmd.ExecuteNonQuery();
                //cmd.Dispose();
                //con.Close();
            }
        }
    }
}
