
namespace Restaurant_Ordering_System.GUI
{
    partial class paymentGUI
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
            this.paymentGridView = new System.Windows.Forms.DataGridView();
            this.btn_pay = new System.Windows.Forms.Button();
            this.btn_invoice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paymentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentGridView
            // 
            this.paymentGridView.AllowUserToAddRows = false;
            this.paymentGridView.AllowUserToDeleteRows = false;
            this.paymentGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paymentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentGridView.Location = new System.Drawing.Point(6, 5);
            this.paymentGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paymentGridView.Name = "paymentGridView";
            this.paymentGridView.ReadOnly = true;
            this.paymentGridView.Size = new System.Drawing.Size(889, 462);
            this.paymentGridView.TabIndex = 0;
            // 
            // btn_pay
            // 
            this.btn_pay.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pay.Location = new System.Drawing.Point(783, 477);
            this.btn_pay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(112, 48);
            this.btn_pay.TabIndex = 1;
            this.btn_pay.Text = "Pay";
            this.btn_pay.UseVisualStyleBackColor = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // btn_invoice
            // 
            this.btn_invoice.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invoice.Location = new System.Drawing.Point(613, 477);
            this.btn_invoice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_invoice.Name = "btn_invoice";
            this.btn_invoice.Size = new System.Drawing.Size(162, 48);
            this.btn_invoice.TabIndex = 2;
            this.btn_invoice.Text = "Generate Invoice";
            this.btn_invoice.UseVisualStyleBackColor = true;
            this.btn_invoice.Click += new System.EventHandler(this.btn_invoice_Click);
            // 
            // paymentGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 544);
            this.Controls.Add(this.btn_invoice);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.paymentGridView);
            this.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "paymentGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "paymentGUI";
            this.Load += new System.EventHandler(this.paymentGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView paymentGridView;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.Button btn_invoice;
    }
}