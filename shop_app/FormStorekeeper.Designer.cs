
namespace shop_app
{
    partial class FormStorekeeper
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поступлениеТовараToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.складToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.производительToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.update_bt = new System.Windows.Forms.Button();
            this.count_lb = new System.Windows.Forms.Label();
            this.add_bt = new System.Windows.Forms.Button();
            this.count_tb = new System.Windows.Forms.TextBox();
            this.product_cb = new System.Windows.Forms.ComboBox();
            this.product_lb = new System.Windows.Forms.Label();
            this.productId_cb = new System.Windows.Forms.ComboBox();
            this.date_dtp = new System.Windows.Forms.DateTimePicker();
            this.date_lb = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поступлениеТовараToolStripMenuItem,
            this.складToolStripMenuItem,
            this.добавитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поступлениеТовараToolStripMenuItem
            // 
            this.поступлениеТовараToolStripMenuItem.Name = "поступлениеТовараToolStripMenuItem";
            this.поступлениеТовараToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.поступлениеТовараToolStripMenuItem.Text = "Поступление товара";
            this.поступлениеТовараToolStripMenuItem.Click += new System.EventHandler(this.поступлениеТовараToolStripMenuItem_Click);
            // 
            // складToolStripMenuItem
            // 
            this.складToolStripMenuItem.Name = "складToolStripMenuItem";
            this.складToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.складToolStripMenuItem.Text = "Склад";
            this.складToolStripMenuItem.Click += new System.EventHandler(this.складToolStripMenuItem_Click);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.товарToolStripMenuItem,
            this.производительToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.добавитьToolStripMenuItem.Text = "Добавить ...";
            // 
            // товарToolStripMenuItem
            // 
            this.товарToolStripMenuItem.Name = "товарToolStripMenuItem";
            this.товарToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.товарToolStripMenuItem.Text = "Товар";
            this.товарToolStripMenuItem.Click += new System.EventHandler(this.товарToolStripMenuItem_Click);
            // 
            // производительToolStripMenuItem
            // 
            this.производительToolStripMenuItem.Name = "производительToolStripMenuItem";
            this.производительToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.производительToolStripMenuItem.Text = "Производитель";
            this.производительToolStripMenuItem.Click += new System.EventHandler(this.производительToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 30);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(776, 234);
            this.dataGridView1.TabIndex = 1;
            // 
            // update_bt
            // 
            this.update_bt.Location = new System.Drawing.Point(694, 277);
            this.update_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update_bt.Name = "update_bt";
            this.update_bt.Size = new System.Drawing.Size(94, 50);
            this.update_bt.TabIndex = 13;
            this.update_bt.Text = "Изменить";
            this.update_bt.UseVisualStyleBackColor = true;
            this.update_bt.Click += new System.EventHandler(this.update_bt_Click);
            // 
            // count_lb
            // 
            this.count_lb.AutoSize = true;
            this.count_lb.Location = new System.Drawing.Point(12, 308);
            this.count_lb.Name = "count_lb";
            this.count_lb.Size = new System.Drawing.Size(61, 17);
            this.count_lb.TabIndex = 12;
            this.count_lb.Text = "Кол-во :";
            // 
            // add_bt
            // 
            this.add_bt.Location = new System.Drawing.Point(594, 277);
            this.add_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_bt.Name = "add_bt";
            this.add_bt.Size = new System.Drawing.Size(94, 50);
            this.add_bt.TabIndex = 11;
            this.add_bt.Text = "Добавить";
            this.add_bt.UseVisualStyleBackColor = true;
            this.add_bt.Click += new System.EventHandler(this.add_bt_Click);
            // 
            // count_tb
            // 
            this.count_tb.Location = new System.Drawing.Point(83, 305);
            this.count_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.count_tb.Name = "count_tb";
            this.count_tb.Size = new System.Drawing.Size(200, 22);
            this.count_tb.TabIndex = 10;
            // 
            // product_cb
            // 
            this.product_cb.FormattingEnabled = true;
            this.product_cb.Location = new System.Drawing.Point(83, 277);
            this.product_cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.product_cb.Name = "product_cb";
            this.product_cb.Size = new System.Drawing.Size(298, 24);
            this.product_cb.TabIndex = 9;
            // 
            // product_lb
            // 
            this.product_lb.AutoSize = true;
            this.product_lb.Location = new System.Drawing.Point(19, 280);
            this.product_lb.Name = "product_lb";
            this.product_lb.Size = new System.Drawing.Size(56, 17);
            this.product_lb.TabIndex = 8;
            this.product_lb.Text = "Товар :";
            // 
            // productId_cb
            // 
            this.productId_cb.FormattingEnabled = true;
            this.productId_cb.Location = new System.Drawing.Point(387, 277);
            this.productId_cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productId_cb.Name = "productId_cb";
            this.productId_cb.Size = new System.Drawing.Size(101, 24);
            this.productId_cb.TabIndex = 14;
            this.productId_cb.Visible = false;
            // 
            // date_dtp
            // 
            this.date_dtp.Location = new System.Drawing.Point(83, 332);
            this.date_dtp.Name = "date_dtp";
            this.date_dtp.Size = new System.Drawing.Size(200, 22);
            this.date_dtp.TabIndex = 15;
            // 
            // date_lb
            // 
            this.date_lb.AutoSize = true;
            this.date_lb.Location = new System.Drawing.Point(23, 337);
            this.date_lb.Name = "date_lb";
            this.date_lb.Size = new System.Drawing.Size(50, 17);
            this.date_lb.TabIndex = 16;
            this.date_lb.Text = "Дата :";
            // 
            // FormStorekeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.Controls.Add(this.date_lb);
            this.Controls.Add(this.date_dtp);
            this.Controls.Add(this.productId_cb);
            this.Controls.Add(this.update_bt);
            this.Controls.Add(this.count_lb);
            this.Controls.Add(this.add_bt);
            this.Controls.Add(this.count_tb);
            this.Controls.Add(this.product_cb);
            this.Controls.Add(this.product_lb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormStorekeeper";
            this.Text = "FormStorekeeper";
            this.Load += new System.EventHandler(this.FormStorekeeper_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поступлениеТовараToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem складToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.Button update_bt;
        private System.Windows.Forms.Label count_lb;
        private System.Windows.Forms.Button add_bt;
        private System.Windows.Forms.TextBox count_tb;
        private System.Windows.Forms.ComboBox product_cb;
        private System.Windows.Forms.Label product_lb;
        private System.Windows.Forms.ToolStripMenuItem товарToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem производительToolStripMenuItem;
        private System.Windows.Forms.ComboBox productId_cb;
        private System.Windows.Forms.DateTimePicker date_dtp;
        private System.Windows.Forms.Label date_lb;
    }
}