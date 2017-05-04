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
            this.button3 = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(195, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hamburgers";
            // 
            // chkPickles
            // 
            this.chkPickles.AutoSize = true;
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
            this.chkTomato.Location = new System.Drawing.Point(15, 85);
            this.chkTomato.Name = "chkTomato";
            this.chkTomato.Size = new System.Drawing.Size(92, 17);
            this.chkTomato.TabIndex = 7;
            this.chkTomato.Text = "Tomato $1.99";
            this.chkTomato.UseVisualStyleBackColor = true;
            // 
            // chkDoublePatty
            // 
            this.chkDoublePatty.AutoSize = true;
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
            this.groupBox2.Controls.Add(this.chkPlainSalad);
            this.groupBox2.Controls.Add(this.chkFruitSalad);
            this.groupBox2.Controls.Add(this.chkGardenSalad);
            this.groupBox2.Controls.Add(this.chkHouseSalad);
            this.groupBox2.Location = new System.Drawing.Point(524, 35);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(180, 219);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salads";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // chkPlainSalad
            // 
            this.chkPlainSalad.AutoSize = true;
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
            this.label1.Location = new System.Drawing.Point(88, 328);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total";
            // 
            // txtOrdersList
            // 
            this.txtOrdersList.Location = new System.Drawing.Point(20, 35);
            this.txtOrdersList.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrdersList.Multiline = true;
            this.txtOrdersList.Name = "txtOrdersList";
            this.txtOrdersList.ReadOnly = true;
            this.txtOrdersList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOrdersList.Size = new System.Drawing.Size(265, 289);
            this.txtOrdersList.TabIndex = 3;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(170, 328);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(96, 20);
            this.txtTotal.TabIndex = 4;
            this.txtTotal.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(170, 358);
            this.txtTax.Margin = new System.Windows.Forms.Padding(2);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(96, 20);
            this.txtTax.TabIndex = 5;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(170, 388);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(96, 20);
            this.txtSubtotal.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 388);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sub Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 358);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tax 8.25%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Order List";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 432);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(746, 440);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 37);
            this.button2.TabIndex = 11;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(171, 432);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 37);
            this.button3.TabIndex = 12;
            this.button3.Text = "Sent";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(591, 440);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(114, 37);
            this.btnAddOrder.TabIndex = 14;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 485);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.button3);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.CheckBox chkPickles;
        private System.Windows.Forms.CheckBox chkLettuce;
        private System.Windows.Forms.CheckBox chkOnions;
        private System.Windows.Forms.CheckBox chkTomato;
        private System.Windows.Forms.CheckBox chkDoublePatty;
    }
}