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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage));
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnAssignTables = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnmenu = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHostBusBoy = new System.Windows.Forms.Button();
            this.btnCook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(659, 101);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(164, 58);
            this.btnEmployees.TabIndex = 0;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAssignTables
            // 
            this.btnAssignTables.Location = new System.Drawing.Point(659, 163);
            this.btnAssignTables.Margin = new System.Windows.Forms.Padding(2);
            this.btnAssignTables.Name = "btnAssignTables";
            this.btnAssignTables.Size = new System.Drawing.Size(164, 58);
            this.btnAssignTables.TabIndex = 1;
            this.btnAssignTables.Text = "Assign Tables";
            this.btnAssignTables.UseVisualStyleBackColor = true;
            this.btnAssignTables.Click += new System.EventHandler(this.btnAssignTables_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(659, 39);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(164, 58);
            this.btnAddEmployee.TabIndex = 3;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnmenu
            // 
            this.btnmenu.Location = new System.Drawing.Point(194, 337);
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
            this.btnLogOut.Location = new System.Drawing.Point(659, 225);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(164, 58);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnHostBusBoy
            // 
            this.btnHostBusBoy.Location = new System.Drawing.Point(356, 337);
            this.btnHostBusBoy.Name = "btnHostBusBoy";
            this.btnHostBusBoy.Size = new System.Drawing.Size(147, 50);
            this.btnHostBusBoy.TabIndex = 20;
            this.btnHostBusBoy.Text = "Host and Bus";
            this.btnHostBusBoy.UseVisualStyleBackColor = true;
            // 
            // btnCook
            // 
            this.btnCook.Location = new System.Drawing.Point(523, 337);
            this.btnCook.Name = "btnCook";
            this.btnCook.Size = new System.Drawing.Size(147, 50);
            this.btnCook.TabIndex = 21;
            this.btnCook.Text = "Cook";
            this.btnCook.UseVisualStyleBackColor = true;
            this.btnCook.Click += new System.EventHandler(this.btnCook_Click);
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 432);
            this.Controls.Add(this.btnCook);
            this.Controls.Add(this.btnHostBusBoy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnAssignTables);
            this.Controls.Add(this.btnEmployees);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Manage";
            this.Text = "Manage";
            this.Load += new System.EventHandler(this.Manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnAssignTables;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHostBusBoy;
        private System.Windows.Forms.Button btnCook;
    }
}