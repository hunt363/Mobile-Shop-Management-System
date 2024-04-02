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
    public partial class Bill_Generation : Form {
        public Bill_Generation() {
            InitializeComponent();
        }

        private void Bill_Generation_Load(object sender, EventArgs e) {
        }
        private void ComBox_Type_SelectedIndexChanged(object sender, EventArgs e) {
            ComBox_Party.Items.Clear();
            OleDbConnection con = new OleDbConnection(Program.ConnectionString);
            con.Open();
            string sql = "select " + ComBox_Type.Text.ToString()[0] + "Name from " + ComBox_Type.Text.ToString() + "s";
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbDataReader reader = cmd.ExecuteReader();
            while(reader.Read()) {
                ComBox_Party.Items.Add(reader[0]);
            }reader.Close();
            con.Close();
            ComBox_Party.Enabled = true;
        }

        private void ComBox_Party_SelectedIndexChanged(object sender, EventArgs e) {
            OleDbConnection con = new OleDbConnection(Program.ConnectionString);
            con.Open();
            string party = ComBox_Type.SelectedItem.ToString();
            string name = ComBox_Party.SelectedItem.ToString();
            string sql = "select " + party + "ID from " + party + "s where " + party[0] + "Name = '" + name+"'";
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbDataReader reader = cmd.ExecuteReader();
            int p_id = 0;
            while(reader.Read()) {
                p_id = reader.GetInt32(0);
            }reader.Close();

            sql = "select Bill_ID, BDate, BTime, Amount from Bills where " + party + "ID=" + p_id;
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();
            DataTable schemaTable = reader.GetSchemaTable();
            while(reader.Read()) {
                string bid = reader.GetInt32(0).ToString();
                string date = reader.GetDateTime(1).ToShortDateString();
                string time = reader.GetDateTime(2).ToShortTimeString();
                string amount = "₹" + reader.GetInt32(3).ToString();
                string ListItem = bid + " | " + date + " | " + time + " | " + amount;
                ListBox_Bills.Items.Add(ListItem);
            }reader.Close();
            con.Close();
        }

        private void Btn_Bill_Click(object sender, EventArgs e) {
            if(ListBox_Bills.SelectedItems.Count == 1) {
                int p_id = 0, a_id = 0, p_qty = 0, a_qty = 0, p_rate = 0, a_rate = 0;
                string party = "", phone = "", accessory = "";
                int b_id = int.Parse(ListBox_Bills.SelectedItem.ToString()[0].ToString());
                OleDbConnection con = new OleDbConnection(Program.ConnectionString);
                con.Open();
                string sql = "delete * from Bill_Temp";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                sql = "select * from Bills where Bill_ID = "+b_id;
                cmd.CommandText = sql;
                OleDbDataReader reader = cmd.ExecuteReader();
                while(reader.Read()) {
                    p_id = reader.GetInt32(6);
                    p_qty = reader.GetInt32(7);
                    a_id = reader.GetInt32(8);
                    a_qty = reader.GetInt32(9);
                }reader.Close();
                sql="select Brand, Model, Price from Phones where PhoneID = "+p_id;
                cmd.CommandText = sql;
                reader = cmd.ExecuteReader();
                while(reader.Read()) {
                    phone = reader.GetString(0) + " " + reader.GetString(1);
                    p_rate = reader.GetInt32(2);
                }reader.Close();
                sql = "select Brand, Model, Price from Accessories where AccessoryID = " + a_id;
                cmd.CommandText = sql;
                reader = cmd.ExecuteReader();
                while(reader.Read()) {
                    accessory = reader.GetString(0) + " " + reader.GetString(1);
                    a_rate = reader.GetInt32(2);
                }reader.Close();
                party = ComBox_Party.SelectedItem.ToString();
                if(p_qty != 0) {
                    cmd.Parameters.Clear();
                    int amount = p_rate * p_qty;
                    sql = "insert into Bill_Temp(SrNo, Product, Rate, Quantity, Amount) values(@no,@product,@rate,@qty,@amount)";
                    cmd.CommandText = sql;
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@no", 1);
                    cmd.Parameters.AddWithValue("@product", phone);
                    cmd.Parameters.AddWithValue("@rate", p_rate);
                    cmd.Parameters.AddWithValue("@qty", p_qty);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.ExecuteNonQuery();
                }
                if(a_qty != 0) {
                    cmd.Parameters.Clear();
                    int amount = a_rate * a_qty;
                    sql = "insert into Bill_Temp(SrNo, Product, Rate, Quantity, Amount) values(@no,@product,@rate,@qty,@amount)";
                    cmd.CommandText = sql;
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@no", 1);
                    cmd.Parameters.AddWithValue("@product", accessory);
                    cmd.Parameters.AddWithValue("@rate", a_rate);
                    cmd.Parameters.AddWithValue("@qty", a_qty);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.ExecuteNonQuery();
                }
                Bill bill = new Bill();
                TextObject txt = (TextObject)bill.ReportDefinition.Sections["Section4"].ReportObjects["Txt_Party"];
                txt.Text = ComBox_Party.Text;
                crystalReportViewer1.ReportSource = bill;
                crystalReportViewer1.Visible = true;
                //cmd.CommandText = "delete * from Bill_Temp";
                //cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
