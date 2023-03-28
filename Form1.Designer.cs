
namespace FolhaDePagamento
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
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.btnSelecionarArquivo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPercentualDoReajuste = new System.Windows.Forms.Label();
            this.lblTotalSemReajuste = new System.Windows.Forms.Label();
            this.lblTotalComReajuste = new System.Windows.Forms.Label();
            this.dgvLeitura = new System.Windows.Forms.DataGridView();
            this.ofdListaFuncionarios = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitura)).BeginInit();
            this.SuspendLayout();
            // 
            // txtArquivo
            // 
            this.txtArquivo.Enabled = false;
            this.txtArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivo.Location = new System.Drawing.Point(34, 27);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(569, 30);
            this.txtArquivo.TabIndex = 1;
            // 
            // btnSelecionarArquivo
            // 
            this.btnSelecionarArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelecionarArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarArquivo.Location = new System.Drawing.Point(631, 26);
            this.btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            this.btnSelecionarArquivo.Size = new System.Drawing.Size(75, 31);
            this.btnSelecionarArquivo.TabIndex = 2;
            this.btnSelecionarArquivo.Text = "...";
            this.btnSelecionarArquivo.UseVisualStyleBackColor = true;
            this.btnSelecionarArquivo.Click += new System.EventHandler(this.btnSelecionarArquivo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(34, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 84);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 232F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.Controls.Add(this.lblPercentualDoReajuste, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalComReajuste, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalSemReajuste, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, -1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(672, 82);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lblPercentualDoReajuste
            // 
            this.lblPercentualDoReajuste.AutoSize = true;
            this.lblPercentualDoReajuste.BackColor = System.Drawing.Color.Yellow;
            this.lblPercentualDoReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentualDoReajuste.Location = new System.Drawing.Point(466, 1);
            this.lblPercentualDoReajuste.Name = "lblPercentualDoReajuste";
            this.lblPercentualDoReajuste.Size = new System.Drawing.Size(198, 25);
            this.lblPercentualDoReajuste.TabIndex = 2;
            this.lblPercentualDoReajuste.Text = "Percentual reajuste";
            // 
            // lblTotalSemReajuste
            // 
            this.lblTotalSemReajuste.AutoSize = true;
            this.lblTotalSemReajuste.BackColor = System.Drawing.Color.Yellow;
            this.lblTotalSemReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSemReajuste.Location = new System.Drawing.Point(4, 1);
            this.lblTotalSemReajuste.Name = "lblTotalSemReajuste";
            this.lblTotalSemReajuste.Size = new System.Drawing.Size(190, 25);
            this.lblTotalSemReajuste.TabIndex = 0;
            this.lblTotalSemReajuste.Text = "Total sem reajuste";
            // 
            // lblTotalComReajuste
            // 
            this.lblTotalComReajuste.AutoSize = true;
            this.lblTotalComReajuste.BackColor = System.Drawing.Color.Yellow;
            this.lblTotalComReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalComReajuste.Location = new System.Drawing.Point(237, 1);
            this.lblTotalComReajuste.Name = "lblTotalComReajuste";
            this.lblTotalComReajuste.Size = new System.Drawing.Size(190, 25);
            this.lblTotalComReajuste.TabIndex = 1;
            this.lblTotalComReajuste.Text = "Total com reajuste";
            // 
            // dgvLeitura
            // 
            this.dgvLeitura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeitura.Location = new System.Drawing.Point(34, 177);
            this.dgvLeitura.Name = "dgvLeitura";
            this.dgvLeitura.RowHeadersWidth = 51;
            this.dgvLeitura.RowTemplate.Height = 24;
            this.dgvLeitura.Size = new System.Drawing.Size(672, 275);
            this.dgvLeitura.TabIndex = 5;
            // 
            // ofdListaFuncionarios
            // 
            this.ofdListaFuncionarios.DefaultExt = "*.txt";
            this.ofdListaFuncionarios.FileName = "DadosFolha";
            this.ofdListaFuncionarios.Filter = "Arquivos texto|*.txt";
            this.ofdListaFuncionarios.Title = "Seleção do arquivo com dados de funcionários";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 472);
            this.Controls.Add(this.dgvLeitura);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSelecionarArquivo);
            this.Controls.Add(this.txtArquivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Button btnSelecionarArquivo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPercentualDoReajuste;
        private System.Windows.Forms.Label lblTotalSemReajuste;
        private System.Windows.Forms.Label lblTotalComReajuste;
        private System.Windows.Forms.DataGridView dgvLeitura;
        private System.Windows.Forms.OpenFileDialog ofdListaFuncionarios;
    }
}

