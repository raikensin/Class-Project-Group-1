namespace RestaurantManagement
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkPickles = new System.Windows.Forms.CheckBox();
            this.chkLettuce = new System.Windows.Forms.CheckBox();
            this.chkOnions = new System.Windows.Forms.CheckBox();
            this.chkTomato = new System.Windows.Forms.CheckBox();
            this.chkDoublePatty = new System.Windows.Forms.CheckBox();
            this.chkHamburger = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkPlainSalad = new System.Windows.Forms.CheckBox();
            this.chkFruitSalad = new System.Windows.Forms.CheckBox();
            this.chkGardenSalad = new System.Windows.Forms.CheckBox();
            this.chkHouseSalad = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkTea = new System.Windows.Forms.CheckBox();
            this.chkSprite = new System.Windows.Forms.CheckBox();
            this.chkCoke = new System.Windows.Forms.CheckBox();
            this.chkRootBeer = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrdersList = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chktable6 = new System.Windows.Forms.CheckBox();
            this.chktable5 = new System.Windows.Forms.CheckBox();
            this.chktable4 = new System.Windows.Forms.CheckBox();
            this.chktable3 = new System.Windows.Forms.CheckBox();
            this.chktable2 = new System.Windows.Forms.CheckBox();
            this.chkTable1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Controls.Add(this.chkPickles);
            this.groupBox1.Controls.Add(this.chkLettuce);
            this.groupBox1.Controls.Add(this.chkOnions);
            this.groupBox1.Controls.Add(this.chkTomato);
            this.groupBox1.Controls.Add(this.chkDoublePatty);
            this.groupBox1.Controls.Add(this.chkHamburger);
            this.groupBox1.Location = new System.Drawing.Point(325, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(162, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hamburgers";
            // 
            // chkPickles
            // 
            this.chkPickles.AutoSize = true;
            this.chkPickles.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chkPickles.Location = new System.Drawing.Point(14, 154);
            this.chkPickles.Name = "chkPickles";
            this.chkPickles.Size = new System.Drawing.Size(85, 17);
            this.chkPickles.TabIndex = 10;
            this.chkPickles.Text = "Pickle $1.99";
            this.chkPickles.UseVisualStyleBackColor = true;
            // 
            // chkLettuce
            // 
            this.chkLettuce.AutoSize = true;
            this.chkLettuce.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chkLettuce.Location = new System.Drawing.Point(14, 131);
            this.chkLettuce.Name = "chkLettuce";
            this.chkLettuce.Size = new System.Drawing.Size(92, 17);
            this.chkLettuce.TabIndex = 9;
            this.chkLettuce.Text = "Lettuce $1.99";
            this.chkLettuce.UseVisualStyleBackColor = true;
            // 
            // chkOnions
            // 
            this.chkOnions.AutoSize = true;
            this.chkOnions.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chkOnions.Location = new System.Drawing.Point(15, 108);
            this.chkOnions.Name = "chkOnions";
            this.chkOnions.Size = new System.Drawing.Size(89, 17);
            this.chkOnions.TabIndex = 8;
            this.chkOnions.Text = "Onions $1.99";
            this.chkOnions.UseVisualStyleBackColor = true;
            // 
            // chkTomato
            // 
            this.chkTomato.AutoSize = true;
            this.chkTomato.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chkTomato.Location = new System.Drawing.Point(15, 85);
            this.chkTomato.Name = "chkTomato";
            this.chkTomato.Size = new System.Drawing.Size(92, 17);
            this.chkTomato.TabIndex = 7;
            this.chkTomato.Text = "Tomato $1.99";
            this.chkTomato.UseVisualStyleBackColor = true;
            this.chkTomato.CheckedChanged += new System.EventHandler(this.chkTomato_CheckedChanged);
            // 
            // chkDoublePatty
            // 
            this.chkDoublePatty.AutoSize = true;
            this.chkDoublePatty.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chkDoublePatty.Location = new System.Drawing.Point(15, 63);
            this.chkDoublePatty.Name = "chkDoublePatty";
            this.chkDoublePatty.Size = new System.Drawing.Size(117, 17);
            this.chkDoublePatty.TabIndex = 6;
            this.chkDoublePatty.Text = "Double Patty $6.99";
            this.chkDoublePatty.UseVisualStyleBackColor = true;
            // 
            // chkHamburger
            // 
            this.chkHamburger.AutoSize = true;
            this.chkHamburger.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chkHamburger.Location = new System.Drawing.Point(15, 37);
            this.chkHamburger.Margin = new System.Windows.Forms.Padding(2);
            this.chkHamburger.Name = "chkHamburger";
            this.chkHamburger.Size = new System.Drawing.Size(114, 17);
            this.chkHamburger.TabIndex = 0;
            this.chkHamburger.Text = "Hamburger $15.75";
            this.chkHamburger.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InfoText;
            this.groupBox2.Controls.Add(this.chkPlainSalad);
            this.groupBox2.Controls.Add(this.chkFruitSalad);
            this.groupBox2.Controls.Add(this.chkGardenSalad);
            this.groupBox2.Controls.Add(this.chkHouseSalad);
            this.groupBox2.Location = new System.Drawing.Point(524, 35);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(139, 219);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salads";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // chkPlainSalad
            // 
            this.chkPlainSalad.AutoSize = true;
            this.chkPlainSalad.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chkPlainSalad.Location = new System.Drawing.Point(16, 132);
            this.chkPlainSalad.Margin = new System.Windows.Forms.Padding(2);
            this.chkPlainSalad.Name = "chkPlainSalad";
            this.chkPlainSalad.Size = new System.Drawing.Size(109, 17);
            this.chkPlainSalad.TabIndex = 3;
            this.chkPlainSalad.Text = "Plain Salad $2.99";
            this.chkPlainSalad.UseVisualStyleBackColor = true;
            // 
            // chkFruitSalad
            // 
            this.chkFruitSalad.AutoSize = true;
            this.chkFruitSalad.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chkFruitSalad.Location = new System.Drawing.Point(16, 102);
            this.chkFruitSalad.Margin = new System.Windows.Forms.Padding(2);
            this.chkFruitSalad.Name = "chkFruitSalad";
            this.chkFruitSalad.Size = new System.Drawing.Size(106, 17);
            this.chkFruitSalad.TabIndex = 2;
            this.chkFruitSalad.Text = "Fruit Salad $6.99";
            this.chkFruitSalad.UseVisualStyleBackColor = true;
            // 
            // chkGardenSalad
            // 
            this.chkGardenSalad.AutoSize = true;
            this.chkGardenSalad.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chkGardenSalad.Location = new System.Drawing.Point(16, 66);
            this.chkGardenSalad.Margin = new System.Windows.Forms.Padding(2);
            this.chkGardenSalad.Name = "chkGardenSalad";
            this.chkGardenSalad.Size = new System.Drawing.Size(121, 17);
            this.chkGardenSalad.TabIndex = 1;
            this.chkGardenSalad.Text = "Garden Salad $9.99";
            this.chkGardenSalad.UseVisualStyleBackColor = true;
            this.chkGardenSalad.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chkHouseSalad
            // 
            this.chkHouseSalad.AutoSize = true;
            this.chkHouseSalad.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chkHouseSalad.Location = new System.Drawing.Point(16, 37);
            this.chkHouseSalad.Margin = new System.Windows.Forms.Padding(2);
            this.chkHouseSalad.Name = "chkHouseSalad";
            this.chkHouseSalad.Size = new System.Drawing.Size(117, 17);
            this.chkHouseSalad.TabIndex = 1;
            this.chkHouseSalad.Text = "House Salad $5.99";
            this.chkHouseSalad.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InfoText;
            this.groupBox3.Controls.Add(this.chkTea);
            this.groupBox3.Controls.Add(this.chkSprite);
            this.groupBox3.Controls.Add(this.chkCoke);
            this.groupBox3.Controls.Add(this.chkRootBeer);
            this.groupBox3.Location = new System.Drawing.Point(709, 35);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(150, 219);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Beverage";
            // 
            // chkTea
            // 
            this.chkTea.AutoSize = true;
            this.chkTea.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chkTea.Location = new System.Drawing.Point(20, 121);
            this.chkTea.Margin = new System.Windows.Forms.Padding(2);
            this.chkTea.Name = "chkTea";
            this.chkTea.Size = new System.Drawing.Size(75, 17);
            this.chkTea.TabIndex = 4;
            this.chkTea.Text = "Tea $1.99";
            this.chkTea.UseVisualStyleBackColor = true;
            this.chkTea.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // chkSprite
            // 
            this.chkSprite.AutoSize = true;
            this.chkSprite.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chkSprite.Location = new System.Drawing.Point(20, 58);
            this.chkSprite.Margin = new System.Windows.Forms.Padding(2);
            this.chkSprite.Name = "chkSprite";
            this.chkSprite.Size = new System.Drawing.Size(83, 17);
            this.chkSprite.TabIndex = 5;
            this.chkSprite.Text = "Sprite $2.99";
            this.chkSprite.UseVisualStyleBackColor = true;
            // 
            // chkCoke
            // 
            this.chkCoke.AutoSize = true;
            this.chkCoke.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chkCoke.Location = new System.Drawing.Point(20, 28);
            this.chkCoke.Margin = new System.Windows.Forms.Padding(2);
            this.chkCoke.Name = "chkCoke";
            this.chkCoke.Size = new System.Drawing.Size(81, 17);
            this.chkCoke.TabIndex = 6;
            this.chkCoke.Text = "Coke $2.99";
            this.chkCoke.UseVisualStyleBackColor = true;
            // 
            // chkRootBeer
            // 
            this.chkRootBeer.AutoSize = true;
            this.chkRootBeer.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chkRootBeer.Location = new System.Drawing.Point(20, 89);
            this.chkRootBeer.Margin = new System.Windows.Forms.Padding(2);
            this.chkRootBeer.Name = "chkRootBeer";
            this.chkRootBeer.Size = new System.Drawing.Size(104, 17);
            this.chkRootBeer.TabIndex = 7;
            this.chkRootBeer.Text = "Root Beer $2.99";
            this.chkRootBeer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InfoText;
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(135, 328);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total";
            // 
            // txtOrdersList
            // 
            this.txtOrdersList.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtOrdersList.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtOrdersList.Location = new System.Drawing.Point(20, 35);
            this.txtOrdersList.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrdersList.Multiline = true;
            this.txtOrdersList.Name = "txtOrdersList";
            this.txtOrdersList.ReadOnly = true;
            this.txtOrdersList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOrdersList.Size = new System.Drawing.Size(265, 289);
            this.txtOrdersList.TabIndex = 3;
            this.txtOrdersList.TextChanged += new System.EventHandler(this.txtOrdersList_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtTotal.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTotal.Location = new System.Drawing.Point(170, 328);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(96, 20);
            this.txtTotal.TabIndex = 4;
            this.txtTotal.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTax
            // 
            this.txtTax.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtTax.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTax.Location = new System.Drawing.Point(170, 352);
            this.txtTax.Margin = new System.Windows.Forms.Padding(2);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(96, 20);
            this.txtTax.TabIndex = 5;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtSubtotal.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSubtotal.Location = new System.Drawing.Point(170, 376);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(96, 20);
            this.txtSubtotal.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InfoText;
            this.label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(113, 379);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sub Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InfoText;
            this.label3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Location = new System.Drawing.Point(109, 355);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tax 8.25%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(108, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Order List";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(27, 456);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 21);
            this.button1.TabIndex = 10;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(746, 456);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 21);
            this.button2.TabIndex = 11;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSend.BackgroundImage")));
            this.btnSend.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSend.Location = new System.Drawing.Point(170, 456);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(114, 21);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "Sent";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddOrder.BackgroundImage")));
            this.btnAddOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddOrder.Location = new System.Drawing.Point(627, 456);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(114, 21);
            this.btnAddOrder.TabIndex = 14;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.InfoText;
            this.groupBox4.Controls.Add(this.chktable6);
            this.groupBox4.Controls.Add(this.chktable5);
            this.groupBox4.Controls.Add(this.chktable4);
            this.groupBox4.Controls.Add(this.chktable3);
            this.groupBox4.Controls.Add(this.chktable2);
            this.groupBox4.Controls.Add(this.chkTable1);
            this.groupBox4.Location = new System.Drawing.Point(670, 268);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(210, 89);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Select Table";
            // 
            // chktable6
            // 
            this.chktable6.AutoSize = true;
            this.chktable6.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chktable6.Location = new System.Drawing.Point(145, 53);
            this.chktable6.Name = "chktable6";
            this.chktable6.Size = new System.Drawing.Size(59, 17);
            this.chktable6.TabIndex = 5;
            this.chktable6.Text = "Table6";
            this.chktable6.UseVisualStyleBackColor = true;
            // 
            // chktable5
            // 
            this.chktable5.AutoSize = true;
            this.chktable5.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chktable5.Location = new System.Drawing.Point(77, 53);
            this.chktable5.Name = "chktable5";
            this.chktable5.Size = new System.Drawing.Size(62, 17);
            this.chktable5.TabIndex = 4;
            this.chktable5.Text = "Table 5";
            this.chktable5.UseVisualStyleBackColor = true;
            // 
            // chktable4
            // 
            this.chktable4.AutoSize = true;
            this.chktable4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chktable4.Location = new System.Drawing.Point(12, 53);
            this.chktable4.Name = "chktable4";
            this.chktable4.Size = new System.Drawing.Size(59, 17);
            this.chktable4.TabIndex = 3;
            this.chktable4.Text = "Table4";
            this.chktable4.UseVisualStyleBackColor = true;
            // 
            // chktable3
            // 
            this.chktable3.AutoSize = true;
            this.chktable3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chktable3.Location = new System.Drawing.Point(145, 31);
            this.chktable3.Name = "chktable3";
            this.chktable3.Size = new System.Drawing.Size(62, 17);
            this.chktable3.TabIndex = 2;
            this.chktable3.Text = "Table 3";
            this.chktable3.UseVisualStyleBackColor = true;
            // 
            // chktable2
            // 
            this.chktable2.AutoSize = true;
            this.chktable2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chktable2.Location = new System.Drawing.Point(77, 31);
            this.chktable2.Name = "chktable2";
            this.chktable2.Size = new System.Drawing.Size(62, 17);
            this.chktable2.TabIndex = 1;
            this.chktable2.Text = "Table 2";
            this.chktable2.UseVisualStyleBackColor = true;
            // 
            // chkTable1
            // 
            this.chkTable1.AutoSize = true;
            this.chkTable1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chkTable1.Location = new System.Drawing.Point(12, 30);
            this.chkTable1.Name = "chkTable1";
            this.chkTable1.Size = new System.Drawing.Size(65, 17);
            this.chkTable1.TabIndex = 0;
            this.chkTable1.Text = "Table 1 ";
            this.chkTable1.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 485);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtOrdersList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkHamburger;
        private System.Windows.Forms.CheckBox chkPlainSalad;
        private System.Windows.Forms.CheckBox chkFruitSalad;
        private System.Windows.Forms.CheckBox chkGardenSalad;
        private System.Windows.Forms.CheckBox chkHouseSalad;
        private System.Windows.Forms.CheckBox chkRootBeer;
        private System.Windows.Forms.CheckBox chkCoke;
        private System.Windows.Forms.CheckBox chkSprite;
        private System.Windows.Forms.CheckBox chkTea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrdersList;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.CheckBox chkPickles;
        private System.Windows.Forms.CheckBox chkLettuce;
        private System.Windows.Forms.CheckBox chkOnions;
        private System.Windows.Forms.CheckBox chkTomato;
        private System.Windows.Forms.CheckBox chkDoublePatty;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chktable6;
        private System.Windows.Forms.CheckBox chktable5;
        private System.Windows.Forms.CheckBox chktable4;
        private System.Windows.Forms.CheckBox chktable3;
        private System.Windows.Forms.CheckBox chktable2;
        private System.Windows.Forms.CheckBox chkTable1;
    }
}