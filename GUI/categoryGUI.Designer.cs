
namespace Restaurant_Ordering_System.GUI
{
    partial class categoryGUI
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cat_updatedesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cat_createdesc = new System.Windows.Forms.TextBox();
            this.txt_catlist_del = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_catlist_update = new System.Windows.Forms.ComboBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_cat_update = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.txt_cat_create = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cat_view = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.cat_manager.Size = new System.Drawing.Size(697, 548);
            this.cat_manager.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txt_cat_updatedesc);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_cat_createdesc);
            this.tabPage1.Controls.Add(this.txt_catlist_del);
            this.tabPage1.Controls.Add(this.btn_delete);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_catlist_update);
            this.tabPage1.Controls.Add(this.btn_update);
            this.tabPage1.Controls.Add(this.txt_cat_update);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btn_create);
            this.tabPage1.Controls.Add(this.txt_cat_create);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(689, 522);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manage";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "SELECT";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "NAME";
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
            // txt_cat_updatedesc
            // 
            this.txt_cat_updatedesc.Location = new System.Drawing.Point(94, 301);
            this.txt_cat_updatedesc.Multiline = true;
            this.txt_cat_updatedesc.Name = "txt_cat_updatedesc";
            this.txt_cat_updatedesc.Size = new System.Drawing.Size(240, 112);
            this.txt_cat_updatedesc.TabIndex = 31;
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
            // txt_cat_createdesc
            // 
            this.txt_cat_createdesc.Location = new System.Drawing.Point(95, 74);
            this.txt_cat_createdesc.Multiline = true;
            this.txt_cat_createdesc.Name = "txt_cat_createdesc";
            this.txt_cat_createdesc.Size = new System.Drawing.Size(240, 112);
            this.txt_cat_createdesc.TabIndex = 28;
            // 
            // txt_catlist_del
            // 
            this.txt_catlist_del.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_catlist_del.FormattingEnabled = true;
            this.txt_catlist_del.Location = new System.Drawing.Point(55, 456);
            this.txt_catlist_del.Name = "txt_catlist_del";
            this.txt_catlist_del.Size = new System.Drawing.Size(240, 21);
            this.txt_catlist_del.TabIndex = 27;
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
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Delete Category";
            // 
            // txt_catlist_update
            // 
            this.txt_catlist_update.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_catlist_update.FormattingEnabled = true;
            this.txt_catlist_update.Location = new System.Drawing.Point(94, 233);
            this.txt_catlist_update.Name = "txt_catlist_update";
            this.txt_catlist_update.Size = new System.Drawing.Size(240, 21);
            this.txt_catlist_update.TabIndex = 24;
            this.txt_catlist_update.SelectedIndexChanged += new System.EventHandler(this.txt_catlist_update_SelectedIndexChanged);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(341, 390);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 23;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_cat_update
            // 
            this.txt_cat_update.Location = new System.Drawing.Point(94, 275);
            this.txt_cat_update.Name = "txt_cat_update";
            this.txt_cat_update.Size = new System.Drawing.Size(240, 20);
            this.txt_cat_update.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Modify Category";
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(342, 163);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 20;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // txt_cat_create
            // 
            this.txt_cat_create.Location = new System.Drawing.Point(95, 48);
            this.txt_cat_create.Name = "txt_cat_create";
            this.txt_cat_create.Size = new System.Drawing.Size(240, 20);
            this.txt_cat_create.TabIndex = 19;
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
            this.cat_view.Size = new System.Drawing.Size(689, 522);
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
            this.dataGridView1.Size = new System.Drawing.Size(683, 516);
            this.dataGridView1.TabIndex = 0;
            // 
            // categoryGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 548);
            this.Controls.Add(this.cat_manager);
            this.Name = "categoryGUI";
            this.Text = "Category Manager";
            this.Load += new System.EventHandler(this.categoryGUI_Load);
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
        private System.Windows.Forms.TabPage cat_view;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cat_updatedesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cat_createdesc;
        private System.Windows.Forms.ComboBox txt_catlist_del;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txt_catlist_update;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_cat_update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.TextBox txt_cat_create;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
    }
}