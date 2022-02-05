
namespace shop_app
{
    partial class FormAdmin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add_bt = new System.Windows.Forms.Button();
            this.update_bt = new System.Windows.Forms.Button();
            this.login_lb = new System.Windows.Forms.Label();
            this.pass_lb = new System.Windows.Forms.Label();
            this.role_lb = new System.Windows.Forms.Label();
            this.login_tb = new System.Windows.Forms.TextBox();
            this.pass_tb = new System.Windows.Forms.TextBox();
            this.role_cb = new System.Windows.Forms.ComboBox();
            this.roleId_cb = new System.Windows.Forms.ComboBox();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.name_lb = new System.Windows.Forms.Label();
            this.del_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(775, 249);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // add_bt
            // 
            this.add_bt.Location = new System.Drawing.Point(695, 263);
            this.add_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_bt.Name = "add_bt";
            this.add_bt.Size = new System.Drawing.Size(94, 57);
            this.add_bt.TabIndex = 1;
            this.add_bt.Text = "Добавить";
            this.add_bt.UseVisualStyleBackColor = true;
            this.add_bt.Click += new System.EventHandler(this.add_bt_Click);
            // 
            // update_bt
            // 
            this.update_bt.Location = new System.Drawing.Point(595, 263);
            this.update_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update_bt.Name = "update_bt";
            this.update_bt.Size = new System.Drawing.Size(94, 57);
            this.update_bt.TabIndex = 2;
            this.update_bt.Text = "Изменить";
            this.update_bt.UseVisualStyleBackColor = true;
            this.update_bt.Click += new System.EventHandler(this.update_bt_Click);
            // 
            // login_lb
            // 
            this.login_lb.AutoSize = true;
            this.login_lb.Location = new System.Drawing.Point(22, 304);
            this.login_lb.Name = "login_lb";
            this.login_lb.Size = new System.Drawing.Size(55, 17);
            this.login_lb.TabIndex = 4;
            this.login_lb.Text = "Логин :";
            // 
            // pass_lb
            // 
            this.pass_lb.AutoSize = true;
            this.pass_lb.Location = new System.Drawing.Point(12, 331);
            this.pass_lb.Name = "pass_lb";
            this.pass_lb.Size = new System.Drawing.Size(65, 17);
            this.pass_lb.TabIndex = 5;
            this.pass_lb.Text = "Пароль :";
            // 
            // role_lb
            // 
            this.role_lb.AutoSize = true;
            this.role_lb.Location = new System.Drawing.Point(32, 358);
            this.role_lb.Name = "role_lb";
            this.role_lb.Size = new System.Drawing.Size(48, 17);
            this.role_lb.TabIndex = 6;
            this.role_lb.Text = "Роль :";
            // 
            // login_tb
            // 
            this.login_tb.Location = new System.Drawing.Point(87, 302);
            this.login_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_tb.Name = "login_tb";
            this.login_tb.Size = new System.Drawing.Size(272, 22);
            this.login_tb.TabIndex = 7;
            // 
            // pass_tb
            // 
            this.pass_tb.Location = new System.Drawing.Point(87, 328);
            this.pass_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pass_tb.Name = "pass_tb";
            this.pass_tb.Size = new System.Drawing.Size(272, 22);
            this.pass_tb.TabIndex = 8;
            // 
            // role_cb
            // 
            this.role_cb.FormattingEnabled = true;
            this.role_cb.Location = new System.Drawing.Point(87, 356);
            this.role_cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.role_cb.Name = "role_cb";
            this.role_cb.Size = new System.Drawing.Size(272, 24);
            this.role_cb.TabIndex = 9;
            // 
            // roleId_cb
            // 
            this.roleId_cb.FormattingEnabled = true;
            this.roleId_cb.Location = new System.Drawing.Point(365, 356);
            this.roleId_cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roleId_cb.Name = "roleId_cb";
            this.roleId_cb.Size = new System.Drawing.Size(111, 24);
            this.roleId_cb.TabIndex = 10;
            this.roleId_cb.Visible = false;
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(87, 276);
            this.name_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(272, 22);
            this.name_tb.TabIndex = 12;
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Location = new System.Drawing.Point(27, 279);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(50, 17);
            this.name_lb.TabIndex = 11;
            this.name_lb.Text = "ФИО :";
            // 
            // del_bt
            // 
            this.del_bt.Location = new System.Drawing.Point(595, 323);
            this.del_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.del_bt.Name = "del_bt";
            this.del_bt.Size = new System.Drawing.Size(194, 27);
            this.del_bt.TabIndex = 13;
            this.del_bt.Text = "Удалить";
            this.del_bt.UseVisualStyleBackColor = true;
            this.del_bt.Click += new System.EventHandler(this.del_bt_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.del_bt);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.name_lb);
            this.Controls.Add(this.roleId_cb);
            this.Controls.Add(this.role_cb);
            this.Controls.Add(this.pass_tb);
            this.Controls.Add(this.login_tb);
            this.Controls.Add(this.role_lb);
            this.Controls.Add(this.pass_lb);
            this.Controls.Add(this.login_lb);
            this.Controls.Add(this.update_bt);
            this.Controls.Add(this.add_bt);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add_bt;
        private System.Windows.Forms.Button update_bt;
        private System.Windows.Forms.Label login_lb;
        private System.Windows.Forms.Label pass_lb;
        private System.Windows.Forms.Label role_lb;
        private System.Windows.Forms.TextBox login_tb;
        private System.Windows.Forms.TextBox pass_tb;
        private System.Windows.Forms.ComboBox role_cb;
        private System.Windows.Forms.ComboBox roleId_cb;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Button del_bt;
    }
}