
namespace Restaurant_Ordering_System.GUI
{
    partial class foodItemGUI
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
            this.cat_manager = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_fooddesc_update = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_fooddesc_create = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_foodname_update = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.txt_foodname_create = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cat_view = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_foodprice_create = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_foodcat_create = new System.Windows.Forms.ComboBox();
            this.txt_foodname_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_foodcat_update = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_foodprice_update = new System.Windows.Forms.TextBox();
            this.txt_foodname_del = new System.Windows.Forms.TextBox();
            this.cat_manager.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.cat_view.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cat_manager
            // 
            this.cat_manager.Controls.Add(this.tabPage1);
            this.cat_manager.Controls.Add(this.cat_view);
            this.cat_manager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cat_manager.Location = new System.Drawing.Point(0, 0);
            this.cat_manager.Name = "cat_manager";
            this.cat_manager.SelectedIndex = 0;
            this.cat_manager.Size = new System.Drawing.Size(800, 560);
            this.cat_manager.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_foodname_del);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txt_foodcat_update);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txt_foodprice_update);
            this.tabPage1.Controls.Add(this.btn_search);
            this.tabPage1.Controls.Add(this.txt_foodname_search);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txt_foodcat_create);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txt_foodprice_create);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.labelname);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txt_fooddesc_update);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_fooddesc_create);
            this.tabPage1.Controls.Add(this.btn_delete);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btn_update);
            this.tabPage1.Controls.Add(this.txt_foodname_update);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btn_create);
            this.tabPage1.Controls.Add(this.txt_foodname_create);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 534);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manage";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 459);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "NAMES";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(8, 278);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(38, 13);
            this.labelname.TabIndex = 33;
            this.labelname.Text = "NAME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "DESCRIPTION";
            // 
            // txt_fooddesc_update
            // 
            this.txt_fooddesc_update.Location = new System.Drawing.Point(94, 301);
            this.txt_fooddesc_update.Multiline = true;
            this.txt_fooddesc_update.Name = "txt_fooddesc_update";
            this.txt_fooddesc_update.Size = new System.Drawing.Size(240, 112);
            this.txt_fooddesc_update.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "DESCRIPTION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "NAME";
            // 
            // txt_fooddesc_create
            // 
            this.txt_fooddesc_create.Location = new System.Drawing.Point(95, 74);
            this.txt_fooddesc_create.Multiline = true;
            this.txt_fooddesc_create.Name = "txt_fooddesc_create";
            this.txt_fooddesc_create.Size = new System.Drawing.Size(240, 112);
            this.txt_fooddesc_create.TabIndex = 28;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(301, 454);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 26;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Delete Food Item";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(592, 390);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 23;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_foodname_update
            // 
            this.txt_foodname_update.Location = new System.Drawing.Point(94, 275);
            this.txt_foodname_update.Name = "txt_foodname_update";
            this.txt_foodname_update.Size = new System.Drawing.Size(240, 20);
            this.txt_foodname_update.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Modify Food Item";
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(592, 163);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 20;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // txt_foodname_create
            // 
            this.txt_foodname_create.Location = new System.Drawing.Point(95, 48);
            this.txt_foodname_create.Name = "txt_foodname_create";
            this.txt_foodname_create.Size = new System.Drawing.Size(240, 20);
            this.txt_foodname_create.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "CREATE";
            // 
            // cat_view
            // 
            this.cat_view.Controls.Add(this.dataGridView1);
            this.cat_view.Location = new System.Drawing.Point(4, 22);
            this.cat_view.Name = "cat_view";
            this.cat_view.Padding = new System.Windows.Forms.Padding(3);
            this.cat_view.Size = new System.Drawing.Size(792, 534);
            this.cat_view.TabIndex = 1;
            this.cat_view.Text = "View";
            this.cat_view.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(786, 528);
            this.dataGridView1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(341, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "PRICE";
            // 
            // txt_foodprice_create
            // 
            this.txt_foodprice_create.Location = new System.Drawing.Point(427, 48);
            this.txt_foodprice_create.Name = "txt_foodprice_create";
            this.txt_foodprice_create.Size = new System.Drawing.Size(240, 20);
            this.txt_foodprice_create.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(341, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "CATEGORY";
            // 
            // txt_foodcat_create
            // 
            this.txt_foodcat_create.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_foodcat_create.FormattingEnabled = true;
            this.txt_foodcat_create.Location = new System.Drawing.Point(427, 74);
            this.txt_foodcat_create.Name = "txt_foodcat_create";
            this.txt_foodcat_create.Size = new System.Drawing.Size(240, 21);
            this.txt_foodcat_create.TabIndex = 38;
            // 
            // txt_foodname_search
            // 
            this.txt_foodname_search.Location = new System.Drawing.Point(12, 231);
            this.txt_foodname_search.Name = "txt_foodname_search";
            this.txt_foodname_search.Size = new System.Drawing.Size(240, 20);
            this.txt_foodname_search.TabIndex = 40;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(260, 229);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 41;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(341, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "CATEGORY";
            // 
            // txt_foodcat_update
            // 
            this.txt_foodcat_update.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_foodcat_update.FormattingEnabled = true;
            this.txt_foodcat_update.Location = new System.Drawing.Point(427, 301);
            this.txt_foodcat_update.Name = "txt_foodcat_update";
            this.txt_foodcat_update.Size = new System.Drawing.Size(240, 21);
            this.txt_foodcat_update.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(341, 278);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "PRICE";
            // 
            // txt_foodprice_update
            // 
            this.txt_foodprice_update.Location = new System.Drawing.Point(427, 275);
            this.txt_foodprice_update.Name = "txt_foodprice_update";
            this.txt_foodprice_update.Size = new System.Drawing.Size(240, 20);
            this.txt_foodprice_update.TabIndex = 42;
            // 
            // txt_foodname_del
            // 
            this.txt_foodname_del.Location = new System.Drawing.Point(55, 456);
            this.txt_foodname_del.Name = "txt_foodname_del";
            this.txt_foodname_del.Size = new System.Drawing.Size(240, 20);
            this.txt_foodname_del.TabIndex = 46;
            // 
            // foodItemGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.cat_manager);
            this.Name = "foodItemGUI";
            this.Text = "foodItemGUI";
            this.Load += new System.EventHandler(this.foodItemGUI_Load);
            this.cat_manager.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.cat_view.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl cat_manager;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_fooddesc_update;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_fooddesc_create;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_foodname_update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.TextBox txt_foodname_create;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage cat_view;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_foodprice_create;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox txt_foodcat_create;
        private System.Windows.Forms.TextBox txt_foodname_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txt_foodcat_update;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_foodprice_update;
        private System.Windows.Forms.TextBox txt_foodname_del;
    }
}