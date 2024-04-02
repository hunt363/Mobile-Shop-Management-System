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
    public partial class Add_Accessories : Form {
        public Add_Accessories() {
            InitializeComponent();
        }

        private void Btn_Add_Click(object sender, EventArgs e) {
            OleDbConnection con = new OleDbConnection(Program.ConnectionString);
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select count(*) from Accessories";
            int hp_id = 0;
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                hp_id = reader.GetInt32(0) + 1 ;
            }
            reader.Close();

            cmd.CommandText = "insert into Accessories(AccessoryID,Brand,Model,Type,Colour,Price) values(@hp_id,@brand,@model,@type,@colour,@price)";
            cmd.Parameters.AddWithValue("@hp_id", hp_id);
            cmd.Parameters.AddWithValue("@brand", ComBox_Brands.Text);
            cmd.Parameters.AddWithValue("@model", Txt_Model.Text);
            cmd.Parameters.AddWithValue("@type", ComBox_Type.Text);
            cmd.Parameters.AddWithValue("@colour", Txt_Colour.Text);
            cmd.Parameters.AddWithValue("@price", Txt_Price.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
            Controls.Clear();
            InitializeComponent();
            MessageBox.Show("Added Successfully", "Database", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }
    }
}
