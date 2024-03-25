using TestNab.Models;

namespace TestNab
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            nameDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            merchantDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            label2 = new Label();
            label1 = new Label();
            dataGridViewCategories = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryBindingSource = new BindingSource(components);
            dataGridViewProducts = new DataGridView();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Metric = new DataGridViewComboBoxColumn();
            productsBindingSource = new BindingSource(components);
            buttonSave = new Button();
            tabPage3 = new TabPage();
            calcGrid = new DataGridView();
            ProductName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Merchant = new DataGridViewTextBoxColumn();
            label4 = new Label();
            numOfPerson = new TextBox();
            checkedListBox1 = new ListBox();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)calcGrid).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(-3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1003, 607);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dataGridViewCategories);
            tabPage1.Controls.Add(dataGridViewProducts);
            tabPage1.Controls.Add(buttonSave);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(995, 579);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dodaj jelo";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(554, 17);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 17;
            label3.Text = "Svi sastojci";
            label3.Click += label3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn2, merchantDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productBindingSource;
            dataGridView1.Location = new Point(554, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(281, 455);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn2.HeaderText = "Naziv";
            nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            // 
            // merchantDataGridViewTextBoxColumn
            // 
            merchantDataGridViewTextBoxColumn.DataPropertyName = "Merchant";
            merchantDataGridViewTextBoxColumn.HeaderText = "Dobavljac";
            merchantDataGridViewTextBoxColumn.Name = "merchantDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Product);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 17);
            label2.Name = "label2";
            label2.Size = new Size(137, 15);
            label2.TabIndex = 15;
            label2.Text = "Sastojci za odabrano jelo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 17);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 14;
            label1.Text = "Odabir i dodavanje jela";
            label1.Click += label1_Click;
            // 
            // dataGridViewCategories
            // 
            dataGridViewCategories.AutoGenerateColumns = false;
            dataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategories.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn });
            dataGridViewCategories.DataSource = categoryBindingSource;
            dataGridViewCategories.Location = new Point(11, 35);
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.Size = new Size(160, 455);
            dataGridViewCategories.TabIndex = 13;
            dataGridViewCategories.SelectionChanged += dataGridViewCategories_SelectionChanged;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Naziv jela";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Category);
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AutoGenerateColumns = false;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { quantityDataGridViewTextBoxColumn, Metric });
            dataGridViewProducts.DataSource = productsBindingSource;
            dataGridViewProducts.Location = new Point(177, 35);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.Size = new Size(371, 455);
            dataGridViewProducts.TabIndex = 12;
            dataGridViewProducts.CellContentClick += dataGridViewProducts_CellContentClick_1;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // Metric
            // 
            Metric.DataPropertyName = "Metric";
            Metric.HeaderText = "Jedinica";
            Metric.Items.AddRange(new object[] { "kg", "g", "l", "kom" });
            Metric.Name = "Metric";
            // 
            // productsBindingSource
            // 
            productsBindingSource.DataMember = "Products";
            productsBindingSource.DataSource = categoryBindingSource;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(866, 35);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(calcGrid);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(numOfPerson);
            tabPage3.Controls.Add(checkedListBox1);
            tabPage3.Controls.Add(button1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(995, 579);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Izracunaj";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // calcGrid
            // 
            calcGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            calcGrid.Columns.AddRange(new DataGridViewColumn[] { ProductName, Quantity, Merchant });
            calcGrid.Location = new Point(324, 18);
            calcGrid.Name = "calcGrid";
            calcGrid.Size = new Size(354, 480);
            calcGrid.TabIndex = 8;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Naziv proizvoda";
            ProductName.Name = "ProductName";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Kolicina";
            Quantity.Name = "Quantity";
            // 
            // Merchant
            // 
            Merchant.HeaderText = "Dobavljac";
            Merchant.Name = "Merchant";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 21);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 7;
            label4.Text = "Odabir jela";
            // 
            // numOfPerson
            // 
            numOfPerson.Location = new Point(187, 18);
            numOfPerson.Name = "numOfPerson";
            numOfPerson.PlaceholderText = "Broj osoba";
            numOfPerson.Size = new Size(100, 23);
            numOfPerson.TabIndex = 6;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.ItemHeight = 15;
            checkedListBox1.Location = new Point(21, 62);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.SelectionMode = SelectionMode.MultiSimple;
            checkedListBox1.Size = new Size(154, 439);
            checkedListBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(199, 62);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Izracunaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(852, 73);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 18;
            label5.Text = "Kad zavrsis menjanje";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(852, 103);
            label6.Name = "label6";
            label6.Size = new Size(113, 15);
            label6.TabIndex = 19;
            label6.Text = "ili dodavanje pritisni";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(867, 131);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 20;
            label7.Text = "dugme SAVE";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 612);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "MainForm";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)calcGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private Button buttonSave;
        private DataGridView dataGridViewProducts;
        private DataGridView dataGridViewCategories;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pCIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private BindingSource categoryBindingSource;
        private BindingSource productsBindingSource;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn Metric;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private BindingSource productBindingSource;
        private Label label3;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn merchantDataGridViewTextBoxColumn;
        private Button button1;
        private ListBox checkedListBox1;
        private Label label4;
        private TextBox numOfPerson;
        private DataGridView calcGrid;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Merchant;
        private Label label5;
        private Label label7;
        private Label label6;
    }
}
