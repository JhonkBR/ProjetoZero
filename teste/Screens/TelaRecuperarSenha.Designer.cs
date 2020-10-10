namespace teste.Telas
{
    partial class TelaRecuperarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaRecuperarSenha));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTexto = new System.Windows.Forms.Label();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.TextLoginRecuperar = new System.Windows.Forms.TextBox();
            this.buttonRecuperarSenha = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMensagemUsuario = new System.Windows.Forms.Label();
            this.labelMensagemPin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(597, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 15);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelTexto
            // 
            this.labelTexto.AutoSize = true;
            this.labelTexto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTexto.ForeColor = System.Drawing.Color.DimGray;
            this.labelTexto.Location = new System.Drawing.Point(78, 132);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(141, 21);
            this.labelTexto.TabIndex = 14;
            this.labelTexto.Text = "Digite seu e-mail:";
            this.labelTexto.Click += new System.EventHandler(this.label3_Click);
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape3.Enabled = false;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 224;
            this.lineShape3.X2 = 573;
            this.lineShape3.Y1 = 150;
            this.lineShape3.Y2 = 150;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.lineShape3});
            this.shapeContainer1.Size = new System.Drawing.Size(655, 396);
            this.shapeContainer1.TabIndex = 15;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.Visible = false;
            this.lineShape1.X1 = 259;
            this.lineShape1.X2 = 450;
            this.lineShape1.Y1 = 239;
            this.lineShape1.Y2 = 239;
            // 
            // TextLoginRecuperar
            // 
            this.TextLoginRecuperar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TextLoginRecuperar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextLoginRecuperar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLoginRecuperar.ForeColor = System.Drawing.Color.DimGray;
            this.TextLoginRecuperar.Location = new System.Drawing.Point(224, 128);
            this.TextLoginRecuperar.Name = "TextLoginRecuperar";
            this.TextLoginRecuperar.Size = new System.Drawing.Size(350, 20);
            this.TextLoginRecuperar.TabIndex = 16;
            this.TextLoginRecuperar.TextChanged += new System.EventHandler(this.TextLoginRecuperar_TextChanged);
            // 
            // buttonRecuperarSenha
            // 
            this.buttonRecuperarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonRecuperarSenha.FlatAppearance.BorderSize = 0;
            this.buttonRecuperarSenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonRecuperarSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRecuperarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecuperarSenha.ForeColor = System.Drawing.Color.LightGray;
            this.buttonRecuperarSenha.Location = new System.Drawing.Point(348, 310);
            this.buttonRecuperarSenha.Name = "buttonRecuperarSenha";
            this.buttonRecuperarSenha.Size = new System.Drawing.Size(216, 40);
            this.buttonRecuperarSenha.TabIndex = 17;
            this.buttonRecuperarSenha.Text = "ENVIAR";
            this.buttonRecuperarSenha.UseVisualStyleBackColor = false;
            this.buttonRecuperarSenha.Click += new System.EventHandler(this.buttonRecuperarSenha_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.ForeColor = System.Drawing.Color.LightGray;
            this.buttonCancelar.Location = new System.Drawing.Point(59, 310);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(216, 40);
            this.buttonCancelar.TabIndex = 18;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(140, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Digite o PIN:";
            this.label1.Visible = false;
            // 
            // textBoxPin
            // 
            this.textBoxPin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBoxPin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPin.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxPin.Location = new System.Drawing.Point(259, 216);
            this.textBoxPin.Name = "textBoxPin";
            this.textBoxPin.Size = new System.Drawing.Size(193, 20);
            this.textBoxPin.TabIndex = 20;
            this.textBoxPin.Visible = false;
            this.textBoxPin.TextChanged += new System.EventHandler(this.textBoxPin_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(159, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 33);
            this.label2.TabIndex = 21;
            this.label2.Text = "Recuperação de Acesso";
            // 
            // labelMensagemUsuario
            // 
            this.labelMensagemUsuario.AutoSize = true;
            this.labelMensagemUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelMensagemUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.labelMensagemUsuario.Location = new System.Drawing.Point(221, 156);
            this.labelMensagemUsuario.Margin = new System.Windows.Forms.Padding(3, 0, 3, 1);
            this.labelMensagemUsuario.Name = "labelMensagemUsuario";
            this.labelMensagemUsuario.Size = new System.Drawing.Size(0, 13);
            this.labelMensagemUsuario.TabIndex = 22;
            // 
            // labelMensagemPin
            // 
            this.labelMensagemPin.AutoSize = true;
            this.labelMensagemPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelMensagemPin.ForeColor = System.Drawing.Color.DimGray;
            this.labelMensagemPin.Location = new System.Drawing.Point(260, 249);
            this.labelMensagemPin.Name = "labelMensagemPin";
            this.labelMensagemPin.Size = new System.Drawing.Size(0, 13);
            this.labelMensagemPin.TabIndex = 23;
            this.labelMensagemPin.Visible = false;
            // 
            // TelaRecuperarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(655, 396);
            this.Controls.Add(this.labelMensagemPin);
            this.Controls.Add(this.labelMensagemUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonRecuperarSenha);
            this.Controls.Add(this.TextLoginRecuperar);
            this.Controls.Add(this.labelTexto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(655, 396);
            this.MinimumSize = new System.Drawing.Size(655, 396);
            this.Name = "TelaRecuperarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaRecuperarSenha";
            this.Load += new System.EventHandler(this.TelaRecuperarSenha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTexto;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.TextBox TextLoginRecuperar;
        private System.Windows.Forms.Button buttonRecuperarSenha;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox textBoxPin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMensagemUsuario;
        private System.Windows.Forms.Label labelMensagemPin;
    }
}