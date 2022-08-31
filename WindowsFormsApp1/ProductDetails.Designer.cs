
namespace WindowsFormsApp1
{
    partial class ProductDetails
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
            this.lblStyle = new System.Windows.Forms.Label();
            this.tbStyle = new System.Windows.Forms.TextBox();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitprice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStyle.Location = new System.Drawing.Point(25, 40);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(58, 21);
            this.lblStyle.TabIndex = 0;
            this.lblStyle.Text = "規格：";
            // 
            // tbStyle
            // 
            this.tbStyle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbStyle.Location = new System.Drawing.Point(89, 37);
            this.tbStyle.Name = "tbStyle";
            this.tbStyle.Size = new System.Drawing.Size(147, 29);
            this.tbStyle.TabIndex = 1;
            // 
            // tbQty
            // 
            this.tbQty.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbQty.Location = new System.Drawing.Point(89, 110);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(147, 29);
            this.tbQty.TabIndex = 3;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblQty.Location = new System.Drawing.Point(25, 113);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(58, 21);
            this.lblQty.TabIndex = 2;
            this.lblQty.Text = "庫存：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(303, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tbUnitPrice
            // 
            this.tbUnitPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbUnitPrice.Location = new System.Drawing.Point(89, 178);
            this.tbUnitPrice.Name = "tbUnitPrice";
            this.tbUnitPrice.Size = new System.Drawing.Size(147, 29);
            this.tbUnitPrice.TabIndex = 8;
            // 
            // lblUnitprice
            // 
            this.lblUnitprice.AutoSize = true;
            this.lblUnitprice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUnitprice.Location = new System.Drawing.Point(25, 181);
            this.lblUnitprice.Name = "lblUnitprice";
            this.lblUnitprice.Size = new System.Drawing.Size(58, 21);
            this.lblUnitprice.TabIndex = 7;
            this.lblUnitprice.Text = "單價：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "確認";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 50);
            this.button2.TabIndex = 10;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 296);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbUnitPrice);
            this.Controls.Add(this.lblUnitprice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbQty);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.tbStyle);
            this.Controls.Add(this.lblStyle);
            this.Name = "ProductDetails";
            this.Text = "ProductDetails";
            this.Load += new System.EventHandler(this.ProductDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.TextBox tbStyle;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbUnitPrice;
        private System.Windows.Forms.Label lblUnitprice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}