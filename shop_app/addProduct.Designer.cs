
namespace shop_app
{
    partial class addProduct
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
            this.maker_cb = new System.Windows.Forms.ComboBox();
            this.category_tb = new System.Windows.Forms.TextBox();
            this.category_lb = new System.Windows.Forms.Label();
            this.maker_lb = new System.Windows.Forms.Label();
            this.ok_bt = new System.Windows.Forms.Button();
            this.makerId_cb = new System.Windows.Forms.ComboBox();
            this.cost_tb = new System.Windows.Forms.TextBox();
            this.cost_lb = new System.Windows.Forms.Label();
            this.cost2_tb = new System.Windows.Forms.TextBox();
            this.cost2_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Location = new System.Drawing.Point(58, 40);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(80, 17);
            this.name_lb.TabIndex = 1;
            this.name_lb.Text = "Название :";
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(144, 37);
            this.name_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(278, 22);
            this.name_tb.TabIndex = 2;
            // 
            // maker_cb
            // 
            this.maker_cb.FormattingEnabled = true;
            this.maker_cb.Location = new System.Drawing.Point(144, 10);
            this.maker_cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maker_cb.Name = "maker_cb";
            this.maker_cb.Size = new System.Drawing.Size(278, 24);
            this.maker_cb.TabIndex = 3;
            // 
            // category_tb
            // 
            this.category_tb.Location = new System.Drawing.Point(144, 63);
            this.category_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.category_tb.Name = "category_tb";
            this.category_tb.Size = new System.Drawing.Size(278, 22);
            this.category_tb.TabIndex = 5;
            // 
            // category_lb
            // 
            this.category_lb.AutoSize = true;
            this.category_lb.Location = new System.Drawing.Point(53, 66);
            this.category_lb.Name = "category_lb";
            this.category_lb.Size = new System.Drawing.Size(85, 17);
            this.category_lb.TabIndex = 4;
            this.category_lb.Text = "Категория :";
            // 
            // maker_lb
            // 
            this.maker_lb.AutoSize = true;
            this.maker_lb.Location = new System.Drawing.Point(20, 13);
            this.maker_lb.Name = "maker_lb";
            this.maker_lb.Size = new System.Drawing.Size(118, 17);
            this.maker_lb.TabIndex = 6;
            this.maker_lb.Text = "Производитель :";
            // 
            // ok_bt
            // 
            this.ok_bt.Location = new System.Drawing.Point(277, 145);
            this.ok_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ok_bt.Name = "ok_bt";
            this.ok_bt.Size = new System.Drawing.Size(145, 28);
            this.ok_bt.TabIndex = 7;
            this.ok_bt.Text = "Подтвердить";
            this.ok_bt.UseVisualStyleBackColor = true;
            this.ok_bt.Click += new System.EventHandler(this.ok_bt_Click);
            // 
            // makerId_cb
            // 
            this.makerId_cb.FormattingEnabled = true;
            this.makerId_cb.Location = new System.Drawing.Point(159, 148);
            this.makerId_cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.makerId_cb.Name = "makerId_cb";
            this.makerId_cb.Size = new System.Drawing.Size(112, 24);
            this.makerId_cb.TabIndex = 8;
            // 
            // cost_tb
            // 
            this.cost_tb.Location = new System.Drawing.Point(144, 93);
            this.cost_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cost_tb.Name = "cost_tb";
            this.cost_tb.Size = new System.Drawing.Size(278, 22);
            this.cost_tb.TabIndex = 10;
            // 
            // cost_lb
            // 
            this.cost_lb.AutoSize = true;
            this.cost_lb.Location = new System.Drawing.Point(31, 96);
            this.cost_lb.Name = "cost_lb";
            this.cost_lb.Size = new System.Drawing.Size(107, 17);
            this.cost_lb.TabIndex = 9;
            this.cost_lb.Text = "Цена закупки :";
            // 
            // cost2_tb
            // 
            this.cost2_tb.Location = new System.Drawing.Point(144, 119);
            this.cost2_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cost2_tb.Name = "cost2_tb";
            this.cost2_tb.Size = new System.Drawing.Size(278, 22);
            this.cost2_tb.TabIndex = 12;
            // 
            // cost2_lb
            // 
            this.cost2_lb.AutoSize = true;
            this.cost2_lb.Location = new System.Drawing.Point(26, 124);
            this.cost2_lb.Name = "cost2_lb";
            this.cost2_lb.Size = new System.Drawing.Size(112, 17);
            this.cost2_lb.TabIndex = 11;
            this.cost2_lb.Text = "Цена продажи :";
            // 
            // addProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 183);
            this.Controls.Add(this.cost2_tb);
            this.Controls.Add(this.cost2_lb);
            this.Controls.Add(this.cost_tb);
            this.Controls.Add(this.cost_lb);
            this.Controls.Add(this.makerId_cb);
            this.Controls.Add(this.ok_bt);
            this.Controls.Add(this.maker_lb);
            this.Controls.Add(this.category_tb);
            this.Controls.Add(this.category_lb);
            this.Controls.Add(this.maker_cb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.name_lb);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "addProduct";
            this.Text = "addProduct";
            this.Load += new System.EventHandler(this.addProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.ComboBox maker_cb;
        private System.Windows.Forms.TextBox category_tb;
        private System.Windows.Forms.Label category_lb;
        private System.Windows.Forms.Label maker_lb;
        private System.Windows.Forms.Button ok_bt;
        private System.Windows.Forms.ComboBox makerId_cb;
        private System.Windows.Forms.TextBox cost_tb;
        private System.Windows.Forms.Label cost_lb;
        private System.Windows.Forms.TextBox cost2_tb;
        private System.Windows.Forms.Label cost2_lb;
    }
}