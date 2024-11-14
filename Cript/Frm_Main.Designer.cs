namespace Cript
{
    partial class Frm_Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_descript1 = new System.Windows.Forms.TextBox();
            this.btn_cript = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cript1 = new System.Windows.Forms.TextBox();
            this.btn_salvarCript = new System.Windows.Forms.Button();
            this.grp_cript = new System.Windows.Forms.GroupBox();
            this.grp_descript = new System.Windows.Forms.GroupBox();
            this.btn_descript = new System.Windows.Forms.Button();
            this.btn_salvarDescript = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_descript2 = new System.Windows.Forms.TextBox();
            this.txt_cript2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grp_cript.SuspendLayout();
            this.grp_descript.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto original:";
            // 
            // txt_descript1
            // 
            this.txt_descript1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descript1.Location = new System.Drawing.Point(216, 54);
            this.txt_descript1.Name = "txt_descript1";
            this.txt_descript1.Size = new System.Drawing.Size(181, 31);
            this.txt_descript1.TabIndex = 1;
            // 
            // btn_cript
            // 
            this.btn_cript.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cript.Location = new System.Drawing.Point(11, 91);
            this.btn_cript.Name = "btn_cript";
            this.btn_cript.Size = new System.Drawing.Size(386, 46);
            this.btn_cript.TabIndex = 2;
            this.btn_cript.Text = "Criptografar";
            this.btn_cript.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Texto criptografado:";
            // 
            // txt_cript1
            // 
            this.txt_cript1.Enabled = false;
            this.txt_cript1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cript1.Location = new System.Drawing.Point(216, 143);
            this.txt_cript1.Name = "txt_cript1";
            this.txt_cript1.Size = new System.Drawing.Size(181, 31);
            this.txt_cript1.TabIndex = 4;
            // 
            // btn_salvarCript
            // 
            this.btn_salvarCript.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvarCript.Location = new System.Drawing.Point(11, 180);
            this.btn_salvarCript.Name = "btn_salvarCript";
            this.btn_salvarCript.Size = new System.Drawing.Size(386, 46);
            this.btn_salvarCript.TabIndex = 6;
            this.btn_salvarCript.Text = "Salvar";
            this.btn_salvarCript.UseVisualStyleBackColor = true;
            // 
            // grp_cript
            // 
            this.grp_cript.Controls.Add(this.btn_cript);
            this.grp_cript.Controls.Add(this.btn_salvarCript);
            this.grp_cript.Controls.Add(this.label1);
            this.grp_cript.Controls.Add(this.txt_cript1);
            this.grp_cript.Controls.Add(this.txt_descript1);
            this.grp_cript.Controls.Add(this.label2);
            this.grp_cript.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_cript.Location = new System.Drawing.Point(12, 12);
            this.grp_cript.Name = "grp_cript";
            this.grp_cript.Size = new System.Drawing.Size(412, 242);
            this.grp_cript.TabIndex = 7;
            this.grp_cript.TabStop = false;
            this.grp_cript.Text = "Criptografar";
            // 
            // grp_descript
            // 
            this.grp_descript.Controls.Add(this.btn_descript);
            this.grp_descript.Controls.Add(this.btn_salvarDescript);
            this.grp_descript.Controls.Add(this.label3);
            this.grp_descript.Controls.Add(this.txt_descript2);
            this.grp_descript.Controls.Add(this.txt_cript2);
            this.grp_descript.Controls.Add(this.label4);
            this.grp_descript.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_descript.Location = new System.Drawing.Point(430, 12);
            this.grp_descript.Name = "grp_descript";
            this.grp_descript.Size = new System.Drawing.Size(412, 242);
            this.grp_descript.TabIndex = 8;
            this.grp_descript.TabStop = false;
            this.grp_descript.Text = "Descriptografar";
            // 
            // btn_descript
            // 
            this.btn_descript.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_descript.Location = new System.Drawing.Point(11, 91);
            this.btn_descript.Name = "btn_descript";
            this.btn_descript.Size = new System.Drawing.Size(386, 46);
            this.btn_descript.TabIndex = 2;
            this.btn_descript.Text = "Descriptografar";
            this.btn_descript.UseVisualStyleBackColor = true;
            // 
            // btn_salvarDescript
            // 
            this.btn_salvarDescript.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvarDescript.Location = new System.Drawing.Point(11, 180);
            this.btn_salvarDescript.Name = "btn_salvarDescript";
            this.btn_salvarDescript.Size = new System.Drawing.Size(386, 46);
            this.btn_salvarDescript.TabIndex = 6;
            this.btn_salvarDescript.Text = "Salvar";
            this.btn_salvarDescript.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Texto original:";
            // 
            // txt_descript2
            // 
            this.txt_descript2.Enabled = false;
            this.txt_descript2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descript2.Location = new System.Drawing.Point(216, 143);
            this.txt_descript2.Name = "txt_descript2";
            this.txt_descript2.Size = new System.Drawing.Size(181, 31);
            this.txt_descript2.TabIndex = 4;
            // 
            // txt_cript2
            // 
            this.txt_cript2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cript2.Location = new System.Drawing.Point(216, 54);
            this.txt_cript2.Name = "txt_cript2";
            this.txt_cript2.Size = new System.Drawing.Size(181, 31);
            this.txt_cript2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Texto criptografado:";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 267);
            this.Controls.Add(this.grp_descript);
            this.Controls.Add(this.grp_cript);
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cript";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.grp_cript.ResumeLayout(false);
            this.grp_cript.PerformLayout();
            this.grp_descript.ResumeLayout(false);
            this.grp_descript.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_descript1;
        private System.Windows.Forms.Button btn_cript;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cript1;
        private System.Windows.Forms.Button btn_salvarCript;
        private System.Windows.Forms.GroupBox grp_cript;
        private System.Windows.Forms.GroupBox grp_descript;
        private System.Windows.Forms.Button btn_descript;
        private System.Windows.Forms.Button btn_salvarDescript;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_descript2;
        private System.Windows.Forms.TextBox txt_cript2;
        private System.Windows.Forms.Label label4;
    }
}

