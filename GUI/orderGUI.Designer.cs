
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
            this.cart_view = new System.Windows.Forms.TabPage();
            this.btn_place_order = new System.Windows.Forms.Button();
            this.citem_qty = new System.Windows.Forms.NumericUpDown();
            this.btn_update_citem = new System.Windows.Forms.Button();
            this.btn_remove_citem = new System.Windows.Forms.Button();
            this.cartGridView = new System.Windows.Forms.DataGridView();
            this.orders_view = new System.Windows.Forms.TabPage();
            this.btn_serve_order = new System.Windows.Forms.Button();
            this.btn_cancel_order = new System.Windows.Forms.Button();
            this.ordersGridView = new System.Windows.Forms.DataGridView();
            this.customer_tab = new System.Windows.Forms.TabPage();
            this.btn_select_customer = new System.Windows.Forms.Button();
            this.customersGridView = new System.Windows.Forms.DataGridView();
            this.menu_view.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).BeginInit();
            this.cat_manager.SuspendLayout();
            this.cart_view.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citem_qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).BeginInit();
            this.orders_view.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).BeginInit();
            this.customer_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_view
            // 
            this.menu_view.Controls.Add(this.btn_addtocart);
            this.menu_view.Controls.Add(this.item_quantity);
            this.menu_view.Controls.Add(this.menuGridView);
            this.menu_view.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_addtocart.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addtocart.Location = new System.Drawing.Point(611, 355);
            this.btn_addtocart.Name = "btn_addtocart";
            this.btn_addtocart.Size = new System.Drawing.Size(173, 33);
            this.btn_addtocart.TabIndex = 2;
            this.btn_addtocart.Text = "Add to Cart";
            this.btn_addtocart.UseVisualStyleBackColor = true;
            this.btn_addtocart.Click += new System.EventHandler(this.btn_addtocart_Click);
            // 
            // item_quantity
            // 
            this.item_quantity.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_quantity.Location = new System.Drawing.Point(485, 358);
            this.item_quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.item_quantity.Name = "item_quantity";
            this.item_quantity.ReadOnly = true;
            this.item_quantity.Size = new System.Drawing.Size(120, 30);
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
            this.menuGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.cat_manager.Controls.Add(this.cart_view);
            this.cat_manager.Controls.Add(this.orders_view);
            this.cat_manager.Controls.Add(this.customer_tab);
            this.cat_manager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cat_manager.Location = new System.Drawing.Point(0, 0);
            this.cat_manager.Name = "cat_manager";
            this.cat_manager.SelectedIndex = 0;
            this.cat_manager.Size = new System.Drawing.Size(800, 450);
            this.cat_manager.TabIndex = 2;
            // 
            // cart_view
            // 
            this.cart_view.Controls.Add(this.btn_place_order);
            this.cart_view.Controls.Add(this.citem_qty);
            this.cart_view.Controls.Add(this.btn_update_citem);
            this.cart_view.Controls.Add(this.btn_remove_citem);
            this.cart_view.Controls.Add(this.cartGridView);
            this.cart_view.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cart_view.Location = new System.Drawing.Point(4, 22);
            this.cart_view.Name = "cart_view";
            this.cart_view.Padding = new System.Windows.Forms.Padding(3);
            this.cart_view.Size = new System.Drawing.Size(792, 424);
            this.cart_view.TabIndex = 2;
            this.cart_view.Text = "Cart";
            this.cart_view.UseVisualStyleBackColor = true;
            // 
            // btn_place_order
            // 
            this.btn_place_order.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_place_order.Location = new System.Drawing.Point(706, 356);
            this.btn_place_order.Name = "btn_place_order";
            this.btn_place_order.Size = new System.Drawing.Size(80, 33);
            this.btn_place_order.TabIndex = 5;
            this.btn_place_order.Text = "Place Order";
            this.btn_place_order.UseVisualStyleBackColor = true;
            this.btn_place_order.Click += new System.EventHandler(this.btn_place_order_Click);
            // 
            // citem_qty
            // 
            this.citem_qty.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citem_qty.Location = new System.Drawing.Point(9, 360);
            this.citem_qty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.citem_qty.Name = "citem_qty";
            this.citem_qty.ReadOnly = true;
            this.citem_qty.Size = new System.Drawing.Size(120, 26);
            this.citem_qty.TabIndex = 4;
            this.citem_qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_update_citem
            // 
            this.btn_update_citem.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_citem.Location = new System.Drawing.Point(135, 356);
            this.btn_update_citem.Name = "btn_update_citem";
            this.btn_update_citem.Size = new System.Drawing.Size(75, 35);
            this.btn_update_citem.TabIndex = 3;
            this.btn_update_citem.Text = "Update";
            this.btn_update_citem.UseVisualStyleBackColor = true;
            this.btn_update_citem.Click += new System.EventHandler(this.btn_update_citem_Click);
            // 
            // btn_remove_citem
            // 
            this.btn_remove_citem.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove_citem.Location = new System.Drawing.Point(216, 356);
            this.btn_remove_citem.Name = "btn_remove_citem";
            this.btn_remove_citem.Size = new System.Drawing.Size(75, 35);
            this.btn_remove_citem.TabIndex = 2;
            this.btn_remove_citem.Text = "Remove";
            this.btn_remove_citem.UseVisualStyleBackColor = true;
            this.btn_remove_citem.Click += new System.EventHandler(this.btn_remove_citem_Click);
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
            this.orders_view.Controls.Add(this.btn_serve_order);
            this.orders_view.Controls.Add(this.btn_cancel_order);
            this.orders_view.Controls.Add(this.ordersGridView);
            this.orders_view.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_view.Location = new System.Drawing.Point(4, 22);
            this.orders_view.Name = "orders_view";
            this.orders_view.Padding = new System.Windows.Forms.Padding(3);
            this.orders_view.Size = new System.Drawing.Size(792, 424);
            this.orders_view.TabIndex = 3;
            this.orders_view.Text = "Orders";
            this.orders_view.UseVisualStyleBackColor = true;
            // 
            // btn_serve_order
            // 
            this.btn_serve_order.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_serve_order.Location = new System.Drawing.Point(554, 358);
            this.btn_serve_order.Name = "btn_serve_order";
            this.btn_serve_order.Size = new System.Drawing.Size(112, 30);
            this.btn_serve_order.TabIndex = 4;
            this.btn_serve_order.Text = "Serve Order";
            this.btn_serve_order.UseVisualStyleBackColor = true;
            this.btn_serve_order.Click += new System.EventHandler(this.btn_serve_order_Click);
            // 
            // btn_cancel_order
            // 
            this.btn_cancel_order.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel_order.Location = new System.Drawing.Point(672, 358);
            this.btn_cancel_order.Name = "btn_cancel_order";
            this.btn_cancel_order.Size = new System.Drawing.Size(112, 30);
            this.btn_cancel_order.TabIndex = 3;
            this.btn_cancel_order.Text = "Cancel Order";
            this.btn_cancel_order.UseVisualStyleBackColor = true;
            this.btn_cancel_order.Click += new System.EventHandler(this.btn_cancel_order_Click);
            // 
            // ordersGridView
            // 
            this.ordersGridView.AllowUserToAddRows = false;
            this.ordersGridView.AllowUserToDeleteRows = false;
            this.ordersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGridView.Location = new System.Drawing.Point(6, 6);
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.ReadOnly = true;
            this.ordersGridView.Size = new System.Drawing.Size(780, 346);
            this.ordersGridView.TabIndex = 2;
            // 
            // customer_tab
            // 
            this.customer_tab.Controls.Add(this.btn_select_customer);
            this.customer_tab.Controls.Add(this.customersGridView);
            this.customer_tab.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_tab.Location = new System.Drawing.Point(4, 22);
            this.customer_tab.Name = "customer_tab";
            this.customer_tab.Padding = new System.Windows.Forms.Padding(3);
            this.customer_tab.Size = new System.Drawing.Size(792, 424);
            this.customer_tab.TabIndex = 4;
            this.customer_tab.Text = "Select Customer";
            this.customer_tab.UseVisualStyleBackColor = true;
            // 
            // btn_select_customer
            // 
            this.btn_select_customer.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select_customer.Location = new System.Drawing.Point(699, 358);
            this.btn_select_customer.Name = "btn_select_customer";
            this.btn_select_customer.Size = new System.Drawing.Size(82, 32);
            this.btn_select_customer.TabIndex = 3;
            this.btn_select_customer.Text = "Select";
            this.btn_select_customer.UseVisualStyleBackColor = true;
            this.btn_select_customer.Click += new System.EventHandler(this.btn_select_customer_Click);
            // 
            // customersGridView
            // 
            this.customersGridView.AllowUserToAddRows = false;
            this.customersGridView.AllowUserToDeleteRows = false;
            this.customersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "orderGUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.orderGUI_FormClosed);
            this.Load += new System.EventHandler(this.orderGUI_Load);
            this.menu_view.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.item_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).EndInit();
            this.cat_manager.ResumeLayout(false);
            this.cart_view.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.citem_qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).EndInit();
            this.orders_view.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).EndInit();
            this.customer_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage menu_view;
        private System.Windows.Forms.DataGridView menuGridView;
        private System.Windows.Forms.TabControl cat_manager;
        private System.Windows.Forms.TabPage cart_view;
        private System.Windows.Forms.DataGridView cartGridView;
        private System.Windows.Forms.NumericUpDown item_quantity;
        private System.Windows.Forms.Button btn_addtocart;
        private System.Windows.Forms.TabPage orders_view;
        private System.Windows.Forms.TabPage customer_tab;
        private System.Windows.Forms.DataGridView ordersGridView;
        private System.Windows.Forms.DataGridView customersGridView;
        private System.Windows.Forms.Button btn_select_customer;
        private System.Windows.Forms.Button btn_update_citem;
        private System.Windows.Forms.Button btn_remove_citem;
        private System.Windows.Forms.NumericUpDown citem_qty;
        private System.Windows.Forms.Button btn_place_order;
        private System.Windows.Forms.Button btn_cancel_order;
        private System.Windows.Forms.Button btn_serve_order;
    }
}