
namespace Restaurant_Ordering_System.GUI
{
    partial class customerGUI
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
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_name_update = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.txt_name_create = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cat_view = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_contact_create = new System.Windows.Forms.TextBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
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
            this.cat_manager.Size = new System.Drawing.Size(717, 404);
            this.cat_manager.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_search);
            this.tabPage1.Controls.Add(this.txt_search);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_contact_create);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btn_update);
            this.tabPage1.Controls.Add(this.txt_name_update);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btn_create);
            this.tabPage1.Controls.Add(this.txt_name_create);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(709, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manage";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "NAME";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(12, 322);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 23;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_name_update
            // 
            this.txt_name_update.Location = new System.Drawing.Point(94, 275);
            this.txt_name_update.Name = "txt_name_update";
            this.txt_name_update.Size = new System.Drawing.Size(240, 20);
            this.txt_name_update.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "MODIFY";
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(12, 138);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 20;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // txt_name_create
            // 
            this.txt_name_create.Location = new System.Drawing.Point(95, 48);
            this.txt_name_create.Name = "txt_name_create";
            this.txt_name_create.Size = new System.Drawing.Size(240, 20);
            this.txt_name_create.TabIndex = 19;
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
            this.cat_view.Size = new System.Drawing.Size(709, 378);
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
            this.dataGridView1.Size = new System.Drawing.Size(703, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "CONTACT";
            // 
            // txt_contact_create
            // 
            this.txt_contact_create.Location = new System.Drawing.Point(95, 91);
            this.txt_contact_create.Name = "txt_contact_create";
            this.txt_contact_create.Size = new System.Drawing.Size(240, 20);
            this.txt_contact_create.TabIndex = 36;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(12, 233);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(240, 20);
            this.txt_search.TabIndex = 38;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(258, 231);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 39;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // customerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 404);
            this.Controls.Add(this.cat_manager);
            this.Name = "customerGUI";
            this.Text = "customerGUI";
            this.Load += new System.EventHandler(this.customerGUI_Load);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_name_update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.TextBox txt_name_create;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage cat_view;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_contact_create;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
    }
}