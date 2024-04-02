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
    public partial class Search_Stock : Form {
        public Search_Stock() {
            InitializeComponent();
        }

        private void ComBox_Type_SelectedIndexChanged(object sender, EventArgs e) {
            ListBox_Specs.Items.Clear();
            ComBox_Model.SelectedText="";
            ComBox_Model.Items.Clear();
            OleDbConnection con = new OleDbConnection(Program.ConnectionString);
            con.Open();
            string table = ComBox_Type.SelectedItem.ToString();
            string sql = "select Model from " + table;
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbDataReader reader = cmd.ExecuteReader();
            while(reader.Read()) {
                ComBox_Model.Items.Add(reader.GetString(0));
            }reader.Close();
            con.Close();
            ComBox_Model.Enabled = true;
        }

        private void ComBox_Model_SelectedIndexChanged(object sender, EventArgs e) {
            ListBox_Specs.Items.Clear();
            OleDbConnection con = new OleDbConnection(Program.ConnectionString);
            con.Open();
            string table = ComBox_Type.SelectedItem.ToString();
            string model = ComBox_Model.SelectedItem.ToString();
            string sql = "select * from " + table + " where Model = '" + model+"'";
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbDataReader reader = cmd.ExecuteReader();
            while(reader.Read()) {
                string item;
                for(int i = 1; i < reader.FieldCount; i++) {
                    item = reader.GetName(i).ToString() + ": " + reader.GetValue(i).ToString();
                    ListBox_Specs.Items.Add(item);
                }
            }reader.Close();
            con.Close();
        }
    }
}
