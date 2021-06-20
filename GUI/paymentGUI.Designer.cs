
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
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paymentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentGridView
            // 
            this.paymentGridView.AllowUserToAddRows = false;
            this.paymentGridView.AllowUserToDeleteRows = false;
            this.paymentGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paymentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentGridView.Location = new System.Drawing.Point(12, 12);
            this.paymentGridView.Name = "paymentGridView";
            this.paymentGridView.ReadOnly = true;
            this.paymentGridView.Size = new System.Drawing.Size(776, 383);
            this.paymentGridView.TabIndex = 0;
            // 
            // btn_pay
            // 
            this.btn_pay.Location = new System.Drawing.Point(713, 401);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(75, 23);
            this.btn_pay.TabIndex = 1;
            this.btn_pay.Text = "Pay";
            this.btn_pay.UseVisualStyleBackColor = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(599, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Generate Bill";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // paymentGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.paymentGridView);
            this.Name = "paymentGUI";
            this.Text = "paymentGUI";
            this.Load += new System.EventHandler(this.paymentGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView paymentGridView;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.Button button2;
    }
}