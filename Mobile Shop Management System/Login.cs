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
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e) {
            OleDbConnection con = new OleDbConnection(Program.ConnectionString);
            string username="-1", password="-1";
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select Username, Password from Login", con);
            OleDbDataReader reader = cmd.ExecuteReader();
            while(reader.Read()) {
                username = reader.GetString(0);
                password = reader.GetString(1);
            }reader.Close();
            cmd.Dispose();
            con.Close();
            if((string.Equals(TxtBox_username.Text, username)) && (string.Equals(TxtBox_password.Text, password))) {
                MessageBox.Show("Login Successful");
                this.DialogResult = DialogResult.OK;
            } else {
                MessageBox.Show("Credentials invalid, please try again");
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e) {
            this.Close();
            this.DialogResult = DialogResult.Abort;
        }
    }
}
