namespace TASKBoard
{
    partial class ParkingLot_Control
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Menu_Page = new System.Windows.Forms.Button();
            this.TODO_Page = new System.Windows.Forms.Button();
            this.DONE_Page = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "ParkingLot";
            // 
            // Menu_Page
            // 
            this.Menu_Page.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Menu_Page.Location = new System.Drawing.Point(810, 26);
            this.Menu_Page.Name = "Menu_Page";
            this.Menu_Page.Size = new System.Drawing.Size(175, 65);
            this.Menu_Page.TabIndex = 14;
            this.Menu_Page.Text = "Menu";
            this.Menu_Page.UseVisualStyleBackColor = true;
            this.Menu_Page.Click += new System.EventHandler(this.Menu_Page_Click);
            // 
            // TODO_Page
            // 
            this.TODO_Page.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TODO_Page.Location = new System.Drawing.Point(991, 26);
            this.TODO_Page.Name = "TODO_Page";
            this.TODO_Page.Size = new System.Drawing.Size(49, 65);
            this.TODO_Page.TabIndex = 13;
            this.TODO_Page.Text = "＞";
            this.TODO_Page.UseVisualStyleBackColor = true;
            this.TODO_Page.Click += new System.EventHandler(this.TODO_Page_Click);
            // 
            // DONE_Page
            // 
            this.DONE_Page.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DONE_Page.Location = new System.Drawing.Point(755, 26);
            this.DONE_Page.Name = "DONE_Page";
            this.DONE_Page.Size = new System.Drawing.Size(49, 65);
            this.DONE_Page.TabIndex = 12;
            this.DONE_Page.Text = "＜";
            this.DONE_Page.UseVisualStyleBackColor = true;
            this.DONE_Page.Click += new System.EventHandler(this.DONE_Page_Click);
            // 
            // ParkingLot_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Menu_Page);
            this.Controls.Add(this.TODO_Page);
            this.Controls.Add(this.DONE_Page);
            this.Controls.Add(this.label1);
            this.Name = "ParkingLot_Control";
            this.Size = new System.Drawing.Size(1051, 796);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Menu_Page;
        private System.Windows.Forms.Button TODO_Page;
        private System.Windows.Forms.Button DONE_Page;
    }
}
