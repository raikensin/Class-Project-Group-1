namespace RestaurantManagement
{
    partial class Manage
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
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnAssignTables = new System.Windows.Forms.Button();
            this.btnmenu = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnHostBusBoy = new System.Windows.Forms.Button();
            this.btnCook = new System.Windows.Forms.Button();
            this.btnInventoryReports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(23, 30);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(143, 50);
            this.btnEmployees.TabIndex = 0;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAssignTables
            // 
            this.btnAssignTables.Location = new System.Drawing.Point(197, 30);
            this.btnAssignTables.Margin = new System.Windows.Forms.Padding(2);
            this.btnAssignTables.Name = "btnAssignTables";
            this.btnAssignTables.Size = new System.Drawing.Size(143, 50);
            this.btnAssignTables.TabIndex = 1;
            this.btnAssignTables.Text = "Assign Tables";
            this.btnAssignTables.UseVisualStyleBackColor = true;
            this.btnAssignTables.Click += new System.EventHandler(this.btnAssignTables_Click);
            // 
            // btnmenu
            // 
            this.btnmenu.Location = new System.Drawing.Point(23, 112);
            this.btnmenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(143, 50);
            this.btnmenu.TabIndex = 4;
            this.btnmenu.Text = "Menu";
            this.btnmenu.UseVisualStyleBackColor = true;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(197, 194);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(143, 48);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnHostBusBoy
            // 
            this.btnHostBusBoy.Location = new System.Drawing.Point(197, 112);
            this.btnHostBusBoy.Name = "btnHostBusBoy";
            this.btnHostBusBoy.Size = new System.Drawing.Size(143, 50);
            this.btnHostBusBoy.TabIndex = 20;
            this.btnHostBusBoy.Text = "Host and Bus";
            this.btnHostBusBoy.UseVisualStyleBackColor = true;
            // 
            // btnCook
            // 
            this.btnCook.Location = new System.Drawing.Point(23, 272);
            this.btnCook.Name = "btnCook";
            this.btnCook.Size = new System.Drawing.Size(147, 50);
            this.btnCook.TabIndex = 21;
            this.btnCook.Text = "Cook";
            this.btnCook.UseVisualStyleBackColor = true;
            this.btnCook.Click += new System.EventHandler(this.btnCook_Click);
            // 
            // btnInventoryReports
            // 
            this.btnInventoryReports.Location = new System.Drawing.Point(23, 194);
            this.btnInventoryReports.Name = "btnInventoryReports";
            this.btnInventoryReports.Size = new System.Drawing.Size(143, 48);
            this.btnInventoryReports.TabIndex = 22;
            this.btnInventoryReports.Text = "Inventory Reports";
            this.btnInventoryReports.UseVisualStyleBackColor = true;
            this.btnInventoryReports.Click += new System.EventHandler(this.btnInventoryReports_Click);
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 356);
            this.Controls.Add(this.btnInventoryReports);
            this.Controls.Add(this.btnCook);
            this.Controls.Add(this.btnHostBusBoy);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.btnAssignTables);
            this.Controls.Add(this.btnEmployees);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Manage";
            this.Text = "Manage";
            this.Load += new System.EventHandler(this.Manage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnAssignTables;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnHostBusBoy;
        private System.Windows.Forms.Button btnCook;
        private System.Windows.Forms.Button btnInventoryReports;
    }
}