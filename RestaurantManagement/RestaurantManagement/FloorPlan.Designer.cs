namespace RestaurantManagement
{
    partial class FloorPlan
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
            this.btnTable1 = new System.Windows.Forms.Button();
            this.btnTable2 = new System.Windows.Forms.Button();
            this.btnTable3 = new System.Windows.Forms.Button();
            this.btnTable4 = new System.Windows.Forms.Button();
            this.btnTable5 = new System.Windows.Forms.Button();
            this.btnTable6 = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnWaitingList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTable1
            // 
            this.btnTable1.Location = new System.Drawing.Point(19, 15);
            this.btnTable1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTable1.Name = "btnTable1";
            this.btnTable1.Size = new System.Drawing.Size(91, 96);
            this.btnTable1.TabIndex = 0;
            this.btnTable1.Text = "Table 1";
            this.btnTable1.UseVisualStyleBackColor = true;
            // 
            // btnTable2
            // 
            this.btnTable2.Location = new System.Drawing.Point(19, 127);
            this.btnTable2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTable2.Name = "btnTable2";
            this.btnTable2.Size = new System.Drawing.Size(91, 96);
            this.btnTable2.TabIndex = 1;
            this.btnTable2.Text = "Table 2";
            this.btnTable2.UseVisualStyleBackColor = true;
            // 
            // btnTable3
            // 
            this.btnTable3.Location = new System.Drawing.Point(19, 240);
            this.btnTable3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTable3.Name = "btnTable3";
            this.btnTable3.Size = new System.Drawing.Size(91, 96);
            this.btnTable3.TabIndex = 2;
            this.btnTable3.Text = "Table 3";
            this.btnTable3.UseVisualStyleBackColor = true;
            // 
            // btnTable4
            // 
            this.btnTable4.Location = new System.Drawing.Point(130, 15);
            this.btnTable4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTable4.Name = "btnTable4";
            this.btnTable4.Size = new System.Drawing.Size(91, 96);
            this.btnTable4.TabIndex = 3;
            this.btnTable4.Text = "Table 4";
            this.btnTable4.UseVisualStyleBackColor = true;
            this.btnTable4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnTable5
            // 
            this.btnTable5.Location = new System.Drawing.Point(130, 127);
            this.btnTable5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTable5.Name = "btnTable5";
            this.btnTable5.Size = new System.Drawing.Size(91, 96);
            this.btnTable5.TabIndex = 4;
            this.btnTable5.Text = "Table 5";
            this.btnTable5.UseVisualStyleBackColor = true;
            // 
            // btnTable6
            // 
            this.btnTable6.Location = new System.Drawing.Point(130, 240);
            this.btnTable6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTable6.Name = "btnTable6";
            this.btnTable6.Size = new System.Drawing.Size(91, 96);
            this.btnTable6.TabIndex = 5;
            this.btnTable6.Text = "Table 6";
            this.btnTable6.UseVisualStyleBackColor = true;
            // 
            // btnReservation
            // 
            this.btnReservation.Location = new System.Drawing.Point(416, 31);
            this.btnReservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(116, 32);
            this.btnReservation.TabIndex = 6;
            this.btnReservation.Text = "Reservation";
            this.btnReservation.UseVisualStyleBackColor = true;
            // 
            // btnWaitingList
            // 
            this.btnWaitingList.Location = new System.Drawing.Point(416, 127);
            this.btnWaitingList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWaitingList.Name = "btnWaitingList";
            this.btnWaitingList.Size = new System.Drawing.Size(116, 32);
            this.btnWaitingList.TabIndex = 7;
            this.btnWaitingList.Text = "Waiting List";
            this.btnWaitingList.UseVisualStyleBackColor = true;
            // 
            // FloorPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 412);
            this.Controls.Add(this.btnWaitingList);
            this.Controls.Add(this.btnReservation);
            this.Controls.Add(this.btnTable6);
            this.Controls.Add(this.btnTable5);
            this.Controls.Add(this.btnTable4);
            this.Controls.Add(this.btnTable3);
            this.Controls.Add(this.btnTable2);
            this.Controls.Add(this.btnTable1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FloorPlan";
            this.Text = "FloorPlan";
            this.Load += new System.EventHandler(this.FloorPlan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTable1;
        private System.Windows.Forms.Button btnTable2;
        private System.Windows.Forms.Button btnTable3;
        private System.Windows.Forms.Button btnTable4;
        private System.Windows.Forms.Button btnTable5;
        private System.Windows.Forms.Button btnTable6;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnWaitingList;
    }
}