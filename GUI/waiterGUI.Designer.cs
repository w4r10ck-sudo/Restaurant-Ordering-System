
namespace Restaurant_Ordering_System.GUI
{
    partial class waiterGUI
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
            this.btn_pd = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.dashboardtab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // dashboardtab
            // 
            this.dashboardtab.Controls.Add(this.label4);
            this.dashboardtab.Controls.Add(this.label5);
            this.dashboardtab.Controls.Add(this.label6);
            this.dashboardtab.Controls.Add(this.label1);
            this.dashboardtab.Controls.Add(this.label2);
            this.dashboardtab.Controls.Add(this.label3);
            this.dashboardtab.Controls.Add(this.show_role);
            this.dashboardtab.Controls.Add(this.show_salary);
            this.dashboardtab.Controls.Add(this.show_contact);
            this.dashboardtab.Controls.Add(this.show_email);
            this.dashboardtab.Controls.Add(this.show_status);
            this.dashboardtab.Controls.Add(this.show_username);
            this.dashboardtab.Controls.Add(this.btn_pd);
            this.dashboardtab.Location = new System.Drawing.Point(4, 22);
            this.dashboardtab.Name = "dashboardtab";
            this.dashboardtab.Padding = new System.Windows.Forms.Padding(3);
            this.dashboardtab.Size = new System.Drawing.Size(792, 424);
            this.dashboardtab.TabIndex = 0;
            this.dashboardtab.Text = "Dashboard";
            this.dashboardtab.UseVisualStyleBackColor = true;
            // 
            // btn_pd
            // 
            this.btn_pd.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pd.Location = new System.Drawing.Point(322, 285);
            this.btn_pd.Name = "btn_pd";
            this.btn_pd.Size = new System.Drawing.Size(165, 40);
            this.btn_pd.TabIndex = 6;
            this.btn_pd.Text = "Place Order";
            this.btn_pd.UseVisualStyleBackColor = true;
            this.btn_pd.Click += new System.EventHandler(this.btn_pd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(469, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(469, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(469, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Role:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Contact:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "User Name:";
            // 
            // show_role
            // 
            this.show_role.AutoSize = true;
            this.show_role.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_role.Location = new System.Drawing.Point(229, 181);
            this.show_role.Name = "show_role";
            this.show_role.Size = new System.Drawing.Size(89, 25);
            this.show_role.TabIndex = 23;
            this.show_role.Text = "label12";
            // 
            // show_salary
            // 
            this.show_salary.AutoSize = true;
            this.show_salary.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_salary.Location = new System.Drawing.Point(553, 114);
            this.show_salary.Name = "show_salary";
            this.show_salary.Size = new System.Drawing.Size(89, 25);
            this.show_salary.TabIndex = 22;
            this.show_salary.Text = "label11";
            // 
            // show_contact
            // 
            this.show_contact.AutoSize = true;
            this.show_contact.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_contact.Location = new System.Drawing.Point(229, 114);
            this.show_contact.Name = "show_contact";
            this.show_contact.Size = new System.Drawing.Size(89, 25);
            this.show_contact.TabIndex = 21;
            this.show_contact.Text = "label10";
            // 
            // show_email
            // 
            this.show_email.AutoSize = true;
            this.show_email.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_email.Location = new System.Drawing.Point(553, 40);
            this.show_email.Name = "show_email";
            this.show_email.Size = new System.Drawing.Size(78, 25);
            this.show_email.TabIndex = 20;
            this.show_email.Text = "label9";
            // 
            // show_status
            // 
            this.show_status.AutoSize = true;
            this.show_status.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_status.Location = new System.Drawing.Point(553, 181);
            this.show_status.Name = "show_status";
            this.show_status.Size = new System.Drawing.Size(78, 25);
            this.show_status.TabIndex = 19;
            this.show_status.Text = "label8";
            // 
            // show_username
            // 
            this.show_username.AutoSize = true;
            this.show_username.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_username.Location = new System.Drawing.Point(229, 40);
            this.show_username.Name = "show_username";
            this.show_username.Size = new System.Drawing.Size(78, 25);
            this.show_username.TabIndex = 18;
            this.show_username.Text = "label2";
            // 
            // waiterGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "waiterGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "waiterGUI";
            this.tabControl1.ResumeLayout(false);
            this.dashboardtab.ResumeLayout(false);
            this.dashboardtab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage dashboardtab;
        private System.Windows.Forms.Button btn_pd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label show_role;
        private System.Windows.Forms.Label show_salary;
        private System.Windows.Forms.Label show_contact;
        private System.Windows.Forms.Label show_email;
        private System.Windows.Forms.Label show_status;
        private System.Windows.Forms.Label show_username;
    }
}