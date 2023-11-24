namespace BaseEditor
{
    partial class Form1
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

        /// <summary>
        /// флаг отмены отображения контекстного меню для элемента DataGridView
        /// </summary>
        private bool cancelContextMenu = false;

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            button1 = new Button();
            button2 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label1 = new Label();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            textBox7 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox5 = new TextBox();
            textBox2 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            button3 = new Button();
            textBox6 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            tabPage4 = new TabPage();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            measureUnitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            balanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            minBalanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            limitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            providerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contextMenuStripForGrid = new ContextMenuStrip(components);
            MenuItemEditProduct = new ToolStripMenuItem();
            MenuItemDeleteProduct = new ToolStripMenuItem();
            productBindingSource = new BindingSource(components);
            button6 = new Button();
            textBox16 = new TextBox();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStripForGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(6, 357);
            button1.Name = "button1";
            button1.Size = new Size(249, 29);
            button1.TabIndex = 2;
            button1.Text = "Удалить предыдущий отчет";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(453, 357);
            button2.Name = "button2";
            button2.Size = new Size(246, 29);
            button2.TabIndex = 3;
            button2.Text = "Обновить остатки";
            button2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1192, 450);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(button2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1184, 417);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Обновить остатки";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(19, 23);
            label1.Margin = new Padding(3, 0, 3, 1);
            label1.Name = "label1";
            label1.Size = new Size(728, 99);
            label1.TabIndex = 4;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(checkBox4);
            tabPage2.Controls.Add(checkBox3);
            tabPage2.Controls.Add(checkBox2);
            tabPage2.Controls.Add(checkBox1);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1184, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Добавить новый товар";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(650, 148);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 246);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Сведения о закупке";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(315, 97);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 30);
            textBox7.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(315, 58);
            label11.Name = "label11";
            label11.Size = new Size(103, 23);
            label11.TabIndex = 2;
            label11.Text = "Количество";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 52);
            label10.Name = "label10";
            label10.Size = new Size(47, 23);
            label10.TabIndex = 1;
            label10.Text = "Дата";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(16, 95);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 30);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.Value = new DateTime(2023, 11, 24, 0, 0, 0, 0);
            // 
            // textBox5
            // 
            textBox5.Location = new Point(1015, 63);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(120, 27);
            textBox5.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(813, 64);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(131, 27);
            textBox2.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1023, 24);
            label9.Name = "label9";
            label9.Size = new Size(112, 20);
            label9.TabIndex = 19;
            label9.Text = "Лимит закупки";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(798, 24);
            label8.Name = "label8";
            label8.Size = new Size(169, 20);
            label8.TabIndex = 18;
            label8.Text = "Минимальный остаток";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(501, 96);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(139, 24);
            checkBox4.TabIndex = 17;
            checkBox4.Text = "Промышленый";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(501, 66);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(125, 24);
            checkBox3.TabIndex = 16;
            checkBox3.Text = "Продуктовый";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(184, 96);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(44, 24);
            checkBox2.TabIndex = 15;
            checkBox2.Text = "кг";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(184, 66);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(49, 24);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "шт";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(17, 318);
            button3.Name = "button3";
            button3.Size = new Size(226, 76);
            button3.TabIndex = 12;
            button3.Text = "Добавить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(644, 66);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(120, 27);
            textBox6.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(393, 66);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(75, 27);
            textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(286, 66);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(75, 27);
            textBox3.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(650, 24);
            label7.Name = "label7";
            label7.Size = new Size(86, 20);
            label7.TabIndex = 6;
            label7.Text = "Поставщик";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(514, 24);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 5;
            label6.Text = "Группа";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(393, 24);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 4;
            label5.Text = "Цена закуп.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(298, 24);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 3;
            label4.Text = "Остаток";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 24);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 2;
            label3.Text = "Ед. изм";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 24);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 0;
            label2.Text = "Название";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridView1);
            tabPage4.Controls.Add(button6);
            tabPage4.Controls.Add(textBox16);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1184, 417);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Редактирование товара";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, measureUnitDataGridViewTextBoxColumn, balanceDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, minBalanceDataGridViewTextBoxColumn, limitDataGridViewTextBoxColumn, groupDataGridViewTextBoxColumn, providerDataGridViewTextBoxColumn });
            dataGridView1.ContextMenuStrip = contextMenuStripForGrid;
            dataGridView1.DataSource = productBindingSource;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(3, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.PapayaWhip;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.SaddleBrown;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1178, 340);
            dataGridView1.TabIndex = 40;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // measureUnitDataGridViewTextBoxColumn
            // 
            measureUnitDataGridViewTextBoxColumn.DataPropertyName = "MeasureUnit";
            measureUnitDataGridViewTextBoxColumn.HeaderText = "MeasureUnit";
            measureUnitDataGridViewTextBoxColumn.MinimumWidth = 6;
            measureUnitDataGridViewTextBoxColumn.Name = "measureUnitDataGridViewTextBoxColumn";
            measureUnitDataGridViewTextBoxColumn.Width = 125;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            balanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            balanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // minBalanceDataGridViewTextBoxColumn
            // 
            minBalanceDataGridViewTextBoxColumn.DataPropertyName = "MinBalance";
            minBalanceDataGridViewTextBoxColumn.HeaderText = "MinBalance";
            minBalanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            minBalanceDataGridViewTextBoxColumn.Name = "minBalanceDataGridViewTextBoxColumn";
            minBalanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // limitDataGridViewTextBoxColumn
            // 
            limitDataGridViewTextBoxColumn.DataPropertyName = "Limit";
            limitDataGridViewTextBoxColumn.HeaderText = "Limit";
            limitDataGridViewTextBoxColumn.MinimumWidth = 6;
            limitDataGridViewTextBoxColumn.Name = "limitDataGridViewTextBoxColumn";
            limitDataGridViewTextBoxColumn.Width = 125;
            // 
            // groupDataGridViewTextBoxColumn
            // 
            groupDataGridViewTextBoxColumn.DataPropertyName = "Group";
            groupDataGridViewTextBoxColumn.HeaderText = "Group";
            groupDataGridViewTextBoxColumn.MinimumWidth = 6;
            groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            groupDataGridViewTextBoxColumn.Width = 125;
            // 
            // providerDataGridViewTextBoxColumn
            // 
            providerDataGridViewTextBoxColumn.DataPropertyName = "Provider";
            providerDataGridViewTextBoxColumn.HeaderText = "Provider";
            providerDataGridViewTextBoxColumn.MinimumWidth = 6;
            providerDataGridViewTextBoxColumn.Name = "providerDataGridViewTextBoxColumn";
            providerDataGridViewTextBoxColumn.Width = 125;
            // 
            // contextMenuStripForGrid
            // 
            contextMenuStripForGrid.ImageScalingSize = new Size(20, 20);
            contextMenuStripForGrid.Items.AddRange(new ToolStripItem[] { MenuItemEditProduct, MenuItemDeleteProduct });
            contextMenuStripForGrid.Name = "contextMenuStripForGrid";
            contextMenuStripForGrid.Size = new Size(225, 52);
            // 
            // MenuItemEditProduct
            // 
            MenuItemEditProduct.Name = "MenuItemEditProduct";
            MenuItemEditProduct.Size = new Size(224, 24);
            MenuItemEditProduct.Text = "Редактировать товар";
            MenuItemEditProduct.Click += MenuItemEditProduct_Click;
            // 
            // MenuItemDeleteProduct
            // 
            MenuItemDeleteProduct.Name = "MenuItemDeleteProduct";
            MenuItemDeleteProduct.Size = new Size(224, 24);
            MenuItemDeleteProduct.Text = "Удалить товар";
            MenuItemDeleteProduct.Click += MenuItemDeleteProduct_Click;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Product);
            // 
            // button6
            // 
            button6.BackColor = Color.CornflowerBlue;
            button6.BackgroundImageLayout = ImageLayout.Center;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(351, 18);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 39;
            button6.Text = "Поиск";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // textBox16
            // 
            textBox16.BorderStyle = BorderStyle.FixedSingle;
            textBox16.ForeColor = SystemColors.GrayText;
            textBox16.Location = new Point(20, 19);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(273, 27);
            textBox16.TabIndex = 38;
            textBox16.Text = "Введите название или часть";
            textBox16.Click += textBox16_Click;
            textBox16.KeyDown += Form1_KeyDown;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1184, 417);
            tabPage3.TabIndex = 4;
            tabPage3.Text = "Анализ";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(1192, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStripForGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
        }

        /// <summary>
        /// Очистка формы после добавления товара
        /// </summary>
        public void TabPageClear()
        {

            foreach (Control c in tabPage2.Controls)
            {
                if (c is TextBox) ((TextBox)c).Text = null;
                if (c is CheckBox) ((CheckBox)c).CheckState = CheckState.Unchecked;

            }

            foreach (Control x in groupBox1.Controls)
            {
                if (x is TextBox) ((TextBox)x).Text = null;
                
            }

        }

        #endregion
        private Button button1;
        private Button button2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox6;
        private Button button3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private Label label8;
        private TextBox textBox5;
        private TextBox textBox2;
        private Label label9;
        private TabPage tabPage4;
        private Button button6;
        private TextBox textBox16;
        private DataGridView dataGridView1;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn measureUnitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn minBalanceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn limitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn providerDataGridViewTextBoxColumn;
        private ContextMenuStrip contextMenuStripForGrid;
        private ToolStripMenuItem MenuItemEditProduct;
        private ToolStripMenuItem MenuItemDeleteProduct;
        private TabPage tabPage3;
        private GroupBox groupBox1;
        private TextBox textBox7;
        private Label label11;
        private Label label10;
        private DateTimePicker dateTimePicker1;
    }
}