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
    public partial class Add_Customer : Form {
        public Add_Customer() {
            InitializeComponent();
        }

        private void Btn_Add_Customer_Click(object sender, EventArgs e) {
            OleDbConnection con = new OleDbConnection(Program.ConnectionString);
            con.Open();
            string sql = "select count(*) from Customers";
            int c_id=0;
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                c_id = reader.GetInt32(0) + 1;
            }
            reader.Close();
            sql = "insert into Customers(CustomerID,CName,Phone,Address) values (@c_id,@name,@phone,@add)";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@c_id", c_id);
            cmd.Parameters.AddWithValue("@name", Txt_Name.Text);
            cmd.Parameters.AddWithValue("@phone", Txt_Phone.Text);
            cmd.Parameters.AddWithValue("@address", Txt_Address.Text);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            MessageBox.Show("Added Successfully", "Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Controls.Clear();
            InitializeComponent();
        }

        private void Add_Customer_Load(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }
    }
}
