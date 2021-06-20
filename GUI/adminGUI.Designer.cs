
namespace Restaurant_Ordering_System.GUI
{
    partial class adminGUI
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
            this.updatetab = new System.Windows.Forms.TabPage();
            this.lb_status = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_block_unblock = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_update_username = new System.Windows.Forms.TextBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.txt_update_contact = new System.Windows.Forms.TextBox();
            this.txt_update_email = new System.Windows.Forms.TextBox();
            this.txt_update_password = new System.Windows.Forms.TextBox();
            this.txt_update_salary = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_update_role = new System.Windows.Forms.ComboBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.profiletab = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.show_role = new System.Windows.Forms.Label();
            this.show_salary = new System.Windows.Forms.Label();
            this.show_contact = new System.Windows.Forms.Label();
            this.show_email = new System.Windows.Forms.Label();
            this.show_status = new System.Windows.Forms.Label();
            this.show_username = new System.Windows.Forms.Label();
            this.viewusertab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabcontrol1 = new System.Windows.Forms.TabControl();
            this.createusertab = new System.Windows.Forms.TabPage();
            this.btn_create = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_role = new System.Windows.Forms.ComboBox();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.updatetab.SuspendLayout();
            this.profiletab.SuspendLayout();
            this.viewusertab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabcontrol1.SuspendLayout();
            this.createusertab.SuspendLayout();
            this.SuspendLayout();
            // 
            // updatetab
            // 
            this.updatetab.Controls.Add(this.lb_status);
            this.updatetab.Controls.Add(this.btn_clear);
            this.updatetab.Controls.Add(this.btn_block_unblock);
            this.updatetab.Controls.Add(this.label12);
            this.updatetab.Controls.Add(this.txt_update_username);
            this.updatetab.Controls.Add(this.txt_search);
            this.updatetab.Controls.Add(this.txt_update_contact);
            this.updatetab.Controls.Add(this.txt_update_email);
            this.updatetab.Controls.Add(this.txt_update_password);
            this.updatetab.Controls.Add(this.txt_update_salary);
            this.updatetab.Controls.Add(this.btn_search);
            this.updatetab.Controls.Add(this.label2);
            this.updatetab.Controls.Add(this.label8);
            this.updatetab.Controls.Add(this.label9);
            this.updatetab.Controls.Add(this.label10);
            this.updatetab.Controls.Add(this.label11);
            this.updatetab.Controls.Add(this.txt_update_role);
            this.updatetab.Controls.Add(this.btn_update);
            this.updatetab.Location = new System.Drawing.Point(4, 22);
            this.updatetab.Name = "updatetab";
            this.updatetab.Padding = new System.Windows.Forms.Padding(3);
            this.updatetab.Size = new System.Drawing.Size(792, 424);
            this.updatetab.TabIndex = 5;
            this.updatetab.Text = "Update User";
            this.updatetab.UseVisualStyleBackColor = true;
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.Location = new System.Drawing.Point(51, 266);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(100, 25);
            this.lb_status.TabIndex = 35;
            this.lb_status.Text = "Status: ";
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(347, 320);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 37);
            this.btn_clear.TabIndex = 34;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_block_unblock
            // 
            this.btn_block_unblock.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_block_unblock.Location = new System.Drawing.Point(162, 320);
            this.btn_block_unblock.Name = "btn_block_unblock";
            this.btn_block_unblock.Size = new System.Drawing.Size(179, 37);
            this.btn_block_unblock.TabIndex = 33;
            this.btn_block_unblock.Text = "Block/Unblock";
            this.btn_block_unblock.UseVisualStyleBackColor = true;
            this.btn_block_unblock.Click += new System.EventHandler(this.btn_block_unblock_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(51, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 25);
            this.label12.TabIndex = 31;
            this.label12.Text = "Username";
            // 
            // txt_update_username
            // 
            this.txt_update_username.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_update_username.Location = new System.Drawing.Point(157, 89);
            this.txt_update_username.Name = "txt_update_username";
            this.txt_update_username.Size = new System.Drawing.Size(220, 30);
            this.txt_update_username.TabIndex = 30;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(56, 19);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(599, 30);
            this.txt_search.TabIndex = 28;
            // 
            // txt_update_contact
            // 
            this.txt_update_contact.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_update_contact.Location = new System.Drawing.Point(538, 89);
            this.txt_update_contact.Name = "txt_update_contact";
            this.txt_update_contact.Size = new System.Drawing.Size(220, 30);
            this.txt_update_contact.TabIndex = 20;
            // 
            // txt_update_email
            // 
            this.txt_update_email.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_update_email.Location = new System.Drawing.Point(157, 150);
            this.txt_update_email.Name = "txt_update_email";
            this.txt_update_email.Size = new System.Drawing.Size(220, 30);
            this.txt_update_email.TabIndex = 19;
            // 
            // txt_update_password
            // 
            this.txt_update_password.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_update_password.Location = new System.Drawing.Point(157, 210);
            this.txt_update_password.Name = "txt_update_password";
            this.txt_update_password.Size = new System.Drawing.Size(220, 30);
            this.txt_update_password.TabIndex = 18;
            // 
            // txt_update_salary
            // 
            this.txt_update_salary.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_update_salary.Location = new System.Drawing.Point(538, 150);
            this.txt_update_salary.Name = "txt_update_salary";
            this.txt_update_salary.Size = new System.Drawing.Size(220, 30);
            this.txt_update_salary.TabIndex = 17;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(661, 17);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(97, 35);
            this.btn_search.TabIndex = 29;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(443, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Contact";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(443, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Salary";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(51, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(443, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "Role";
            // 
            // txt_update_role
            // 
            this.txt_update_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_update_role.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_update_role.FormattingEnabled = true;
            this.txt_update_role.Items.AddRange(new object[] {
            "Manager",
            "Waiter",
            "Chef"});
            this.txt_update_role.Location = new System.Drawing.Point(538, 210);
            this.txt_update_role.Name = "txt_update_role";
            this.txt_update_role.Size = new System.Drawing.Size(220, 33);
            this.txt_update_role.TabIndex = 21;
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(59, 320);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(97, 37);
            this.btn_update.TabIndex = 15;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // profiletab
            // 
            this.profiletab.Controls.Add(this.label16);
            this.profiletab.Controls.Add(this.label17);
            this.profiletab.Controls.Add(this.label18);
            this.profiletab.Controls.Add(this.label13);
            this.profiletab.Controls.Add(this.label14);
            this.profiletab.Controls.Add(this.label15);
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
            this.profiletab.TabIndex = 4;
            this.profiletab.Text = "Profile";
            this.profiletab.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(463, 175);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 25);
            this.label16.TabIndex = 20;
            this.label16.Text = "Salary";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(463, 101);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 25);
            this.label17.TabIndex = 19;
            this.label17.Text = "Email:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(463, 242);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 25);
            this.label18.TabIndex = 18;
            this.label18.Text = "Status";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(112, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 25);
            this.label13.TabIndex = 17;
            this.label13.Text = "Role:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(112, 175);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 25);
            this.label14.TabIndex = 16;
            this.label14.Text = "Contact:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(112, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 25);
            this.label15.TabIndex = 15;
            this.label15.Text = "User Name:";
            // 
            // show_role
            // 
            this.show_role.AutoSize = true;
            this.show_role.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_role.Location = new System.Drawing.Point(240, 242);
            this.show_role.Name = "show_role";
            this.show_role.Size = new System.Drawing.Size(89, 25);
            this.show_role.TabIndex = 5;
            this.show_role.Text = "label12";
            // 
            // show_salary
            // 
            this.show_salary.AutoSize = true;
            this.show_salary.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_salary.Location = new System.Drawing.Point(547, 175);
            this.show_salary.Name = "show_salary";
            this.show_salary.Size = new System.Drawing.Size(89, 25);
            this.show_salary.TabIndex = 4;
            this.show_salary.Text = "label11";
            // 
            // show_contact
            // 
            this.show_contact.AutoSize = true;
            this.show_contact.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_contact.Location = new System.Drawing.Point(240, 175);
            this.show_contact.Name = "show_contact";
            this.show_contact.Size = new System.Drawing.Size(89, 25);
            this.show_contact.TabIndex = 3;
            this.show_contact.Text = "label10";
            // 
            // show_email
            // 
            this.show_email.AutoSize = true;
            this.show_email.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_email.Location = new System.Drawing.Point(547, 101);
            this.show_email.Name = "show_email";
            this.show_email.Size = new System.Drawing.Size(78, 25);
            this.show_email.TabIndex = 2;
            this.show_email.Text = "label9";
            // 
            // show_status
            // 
            this.show_status.AutoSize = true;
            this.show_status.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_status.Location = new System.Drawing.Point(547, 242);
            this.show_status.Name = "show_status";
            this.show_status.Size = new System.Drawing.Size(78, 25);
            this.show_status.TabIndex = 1;
            this.show_status.Text = "label8";
            // 
            // show_username
            // 
            this.show_username.AutoSize = true;
            this.show_username.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_username.Location = new System.Drawing.Point(240, 101);
            this.show_username.Name = "show_username";
            this.show_username.Size = new System.Drawing.Size(78, 25);
            this.show_username.TabIndex = 0;
            this.show_username.Text = "label2";
            // 
            // viewusertab
            // 
            this.viewusertab.Controls.Add(this.dataGridView1);
            this.viewusertab.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewusertab.Location = new System.Drawing.Point(4, 22);
            this.viewusertab.Name = "viewusertab";
            this.viewusertab.Padding = new System.Windows.Forms.Padding(3);
            this.viewusertab.Size = new System.Drawing.Size(792, 424);
            this.viewusertab.TabIndex = 3;
            this.viewusertab.Text = "View Users";
            this.viewusertab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 358);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabcontrol1
            // 
            this.tabcontrol1.Controls.Add(this.createusertab);
            this.tabcontrol1.Controls.Add(this.viewusertab);
            this.tabcontrol1.Controls.Add(this.profiletab);
            this.tabcontrol1.Controls.Add(this.updatetab);
            this.tabcontrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol1.Location = new System.Drawing.Point(0, 0);
            this.tabcontrol1.Name = "tabcontrol1";
            this.tabcontrol1.SelectedIndex = 0;
            this.tabcontrol1.Size = new System.Drawing.Size(800, 450);
            this.tabcontrol1.TabIndex = 0;
            this.tabcontrol1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // createusertab
            // 
            this.createusertab.Controls.Add(this.btn_create);
            this.createusertab.Controls.Add(this.label7);
            this.createusertab.Controls.Add(this.label6);
            this.createusertab.Controls.Add(this.label5);
            this.createusertab.Controls.Add(this.label4);
            this.createusertab.Controls.Add(this.label3);
            this.createusertab.Controls.Add(this.label1);
            this.createusertab.Controls.Add(this.txt_role);
            this.createusertab.Controls.Add(this.txt_contact);
            this.createusertab.Controls.Add(this.txt_email);
            this.createusertab.Controls.Add(this.txt_pass);
            this.createusertab.Controls.Add(this.txt_salary);
            this.createusertab.Controls.Add(this.txt_username);
            this.createusertab.Location = new System.Drawing.Point(4, 22);
            this.createusertab.Name = "createusertab";
            this.createusertab.Padding = new System.Windows.Forms.Padding(3);
            this.createusertab.Size = new System.Drawing.Size(792, 424);
            this.createusertab.TabIndex = 0;
            this.createusertab.Text = "Create User";
            this.createusertab.UseVisualStyleBackColor = true;
            // 
            // btn_create
            // 
            this.btn_create.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.Location = new System.Drawing.Point(651, 247);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(79, 35);
            this.btn_create.TabIndex = 13;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(426, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(426, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(426, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Role";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // txt_role
            // 
            this.txt_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_role.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_role.FormattingEnabled = true;
            this.txt_role.Items.AddRange(new object[] {
            "Manager",
            "Waiter",
            "Chef"});
            this.txt_role.Location = new System.Drawing.Point(510, 189);
            this.txt_role.Name = "txt_role";
            this.txt_role.Size = new System.Drawing.Size(220, 29);
            this.txt_role.TabIndex = 5;
            // 
            // txt_contact
            // 
            this.txt_contact.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact.Location = new System.Drawing.Point(510, 58);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(220, 26);
            this.txt_contact.TabIndex = 4;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(112, 126);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(220, 26);
            this.txt_email.TabIndex = 3;
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(112, 189);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(220, 26);
            this.txt_pass.TabIndex = 2;
            // 
            // txt_salary
            // 
            this.txt_salary.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salary.Location = new System.Drawing.Point(510, 126);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(220, 26);
            this.txt_salary.TabIndex = 1;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(112, 58);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(220, 26);
            this.txt_username.TabIndex = 0;
            // 
            // adminGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabcontrol1);
            this.Name = "adminGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.adminGUI_Load);
            this.updatetab.ResumeLayout(false);
            this.updatetab.PerformLayout();
            this.profiletab.ResumeLayout(false);
            this.profiletab.PerformLayout();
            this.viewusertab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabcontrol1.ResumeLayout(false);
            this.createusertab.ResumeLayout(false);
            this.createusertab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage updatetab;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_block_unblock;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_update_username;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.TextBox txt_update_contact;
        private System.Windows.Forms.TextBox txt_update_email;
        private System.Windows.Forms.TextBox txt_update_password;
        private System.Windows.Forms.TextBox txt_update_salary;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox txt_update_role;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TabPage profiletab;
        private System.Windows.Forms.Label show_role;
        private System.Windows.Forms.Label show_salary;
        private System.Windows.Forms.Label show_contact;
        private System.Windows.Forms.Label show_email;
        private System.Windows.Forms.Label show_status;
        private System.Windows.Forms.Label show_username;
        private System.Windows.Forms.TabPage viewusertab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabcontrol1;
        private System.Windows.Forms.TabPage createusertab;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txt_role;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}