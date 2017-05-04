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
            this.bntDelete = new System.Windows.Forms.Button();
            this.txtOrder1 = new System.Windows.Forms.TextBox();
            this.lblKitchen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntComplete
            // 
            this.bntComplete.Location = new System.Drawing.Point(207, 391);
            this.bntComplete.Name = "bntComplete";
            this.bntComplete.Size = new System.Drawing.Size(116, 41);
            this.bntComplete.TabIndex = 0;
            this.bntComplete.Text = "Complete";
            this.bntComplete.UseVisualStyleBackColor = true;
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(367, 389);
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
            this.txtOrder1.Size = new System.Drawing.Size(700, 347);
            this.txtOrder1.TabIndex = 2;
            this.txtOrder1.TextChanged += new System.EventHandler(this.txtOrder1_TextChanged);
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
            // KitchenScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 442);
            this.Controls.Add(this.lblKitchen);
            this.Controls.Add(this.txtOrder1);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.bntComplete);
            this.Name = "KitchenScreen";
            this.Text = "KitchenScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntComplete;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.TextBox txtOrder1;
        private System.Windows.Forms.Label lblKitchen;
    }
}