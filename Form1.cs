using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace BaseEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string measureUnit;
        string group;
        List<Product> productsForChange;
        List<Product> productsForDelete;


        private void button1_Click_1(object sender, EventArgs e)
        {
            var files = Directory.GetFiles("C:\\Отчеты");

            foreach (var file in files) { File.Delete(file); MessageBox.Show("Файлы удалены"); };


        }

        // Добавление
        private void button3_Click(object sender, EventArgs e)
        {

            using (SurpriseStoreListContext db = new SurpriseStoreListContext())
            {
                Product product = new Product
                {
                    Name = textBox1.Text,
                    MeasureUnit = measureUnit,
                    Balance = Convert.ToDecimal(textBox3.Text),
                    Price = Convert.ToDecimal(textBox4.Text),
                    Group = group,
                    Provider = textBox6.Text,
                    MinBalance = Convert.ToDecimal(textBox2.Text),
                    Limit = Convert.ToDecimal(textBox5.Text),
                };


                db.Products.Add(product);
                db.SaveChanges();
            }

            MessageBox.Show("Товар добавлен");
            TabPageClear();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            measureUnit = "кг";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            measureUnit = "шт";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            group = "продуктовый";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            group = "промышленный";
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button6_Click(sender, e);
            }
        }

        /// <summary>
        /// Поиск товара для редактирования или удаления
        /// </summary>
        private void button6_Click(object sender, EventArgs e)
        {
            using (SurpriseStoreListContext db = new SurpriseStoreListContext())
            {

                var products = db.Products.Where(p => EF.Functions.Like(p.Name!, "%" + textBox16.Text + "%"));

                dataGridView1.DataSource = products.ToList();

                productsForChange = products.ToList();
                productsForDelete = products.ToList();

            }
        }


        // Очистка поля для ввода
        private void textBox16_Click(object sender, EventArgs e)
        {
            textBox16.Text = string.Empty;
        }



        private void MenuItemEditProduct_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;

            foreach (DataGridViewRow selectedRow in selectedRows)
            {
                int rowIndex = selectedRow.Index;

                if (rowIndex < 0)
                {
                    continue;
                }

                Product product = productsForChange[rowIndex];

                FrmEditProduct editProduct = new FrmEditProduct();
                editProduct.EditedProduct = product;
                editProduct.LoadSelectedRow();

                editProduct.Show();
                productsForChange.Clear();
                productsForDelete.Clear();
            }
        }

        private void MenuItemDeleteProduct_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;

            foreach (DataGridViewRow selectedRow in selectedRows)
            {
                int rowIndex = selectedRow.Index;

                if (rowIndex < 0)
                {
                    continue;
                }

                Product productForDel = productsForDelete[rowIndex];

                DialogResult dlgConfirm = MessageBox.Show("Удалить этот товар?\r\n\r\n" + productForDel.Name, "Подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgConfirm == DialogResult.Yes)
                {
                    using (SurpriseStoreListContext db = new SurpriseStoreListContext())
                    {
                        //получаем объект
                        Product? product = db.Products.FirstOrDefault(p => p.Name == productForDel.Name);
                        if (product != null)
                        {
                            //удаляем объект
                            db.Products.Remove(product);
                            db.SaveChanges();

                            //очистка списков
                            productsForChange.Clear();
                            productsForDelete.Clear();
                        }

                    }
                }
            }
        }


    }

}