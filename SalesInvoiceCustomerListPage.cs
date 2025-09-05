using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DatabaseConfiguration
{
    public partial class SalesInvoiceCustomerListPage : Form
    {      
        public SalesInvoiceCustomerListPage()
        {
            InitializeComponent();
        }

        private void ListPage_Load(object sender, EventArgs e)
        {     
            SelectedDateData();
        }

        public void fillgrid()
        {
            sqlparam dtList = new  sqlparam();
            dtList.status = "Select";

            DataTable selectedDate = CommonHelper.GetDataTable("Datalist", dtList);
            dgvCustomerData.DataSource = selectedDate;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        //Search form date....To date
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SelectedDateData();       
        }


        public void SelectedDateData()
        {           
            sqlparam dateSearch = new sqlparam();
            dateSearch.status = "DateBySearchData";
            dateSearch.Fromdate = dtpForm.Value.Date;
            dateSearch.Todate = dtpTo.Value.Date;

            DataTable SearchByDate = CommonHelper.GetDataTable("Datalist", dateSearch);
            dgvCustomerData.DataSource = SearchByDate;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SelectedDateData(); 
        }

        //Search Name
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sqlparam getData = new sqlparam();
            getData.status = "SearchCustomerName";
            getData.CustomerName = txtNameSearch.Text;
            DataTable dt = CommonHelper.GetDataTable("Datalist", getData);
            dgvCustomerData.DataSource = dt;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {           
            this.Hide();
    
            SalesInvoice s1 = new SalesInvoice();
            var result = s1.ShowDialog();

            if (result == DialogResult.OK)
            {
                fillgrid(); // ✅ refresh customer list after add
            }
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCustomerData.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCustomerData.SelectedRows[0];

                string invoiceNo = row.Cells["SalesInvoice_Number"].Value.ToString();
                string date = row.Cells["SalesInvoice_Date"].Value.ToString();
                string customerName = row.Cells["Customer_Name"].Value.ToString();
                string address = row.Cells["Customer_Address"].Value.ToString();
                string mobileNo = row.Cells["Phone_No"].Value.ToString();
                string state = row.Cells["State"].Value.ToString();

                // ✅ Only one object
                SalesInvoice si = new SalesInvoice(invoiceNo, date, customerName, address, mobileNo, state);
                var result = si.ShowDialog();

                if (result == DialogResult.OK)
                {
                    fillgrid(); // refresh list
                }
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgvCustomerData.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCustomerData.SelectedRows[0];

                string invoiceNo = row.Cells["SalesInvoice_Number"].Value.ToString();
                string date = row.Cells["SalesInvoice_Date"].Value.ToString();
                string customerName = row.Cells["Customer_Name"].Value.ToString();
                string address = row.Cells["Customer_Address"].Value.ToString();
                string mobileNo = row.Cells["Phone_No"].Value.ToString();
                string state = row.Cells["State"].Value.ToString();

                // ✅ Open SalesInvoice in View mode
                SalesInvoice si = new SalesInvoice(invoiceNo, date, customerName, address, mobileNo, state, true);
                si.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }
        }
    }
}
