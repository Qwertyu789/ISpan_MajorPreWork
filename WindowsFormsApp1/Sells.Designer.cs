
namespace WindowsFormsApp1
{
    partial class Sells
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgProductList = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.cbProductRegion = new System.Windows.Forms.ComboBox();
            this.cbProductType = new System.Windows.Forms.ComboBox();
            this.btnDelProductDetail = new System.Windows.Forms.Button();
            this.btnAddProductDetail = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.cbProductShipper = new System.Windows.Forms.ComboBox();
            this.dgProductDetail = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.lbSeller = new System.Windows.Forms.Label();
            this.tbProduectAdFee = new System.Windows.Forms.TextBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbProductDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgProductList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel2.Controls.Add(this.button7);
            this.splitContainer1.Panel2.Controls.Add(this.cbProductRegion);
            this.splitContainer1.Panel2.Controls.Add(this.cbProductType);
            this.splitContainer1.Panel2.Controls.Add(this.btnDelProductDetail);
            this.splitContainer1.Panel2.Controls.Add(this.btnAddProductDetail);
            this.splitContainer1.Panel2.Controls.Add(this.button5);
            this.splitContainer1.Panel2.Controls.Add(this.button4);
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.cbProductShipper);
            this.splitContainer1.Panel2.Controls.Add(this.dgProductDetail);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.lbSeller);
            this.splitContainer1.Panel2.Controls.Add(this.tbProduectAdFee);
            this.splitContainer1.Panel2.Controls.Add(this.tbProductName);
            this.splitContainer1.Panel2.Controls.Add(this.tbProductDescription);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.lbNum);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.lbTitle);
            this.splitContainer1.Size = new System.Drawing.Size(1083, 752);
            this.splitContainer1.SplitterDistance = 322;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgProductList
            // 
            this.dgProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProductList.Location = new System.Drawing.Point(0, 0);
            this.dgProductList.Name = "dgProductList";
            this.dgProductList.RowTemplate.Height = 24;
            this.dgProductList.Size = new System.Drawing.Size(322, 752);
            this.dgProductList.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(271, 294);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(67, 34);
            this.button7.TabIndex = 31;
            this.button7.Text = "刪除規格";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // cbProductRegion
            // 
            this.cbProductRegion.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbProductRegion.FormattingEnabled = true;
            this.cbProductRegion.Location = new System.Drawing.Point(125, 163);
            this.cbProductRegion.Name = "cbProductRegion";
            this.cbProductRegion.Size = new System.Drawing.Size(157, 29);
            this.cbProductRegion.TabIndex = 19;
            // 
            // cbProductType
            // 
            this.cbProductType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbProductType.FormattingEnabled = true;
            this.cbProductType.Location = new System.Drawing.Point(125, 124);
            this.cbProductType.Name = "cbProductType";
            this.cbProductType.Size = new System.Drawing.Size(157, 29);
            this.cbProductType.TabIndex = 29;
            // 
            // btnDelProductDetail
            // 
            this.btnDelProductDetail.Location = new System.Drawing.Point(198, 293);
            this.btnDelProductDetail.Name = "btnDelProductDetail";
            this.btnDelProductDetail.Size = new System.Drawing.Size(67, 34);
            this.btnDelProductDetail.TabIndex = 28;
            this.btnDelProductDetail.Text = "規格更新";
            this.btnDelProductDetail.UseVisualStyleBackColor = true;
            // 
            // btnAddProductDetail
            // 
            this.btnAddProductDetail.Location = new System.Drawing.Point(125, 293);
            this.btnAddProductDetail.Name = "btnAddProductDetail";
            this.btnAddProductDetail.Size = new System.Drawing.Size(67, 34);
            this.btnAddProductDetail.TabIndex = 27;
            this.btnAddProductDetail.Text = "規格新增";
            this.btnAddProductDetail.UseVisualStyleBackColor = true;
            this.btnAddProductDetail.Click += new System.EventHandler(this.btnAddProductDetail_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(680, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 34);
            this.button5.TabIndex = 26;
            this.button5.Text = "刪除";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(607, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 34);
            this.button4.TabIndex = 25;
            this.button4.Text = "修改";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(534, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 34);
            this.button3.TabIndex = 24;
            this.button3.Text = "新增";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(678, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 34);
            this.button2.TabIndex = 23;
            this.button2.Text = "刪除照片";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(297, 111);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(457, 144);
            this.flowLayoutPanel1.TabIndex = 22;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(605, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // cbProductShipper
            // 
            this.cbProductShipper.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbProductShipper.FormattingEnabled = true;
            this.cbProductShipper.Location = new System.Drawing.Point(125, 207);
            this.cbProductShipper.Name = "cbProductShipper";
            this.cbProductShipper.Size = new System.Drawing.Size(157, 29);
            this.cbProductShipper.TabIndex = 18;
            // 
            // dgProductDetail
            // 
            this.dgProductDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductDetail.Location = new System.Drawing.Point(8, 333);
            this.dgProductDetail.Name = "dgProductDetail";
            this.dgProductDetail.RowTemplate.Height = 24;
            this.dgProductDetail.Size = new System.Drawing.Size(737, 131);
            this.dgProductDetail.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(3, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 26);
            this.label9.TabIndex = 16;
            this.label9.Text = "產品規格：";
            // 
            // lbSeller
            // 
            this.lbSeller.AutoSize = true;
            this.lbSeller.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbSeller.Location = new System.Drawing.Point(415, 34);
            this.lbSeller.Name = "lbSeller";
            this.lbSeller.Size = new System.Drawing.Size(30, 26);
            this.lbSeller.TabIndex = 15;
            this.lbSeller.Text = "__";
            this.lbSeller.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbProduectAdFee
            // 
            this.tbProduectAdFee.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbProduectAdFee.Location = new System.Drawing.Point(444, 76);
            this.tbProduectAdFee.Name = "tbProduectAdFee";
            this.tbProduectAdFee.Size = new System.Drawing.Size(157, 29);
            this.tbProduectAdFee.TabIndex = 14;
            // 
            // tbProductName
            // 
            this.tbProductName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbProductName.Location = new System.Drawing.Point(125, 78);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(157, 29);
            this.tbProductName.TabIndex = 10;
            // 
            // tbProductDescription
            // 
            this.tbProductDescription.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbProductDescription.Location = new System.Drawing.Point(7, 531);
            this.tbProductDescription.Multiline = true;
            this.tbProductDescription.Name = "tbProductDescription";
            this.tbProductDescription.Size = new System.Drawing.Size(738, 209);
            this.tbProductDescription.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(2, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 26);
            this.label7.TabIndex = 8;
            this.label7.Text = "出貨方式：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(3, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "產品描述：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(334, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "廣宣費用：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(23, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "出貨自：";
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbNum.Location = new System.Drawing.Point(125, 34);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(30, 26);
            this.lbNum.TabIndex = 4;
            this.lbNum.Text = "__";
            this.lbNum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(334, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "賣家：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(44, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "類別：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(44, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "名稱：";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbTitle.Location = new System.Drawing.Point(44, 34);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(75, 26);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "編號：";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Sells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 752);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Sells";
            this.Text = "Sells";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgProductList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgProductDetail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbSeller;
        private System.Windows.Forms.TextBox tbProductDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbProductRegion;
        private System.Windows.Forms.ComboBox cbProductShipper;
        private System.Windows.Forms.TextBox tbProduectAdFee;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDelProductDetail;
        private System.Windows.Forms.Button btnAddProductDetail;
        private System.Windows.Forms.ComboBox cbProductType;
        private System.Windows.Forms.Button button7;
    }
}