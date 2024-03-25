using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Windows.Forms;
using TestNab.Models;

namespace TestNab
{
    public partial class MainForm : Form
    {
        private ProductsContext? dbContext;
        DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
        Dictionary<string, int> categoriesCheck = new Dictionary<string, int>();
        private List<int> selectedCategoryIds = new List<int>();
        public MainForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            using (var db = new ProductsContext())
            {
                col.Name = "ProductNameDDL";
                col.HeaderText = "Sastojci";
                col.DataPropertyName = "ProductName";
                col.DataSource = db.Products.ToList();
                col.ValueMember = "Name";
                col.DisplayMember = "Name";
            }
            dataGridViewProducts.Columns.Add(col);
            dataGridViewProducts.Columns["ProductNameDDL"].DisplayIndex = 0;
            base.OnLoad(e);
            this.dbContext = new ProductsContext();

            // Uncomment the line below to start fresh with a new database.
            //this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.dbContext.Categories.Load();

            this.dbContext.Products.Load();

            this.categoryBindingSource.DataSource = dbContext.Categories.Local.ToBindingList();
            this.productBindingSource.DataSource = dbContext.Products.Local.ToBindingList();

            PopulateCategoryList();
        }

        private void PopulateCategoryList()
        {
            this.checkedListBox1.Items.Clear();
            this.categoriesCheck.Clear();
            foreach (var category in dbContext.Categories.ToList())
            {
                System.Console.WriteLine(category.Name);
                this.checkedListBox1.Items.Add(category.Name);
                categoriesCheck.Add(category.Name, category.CategoryId);
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dbContext != null)
            {
                var category = (Category)this.dataGridViewCategories.CurrentRow.DataBoundItem;

                if (category != null)
                {
                    this.dbContext.Entry(category).Collection(e => e.Products).Load();
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.dbContext!.SaveChanges();

            this.dataGridViewCategories.Refresh();
            this.dataGridViewProducts.Refresh();

            col.DataSource = dbContext.Products.ToList();
            PopulateCategoryList();
        }

        private void dataGridViewProducts_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public List<ProductCategory> GetProductsForCategories(List<int> categoryIds, int numPeople)
        {
            using (var context = new ProductsContext())
            {
                var products = context.ProductCategories
                     .Where(pc => categoryIds.Contains(pc.CategoryId))
                     .GroupBy(pc => pc.ProductName)
                     .Select(group => new ProductCategory
                     {
                         ProductName = group.Key,
                         Quantity = group.Sum(pc => pc.Quantity) * numPeople,
                         Metric = group.FirstOrDefault().Metric
                     })
                     .ToList();

                foreach (var product in products)
                {
                    var productName = product.ProductName;
                    var merchant = context.Products
                        .Where(p => p.Name == productName)
                        .Select(p => p.Merchant)
                        .FirstOrDefault();

                    product.Merchant = merchant;
                }

                return products;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            selectedCategoryIds.Clear();

            foreach (string selectedCategoryName in checkedListBox1.SelectedItems)
            {
                int categoryId = categoriesCheck[selectedCategoryName];
                selectedCategoryIds.Add(categoryId);
            }
            int numberOfPeople;

            if (int.TryParse(numOfPerson.Text, out numberOfPeople))
            {
                // Parsing successful, numberOfPeople contains the valid number
            }
            else
            {
                // Parsing failed, set numberOfPeople to 1
                numberOfPeople = 1;
            }

            var prod = GetProductsForCategories(selectedCategoryIds, numberOfPeople);

            this.calcGrid.Rows.Clear();
            foreach (var product in prod)
            {
                this.calcGrid.Rows.Add(product.ProductName, product.Quantity + " " + product.Metric, product.Merchant);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
