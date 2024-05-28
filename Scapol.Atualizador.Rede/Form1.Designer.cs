namespace Scapol.Atualizador.Rede
{
    partial class Form1
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sttlblMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.sttlblMensagemErro = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSelArquivo = new System.Windows.Forms.Label();
            this.edtCaminhoArquivo = new System.Windows.Forms.TextBox();
            this.btnSelArquivo = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblContador = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sttlblMensagem,
            this.sttlblMensagemErro});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sttlblMensagem
            // 
            this.sttlblMensagem.Name = "sttlblMensagem";
            this.sttlblMensagem.Size = new System.Drawing.Size(0, 16);
            // 
            // sttlblMensagemErro
            // 
            this.sttlblMensagemErro.Name = "sttlblMensagemErro";
            this.sttlblMensagemErro.Size = new System.Drawing.Size(0, 16);
            // 
            // lblSelArquivo
            // 
            this.lblSelArquivo.AutoSize = true;
            this.lblSelArquivo.Location = new System.Drawing.Point(12, 9);
            this.lblSelArquivo.Name = "lblSelArquivo";
            this.lblSelArquivo.Size = new System.Drawing.Size(108, 16);
            this.lblSelArquivo.TabIndex = 1;
            this.lblSelArquivo.Text = "Caminho arquivo";
            // 
            // edtCaminhoArquivo
            // 
            this.edtCaminhoArquivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtCaminhoArquivo.Location = new System.Drawing.Point(12, 28);
            this.edtCaminhoArquivo.Name = "edtCaminhoArquivo";
            this.edtCaminhoArquivo.ReadOnly = true;
            this.edtCaminhoArquivo.Size = new System.Drawing.Size(543, 22);
            this.edtCaminhoArquivo.TabIndex = 2;
            // 
            // btnSelArquivo
            // 
            this.btnSelArquivo.Location = new System.Drawing.Point(561, 12);
            this.btnSelArquivo.Name = "btnSelArquivo";
            this.btnSelArquivo.Size = new System.Drawing.Size(227, 38);
            this.btnSelArquivo.TabIndex = 3;
            this.btnSelArquivo.Text = "Selecionar Arquivo";
            this.btnSelArquivo.UseVisualStyleBackColor = true;
            this.btnSelArquivo.Click += new System.EventHandler(this.btnSelArquivo_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 87);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(12, 68);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(0, 16);
            this.lblContador.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnSelArquivo);
            this.Controls.Add(this.edtCaminhoArquivo);
            this.Controls.Add(this.lblSelArquivo);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Atualizador Rede";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sttlblMensagem;
        private System.Windows.Forms.ToolStripStatusLabel sttlblMensagemErro;
        private System.Windows.Forms.Label lblSelArquivo;
        private System.Windows.Forms.TextBox edtCaminhoArquivo;
        private System.Windows.Forms.Button btnSelArquivo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblContador;
    }
}

