
namespace REGEX
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_movil = new System.Windows.Forms.Label();
            this.lb_mail = new System.Windows.Forms.Label();
            this.lb_SW = new System.Windows.Forms.Label();
            this.txt_movil = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_SW = new System.Windows.Forms.TextBox();
            this.bnt_movil = new System.Windows.Forms.Button();
            this.bnt_mail = new System.Windows.Forms.Button();
            this.bnt_SW = new System.Windows.Forms.Button();
            this.txt_movil_y = new System.Windows.Forms.TextBox();
            this.txt_mail_y = new System.Windows.Forms.TextBox();
            this.txt_SW_y = new System.Windows.Forms.TextBox();
            this.pnl_movil = new System.Windows.Forms.Panel();
            this.pnl_mail = new System.Windows.Forms.Panel();
            this.pnl_SW = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lb_movil
            // 
            this.lb_movil.AutoSize = true;
            this.lb_movil.Location = new System.Drawing.Point(12, 44);
            this.lb_movil.Name = "lb_movil";
            this.lb_movil.Size = new System.Drawing.Size(79, 13);
            this.lb_movil.TabIndex = 0;
            this.lb_movil.Text = "Telefono móvil:";
            // 
            // lb_mail
            // 
            this.lb_mail.AutoSize = true;
            this.lb_mail.Location = new System.Drawing.Point(54, 80);
            this.lb_mail.Name = "lb_mail";
            this.lb_mail.Size = new System.Drawing.Size(37, 13);
            this.lb_mail.TabIndex = 1;
            this.lb_mail.Text = "e-mail:";
            // 
            // lb_SW
            // 
            this.lb_SW.AutoSize = true;
            this.lb_SW.Location = new System.Drawing.Point(10, 115);
            this.lb_SW.Name = "lb_SW";
            this.lb_SW.Size = new System.Drawing.Size(81, 13);
            this.lb_SW.TabIndex = 2;
            this.lb_SW.Text = "Codi Star Wars:";
            // 
            // txt_movil
            // 
            this.txt_movil.Location = new System.Drawing.Point(97, 41);
            this.txt_movil.Name = "txt_movil";
            this.txt_movil.Size = new System.Drawing.Size(187, 20);
            this.txt_movil.TabIndex = 3;
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(97, 77);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(187, 20);
            this.txt_mail.TabIndex = 4;
            // 
            // txt_SW
            // 
            this.txt_SW.Location = new System.Drawing.Point(97, 112);
            this.txt_SW.Name = "txt_SW";
            this.txt_SW.Size = new System.Drawing.Size(187, 20);
            this.txt_SW.TabIndex = 5;
            // 
            // bnt_movil
            // 
            this.bnt_movil.Location = new System.Drawing.Point(341, 39);
            this.bnt_movil.Name = "bnt_movil";
            this.bnt_movil.Size = new System.Drawing.Size(75, 23);
            this.bnt_movil.TabIndex = 6;
            this.bnt_movil.Text = "Verificar";
            this.bnt_movil.UseVisualStyleBackColor = true;
            this.bnt_movil.Click += new System.EventHandler(this.bnt_movil_Click);
            // 
            // bnt_mail
            // 
            this.bnt_mail.Location = new System.Drawing.Point(341, 75);
            this.bnt_mail.Name = "bnt_mail";
            this.bnt_mail.Size = new System.Drawing.Size(75, 23);
            this.bnt_mail.TabIndex = 7;
            this.bnt_mail.Text = "Verificar";
            this.bnt_mail.UseVisualStyleBackColor = true;
            // 
            // bnt_SW
            // 
            this.bnt_SW.Location = new System.Drawing.Point(341, 110);
            this.bnt_SW.Name = "bnt_SW";
            this.bnt_SW.Size = new System.Drawing.Size(75, 23);
            this.bnt_SW.TabIndex = 8;
            this.bnt_SW.Text = "Verificar";
            this.bnt_SW.UseVisualStyleBackColor = true;
            // 
            // txt_movil_y
            // 
            this.txt_movil_y.BackColor = System.Drawing.SystemColors.Info;
            this.txt_movil_y.Enabled = false;
            this.txt_movil_y.Location = new System.Drawing.Point(434, 41);
            this.txt_movil_y.Name = "txt_movil_y";
            this.txt_movil_y.Size = new System.Drawing.Size(354, 20);
            this.txt_movil_y.TabIndex = 9;
            this.txt_movil_y.Text = "^\\(?\\+\\d{1,3}\\)?-\\d{3}.\\d{2}.\\d{2}.\\d{2}$";
            // 
            // txt_mail_y
            // 
            this.txt_mail_y.BackColor = System.Drawing.SystemColors.Info;
            this.txt_mail_y.Enabled = false;
            this.txt_mail_y.Location = new System.Drawing.Point(434, 77);
            this.txt_mail_y.Name = "txt_mail_y";
            this.txt_mail_y.Size = new System.Drawing.Size(354, 20);
            this.txt_mail_y.TabIndex = 10;
            // 
            // txt_SW_y
            // 
            this.txt_SW_y.BackColor = System.Drawing.SystemColors.Info;
            this.txt_SW_y.Enabled = false;
            this.txt_SW_y.Location = new System.Drawing.Point(434, 112);
            this.txt_SW_y.Name = "txt_SW_y";
            this.txt_SW_y.Size = new System.Drawing.Size(354, 20);
            this.txt_SW_y.TabIndex = 11;
            // 
            // pnl_movil
            // 
            this.pnl_movil.BackColor = System.Drawing.SystemColors.Menu;
            this.pnl_movil.Location = new System.Drawing.Point(302, 39);
            this.pnl_movil.Name = "pnl_movil";
            this.pnl_movil.Size = new System.Drawing.Size(33, 23);
            this.pnl_movil.TabIndex = 12;
            // 
            // pnl_mail
            // 
            this.pnl_mail.BackColor = System.Drawing.SystemColors.Menu;
            this.pnl_mail.Location = new System.Drawing.Point(302, 75);
            this.pnl_mail.Name = "pnl_mail";
            this.pnl_mail.Size = new System.Drawing.Size(33, 23);
            this.pnl_mail.TabIndex = 13;
            // 
            // pnl_SW
            // 
            this.pnl_SW.BackColor = System.Drawing.SystemColors.Menu;
            this.pnl_SW.Location = new System.Drawing.Point(302, 110);
            this.pnl_SW.Name = "pnl_SW";
            this.pnl_SW.Size = new System.Drawing.Size(33, 23);
            this.pnl_SW.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 172);
            this.Controls.Add(this.pnl_SW);
            this.Controls.Add(this.pnl_mail);
            this.Controls.Add(this.pnl_movil);
            this.Controls.Add(this.txt_SW_y);
            this.Controls.Add(this.txt_mail_y);
            this.Controls.Add(this.txt_movil_y);
            this.Controls.Add(this.bnt_SW);
            this.Controls.Add(this.bnt_mail);
            this.Controls.Add(this.bnt_movil);
            this.Controls.Add(this.txt_SW);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_movil);
            this.Controls.Add(this.lb_SW);
            this.Controls.Add(this.lb_mail);
            this.Controls.Add(this.lb_movil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_movil;
        private System.Windows.Forms.Label lb_mail;
        private System.Windows.Forms.Label lb_SW;
        private System.Windows.Forms.TextBox txt_movil;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_SW;
        private System.Windows.Forms.Button bnt_movil;
        private System.Windows.Forms.Button bnt_mail;
        private System.Windows.Forms.Button bnt_SW;
        private System.Windows.Forms.TextBox txt_movil_y;
        private System.Windows.Forms.TextBox txt_mail_y;
        private System.Windows.Forms.TextBox txt_SW_y;
        private System.Windows.Forms.Panel pnl_movil;
        private System.Windows.Forms.Panel pnl_mail;
        private System.Windows.Forms.Panel pnl_SW;
    }
}

