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
    public partial class Add_Phone : Form {
        public Add_Phone() {
            InitializeComponent();
        }

        private void Btn_Add_Click(object sender, EventArgs e) {
            OleDbConnection con=new OleDbConnection(Program.ConnectionString);
            int p_id = 0;
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "select count(*) from Phones";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                p_id = reader.GetInt32(0) + 1;
            }reader.Close();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Phones(PhoneID,Brand,Model,Chipset,RAM,Storage,Colour,Price) values(@p_id,@brand,@model,@chipset,@ram,@storage,@colour,@price)";
            cmd.Parameters.AddWithValue("@p_id", p_id);
            cmd.Parameters.AddWithValue("@brand", ComBox_Brands.Text);
            cmd.Parameters.AddWithValue("@model", Txt_Model.Text);
            cmd.Parameters.AddWithValue("@chipset", Txt_Chipset.Text);
            cmd.Parameters.AddWithValue("@ram", ComBox_RAM.Text);
            cmd.Parameters.AddWithValue("storage", ComBox_Storage.Text);
            cmd.Parameters.AddWithValue("@colour", Txt_Colour.Text);
            cmd.Parameters.AddWithValue("@price", Txt_Price.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
            Controls.Clear();
            InitializeComponent();
            MessageBox.Show("Added Successfully", "Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
