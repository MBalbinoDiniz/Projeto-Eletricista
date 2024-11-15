namespace ProjetoEletricista
{
    partial class FormTensao
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
            LblTensao = new Label();
            TxtCorrenteFormTensao = new TextBox();
            TxtResistenciaFormTensao = new TextBox();
            LblResistencia = new Label();
            BtnCalcularFormTensao = new Button();
            pictureBox1 = new PictureBox();
            BtnSairFormCalculoTensao = new Button();
            BtnVoltarFormCalculoTensao = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LblTensao
            // 
            LblTensao.AutoSize = true;
            LblTensao.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTensao.Location = new Point(273, 136);
            LblTensao.Margin = new Padding(2, 0, 2, 0);
            LblTensao.Name = "LblTensao";
            LblTensao.Size = new Size(126, 24);
            LblTensao.TabIndex = 2;
            LblTensao.Text = "Corrente (A)";
            // 
            // TxtCorrenteFormTensao
            // 
            TxtCorrenteFormTensao.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtCorrenteFormTensao.Location = new Point(407, 136);
            TxtCorrenteFormTensao.Margin = new Padding(2);
            TxtCorrenteFormTensao.Name = "TxtCorrenteFormTensao";
            TxtCorrenteFormTensao.Size = new Size(121, 30);
            TxtCorrenteFormTensao.TabIndex = 3;
            // 
            // TxtResistenciaFormTensao
            // 
            TxtResistenciaFormTensao.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtResistenciaFormTensao.Location = new Point(407, 177);
            TxtResistenciaFormTensao.Margin = new Padding(2);
            TxtResistenciaFormTensao.Name = "TxtResistenciaFormTensao";
            TxtResistenciaFormTensao.Size = new Size(121, 30);
            TxtResistenciaFormTensao.TabIndex = 4;
            // 
            // LblResistencia
            // 
            LblResistencia.AutoSize = true;
            LblResistencia.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblResistencia.Location = new Point(244, 179);
            LblResistencia.Margin = new Padding(2, 0, 2, 0);
            LblResistencia.Name = "LblResistencia";
            LblResistencia.Size = new Size(155, 24);
            LblResistencia.TabIndex = 5;
            LblResistencia.Text = "Resistência (Ω)";
            // 
            // BtnCalcularFormTensao
            // 
            BtnCalcularFormTensao.Cursor = Cursors.Hand;
            BtnCalcularFormTensao.FlatAppearance.BorderColor = Color.Black;
            BtnCalcularFormTensao.FlatAppearance.BorderSize = 3;
            BtnCalcularFormTensao.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            BtnCalcularFormTensao.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            BtnCalcularFormTensao.FlatStyle = FlatStyle.Flat;
            BtnCalcularFormTensao.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCalcularFormTensao.Image = Properties.Resources.tensão1;
            BtnCalcularFormTensao.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCalcularFormTensao.Location = new Point(327, 339);
            BtnCalcularFormTensao.Margin = new Padding(2);
            BtnCalcularFormTensao.Name = "BtnCalcularFormTensao";
            BtnCalcularFormTensao.Size = new Size(150, 50);
            BtnCalcularFormTensao.TabIndex = 8;
            BtnCalcularFormTensao.Text = "   Calcular";
            BtnCalcularFormTensao.UseVisualStyleBackColor = true;
            BtnCalcularFormTensao.Click += BtnCalcularFormTensao_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Eletrica;
            pictureBox1.Location = new Point(-6, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(788, 456);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // BtnSairFormCalculoTensao
            // 
            BtnSairFormCalculoTensao.Cursor = Cursors.Hand;
            BtnSairFormCalculoTensao.FlatAppearance.BorderColor = Color.Black;
            BtnSairFormCalculoTensao.FlatAppearance.BorderSize = 3;
            BtnSairFormCalculoTensao.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            BtnSairFormCalculoTensao.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            BtnSairFormCalculoTensao.FlatStyle = FlatStyle.Flat;
            BtnSairFormCalculoTensao.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSairFormCalculoTensao.Image = Properties.Resources.sair2;
            BtnSairFormCalculoTensao.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSairFormCalculoTensao.Location = new Point(522, 339);
            BtnSairFormCalculoTensao.Margin = new Padding(2);
            BtnSairFormCalculoTensao.Name = "BtnSairFormCalculoTensao";
            BtnSairFormCalculoTensao.Size = new Size(150, 50);
            BtnSairFormCalculoTensao.TabIndex = 12;
            BtnSairFormCalculoTensao.Text = "Sair";
            BtnSairFormCalculoTensao.UseVisualStyleBackColor = true;
            BtnSairFormCalculoTensao.Click += BtnSairFormCalculoTensao_Click;
            // 
            // BtnVoltarFormCalculoTensao
            // 
            BtnVoltarFormCalculoTensao.Cursor = Cursors.Hand;
            BtnVoltarFormCalculoTensao.FlatAppearance.BorderColor = Color.Black;
            BtnVoltarFormCalculoTensao.FlatAppearance.BorderSize = 3;
            BtnVoltarFormCalculoTensao.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            BtnVoltarFormCalculoTensao.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            BtnVoltarFormCalculoTensao.FlatStyle = FlatStyle.Flat;
            BtnVoltarFormCalculoTensao.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVoltarFormCalculoTensao.Image = Properties.Resources.voltar;
            BtnVoltarFormCalculoTensao.ImageAlign = ContentAlignment.MiddleLeft;
            BtnVoltarFormCalculoTensao.Location = new Point(127, 339);
            BtnVoltarFormCalculoTensao.Margin = new Padding(2);
            BtnVoltarFormCalculoTensao.Name = "BtnVoltarFormCalculoTensao";
            BtnVoltarFormCalculoTensao.Size = new Size(150, 50);
            BtnVoltarFormCalculoTensao.TabIndex = 11;
            BtnVoltarFormCalculoTensao.Text = "Voltar";
            BtnVoltarFormCalculoTensao.UseVisualStyleBackColor = true;
            BtnVoltarFormCalculoTensao.Click += BtnVoltarFormCalculoTensao_Click;
            // 
            // FormTensao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(BtnSairFormCalculoTensao);
            Controls.Add(BtnVoltarFormCalculoTensao);
            Controls.Add(BtnCalcularFormTensao);
            Controls.Add(LblResistencia);
            Controls.Add(TxtResistenciaFormTensao);
            Controls.Add(TxtCorrenteFormTensao);
            Controls.Add(LblTensao);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "FormTensao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cálculo de Tensão";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LblTensao;
        private TextBox TxtCorrenteFormTensao;
        private TextBox TxtResistenciaFormTensao;
        private Label LblResistencia;
        private Button BtnCalcularFormTensao;
        private PictureBox pictureBox1;
        private Button BtnSairFormCalculoTensao;
        private Button BtnVoltarFormCalculoTensao;
    }
}