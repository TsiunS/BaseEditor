using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseEditor
{
    public partial class FrmEditProduct : Form
    {


        public Product EditedProduct { get; set; }


        public FrmEditProduct()
        {
            InitializeComponent();
        }

        public void LoadSelectedRow()
        {
            // Помещаем в источник данных экземпляр для редактируемого товара
            productBindingSource.Add(EditedProduct);
            productBindingSource1.Add(EditedProduct);
            productBindingSource2.Add(EditedProduct);
            productBindingSource3.Add(EditedProduct);
            productBindingSource4.Add(EditedProduct);
            productBindingSource5.Add(EditedProduct);
            productBindingSource6.Add(EditedProduct);
            productBindingSource7.Add(EditedProduct);
            productBindingSource8.Add(EditedProduct);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void buttonOK_Click_1(object sender, EventArgs e)
        {
            using (SurpriseStoreListContext db = new SurpriseStoreListContext())
            {
                //получаем объект
                Product? product = db.Products.FirstOrDefault(p => p.Id.ToString() == textBox9.Text);
                if (product != null)
                {
                    product.Name = textBox1.Text;
                    product.MeasureUnit = textBox7.Text;
                    product.Balance = Convert.ToDecimal(textBox3.Text);
                    product.Price = Convert.ToDecimal(textBox8.Text);
                    product.MinBalance = Convert.ToDecimal(textBox4.Text);
                    product.Limit = Convert.ToDecimal(textBox6.Text);
                    product.Group = textBox2.Text;
                    product.Provider = textBox5.Text;
                    //обновляем объект
                    db.Products.Update(product);
                    db.SaveChanges();

                }

            }

            MessageBox.Show("Изменения внесены");
            Close();
        }

        // Добавление новой закупки по товару

        /*using (var context = new BloggingContext())
{
    var blog = context.Blogs.Include(b => b.Posts).First();
    var post = new Post { Title = "Intro to EF Core" };

    blog.Posts.Add(post);
    context.SaveChanges();
}
         */
        private void buttonOkPurch_Click(object sender, EventArgs e)
        {
            using (SurpriseStoreListContext db = new SurpriseStoreListContext())
            {
                //получаем объект

                var product = db.Products.Include(u => u.Purchases).FirstOrDefault(p => p.Id.ToString() == textBox9.Text);


                Purchase purchase = new Purchase()
                {
                    Date = dateTimePicker2.Value,
                    Quantity = Convert.ToDecimal(textBox10.Text),
                    UnitPrice = Convert.ToDecimal(textBox11.Text),
                    SumPurchase = Convert.ToDecimal(textBox10.Text) * Convert.ToDecimal(textBox11.Text)
                };

                product.Purchases.Add(purchase);

                db.SaveChanges();

            }

            MessageBox.Show("Закупка добавлена, остатки обновлены");
            Close();
        }






    }

}
