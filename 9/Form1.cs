using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9
{
    public partial class Form1 : Form
    {
        Model1 db = new Model1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet.Categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter.Fill(this.northwindDataSet.Categories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);
            categoriesBindingSource.DataSource = db.Categories.ToList();
            productsBindingSource.DataSource = db.Products.ToList();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
