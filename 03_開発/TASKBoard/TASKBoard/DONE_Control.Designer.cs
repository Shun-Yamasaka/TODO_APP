namespace TASKBoard
{
    partial class DONE_Control
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
            this.TODO_Page = new System.Windows.Forms.Button();
            this.Parking_Page = new System.Windows.Forms.Button();
            this.Menu_Page = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "DONE";
            // 
            // TODO_Page
            // 
            this.TODO_Page.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TODO_Page.Location = new System.Drawing.Point(755, 26);
            this.TODO_Page.Name = "TODO_Page";
            this.TODO_Page.Size = new System.Drawing.Size(49, 65);
            this.TODO_Page.TabIndex = 6;
            this.TODO_Page.Text = "＜";
            this.TODO_Page.UseVisualStyleBackColor = true;
            this.TODO_Page.Click += new System.EventHandler(this.TODO_Page_Click);
            // 
            // Parking_Page
            // 
            this.Parking_Page.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Parking_Page.Location = new System.Drawing.Point(991, 26);
            this.Parking_Page.Name = "Parking_Page";
            this.Parking_Page.Size = new System.Drawing.Size(49, 65);
            this.Parking_Page.TabIndex = 7;
            this.Parking_Page.Text = "＞";
            this.Parking_Page.UseVisualStyleBackColor = true;
            this.Parking_Page.Click += new System.EventHandler(this.Parking_Page_Click);
            // 
            // Menu_Page
            // 
            this.Menu_Page.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Menu_Page.Location = new System.Drawing.Point(810, 26);
            this.Menu_Page.Name = "Menu_Page";
            this.Menu_Page.Size = new System.Drawing.Size(175, 65);
            this.Menu_Page.TabIndex = 8;
            this.Menu_Page.Text = "Menu";
            this.Menu_Page.UseVisualStyleBackColor = true;
            this.Menu_Page.Click += new System.EventHandler(this.Menu_Page_Click);
            // 
            // DONE_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Menu_Page);
            this.Controls.Add(this.Parking_Page);
            this.Controls.Add(this.TODO_Page);
            this.Controls.Add(this.label1);
            this.Name = "DONE_Control";
            this.Size = new System.Drawing.Size(1051, 796);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TODO_Page;
        private System.Windows.Forms.Button Parking_Page;
        private System.Windows.Forms.Button Menu_Page;
    }
}
