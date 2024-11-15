namespace ProjetoEletricista
{
    partial class FormCorrente
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
            LblREsistenciaFormCorrente = new Label();
            LblTensaoFormCorrente = new Label();
            BtnCalcularFormCorrente = new Button();
            TxtResistenciaFormCorrente = new TextBox();
            TxtTensaoFormCorrente = new TextBox();
            pictureBox1 = new PictureBox();
            BtnVoltarFormCalculoCorrente = new Button();
            BtnSairFormCalculoCorrente = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LblREsistenciaFormCorrente
            // 
            LblREsistenciaFormCorrente.AutoSize = true;
            LblREsistenciaFormCorrente.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblREsistenciaFormCorrente.Location = new Point(222, 130);
            LblREsistenciaFormCorrente.Margin = new Padding(2, 0, 2, 0);
            LblREsistenciaFormCorrente.Name = "LblREsistenciaFormCorrente";
            LblREsistenciaFormCorrente.Size = new Size(155, 24);
            LblREsistenciaFormCorrente.TabIndex = 2;
            LblREsistenciaFormCorrente.Text = "Resistência (Ω)";
            // 
            // LblTensaoFormCorrente
            // 
            LblTensaoFormCorrente.AutoSize = true;
            LblTensaoFormCorrente.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTensaoFormCorrente.Location = new Point(265, 190);
            LblTensaoFormCorrente.Margin = new Padding(2, 0, 2, 0);
            LblTensaoFormCorrente.Name = "LblTensaoFormCorrente";
            LblTensaoFormCorrente.Size = new Size(112, 24);
            LblTensaoFormCorrente.TabIndex = 3;
            LblTensaoFormCorrente.Text = "Tensão (V)";
            // 
            // BtnCalcularFormCorrente
            // 
            BtnCalcularFormCorrente.Cursor = Cursors.Hand;
            BtnCalcularFormCorrente.FlatAppearance.BorderColor = Color.Black;
            BtnCalcularFormCorrente.FlatAppearance.BorderSize = 3;
            BtnCalcularFormCorrente.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            BtnCalcularFormCorrente.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            BtnCalcularFormCorrente.FlatStyle = FlatStyle.Flat;
            BtnCalcularFormCorrente.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCalcularFormCorrente.Image = Properties.Resources.corrente;
            BtnCalcularFormCorrente.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCalcularFormCorrente.Location = new Point(309, 346);
            BtnCalcularFormCorrente.Margin = new Padding(2);
            BtnCalcularFormCorrente.Name = "BtnCalcularFormCorrente";
            BtnCalcularFormCorrente.Size = new Size(150, 50);
            BtnCalcularFormCorrente.TabIndex = 5;
            BtnCalcularFormCorrente.Text = "   Calcular";
            BtnCalcularFormCorrente.UseVisualStyleBackColor = true;
            BtnCalcularFormCorrente.Click += BtnCalcularFormCorrente_Click;
            // 
            // TxtResistenciaFormCorrente
            // 
            TxtResistenciaFormCorrente.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtResistenciaFormCorrente.Location = new Point(390, 130);
            TxtResistenciaFormCorrente.Margin = new Padding(2);
            TxtResistenciaFormCorrente.Name = "TxtResistenciaFormCorrente";
            TxtResistenciaFormCorrente.Size = new Size(121, 30);
            TxtResistenciaFormCorrente.TabIndex = 6;
            // 
            // TxtTensaoFormCorrente
            // 
            TxtTensaoFormCorrente.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtTensaoFormCorrente.Location = new Point(390, 187);
            TxtTensaoFormCorrente.Margin = new Padding(2);
            TxtTensaoFormCorrente.Name = "TxtTensaoFormCorrente";
            TxtTensaoFormCorrente.Size = new Size(121, 30);
            TxtTensaoFormCorrente.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Eletrica;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(786, 454);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // BtnVoltarFormCalculoCorrente
            // 
            BtnVoltarFormCalculoCorrente.Cursor = Cursors.Hand;
            BtnVoltarFormCalculoCorrente.FlatAppearance.BorderColor = Color.Black;
            BtnVoltarFormCalculoCorrente.FlatAppearance.BorderSize = 3;
            BtnVoltarFormCalculoCorrente.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            BtnVoltarFormCalculoCorrente.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            BtnVoltarFormCalculoCorrente.FlatStyle = FlatStyle.Flat;
            BtnVoltarFormCalculoCorrente.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVoltarFormCalculoCorrente.Image = Properties.Resources.voltar;
            BtnVoltarFormCalculoCorrente.ImageAlign = ContentAlignment.MiddleLeft;
            BtnVoltarFormCalculoCorrente.Location = new Point(117, 346);
            BtnVoltarFormCalculoCorrente.Margin = new Padding(2);
            BtnVoltarFormCalculoCorrente.Name = "BtnVoltarFormCalculoCorrente";
            BtnVoltarFormCalculoCorrente.Size = new Size(150, 50);
            BtnVoltarFormCalculoCorrente.TabIndex = 9;
            BtnVoltarFormCalculoCorrente.Text = "Voltar";
            BtnVoltarFormCalculoCorrente.UseVisualStyleBackColor = true;
            BtnVoltarFormCalculoCorrente.Click += BtnVoltarFormHistorico_Click;
            // 
            // BtnSairFormCalculoCorrente
            // 
            BtnSairFormCalculoCorrente.Cursor = Cursors.Hand;
            BtnSairFormCalculoCorrente.FlatAppearance.BorderColor = Color.Black;
            BtnSairFormCalculoCorrente.FlatAppearance.BorderSize = 3;
            BtnSairFormCalculoCorrente.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            BtnSairFormCalculoCorrente.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            BtnSairFormCalculoCorrente.FlatStyle = FlatStyle.Flat;
            BtnSairFormCalculoCorrente.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSairFormCalculoCorrente.Image = Properties.Resources.sair2;
            BtnSairFormCalculoCorrente.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSairFormCalculoCorrente.Location = new Point(512, 346);
            BtnSairFormCalculoCorrente.Margin = new Padding(2);
            BtnSairFormCalculoCorrente.Name = "BtnSairFormCalculoCorrente";
            BtnSairFormCalculoCorrente.Size = new Size(150, 50);
            BtnSairFormCalculoCorrente.TabIndex = 10;
            BtnSairFormCalculoCorrente.Text = "Sair";
            BtnSairFormCalculoCorrente.UseVisualStyleBackColor = true;
            BtnSairFormCalculoCorrente.Click += BtnSairFormCalculoCorrente_Click;
            // 
            // FormCorrente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(BtnSairFormCalculoCorrente);
            Controls.Add(BtnVoltarFormCalculoCorrente);
            Controls.Add(TxtTensaoFormCorrente);
            Controls.Add(TxtResistenciaFormCorrente);
            Controls.Add(BtnCalcularFormCorrente);
            Controls.Add(LblTensaoFormCorrente);
            Controls.Add(LblREsistenciaFormCorrente);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "FormCorrente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cálculo de Corrente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LblREsistenciaFormCorrente;
        private Label LblTensaoFormCorrente;
        private Button BtnCalcularFormCorrente;
        private TextBox TxtResistenciaFormCorrente;
        private TextBox TxtTensaoFormCorrente;
        private PictureBox pictureBox1;
        private Button BtnVoltarFormCalculoCorrente;
        private Button BtnSairFormCalculoCorrente;
    }
}