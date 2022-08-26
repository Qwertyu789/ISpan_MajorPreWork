
namespace MajorHW
{
    partial class Login
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnlogin = new System.Windows.Forms.Button();
            this.lbAC = new System.Windows.Forms.Label();
            this.tbAC = new System.Windows.Forms.TextBox();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.lbPW = new System.Windows.Forms.Label();
            this.btnCreateAC = new System.Windows.Forms.Button();
            this.btnFindPW = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnlogin.Location = new System.Drawing.Point(275, 41);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(172, 67);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lbAC
            // 
            this.lbAC.AutoSize = true;
            this.lbAC.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbAC.Location = new System.Drawing.Point(24, 48);
            this.lbAC.Name = "lbAC";
            this.lbAC.Size = new System.Drawing.Size(75, 26);
            this.lbAC.TabIndex = 1;
            this.lbAC.Text = "帳號：";
            // 
            // tbAC
            // 
            this.tbAC.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbAC.Location = new System.Drawing.Point(103, 41);
            this.tbAC.Name = "tbAC";
            this.tbAC.Size = new System.Drawing.Size(166, 35);
            this.tbAC.TabIndex = 2;
            this.tbAC.Text = "aaaa";
            // 
            // tbPW
            // 
            this.tbPW.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbPW.Location = new System.Drawing.Point(103, 107);
            this.tbPW.Name = "tbPW";
            this.tbPW.Size = new System.Drawing.Size(166, 35);
            this.tbPW.TabIndex = 4;
            this.tbPW.Text = "123";
            // 
            // lbPW
            // 
            this.lbPW.AutoSize = true;
            this.lbPW.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbPW.Location = new System.Drawing.Point(24, 114);
            this.lbPW.Name = "lbPW";
            this.lbPW.Size = new System.Drawing.Size(75, 26);
            this.lbPW.TabIndex = 3;
            this.lbPW.Text = "密碼：";
            // 
            // btnCreateAC
            // 
            this.btnCreateAC.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreateAC.Location = new System.Drawing.Point(242, 203);
            this.btnCreateAC.Name = "btnCreateAC";
            this.btnCreateAC.Size = new System.Drawing.Size(205, 33);
            this.btnCreateAC.TabIndex = 5;
            this.btnCreateAC.Text = "創建帳號";
            this.btnCreateAC.UseVisualStyleBackColor = true;
            // 
            // btnFindPW
            // 
            this.btnFindPW.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFindPW.Location = new System.Drawing.Point(29, 203);
            this.btnFindPW.Name = "btnFindPW";
            this.btnFindPW.Size = new System.Drawing.Size(207, 33);
            this.btnFindPW.TabIndex = 6;
            this.btnFindPW.Text = "忘記密碼";
            this.btnFindPW.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(522, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(407, 188);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(275, 114);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(172, 28);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 261);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFindPW);
            this.Controls.Add(this.btnCreateAC);
            this.Controls.Add(this.tbPW);
            this.Controls.Add(this.lbPW);
            this.Controls.Add(this.tbAC);
            this.Controls.Add(this.lbAC);
            this.Controls.Add(this.btnlogin);
            this.Name = "Login";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lbAC;
        private System.Windows.Forms.TextBox tbAC;
        private System.Windows.Forms.TextBox tbPW;
        private System.Windows.Forms.Label lbPW;
        private System.Windows.Forms.Button btnCreateAC;
        private System.Windows.Forms.Button btnFindPW;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancel;
    }
}

