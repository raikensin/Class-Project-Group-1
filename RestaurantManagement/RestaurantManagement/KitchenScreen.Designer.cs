﻿namespace RestaurantManagement
{
    partial class KitchenScreen
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
            this.bntDone = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            this.txtOrder1 = new System.Windows.Forms.TextBox();
            this.dtpDateAndTime = new System.Windows.Forms.DateTimePicker();
            this.lblKitchen = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bntDone
            // 
            this.bntDone.Location = new System.Drawing.Point(581, 368);
            this.bntDone.Name = "bntDone";
            this.bntDone.Size = new System.Drawing.Size(116, 41);
            this.bntDone.TabIndex = 0;
            this.bntDone.Text = "Done";
            this.bntDone.UseVisualStyleBackColor = true;
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(34, 367);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(123, 43);
            this.bntDelete.TabIndex = 1;
            this.bntDelete.Text = "Delete";
            this.bntDelete.UseVisualStyleBackColor = true;
            // 
            // txtOrder1
            // 
            this.txtOrder1.Location = new System.Drawing.Point(7, 36);
            this.txtOrder1.Multiline = true;
            this.txtOrder1.Name = "txtOrder1";
            this.txtOrder1.Size = new System.Drawing.Size(222, 323);
            this.txtOrder1.TabIndex = 2;
            this.txtOrder1.TextChanged += new System.EventHandler(this.txtOrder1_TextChanged);
            // 
            // dtpDateAndTime
            // 
            this.dtpDateAndTime.Location = new System.Drawing.Point(235, 10);
            this.dtpDateAndTime.Name = "dtpDateAndTime";
            this.dtpDateAndTime.Size = new System.Drawing.Size(266, 20);
            this.dtpDateAndTime.TabIndex = 4;
            this.dtpDateAndTime.Value = new System.DateTime(2017, 5, 3, 16, 51, 23, 0);
            // 
            // lblKitchen
            // 
            this.lblKitchen.AutoSize = true;
            this.lblKitchen.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitchen.Location = new System.Drawing.Point(6, 2);
            this.lblKitchen.Name = "lblKitchen";
            this.lblKitchen.Size = new System.Drawing.Size(99, 31);
            this.lblKitchen.TabIndex = 4;
            this.lblKitchen.Text = "Kitcken";
            this.lblKitchen.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(478, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 323);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(235, 36);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 323);
            this.textBox2.TabIndex = 6;
            // 
            // KitchenScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 421);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblKitchen);
            this.Controls.Add(this.dtpDateAndTime);
            this.Controls.Add(this.txtOrder1);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.bntDone);
            this.Name = "KitchenScreen";
            this.Text = "KitchenScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntDone;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.TextBox txtOrder1;
        private System.Windows.Forms.DateTimePicker dtpDateAndTime;
        private System.Windows.Forms.Label lblKitchen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}