
namespace shop_app
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enter_bt = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.login_tb = new System.Windows.Forms.TextBox();
            this.login_lb = new System.Windows.Forms.Label();
            this.pass_lb = new System.Windows.Forms.Label();
            this.pass_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enter_bt
            // 
            this.enter_bt.Location = new System.Drawing.Point(15, 97);
            this.enter_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enter_bt.Name = "enter_bt";
            this.enter_bt.Size = new System.Drawing.Size(301, 29);
            this.enter_bt.TabIndex = 0;
            this.enter_bt.Text = "Подтвердить";
            this.enter_bt.UseVisualStyleBackColor = true;
            this.enter_bt.Click += new System.EventHandler(this.enter_bt_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label.Location = new System.Drawing.Point(97, 10);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(133, 28);
            this.label.TabIndex = 1;
            this.label.Text = "Авторизация";
            // 
            // login_tb
            // 
            this.login_tb.Location = new System.Drawing.Point(87, 45);
            this.login_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_tb.Name = "login_tb";
            this.login_tb.Size = new System.Drawing.Size(229, 22);
            this.login_tb.TabIndex = 2;
            // 
            // login_lb
            // 
            this.login_lb.AutoSize = true;
            this.login_lb.Location = new System.Drawing.Point(22, 47);
            this.login_lb.Name = "login_lb";
            this.login_lb.Size = new System.Drawing.Size(55, 17);
            this.login_lb.TabIndex = 3;
            this.login_lb.Text = "Логин :";
            // 
            // pass_lb
            // 
            this.pass_lb.AutoSize = true;
            this.pass_lb.Location = new System.Drawing.Point(12, 74);
            this.pass_lb.Name = "pass_lb";
            this.pass_lb.Size = new System.Drawing.Size(65, 17);
            this.pass_lb.TabIndex = 4;
            this.pass_lb.Text = "Пароль :";
            // 
            // pass_tb
            // 
            this.pass_tb.Location = new System.Drawing.Point(87, 71);
            this.pass_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pass_tb.Name = "pass_tb";
            this.pass_tb.Size = new System.Drawing.Size(229, 22);
            this.pass_tb.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 137);
            this.Controls.Add(this.pass_tb);
            this.Controls.Add(this.pass_lb);
            this.Controls.Add(this.login_lb);
            this.Controls.Add(this.login_tb);
            this.Controls.Add(this.label);
            this.Controls.Add(this.enter_bt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enter_bt;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox login_tb;
        private System.Windows.Forms.Label login_lb;
        private System.Windows.Forms.Label pass_lb;
        private System.Windows.Forms.TextBox pass_tb;
    }
}

