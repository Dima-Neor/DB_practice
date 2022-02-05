
namespace shop_app
{
    partial class FormSeller
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
            this.проданныеТоварыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.складToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.product_lb = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.add_bt = new System.Windows.Forms.Button();
            this.count_lb = new System.Windows.Forms.Label();
            this.update_bt = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проданныеТоварыToolStripMenuItem,
            this.складToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // проданныеТоварыToolStripMenuItem
            // 
            this.проданныеТоварыToolStripMenuItem.Name = "проданныеТоварыToolStripMenuItem";
            this.проданныеТоварыToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.проданныеТоварыToolStripMenuItem.Text = "Проданные товары";
            // 
            // складToolStripMenuItem
            // 
            this.складToolStripMenuItem.Name = "складToolStripMenuItem";
            this.складToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.складToolStripMenuItem.Text = "Склад";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 30);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(775, 223);
            this.dataGridView1.TabIndex = 1;
            // 
            // product_lb
            // 
            this.product_lb.AutoSize = true;
            this.product_lb.Location = new System.Drawing.Point(20, 265);
            this.product_lb.Name = "product_lb";
            this.product_lb.Size = new System.Drawing.Size(56, 17);
            this.product_lb.TabIndex = 2;
            this.product_lb.Text = "Товар :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 262);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(254, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 290);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 22);
            this.textBox1.TabIndex = 4;
            // 
            // add_bt
            // 
            this.add_bt.Location = new System.Drawing.Point(594, 262);
            this.add_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_bt.Name = "add_bt";
            this.add_bt.Size = new System.Drawing.Size(94, 50);
            this.add_bt.TabIndex = 5;
            this.add_bt.Text = "Добавить";
            this.add_bt.UseVisualStyleBackColor = true;
            // 
            // count_lb
            // 
            this.count_lb.AutoSize = true;
            this.count_lb.Location = new System.Drawing.Point(13, 293);
            this.count_lb.Name = "count_lb";
            this.count_lb.Size = new System.Drawing.Size(61, 17);
            this.count_lb.TabIndex = 6;
            this.count_lb.Text = "Кол-во :";
            // 
            // update_bt
            // 
            this.update_bt.Location = new System.Drawing.Point(694, 262);
            this.update_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update_bt.Name = "update_bt";
            this.update_bt.Size = new System.Drawing.Size(94, 50);
            this.update_bt.TabIndex = 7;
            this.update_bt.Text = "Изменить";
            this.update_bt.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(344, 262);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(92, 24);
            this.comboBox2.TabIndex = 8;
            // 
            // FormSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 328);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.update_bt);
            this.Controls.Add(this.count_lb);
            this.Controls.Add(this.add_bt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.product_lb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSeller";
            this.Text = "FormSeller";
            this.Load += new System.EventHandler(this.FormSeller_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem проданныеТоварыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem складToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label product_lb;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button add_bt;
        private System.Windows.Forms.Label count_lb;
        private System.Windows.Forms.Button update_bt;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}