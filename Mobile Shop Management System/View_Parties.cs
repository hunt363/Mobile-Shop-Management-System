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
    public partial class View_Parties : Form {
        public View_Parties() {
            InitializeComponent();
        }

        private void ComBox_Type_SelectedIndexChanged(object sender, EventArgs e) {
            ComBox_Party.Items.Clear();
            TextBox_Address.Text = TextBox_Phone.Text = "";

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
            string table = ComBox_Type.SelectedItem.ToString()+"s";
            string name = ComBox_Party.SelectedItem.ToString();
            string sql = "select Address, Phone from " + table + " where " + table[0].ToString() + "Name = '" + name + "'";
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbDataReader reader = cmd.ExecuteReader();
            while(reader.Read()) {
                TextBox_Address.Text = reader.GetString(0);
                TextBox_Phone.Text = reader.GetString(1);
            }reader.Close();
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void View_Parties_Load(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }
    }
}
