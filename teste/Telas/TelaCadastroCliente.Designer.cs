namespace teste.Telas
{
    partial class TelaCadastroCliente
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
            this.button_PesquisarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_PesquisarCliente
            // 
            this.button_PesquisarCliente.Location = new System.Drawing.Point(560, 371);
            this.button_PesquisarCliente.Name = "button_PesquisarCliente";
            this.button_PesquisarCliente.Size = new System.Drawing.Size(75, 23);
            this.button_PesquisarCliente.TabIndex = 0;
            this.button_PesquisarCliente.Text = "Pesquisar";
            this.button_PesquisarCliente.UseVisualStyleBackColor = true;
            this.button_PesquisarCliente.Click += new System.EventHandler(this.button_PesquisarCliente_Click);
            // 
            // TelaCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.button_PesquisarCliente);
            this.Name = "TelaCadastroCliente";
            this.Text = "TelaCadastroCliente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_PesquisarCliente;
    }
}