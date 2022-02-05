
namespace shop_app
{
    partial class addMaker
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
            this.name_lb = new System.Windows.Forms.Label();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.ok_bt = new System.Windows.Forms.Button();
            this.country_tb = new System.Windows.Forms.TextBox();
            this.country_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Location = new System.Drawing.Point(12, 12);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(80, 17);
            this.name_lb.TabIndex = 0;
            this.name_lb.Text = "Название :";
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(102, 10);
            this.name_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(278, 22);
            this.name_tb.TabIndex = 1;
            // 
            // ok_bt
            // 
            this.ok_bt.Location = new System.Drawing.Point(236, 62);
            this.ok_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ok_bt.Name = "ok_bt";
            this.ok_bt.Size = new System.Drawing.Size(145, 30);
            this.ok_bt.TabIndex = 2;
            this.ok_bt.Text = "Подтвердить";
            this.ok_bt.UseVisualStyleBackColor = true;
            this.ok_bt.Click += new System.EventHandler(this.ok_bt_Click);
            // 
            // country_tb
            // 
            this.country_tb.Location = new System.Drawing.Point(102, 36);
            this.country_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.country_tb.Name = "country_tb";
            this.country_tb.Size = new System.Drawing.Size(278, 22);
            this.country_tb.TabIndex = 4;
            // 
            // country_lb
            // 
            this.country_lb.AutoSize = true;
            this.country_lb.Location = new System.Drawing.Point(28, 39);
            this.country_lb.Name = "country_lb";
            this.country_lb.Size = new System.Drawing.Size(64, 17);
            this.country_lb.TabIndex = 3;
            this.country_lb.Text = "Страна :";
            // 
            // addMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 103);
            this.Controls.Add(this.country_tb);
            this.Controls.Add(this.country_lb);
            this.Controls.Add(this.ok_bt);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.name_lb);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "addMaker";
            this.Text = "addMaker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Button ok_bt;
        private System.Windows.Forms.TextBox country_tb;
        private System.Windows.Forms.Label country_lb;
    }
}