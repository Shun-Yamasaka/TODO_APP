﻿namespace TASKBoard
{
    partial class TODO_Control
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
            this.DOING_Page = new System.Windows.Forms.Button();
            this.Parking_Page = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "TODO";
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
            // DOING_Page
            // 
            this.DOING_Page.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DOING_Page.Location = new System.Drawing.Point(991, 26);
            this.DOING_Page.Name = "DOING_Page";
            this.DOING_Page.Size = new System.Drawing.Size(49, 65);
            this.DOING_Page.TabIndex = 13;
            this.DOING_Page.Text = "＞";
            this.DOING_Page.UseVisualStyleBackColor = true;
            this.DOING_Page.Click += new System.EventHandler(this.DOING_Page_Click);
            // 
            // Parking_Page
            // 
            this.Parking_Page.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Parking_Page.Location = new System.Drawing.Point(755, 26);
            this.Parking_Page.Name = "Parking_Page";
            this.Parking_Page.Size = new System.Drawing.Size(49, 65);
            this.Parking_Page.TabIndex = 12;
            this.Parking_Page.Text = "＜";
            this.Parking_Page.UseVisualStyleBackColor = true;
            this.Parking_Page.Click += new System.EventHandler(this.Parking_Page_Click);
            // 
            // TODO_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Menu_Page);
            this.Controls.Add(this.DOING_Page);
            this.Controls.Add(this.Parking_Page);
            this.Controls.Add(this.label1);
            this.Name = "TODO_Control";
            this.Size = new System.Drawing.Size(1051, 796);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Menu_Page;
        private System.Windows.Forms.Button DOING_Page;
        private System.Windows.Forms.Button Parking_Page;
    }
}
