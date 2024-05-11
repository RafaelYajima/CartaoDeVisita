namespace CartaoDeVisita
{
    partial class cartaoVizita
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
            this.nomeCartao = new System.Windows.Forms.Label();
            this.idadeCartao = new System.Windows.Forms.Label();
            this.telefoneCartao = new System.Windows.Forms.Label();
            this.emailCartao = new System.Windows.Forms.Label();
            this.enderecoCartao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeCartao
            // 
            this.nomeCartao.AutoSize = true;
            this.nomeCartao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.nomeCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeCartao.Location = new System.Drawing.Point(152, 163);
            this.nomeCartao.Name = "nomeCartao";
            this.nomeCartao.Size = new System.Drawing.Size(85, 32);
            this.nomeCartao.TabIndex = 0;
            this.nomeCartao.Text = "nome";
            // 
            // idadeCartao
            // 
            this.idadeCartao.AutoSize = true;
            this.idadeCartao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.idadeCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idadeCartao.Location = new System.Drawing.Point(153, 209);
            this.idadeCartao.Name = "idadeCartao";
            this.idadeCartao.Size = new System.Drawing.Size(85, 32);
            this.idadeCartao.TabIndex = 1;
            this.idadeCartao.Text = "idade";
            // 
            // telefoneCartao
            // 
            this.telefoneCartao.AutoSize = true;
            this.telefoneCartao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.telefoneCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneCartao.Location = new System.Drawing.Point(152, 253);
            this.telefoneCartao.Name = "telefoneCartao";
            this.telefoneCartao.Size = new System.Drawing.Size(117, 32);
            this.telefoneCartao.TabIndex = 3;
            this.telefoneCartao.Text = "telefone";
            // 
            // emailCartao
            // 
            this.emailCartao.AutoSize = true;
            this.emailCartao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.emailCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailCartao.Location = new System.Drawing.Point(152, 295);
            this.emailCartao.Name = "emailCartao";
            this.emailCartao.Size = new System.Drawing.Size(86, 32);
            this.emailCartao.TabIndex = 4;
            this.emailCartao.Text = "Email";
            // 
            // enderecoCartao
            // 
            this.enderecoCartao.AutoSize = true;
            this.enderecoCartao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.enderecoCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoCartao.Location = new System.Drawing.Point(152, 337);
            this.enderecoCartao.Name = "enderecoCartao";
            this.enderecoCartao.Size = new System.Drawing.Size(133, 32);
            this.enderecoCartao.TabIndex = 5;
            this.enderecoCartao.Text = "endereco";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(147, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 225);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // cartaoVizita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(667, 531);
            this.Controls.Add(this.enderecoCartao);
            this.Controls.Add(this.emailCartao);
            this.Controls.Add(this.telefoneCartao);
            this.Controls.Add(this.idadeCartao);
            this.Controls.Add(this.nomeCartao);
            this.Controls.Add(this.pictureBox1);
            this.Name = "cartaoVizita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cartaoVizita";
            this.Load += new System.EventHandler(this.cartaoVizita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeCartao;
        private System.Windows.Forms.Label idadeCartao;
        private System.Windows.Forms.Label telefoneCartao;
        private System.Windows.Forms.Label emailCartao;
        private System.Windows.Forms.Label enderecoCartao;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}