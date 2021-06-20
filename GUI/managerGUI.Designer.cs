
namespace Restaurant_Ordering_System.GUI
{
    partial class managerGUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dashboardtab = new System.Windows.Forms.TabPage();
            this.btn_kit_manage = new System.Windows.Forms.Button();
            this.btn_order_hist = new System.Windows.Forms.Button();
            this.btn_pd = new System.Windows.Forms.Button();
            this.btn_fooditem = new System.Windows.Forms.Button();
            this.btn_customer = new System.Windows.Forms.Button();
            this.btn_payment = new System.Windows.Forms.Button();
            this.btn_category = new System.Windows.Forms.Button();
            this.profiletab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.show_role = new System.Windows.Forms.Label();
            this.show_salary = new System.Windows.Forms.Label();
            this.show_contact = new System.Windows.Forms.Label();
            this.show_email = new System.Windows.Forms.Label();
            this.show_status = new System.Windows.Forms.Label();
            this.show_username = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.dashboardtab.SuspendLayout();
            this.profiletab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.dashboardtab);
            this.tabControl1.Controls.Add(this.profiletab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // dashboardtab
            // 
            this.dashboardtab.Controls.Add(this.btn_kit_manage);
            this.dashboardtab.Controls.Add(this.btn_order_hist);
            this.dashboardtab.Controls.Add(this.btn_pd);
            this.dashboardtab.Controls.Add(this.btn_fooditem);
            this.dashboardtab.Controls.Add(this.btn_customer);
            this.dashboardtab.Controls.Add(this.btn_payment);
            this.dashboardtab.Controls.Add(this.btn_category);
            this.dashboardtab.Location = new System.Drawing.Point(4, 22);
            this.dashboardtab.Name = "dashboardtab";
            this.dashboardtab.Padding = new System.Windows.Forms.Padding(3);
            this.dashboardtab.Size = new System.Drawing.Size(792, 424);
            this.dashboardtab.TabIndex = 0;
            this.dashboardtab.Text = "Dashboard";
            this.dashboardtab.UseVisualStyleBackColor = true;
            // 
            // btn_kit_manage
            // 
            this.btn_kit_manage.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kit_manage.Location = new System.Drawing.Point(425, 136);
            this.btn_kit_manage.Name = "btn_kit_manage";
            this.btn_kit_manage.Size = new System.Drawing.Size(131, 40);
            this.btn_kit_manage.TabIndex = 8;
            this.btn_kit_manage.Text = "Kitchen Manager";
            this.btn_kit_manage.UseVisualStyleBackColor = true;
            this.btn_kit_manage.Click += new System.EventHandler(this.btn_kit_manage_Click);
            // 
            // btn_order_hist
            // 
            this.btn_order_hist.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order_hist.Location = new System.Drawing.Point(246, 136);
            this.btn_order_hist.Name = "btn_order_hist";
            this.btn_order_hist.Size = new System.Drawing.Size(131, 40);
            this.btn_order_hist.TabIndex = 7;
            this.btn_order_hist.Text = "Orders History";
            this.btn_order_hist.UseVisualStyleBackColor = true;
            this.btn_order_hist.Click += new System.EventHandler(this.btn_order_hist_Click);
            // 
            // btn_pd
            // 
            this.btn_pd.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pd.Location = new System.Drawing.Point(601, 62);
            this.btn_pd.Name = "btn_pd";
            this.btn_pd.Size = new System.Drawing.Size(160, 40);
            this.btn_pd.TabIndex = 6;
            this.btn_pd.Text = "Place Order";
            this.btn_pd.UseVisualStyleBackColor = true;
            this.btn_pd.Click += new System.EventHandler(this.btn_pd_Click);
            // 
            // btn_fooditem
            // 
            this.btn_fooditem.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fooditem.Location = new System.Drawing.Point(246, 62);
            this.btn_fooditem.Name = "btn_fooditem";
            this.btn_fooditem.Size = new System.Drawing.Size(131, 40);
            this.btn_fooditem.TabIndex = 5;
            this.btn_fooditem.Text = "Food Item";
            this.btn_fooditem.UseVisualStyleBackColor = true;
            this.btn_fooditem.Click += new System.EventHandler(this.btn_fooditem_Click);
            // 
            // btn_customer
            // 
            this.btn_customer.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customer.Location = new System.Drawing.Point(425, 62);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(131, 40);
            this.btn_customer.TabIndex = 4;
            this.btn_customer.Text = "Customer";
            this.btn_customer.UseVisualStyleBackColor = true;
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // btn_payment
            // 
            this.btn_payment.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payment.Location = new System.Drawing.Point(63, 136);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(131, 40);
            this.btn_payment.TabIndex = 3;
            this.btn_payment.Text = "Payment";
            this.btn_payment.UseVisualStyleBackColor = true;
            this.btn_payment.Click += new System.EventHandler(this.btn_payment_Click);
            // 
            // btn_category
            // 
            this.btn_category.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_category.Location = new System.Drawing.Point(63, 62);
            this.btn_category.Name = "btn_category";
            this.btn_category.Size = new System.Drawing.Size(131, 40);
            this.btn_category.TabIndex = 0;
            this.btn_category.Text = "Category Manager";
            this.btn_category.UseVisualStyleBackColor = true;
            this.btn_category.Click += new System.EventHandler(this.btn_category_Click);
            // 
            // profiletab
            // 
            this.profiletab.Controls.Add(this.label4);
            this.profiletab.Controls.Add(this.label5);
            this.profiletab.Controls.Add(this.label6);
            this.profiletab.Controls.Add(this.label1);
            this.profiletab.Controls.Add(this.label2);
            this.profiletab.Controls.Add(this.label3);
            this.profiletab.Controls.Add(this.show_role);
            this.profiletab.Controls.Add(this.show_salary);
            this.profiletab.Controls.Add(this.show_contact);
            this.profiletab.Controls.Add(this.show_email);
            this.profiletab.Controls.Add(this.show_status);
            this.profiletab.Controls.Add(this.show_username);
            this.profiletab.Location = new System.Drawing.Point(4, 22);
            this.profiletab.Name = "profiletab";
            this.profiletab.Padding = new System.Windows.Forms.Padding(3);
            this.profiletab.Size = new System.Drawing.Size(792, 424);
            this.profiletab.TabIndex = 1;
            this.profiletab.Text = "Profile";
            this.profiletab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(477, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(477, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(477, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Role:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Contact:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "User Name:";
            // 
            // show_role
            // 
            this.show_role.AutoSize = true;
            this.show_role.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_role.Location = new System.Drawing.Point(237, 241);
            this.show_role.Name = "show_role";
            this.show_role.Size = new System.Drawing.Size(89, 25);
            this.show_role.TabIndex = 11;
            this.show_role.Text = "label12";
            // 
            // show_salary
            // 
            this.show_salary.AutoSize = true;
            this.show_salary.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_salary.Location = new System.Drawing.Point(561, 174);
            this.show_salary.Name = "show_salary";
            this.show_salary.Size = new System.Drawing.Size(89, 25);
            this.show_salary.TabIndex = 10;
            this.show_salary.Text = "label11";
            // 
            // show_contact
            // 
            this.show_contact.AutoSize = true;
            this.show_contact.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_contact.Location = new System.Drawing.Point(237, 174);
            this.show_contact.Name = "show_contact";
            this.show_contact.Size = new System.Drawing.Size(89, 25);
            this.show_contact.TabIndex = 9;
            this.show_contact.Text = "label10";
            // 
            // show_email
            // 
            this.show_email.AutoSize = true;
            this.show_email.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_email.Location = new System.Drawing.Point(561, 100);
            this.show_email.Name = "show_email";
            this.show_email.Size = new System.Drawing.Size(78, 25);
            this.show_email.TabIndex = 8;
            this.show_email.Text = "label9";
            // 
            // show_status
            // 
            this.show_status.AutoSize = true;
            this.show_status.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_status.Location = new System.Drawing.Point(561, 241);
            this.show_status.Name = "show_status";
            this.show_status.Size = new System.Drawing.Size(78, 25);
            this.show_status.TabIndex = 7;
            this.show_status.Text = "label8";
            // 
            // show_username
            // 
            this.show_username.AutoSize = true;
            this.show_username.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_username.Location = new System.Drawing.Point(237, 100);
            this.show_username.Name = "show_username";
            this.show_username.Size = new System.Drawing.Size(78, 25);
            this.show_username.TabIndex = 6;
            this.show_username.Text = "label2";
            // 
            // managerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "managerGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management";
            this.tabControl1.ResumeLayout(false);
            this.dashboardtab.ResumeLayout(false);
            this.profiletab.ResumeLayout(false);
            this.profiletab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage dashboardtab;
        private System.Windows.Forms.TabPage profiletab;
        private System.Windows.Forms.Label show_role;
        private System.Windows.Forms.Label show_salary;
        private System.Windows.Forms.Label show_contact;
        private System.Windows.Forms.Label show_email;
        private System.Windows.Forms.Label show_status;
        private System.Windows.Forms.Label show_username;
        private System.Windows.Forms.Button btn_category;
        private System.Windows.Forms.Button btn_fooditem;
        private System.Windows.Forms.Button btn_customer;
        private System.Windows.Forms.Button btn_payment;
        private System.Windows.Forms.Button btn_pd;
        private System.Windows.Forms.Button btn_order_hist;
        private System.Windows.Forms.Button btn_kit_manage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}