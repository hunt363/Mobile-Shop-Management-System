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

namespace Mobile_Shop_Management_System
{
    public partial class Add_Supplier : Form
    {
        public Add_Supplier()
        {
            InitializeComponent();
        }

        private void Btn_Add_Customer_Click(object sender, EventArgs e){
            OleDbConnection con = new OleDbConnection(Program.ConnectionString);
            con.Open();
            string sql = "select count(*) from Suppliers";
            int s_id = 0;
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                s_id = reader.GetInt32(0) + 1;
            }
            reader.Close();
            sql = "insert into Suppliers(SupplierID,SName,Address,Phone) values (@s_id,@name,@add,@phone)";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@s_id", s_id);
            cmd.Parameters.AddWithValue("@name", Txt_Name.Text);
            cmd.Parameters.AddWithValue("@add", Txt_Address.Text);
            cmd.Parameters.AddWithValue("@phone", Txt_Phone.Text);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            MessageBox.Show("Added Successfully", "Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Controls.Clear();
            InitializeComponent();
        }

        private void Add_Supplier_Load(object sender, EventArgs e) {

        }
    }
}
