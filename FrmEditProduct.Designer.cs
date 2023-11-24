namespace BaseEditor
{
    partial class FrmEditProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox5 = new TextBox();
            productBindingSource8 = new BindingSource(components);
            textBox2 = new TextBox();
            productBindingSource7 = new BindingSource(components);
            label9 = new Label();
            label8 = new Label();
            textBox6 = new TextBox();
            productBindingSource6 = new BindingSource(components);
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            productBindingSource1 = new BindingSource(components);
            label2 = new Label();
            textBox7 = new TextBox();
            productBindingSource2 = new BindingSource(components);
            textBox3 = new TextBox();
            productBindingSource3 = new BindingSource(components);
            textBox4 = new TextBox();
            productBindingSource5 = new BindingSource(components);
            textBox8 = new TextBox();
            productBindingSource4 = new BindingSource(components);
            buttonOK = new Button();
            buttonCancel = new Button();
            textBox9 = new TextBox();
            productBindingSource = new BindingSource(components);
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonOkPurch = new Button();
            textBox10 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            dateTimePicker2 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)productBindingSource8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", productBindingSource8, "Provider", true));
            textBox5.Location = new Point(1130, 82);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(166, 27);
            textBox5.TabIndex = 35;
            // 
            // productBindingSource8
            // 
            productBindingSource8.DataSource = typeof(Product);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", productBindingSource7, "Group", true));
            textBox2.Location = new Point(971, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(131, 27);
            textBox2.TabIndex = 34;
            // 
            // productBindingSource7
            // 
            productBindingSource7.DataSource = typeof(Product);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(856, 43);
            label9.Name = "label9";
            label9.Size = new Size(112, 20);
            label9.TabIndex = 33;
            label9.Text = "Лимит закупки";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(728, 43);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 32;
            label8.Text = "Мин. остаток";
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", productBindingSource6, "Limit", true));
            textBox6.Location = new Point(856, 82);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(93, 27);
            textBox6.TabIndex = 31;
            // 
            // productBindingSource6
            // 
            productBindingSource6.DataSource = typeof(Product);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1130, 43);
            label7.Name = "label7";
            label7.Size = new Size(86, 20);
            label7.TabIndex = 28;
            label7.Text = "Поставщик";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1000, 43);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 27;
            label6.Text = "Группа";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(610, 43);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 26;
            label5.Text = "Цена закуп.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(509, 43);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 25;
            label4.Text = "Остаток";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(419, 43);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 24;
            label3.Text = "Ед. изм";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", productBindingSource1, "Name", true));
            textBox1.Location = new Point(91, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(305, 27);
            textBox1.TabIndex = 23;
            // 
            // productBindingSource1
            // 
            productBindingSource1.DataSource = typeof(Product);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 43);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 22;
            label2.Text = "Название";
            // 
            // textBox7
            // 
            textBox7.DataBindings.Add(new Binding("Text", productBindingSource2, "MeasureUnit", true));
            textBox7.Location = new Point(416, 82);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(62, 27);
            textBox7.TabIndex = 36;
            // 
            // productBindingSource2
            // 
            productBindingSource2.DataSource = typeof(Product);
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", productBindingSource3, "Balance", true));
            textBox3.Location = new Point(509, 82);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(80, 27);
            textBox3.TabIndex = 37;
            // 
            // productBindingSource3
            // 
            productBindingSource3.DataSource = typeof(Product);
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", productBindingSource5, "MinBalance", true));
            textBox4.Location = new Point(737, 82);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(78, 27);
            textBox4.TabIndex = 38;
            // 
            // productBindingSource5
            // 
            productBindingSource5.DataSource = typeof(Product);
            // 
            // textBox8
            // 
            textBox8.DataBindings.Add(new Binding("Text", productBindingSource4, "Price", true));
            textBox8.Location = new Point(620, 82);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(80, 27);
            textBox8.TabIndex = 39;
            // 
            // productBindingSource4
            // 
            productBindingSource4.DataSource = typeof(Product);
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(82, 354);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(139, 39);
            buttonOK.TabIndex = 40;
            buttonOK.Text = "ОК";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click_1;
            // 
            // buttonCancel
            // 
            buttonCancel.Enabled = false;
            buttonCancel.FlatStyle = FlatStyle.System;
            buttonCancel.Location = new Point(522, 354);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(123, 39);
            buttonCancel.TabIndex = 41;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            textBox9.DataBindings.Add(new Binding("Text", productBindingSource, "Id", true));
            textBox9.Location = new Point(8, 82);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(62, 27);
            textBox9.TabIndex = 42;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Product);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 43);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 43;
            label1.Text = "Id";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(buttonOkPurch);
            groupBox2.Controls.Add(textBox10);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ControlText;
            groupBox2.Location = new Point(741, 168);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(555, 240);
            groupBox2.TabIndex = 44;
            groupBox2.TabStop = false;
            groupBox2.Text = "Добавить новую закупку";
            // 
            // buttonOkPurch
            // 
            buttonOkPurch.Location = new Point(315, 186);
            buttonOkPurch.Name = "buttonOkPurch";
            buttonOkPurch.Size = new Size(125, 36);
            buttonOkPurch.TabIndex = 41;
            buttonOkPurch.Text = "ОК";
            buttonOkPurch.UseVisualStyleBackColor = true;
            buttonOkPurch.Click += buttonOkPurch_Click;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(315, 97);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(125, 30);
            textBox10.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(315, 58);
            label12.Name = "label12";
            label12.Size = new Size(103, 23);
            label12.TabIndex = 2;
            label12.Text = "Количество";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(22, 52);
            label13.Name = "label13";
            label13.Size = new Size(47, 23);
            label13.TabIndex = 1;
            label13.Text = "Дата";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker2.Location = new Point(22, 97);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 30);
            dateTimePicker2.TabIndex = 0;
            dateTimePicker2.Value = new DateTime(2023, 11, 24, 0, 0, 0, 0);
            // 
            // FrmEditProduct
            // 
            AcceptButton = buttonOK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(1320, 450);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(textBox9);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(textBox8);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox7);
            Controls.Add(textBox5);
            Controls.Add(textBox2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Name = "FrmEditProduct";
            Text = "Редактировать товар";
            ((System.ComponentModel.ISupportInitialize)productBindingSource8).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource7).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource6).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource5).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource4).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox5;
        private TextBox textBox2;
        private Label label9;
        private Label label8;
        private TextBox textBox6;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox7;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox8;
        private Button buttonOK;
        private Button buttonCancel;
        private TextBox textBox9;
        private Label label1;
        private BindingSource productBindingSource8;
        private BindingSource productBindingSource7;
        private BindingSource productBindingSource6;
        private BindingSource productBindingSource1;
        private BindingSource productBindingSource2;
        private BindingSource productBindingSource3;
        private BindingSource productBindingSource5;
        private BindingSource productBindingSource4;
        private BindingSource productBindingSource;
        private GroupBox groupBox2;
        private TextBox textBox10;
        private Label label12;
        private Label label13;
        private DateTimePicker dateTimePicker2;
        private Button buttonOkPurch;
    }
}