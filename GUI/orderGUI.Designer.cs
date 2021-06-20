
namespace Restaurant_Ordering_System.GUI
{
    partial class orderGUI
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
            this.menu_view = new System.Windows.Forms.TabPage();
            this.btn_addtocart = new System.Windows.Forms.Button();
            this.item_quantity = new System.Windows.Forms.NumericUpDown();
            this.menuGridView = new System.Windows.Forms.DataGridView();
            this.cat_manager = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cartGridView = new System.Windows.Forms.DataGridView();
            this.orders_view = new System.Windows.Forms.TabPage();
            this.customer_tab = new System.Windows.Forms.TabPage();
            this.ordersGridView = new System.Windows.Forms.DataGridView();
            this.customersGridView = new System.Windows.Forms.DataGridView();
            this.menu_view.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).BeginInit();
            this.cat_manager.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).BeginInit();
            this.orders_view.SuspendLayout();
            this.customer_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_view
            // 
            this.menu_view.Controls.Add(this.btn_addtocart);
            this.menu_view.Controls.Add(this.item_quantity);
            this.menu_view.Controls.Add(this.menuGridView);
            this.menu_view.Location = new System.Drawing.Point(4, 22);
            this.menu_view.Name = "menu_view";
            this.menu_view.Padding = new System.Windows.Forms.Padding(3);
            this.menu_view.Size = new System.Drawing.Size(792, 424);
            this.menu_view.TabIndex = 1;
            this.menu_view.Text = "Menu";
            this.menu_view.UseVisualStyleBackColor = true;
            // 
            // btn_addtocart
            // 
            this.btn_addtocart.Location = new System.Drawing.Point(470, 370);
            this.btn_addtocart.Name = "btn_addtocart";
            this.btn_addtocart.Size = new System.Drawing.Size(75, 23);
            this.btn_addtocart.TabIndex = 2;
            this.btn_addtocart.Text = "Add to Cart";
            this.btn_addtocart.UseVisualStyleBackColor = true;
            // 
            // item_quantity
            // 
            this.item_quantity.Location = new System.Drawing.Point(344, 373);
            this.item_quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.item_quantity.Name = "item_quantity";
            this.item_quantity.Size = new System.Drawing.Size(120, 20);
            this.item_quantity.TabIndex = 1;
            this.item_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // menuGridView
            // 
            this.menuGridView.AllowUserToAddRows = false;
            this.menuGridView.AllowUserToDeleteRows = false;
            this.menuGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.menuGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuGridView.Location = new System.Drawing.Point(6, 3);
            this.menuGridView.Name = "menuGridView";
            this.menuGridView.ReadOnly = true;
            this.menuGridView.Size = new System.Drawing.Size(778, 346);
            this.menuGridView.TabIndex = 0;
            // 
            // cat_manager
            // 
            this.cat_manager.Controls.Add(this.menu_view);
            this.cat_manager.Controls.Add(this.tabPage1);
            this.cat_manager.Controls.Add(this.orders_view);
            this.cat_manager.Controls.Add(this.customer_tab);
            this.cat_manager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cat_manager.Location = new System.Drawing.Point(0, 0);
            this.cat_manager.Name = "cat_manager";
            this.cat_manager.SelectedIndex = 0;
            this.cat_manager.Size = new System.Drawing.Size(800, 450);
            this.cat_manager.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cartGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Cart";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cartGridView
            // 
            this.cartGridView.AllowUserToAddRows = false;
            this.cartGridView.AllowUserToDeleteRows = false;
            this.cartGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartGridView.Location = new System.Drawing.Point(8, 6);
            this.cartGridView.Name = "cartGridView";
            this.cartGridView.ReadOnly = true;
            this.cartGridView.Size = new System.Drawing.Size(778, 346);
            this.cartGridView.TabIndex = 1;
            // 
            // orders_view
            // 
            this.orders_view.Controls.Add(this.ordersGridView);
            this.orders_view.Location = new System.Drawing.Point(4, 22);
            this.orders_view.Name = "orders_view";
            this.orders_view.Padding = new System.Windows.Forms.Padding(3);
            this.orders_view.Size = new System.Drawing.Size(792, 424);
            this.orders_view.TabIndex = 3;
            this.orders_view.Text = "Orders";
            this.orders_view.UseVisualStyleBackColor = true;
            // 
            // customer_tab
            // 
            this.customer_tab.Controls.Add(this.customersGridView);
            this.customer_tab.Location = new System.Drawing.Point(4, 22);
            this.customer_tab.Name = "customer_tab";
            this.customer_tab.Padding = new System.Windows.Forms.Padding(3);
            this.customer_tab.Size = new System.Drawing.Size(792, 424);
            this.customer_tab.TabIndex = 4;
            this.customer_tab.Text = "Select Customer";
            this.customer_tab.UseVisualStyleBackColor = true;
            // 
            // ordersGridView
            // 
            this.ordersGridView.AllowUserToAddRows = false;
            this.ordersGridView.AllowUserToDeleteRows = false;
            this.ordersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGridView.Location = new System.Drawing.Point(8, 6);
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.ReadOnly = true;
            this.ordersGridView.Size = new System.Drawing.Size(778, 346);
            this.ordersGridView.TabIndex = 2;
            // 
            // customersGridView
            // 
            this.customersGridView.AllowUserToAddRows = false;
            this.customersGridView.AllowUserToDeleteRows = false;
            this.customersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersGridView.Location = new System.Drawing.Point(3, 6);
            this.customersGridView.Name = "customersGridView";
            this.customersGridView.ReadOnly = true;
            this.customersGridView.Size = new System.Drawing.Size(778, 346);
            this.customersGridView.TabIndex = 2;
            // 
            // orderGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cat_manager);
            this.Name = "orderGUI";
            this.Text = "orderGUI";
            this.Load += new System.EventHandler(this.orderGUI_Load);
            this.menu_view.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.item_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).EndInit();
            this.cat_manager.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).EndInit();
            this.orders_view.ResumeLayout(false);
            this.customer_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage menu_view;
        private System.Windows.Forms.DataGridView menuGridView;
        private System.Windows.Forms.TabControl cat_manager;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView cartGridView;
        private System.Windows.Forms.NumericUpDown item_quantity;
        private System.Windows.Forms.Button btn_addtocart;
        private System.Windows.Forms.TabPage orders_view;
        private System.Windows.Forms.TabPage customer_tab;
        private System.Windows.Forms.DataGridView ordersGridView;
        private System.Windows.Forms.DataGridView customersGridView;
    }
}