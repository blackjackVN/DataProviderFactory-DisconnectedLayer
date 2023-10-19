using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDisconnectedLayer
{
    public partial class frmMyStore : Form
    {
        public frmMyStore()
        {
            InitializeComponent();
        }
        DataSet dsMyStore = new DataSet();
        private void button3_Click(object sender, EventArgs e) => this.Close();
        
        private void button1_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = dsMyStore.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = dsMyStore.Tables[1];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMyStore_Load(object sender, EventArgs e)
        {

            string ConnectionString = "Server=LAPTOP-RJMBBSNT;uid=sa;pwd=cuong2003;database=MyStore;TrustServerCertificate=true;Trusted_Connection=SSPI;Encrypt=false;";
            string SQL = "Select ProductID, ProductName,UnitInStock From Productlist; Select * From Categories";
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(SQL, ConnectionString);
                dataAdapter.Fill(dsMyStore);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Get Data From Database");
            }
        
        }
    }
}
