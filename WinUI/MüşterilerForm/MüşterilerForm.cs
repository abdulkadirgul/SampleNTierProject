using NTier.BLL.BaseRepository;
using NTier.DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI.MüşterilerForm
{
    public partial class MüşterilerForm : Form
    {
        public MüşterilerForm()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();
        BaseRepository<Customer> customerRepository = new BaseRepository<Customer>();
        private void MüşterilerForm_Load(object sender, EventArgs e)
        {
            GetCustomersList();
            lblSirketSayisi.Text = db.Customers.Count().ToString();
            lblMüsteriSayisi.Text = db.Customers.Count().ToString();
            
        


        }

        public void GetCustomersList()
        {

            listView1.Items.Clear();

            var customers = customerRepository.GetAll();

            foreach (Customer customer in customers)
            {

                ListViewItem lvi = new ListViewItem();
                lvi.Text = customer.CustomerID.ToString();
                lvi.SubItems.Add(customer.CompanyName);
                lvi.SubItems.Add(customer.ContactName);
                lvi.SubItems.Add(customer.City);
                lvi.SubItems.Add(customer.Phone);
                listView1.Items.Add(lvi);

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.CustomerID = txtMüsteriID.Text;
            customer.CompanyName = txtsirketAdi.Text;
            customer.ContactName = txtmüsteriAdi.Text;
            customer.City = txtSehirAdi.Text;
            customer.Phone = txtTlfNumarasi.Text;

            customerRepository.Add(customer);
            GetCustomersList();
        }
        public void GetCustomersList(string param)
        {

            listView1.Items.Clear();

            var customers = customerRepository.GetAll().Where(x=>x.CompanyName.ToLower().Contains(param) || x.ContactName.ToLower().Contains(param)|| x.CustomerID.ToLower().Contains(param) || x.City.ToLower().Contains(param)|| x.Phone.ToLower().Contains(param));

            foreach (Customer customer in customers)
            {

                ListViewItem lvi = new ListViewItem();
                lvi.Text = customer.CustomerID.ToString();
                lvi.SubItems.Add(customer.CompanyName);
                lvi.SubItems.Add(customer.ContactName);
                lvi.SubItems.Add(customer.City);
                lvi.SubItems.Add(customer.Phone);
                listView1.Items.Add(lvi);

            }
        }
        private void btnMusteriAra_Click(object sender, EventArgs e)
        {
            GetCustomersList(textBox1.Text.ToLower());
        }
    }
}
