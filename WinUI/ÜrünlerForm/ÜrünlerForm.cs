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

namespace WinUI.ÜrünlerForm
{
    public partial class ÜrünlerForm : Form
    {
        public ÜrünlerForm()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();
       BaseRepository<Product> productrepository = new BaseRepository<Product>();
        

        private void ÜrünlerForm_Load(object sender, EventArgs e)
        {
            GetProductList();
            lblÜrünÇesidi.Text = db.Categories.Count().ToString();
            lblÜrünStok.Text = db.Products.Sum(x => x.UnitsInStock).ToString();
            lblÜrünSayısı.Text = db.Products.Count().ToString();

         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var productId = Convert.ToInt32(listView1.SelectedItems[0].Text);
            var result = productrepository.Delete(productId);
            MessageBox.Show(result);
            GetProductList();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product();
            newProduct.ProductName = textBox1.Text;
            newProduct.UnitPrice = nudUnitPrice.Value;
            newProduct.UnitsInStock = (short)nudUnitStock.Value;
            productrepository.Add(newProduct);
            GetProductList();
        }
        private void GetProductList()
        {
            listView1.Items.Clear();
        var products = productrepository.GetAll();


            foreach (var product in products)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = product.ProductID.ToString();
                lvi.SubItems.Add(product.ProductName);
                lvi.SubItems.Add(product.UnitPrice.ToString());
                lvi.SubItems.Add(product.UnitsInStock.ToString());
                listView1.Items.Add(lvi);
            }
        }

        private void GetProductList(string parametre)
        {
            listView1.Items.Clear();
            var products = productrepository.GetAll().Where(x => x.ProductName.ToLower().StartsWith(parametre));
            foreach (var product in products)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = product.ProductID.ToString();
                lvi.SubItems.Add(product.ProductName);
                lvi.SubItems.Add(product.UnitPrice.ToString());
                lvi.SubItems.Add(product.UnitsInStock.ToString());
                listView1.Items.Add(lvi);
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            GetProductList(textBox2.Text.ToLower());
        }
        
       

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var products = productrepository.GetAll().OrderBy(x => x.UnitPrice);
            foreach (var product in products)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = product.ProductID.ToString();
                lvi.SubItems.Add(product.ProductName);
                lvi.SubItems.Add(product.UnitPrice.ToString());
                lvi.SubItems.Add(product.UnitsInStock.ToString());
                listView1.Items.Add(lvi);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var products = productrepository.GetAll().OrderByDescending(x => x.UnitPrice);
            foreach (var product in products)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = product.ProductID.ToString();
                lvi.SubItems.Add(product.ProductName);
                lvi.SubItems.Add(product.UnitPrice.ToString());
                lvi.SubItems.Add(product.UnitsInStock.ToString());
                listView1.Items.Add(lvi);
            }
        }

        
    }
}
