using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace BaseEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string measureUnitForAddManual;
        string groupForAddManual;
        List<Product> productsForChange;
        List<Product> productsForDelete;


        // ������� ������������ ����� �� �����
        private void button1_Click_1(object sender, EventArgs e)
        {
            var files = Directory.GetFiles("C:\\������");

            foreach (var file in files) { File.Delete(file); MessageBox.Show("����� �������"); };


        }

        #region ���������� ������ ������ �������
        private void button3_Click(object sender, EventArgs e)
        {

            using (SurpriseStoreListContext db = new SurpriseStoreListContext())
            {
                Product product = new Product
                {
                    Name = textBox1.Text,
                    MeasureUnit = measureUnitForAddManual,
                    Balance = Convert.ToDecimal(textBox3.Text),
                    Price = Convert.ToDecimal(textBox4.Text),
                    Group = groupForAddManual,
                    Provider = textBox6.Text,
                    MinBalance = Convert.ToDecimal(textBox2.Text),
                    Limit = Convert.ToDecimal(textBox5.Text),
                };

                db.Products.Add(product);

                Purchase purchases = new Purchase()
                {
                    Date = dateTimePicker1.Value,
                    Quantity = Convert.ToDecimal(textBox7.Text),
                    Product = product

                };

                db.Add(purchases);
                db.SaveChanges();
            }

            MessageBox.Show("����� ��������");
            TabPageClear();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            measureUnitForAddManual = "��";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            measureUnitForAddManual = "��";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            groupForAddManual = "�����������";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            groupForAddManual = "������������";
        }
        #endregion


        #region ����� ������ ��� �������������� ��� ��������

        private void button6_Click(object sender, EventArgs e)
        {
            using (SurpriseStoreListContext db = new SurpriseStoreListContext())
            {

                var products = db.Products.Include(u => u.Purchases).Where(p => EF.Functions.Like(p.Name!, "%" + textBox16.Text + "%"));


                dataGridView1.DataSource = products.ToList();

                productsForChange = products.ToList();
                productsForDelete = products.ToList();

            }
        }


        // ������� ���� ��� �����
        private void textBox16_Click(object sender, EventArgs e)
        {
            textBox16.Text = string.Empty;
        }

        // ����� � ���� �������� Enter
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button6_Click(sender, e);
            }
        }


        #endregion

        #region ���� �� ������ ��� � ����� ���� �������������� ������
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
                // productsForChange.Clear();
                // productsForDelete.Clear();
            }
        }
        #endregion

        #region ���� �� ������ ��� � ����� �������� ������
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

                DialogResult dlgConfirm = MessageBox.Show("������� ���� �����?\r\n\r\n" + productForDel.Name, "�����������", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgConfirm == DialogResult.Yes)
                {
                    using (SurpriseStoreListContext db = new SurpriseStoreListContext())
                    {
                        //�������� ������
                        Product? product = db.Products.FirstOrDefault(p => p.Name == productForDel.Name);
                        if (product != null)
                        {
                            //������� ������
                            db.Products.Remove(product);
                            db.SaveChanges();

                            //������� ������� 
                            // productsForChange.Clear();
                            //   productsForDelete.Clear();
                        }

                    }
                }
            }
        }
        #endregion

        #region ���������� �������� �� ������ ������� �� �������������
        private void button2_Click(object sender, EventArgs e)
        {
            int newProductsAddSum = 0; // ���������� ����� ����������� �������
            string groupForAddProduct = "�� ����������";
            string name = "";
            decimal balanceToday = 0;
            decimal price = 0;
            string measureUnit = "";


            DateTime dateforTest3011 = new DateTime(2023, 11, 18);

            List<string> errors = new List<string>();
            string pathForErrorsReport = $"C:\\Users\\Sergey\\Documents\\Base\\����� �� {dateforTest3011:dd/MM/yyyy}.txt";

            string path = "C:\\Users\\Sergey\\Documents\\�����������\\����������\\����� �������\\�������1711.txt";


            string[] strings = GetStringsFromFile(path);


            // ��������� ������ 

            using (SurpriseStoreListContext db = new SurpriseStoreListContext())
            {

                for (int i = 0; i < strings.Length - 1; i++)
                {
                    if (strings[i].Contains("�����������")) groupForAddProduct = "�����������";
                    if (strings[i].Contains("������������")) groupForAddProduct = "������������";

                    if (strings[i].Contains("������ �� ������") || !char.IsDigit(strings[i][0]))
                        continue;

                    //if (strings[i].Contains("���� ������ ������"))
                    //{

                    //}


                    string[] prodProp = strings[i].Split('\t');

                    try
                    {
                        name = prodProp[1];
                        if (prodProp[4] == "") // ������ ��� ������� ������
                            continue;
                        balanceToday = Convert.ToDecimal(prodProp[4]);
                        measureUnit = prodProp[3];

                        // ��������� ���������� ����� � ������
                        price = prodProp[5] == "" ? Convert.ToDecimal(prodProp[6]) : Convert.ToDecimal(prodProp[5]);
                    }
                    catch (Exception ex)
                    {
                        errors.Add(ex.Message + $"\n����� �� �������� ��-�� ������ ������" + strings[i]);
                    }

                    decimal totalSold = 0;

                    // ���� ����� � ����� ��������� ����
                    if (db.Products.Any(p => p.Name == name))
                    {
                        var products = db.Products.Include(u => u.Sales).Include(z => z.Purchases).Where(p => p.Name == name);

                        foreach (Product product in products)
                        {
                            // ��������� ������� �������
                            if (product.Purchases.Any(d => d.Date == dateforTest3011.AddDays(-1)))
                            {
                                // ���� ���������� ������ � �������� ����� �� ��� � � ��������� �������,
                                // ������ ���� ����� ������ �������� � ��� ��������� �� ����
                                var purchases = product.Purchases.Where(d => d.Date == dateforTest3011.AddDays(-1) && d.Quantity != product.Balance);

                                foreach (var purchase in purchases)
                                {
                                    // ���� ������� ������� ������ ������ ��� ����� ������������ � ���������� �������, ���� �������
                                    if (balanceToday < purchase.Quantity + product.Balance)
                                    {
                                        //������� ��������� ���������� ���������� ������ � ��������� �������
                                        totalSold = purchase.Quantity + product.Balance - balanceToday;

                                        product.Sales.Add(new Sales()
                                        {
                                            Date = dateforTest3011.AddDays(-1),          //DateTime.Today.AddDays(-1),
                                            Product = product,
                                            TotalSold = totalSold,
                                            Sum = totalSold * product.Price
                                        });


                                    }
                                    // ���� ������� ������� ������ ����� ����� ������������ � ���������� �������, ���� �������� ��� ������
                                    if (balanceToday <= purchase.Quantity + product.Balance)
                                    {
                                        // ��������� ������� � ������ �������
                                        product.Balance = balanceToday;

                                    }


                                }


                            }
                            else
                            {
                                // ���� ����� ������� ��� �������������, � ������� �������������, ������ �������� �� ������
                                if (balanceToday < 0 && product.Balance >= 0)
                                {
                                    errors.Add("� ������" + product.Name + "�������� ������������� �������! ��������� ���������� �� ������.");
                                }

                                // ���� ����� ������� ��� �������������, � ������� �������������, ������ ���� �������
                                if (balanceToday >= 0 && product.Balance < 0)
                                {
                                    errors.Add("� ������" + product.Name + "������������� ������� ���� �������������, �� ������� �� �������.���� ���� �������, ��������� ����� �������.");
                                }


                                // ���� ������� ������� ������ ��� �����, ������ ���� �������/ ���� ���������� �������������
                                if (balanceToday < product.Balance || (product.Balance < 0 && balanceToday > product.Balance))
                                {

                                    totalSold = Math.Abs(product.Balance - balanceToday);

                                    product.Sales.Add(new Sales()
                                    {
                                        Date = dateforTest3011.AddDays(-1),          //DateTime.Today.AddDays(-1),
                                        Product = product,
                                        TotalSold = totalSold,
                                        Sum = totalSold * product.Price
                                    });

                                    //  ��������� �������
                                    product.Balance = balanceToday;

                                }



                            }



                            // ���� �� ����� ��������� ������ ������� ��� �������� ����� �����, ��.��������� "��" ������ �� ������ � ������
                            if (product.MeasureUnit == "��")
                                product.MeasureUnit = measureUnit;
                            if (product.Group == "�� ���������")
                                product.Group = groupForAddProduct;
                            break;
                        }

                    }
                    else
                    {
                        // ���� � ������ ������� �������� ����� �����,� � �������� ����� ��� �� ����, ������� ���

                        try
                        {
                            Product product = new Product
                            {
                                Name = name,
                                MeasureUnit = measureUnit,
                                Balance = balanceToday,
                                Price = price,
                                Group = groupForAddProduct,
                                Provider = "�� ���������",
                                MinBalance = measureUnit == "��" ? 0.1m : 1.0m,
                                Limit = 5000.0m,
                                Purchases = new List<Purchase>(),
                                Sales = new List<Sales>()
                            };

                            product.Purchases.Add(new Purchase
                            {
                                Date = dateforTest3011.AddDays(-1),
                                Quantity = balanceToday,
                                Product = product,
                                UnitPrice = price,
                                SumPurchase = balanceToday * price
                            });

                            db.Products.Add(product);
                            newProductsAddSum += 1;
                        }
                        catch (Exception ex)
                        {
                            errors.Add(ex.Message + $"\n����� ����� {name} �� ��������");

                        }

                    }

                    db.SaveChanges();


                }

            }

            if (errors.Count > 0)
            {
                SaveFile(pathForErrorsReport, errors);
                errors.Clear();
                MessageBox.Show($"����� ���������.\n" +
                    $" ��������� ����� �������: {newProductsAddSum}\n" +
                    $"���� ������ ��������� � ������ � ����� ����.");
            }
            else
            {
                MessageBox.Show($"������� ���������.\n ��������� ����� �������: {newProductsAddSum}");
            }



        }
        #endregion


        #region ���������� �������
        private void button1_Click(object sender, EventArgs e)
        {
            //�������� ������� ����� ������ � ���������� ����� ��������

            int newProductsAddSum = 0;
            List<string> errors = new List<string>();
            string pathForErrorsReport = "C:\\Users\\Sergey\\Documents\\Base\\�� �������� �� �������.txt";

            string provider = "";
            string name = "";
            decimal quantity = 0;
            decimal sumPurchase = 0;
            decimal price = 0;
            // ��� ����� 29.11.2023
            DateTime datePurchase = new DateTime(2023, 11, 18); //DateTime.Today;

            string path = "C:\\Users\\Sergey\\Documents\\�����������\\����������\\����� �������\\�������1711.txt";


            string[] strings = GetStringsFromFile(path);

            using (SurpriseStoreListContext db = new SurpriseStoreListContext())
            {

                for (int i = 0; i < strings.Length - 1; i++)
                {
                    if (!char.IsDigit(strings[i][0])) continue;

                    string[] prodProp;

                    if (char.IsDigit(strings[i][0]) && strings[i - 1].Contains("�������� �����"))
                    {
                        prodProp = strings[i - 2].Split('\t');
                        provider = prodProp[0];

                    }
                    if (char.IsDigit(strings[i][0]))
                    {
                        prodProp = strings[i].Split('\t');
                        name = prodProp[2];
                        quantity = Convert.ToDecimal(prodProp[4]);
                        sumPurchase = Convert.ToDecimal(prodProp[5]);
                        price = Math.Round(sumPurchase / quantity, 2);
                        datePurchase = GetDatePurchase(strings[i + 1].Split('\t'));
                    }


                    // ���� ����� � ����� ��������� ����
                    if (db.Products.Any(p => p.Name == name))
                    {
                        var products = db.Products.Include(u => u.Purchases).Where(p => p.Name == name);
                        foreach (Product product in products)
                        {
                            // ���������� �������

                            product.Price = price; // ���� ����� ������ ��������� ����, ����� �������� ���
                            Purchase yesterdayPurchase = new Purchase
                            {
                                Product = product,
                                Date = datePurchase,
                                Quantity = quantity,
                                UnitPrice = price,
                                SumPurchase = sumPurchase
                            };
                            product.Purchases.Add(yesterdayPurchase);
                            break;
                        }

                    }
                    else
                    {
                        // ������� ����� �����

                        try
                        {
                            Product product = new Product
                            {
                                Name = name,
                                MeasureUnit = "��",
                                Balance = quantity,
                                Price = price,
                                Group = "�� ���������",
                                Provider = provider,
                                MinBalance = 1.0m,
                                Limit = 5000.0m,
                                Purchases = new List<Purchase>(),
                                Sales = new List<Sales>()
                            };

                            Purchase yesterdayPurchase = new Purchase
                            {
                                Product = product,
                                Date = datePurchase,
                                Quantity = quantity,
                                UnitPrice = price,
                                SumPurchase = sumPurchase
                            };

                            product.Purchases.Add(yesterdayPurchase);
                            db.Products.Add(product);
                            newProductsAddSum += 1;
                        }
                        catch (Exception ex)
                        {
                            errors.Add(ex.Message + $"\n����� {name} �� ��������");

                        }

                    }

                    db.SaveChanges();

                }

            }


            if (errors.Count > 0)
            {
                SaveFile(pathForErrorsReport, errors);
                errors.Clear();
                MessageBox.Show($"������� ���������.\n ��������� ����� �������: {newProductsAddSum}\n" +
                    $"���� ������ ��������� � ������ � ����� ����.");
            }
            else
            {
                MessageBox.Show($"������� ���������.\n ��������� ����� �������: {newProductsAddSum}\n" +
                    $"������ ��������� ���");
            }
        }

        private DateTime GetDatePurchase(string[] stringWithDate)
        {
            string[] invoiceElements = stringWithDate[2].Split(' ');

            string[] dateElements = invoiceElements[4].Split(".");
            int day = Convert.ToInt32(dateElements[0]);
            int month = Convert.ToInt32(dateElements[1]);
            int year = Convert.ToInt32(dateElements[2]);

            return new DateTime(year, month, day);

        }
        #endregion
        static void SaveFile(string path, List<string> er)
        {
            using (var sw = new StreamWriter(path, true, Encoding.UTF8))
            {
                foreach (var item in er)
                {
                    sw.WriteLine(item);
                }

            }
        }

        // ������� ��
        private void button4_Click(object sender, EventArgs e)
        {
            using (SurpriseStoreListContext db = new SurpriseStoreListContext())
            {
                //�������� ������
                var products = db.Products.ToList();
                foreach (var product in products)
                {

                    //������� ������
                    db.Products.Remove(product);


                }
                db.SaveChanges();

            }

        }

        // �������� �������� ������������
        private void button5_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\Sergey\\Documents\\�����������\\����������\\����������������.csv";

            string[] strings = GetStringsFromFile(path);

            using (SurpriseStoreListContext db = new SurpriseStoreListContext())
            {
                for (int i = 0; i < strings.Length - 1; i++)
                {

                    string[] prodProp = strings[i].Split(';');

                    Product product = new Product
                    {
                        Name = prodProp[0],
                        MeasureUnit = prodProp[1],
                        Balance = Convert.ToDecimal(prodProp[2]),
                        Price = Convert.ToDecimal(prodProp[3]),
                        Group = prodProp[5],
                        Provider = prodProp[4],
                        MinBalance = prodProp[1] == "��" ? 0.1m : 1.0m,
                        Limit = 5000.0m,
                        // Id = Convert.ToInt32(prodProp[6])
                        Purchases = new List<Purchase>(),
                        Sales = new List<Sales>()

                    };

                    db.Products.Add(product);

                }
                db.SaveChanges();
            }


        }

        /// <summary>
        /// ��������� ������� ����� �� �����
        /// </summary>
        /// <param name="path">���� � �����</param>
        /// <returns></returns>
        private string[] GetStringsFromFile(string path)
        {
            using (FileStream stream = File.OpenRead(path))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);

                string textFromFile = System.Text.Encoding.Default.GetString(buffer);
                Console.WriteLine(textFromFile);

            };

            string stringFromFile;

            using (var sr = new StreamReader(path, Encoding.UTF8))
            {
                stringFromFile = sr.ReadToEnd();
            }

            return stringFromFile.Split('\n');
        }

        private void MenuItemAnaliticProduct_Clic(object sender, EventArgs e)
        {

        }
    }

}