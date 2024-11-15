namespace ProjetoEletricista
{
    partial class FormHistorico
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxHistoricoTensao; // ListBox adicionado corretamente

        /// <summary>
        /// Limpar recursos sendo usados.
        /// </summary>
        /// <param name="disposing"></param>
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
        /// Método obrigatório para o Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxHistoricoTensao = new ListBox();
            BtnSairFormHistorico = new Button();
            BtnVoltarFormHistorico = new Button();
            BtnLimparFormHistorico = new Button();
            listBoxHistoricoResistencia = new ListBox();
            listBoxHistoricoCorrente = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBoxHistoricoTensao
            // 
            listBoxHistoricoTensao.AccessibleDescription = "Cálculo de Tensão";
            listBoxHistoricoTensao.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxHistoricoTensao.FormattingEnabled = true;
            listBoxHistoricoTensao.ItemHeight = 23;
            listBoxHistoricoTensao.Location = new Point(11, 39);
            listBoxHistoricoTensao.Margin = new Padding(2);
            listBoxHistoricoTensao.Name = "listBoxHistoricoTensao";
            listBoxHistoricoTensao.Size = new Size(745, 142);
            listBoxHistoricoTensao.TabIndex = 0;
            listBoxHistoricoTensao.SelectedIndexChanged += listBoxHistoricoTensao_SelectedIndexChanged;
            // 
            // BtnSairFormHistorico
            // 
            BtnSairFormHistorico.Cursor = Cursors.Hand;
            BtnSairFormHistorico.FlatAppearance.BorderColor = Color.Black;
            BtnSairFormHistorico.FlatAppearance.BorderSize = 3;
            BtnSairFormHistorico.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            BtnSairFormHistorico.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            BtnSairFormHistorico.FlatStyle = FlatStyle.Flat;
            BtnSairFormHistorico.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSairFormHistorico.Image = Properties.Resources.sair2;
            BtnSairFormHistorico.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSairFormHistorico.Location = new Point(538, 601);
            BtnSairFormHistorico.Margin = new Padding(2);
            BtnSairFormHistorico.Name = "BtnSairFormHistorico";
            BtnSairFormHistorico.Size = new Size(150, 50);
            BtnSairFormHistorico.TabIndex = 1;
            BtnSairFormHistorico.Text = "Sair";
            BtnSairFormHistorico.UseVisualStyleBackColor = true;
            BtnSairFormHistorico.Click += BtnSairFormHistorico_Click;
            // 
            // BtnVoltarFormHistorico
            // 
            BtnVoltarFormHistorico.Cursor = Cursors.Hand;
            BtnVoltarFormHistorico.FlatAppearance.BorderColor = Color.Black;
            BtnVoltarFormHistorico.FlatAppearance.BorderSize = 3;
            BtnVoltarFormHistorico.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            BtnVoltarFormHistorico.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            BtnVoltarFormHistorico.FlatStyle = FlatStyle.Flat;
            BtnVoltarFormHistorico.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVoltarFormHistorico.Image = Properties.Resources.voltar;
            BtnVoltarFormHistorico.ImageAlign = ContentAlignment.MiddleLeft;
            BtnVoltarFormHistorico.Location = new Point(86, 601);
            BtnVoltarFormHistorico.Margin = new Padding(2);
            BtnVoltarFormHistorico.Name = "BtnVoltarFormHistorico";
            BtnVoltarFormHistorico.Size = new Size(150, 50);
            BtnVoltarFormHistorico.TabIndex = 2;
            BtnVoltarFormHistorico.Text = "Voltar";
            BtnVoltarFormHistorico.UseVisualStyleBackColor = true;
            BtnVoltarFormHistorico.Click += BtnVoltarFormHistorico_Click;
            // 
            // BtnLimparFormHistorico
            // 
            BtnLimparFormHistorico.Cursor = Cursors.Hand;
            BtnLimparFormHistorico.FlatAppearance.BorderColor = Color.Black;
            BtnLimparFormHistorico.FlatAppearance.BorderSize = 3;
            BtnLimparFormHistorico.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            BtnLimparFormHistorico.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            BtnLimparFormHistorico.FlatStyle = FlatStyle.Flat;
            BtnLimparFormHistorico.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLimparFormHistorico.Image = Properties.Resources.limpar1;
            BtnLimparFormHistorico.ImageAlign = ContentAlignment.MiddleLeft;
            BtnLimparFormHistorico.Location = new Point(312, 601);
            BtnLimparFormHistorico.Margin = new Padding(2);
            BtnLimparFormHistorico.Name = "BtnLimparFormHistorico";
            BtnLimparFormHistorico.Size = new Size(150, 50);
            BtnLimparFormHistorico.TabIndex = 3;
            BtnLimparFormHistorico.Text = "   Limpar";
            BtnLimparFormHistorico.UseVisualStyleBackColor = true;
            BtnLimparFormHistorico.Click += BtnLimparFormHistorico_Click;
            // 
            // listBoxHistoricoResistencia
            // 
            listBoxHistoricoResistencia.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxHistoricoResistencia.FormattingEnabled = true;
            listBoxHistoricoResistencia.ItemHeight = 23;
            listBoxHistoricoResistencia.Location = new Point(11, 227);
            listBoxHistoricoResistencia.Margin = new Padding(2);
            listBoxHistoricoResistencia.Name = "listBoxHistoricoResistencia";
            listBoxHistoricoResistencia.Size = new Size(745, 142);
            listBoxHistoricoResistencia.TabIndex = 4;
            // 
            // listBoxHistoricoCorrente
            // 
            listBoxHistoricoCorrente.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxHistoricoCorrente.FormattingEnabled = true;
            listBoxHistoricoCorrente.ItemHeight = 23;
            listBoxHistoricoCorrente.Location = new Point(11, 412);
            listBoxHistoricoCorrente.Margin = new Padding(2);
            listBoxHistoricoCorrente.Name = "listBoxHistoricoCorrente";
            listBoxHistoricoCorrente.Size = new Size(745, 142);
            listBoxHistoricoCorrente.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Image = Properties.Resources.tensão1;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(11, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(225, 24);
            label1.TabIndex = 6;
            label1.Text = "     Cálculos de Tensão";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Image = Properties.Resources.resistência;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(11, 201);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(271, 24);
            label2.TabIndex = 7;
            label2.Text = "      Cálculos de Resistência";
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Image = Properties.Resources.tensão;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(11, 386);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(245, 24);
            label3.TabIndex = 8;
            label3.Text = "      Cálculos de Corrente";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Eletrica;
            pictureBox1.Location = new Point(-3, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(798, 714);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // FormHistorico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 702);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxHistoricoCorrente);
            Controls.Add(listBoxHistoricoResistencia);
            Controls.Add(BtnLimparFormHistorico);
            Controls.Add(BtnVoltarFormHistorico);
            Controls.Add(BtnSairFormHistorico);
            Controls.Add(listBoxHistoricoTensao);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "FormHistorico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Histórico de Cálculos";
            Load += FormHistorico_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSairFormHistorico;
        private Button BtnVoltarFormHistorico;
        private Button BtnLimparFormHistorico;
        private ListBox listBoxHistoricoResistencia;
        private ListBox listBoxHistoricoCorrente;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
    }
}