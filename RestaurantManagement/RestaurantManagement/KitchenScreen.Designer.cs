namespace RestaurantManagement
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
            this.bntComplete = new System.Windows.Forms.Button();
            this.txtOrder1 = new System.Windows.Forms.TextBox();
            this.lblKitchen = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtOrderNum = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.lalOrderNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntComplete
            // 
            this.bntComplete.Location = new System.Drawing.Point(390, 415);
            this.bntComplete.Name = "bntComplete";
            this.bntComplete.Size = new System.Drawing.Size(116, 41);
            this.bntComplete.TabIndex = 0;
            this.bntComplete.Text = "Complete";
            this.bntComplete.UseVisualStyleBackColor = true;
            this.bntComplete.Click += new System.EventHandler(this.bntComplete_Click);
            // 
            // txtOrder1
            // 
            this.txtOrder1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtOrder1.Location = new System.Drawing.Point(7, 36);
            this.txtOrder1.Multiline = true;
            this.txtOrder1.Name = "txtOrder1";
            this.txtOrder1.ReadOnly = true;
            this.txtOrder1.Size = new System.Drawing.Size(700, 347);
            this.txtOrder1.TabIndex = 2;
            this.txtOrder1.TextChanged += new System.EventHandler(this.txtOrder1_TextChanged);
            // 
            // lblKitchen
            // 
            this.lblKitchen.AutoSize = true;
            this.lblKitchen.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitchen.Location = new System.Drawing.Point(296, 0);
            this.lblKitchen.Name = "lblKitchen";
            this.lblKitchen.Size = new System.Drawing.Size(116, 33);
            this.lblKitchen.TabIndex = 4;
            this.lblKitchen.Text = "Kitchen";
            this.lblKitchen.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(200, 415);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 41);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtOrderNum
            // 
            this.txtOrderNum.Location = new System.Drawing.Point(409, 389);
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.Size = new System.Drawing.Size(72, 20);
            this.txtOrderNum.TabIndex = 6;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(682, 36);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(24, 347);
            this.vScrollBar1.TabIndex = 7;
            // 
            // lalOrderNumber
            // 
            this.lalOrderNumber.AutoSize = true;
            this.lalOrderNumber.Location = new System.Drawing.Point(362, 392);
            this.lalOrderNumber.Name = "lalOrderNumber";
            this.lalOrderNumber.Size = new System.Drawing.Size(40, 13);
            this.lalOrderNumber.TabIndex = 8;
            this.lalOrderNumber.Text = "Order#";
            // 
            // KitchenScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 468);
            this.Controls.Add(this.lalOrderNumber);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.txtOrderNum);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblKitchen);
            this.Controls.Add(this.txtOrder1);
            this.Controls.Add(this.bntComplete);
            this.Name = "KitchenScreen";
            this.Text = "KitchenScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntComplete;
        private System.Windows.Forms.TextBox txtOrder1;
        private System.Windows.Forms.Label lblKitchen;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtOrderNum;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label lalOrderNumber;
    }
}