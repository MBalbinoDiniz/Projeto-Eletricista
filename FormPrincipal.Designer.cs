namespace ProjetoEletricista
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnTensao = new Button();
            BtnResistencia = new Button();
            BtnCorrente = new Button();
            BtnHistorico = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnTensao
            // 
            BtnTensao.Cursor = Cursors.Hand;
            BtnTensao.FlatAppearance.BorderColor = Color.Black;
            BtnTensao.FlatAppearance.BorderSize = 3;
            BtnTensao.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            BtnTensao.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            BtnTensao.FlatStyle = FlatStyle.Flat;
            BtnTensao.Font = new Font("Arial", 12F, FontStyle.Bold);
            BtnTensao.ForeColor = SystemColors.ActiveCaptionText;
            BtnTensao.Image = Properties.Resources.tensão1;
            BtnTensao.ImageAlign = ContentAlignment.MiddleLeft;
            BtnTensao.Location = new Point(55, 259);
            BtnTensao.Margin = new Padding(2);
            BtnTensao.Name = "BtnTensao";
            BtnTensao.Size = new Size(150, 50);
            BtnTensao.TabIndex = 0;
            BtnTensao.Text = "   Tensão";
            BtnTensao.UseVisualStyleBackColor = true;
            BtnTensao.Click += BtnTensao_Click;
            // 
            // BtnResistencia
            // 
            BtnResistencia.Cursor = Cursors.Hand;
            BtnResistencia.FlatAppearance.BorderColor = Color.Black;
            BtnResistencia.FlatAppearance.BorderSize = 3;
            BtnResistencia.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            BtnResistencia.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            BtnResistencia.FlatStyle = FlatStyle.Flat;
            BtnResistencia.Font = new Font("Arial", 12F, FontStyle.Bold);
            BtnResistencia.Image = Properties.Resources.resistência;
            BtnResistencia.ImageAlign = ContentAlignment.MiddleLeft;
            BtnResistencia.Location = new Point(225, 259);
            BtnResistencia.Margin = new Padding(2);
            BtnResistencia.Name = "BtnResistencia";
            BtnResistencia.Size = new Size(164, 50);
            BtnResistencia.TabIndex = 1;
            BtnResistencia.Text = "    Resitência";
            BtnResistencia.UseVisualStyleBackColor = true;
            BtnResistencia.Click += BtnResistencia_Click;
            // 
            // BtnCorrente
            // 
            BtnCorrente.Cursor = Cursors.Hand;
            BtnCorrente.FlatAppearance.BorderColor = Color.Black;
            BtnCorrente.FlatAppearance.BorderSize = 3;
            BtnCorrente.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            BtnCorrente.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            BtnCorrente.FlatStyle = FlatStyle.Flat;
            BtnCorrente.Font = new Font("Arial", 12F, FontStyle.Bold);
            BtnCorrente.Image = Properties.Resources.corrente;
            BtnCorrente.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCorrente.Location = new Point(406, 259);
            BtnCorrente.Margin = new Padding(2);
            BtnCorrente.Name = "BtnCorrente";
            BtnCorrente.Size = new Size(150, 50);
            BtnCorrente.TabIndex = 2;
            BtnCorrente.Text = "    Corrente";
            BtnCorrente.UseVisualStyleBackColor = true;
            BtnCorrente.Click += BtnCorrente_Click;
            // 
            // BtnHistorico
            // 
            BtnHistorico.Cursor = Cursors.Hand;
            BtnHistorico.FlatAppearance.BorderColor = Color.Black;
            BtnHistorico.FlatAppearance.BorderSize = 3;
            BtnHistorico.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            BtnHistorico.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            BtnHistorico.FlatStyle = FlatStyle.Flat;
            BtnHistorico.Font = new Font("Arial", 12F, FontStyle.Bold);
            BtnHistorico.Image = Properties.Resources.historico;
            BtnHistorico.ImageAlign = ContentAlignment.MiddleLeft;
            BtnHistorico.Location = new Point(573, 259);
            BtnHistorico.Margin = new Padding(2);
            BtnHistorico.Name = "BtnHistorico";
            BtnHistorico.Size = new Size(150, 50);
            BtnHistorico.TabIndex = 3;
            BtnHistorico.Text = "    Histórico";
            BtnHistorico.UseVisualStyleBackColor = true;
            BtnHistorico.Click += BtnHistorico_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Eletrica;
            pictureBox1.Location = new Point(-4, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(787, 463);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Yellow;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 95);
            label1.Name = "label1";
            label1.Size = new Size(654, 33);
            label1.TabIndex = 5;
            label1.Text = "ESCOLHA O CÁLCULO QUE DESEJA REALIZAR";
            label1.Click += label1_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(label1);
            Controls.Add(BtnHistorico);
            Controls.Add(BtnCorrente);
            Controls.Add(BtnResistencia);
            Controls.Add(BtnTensao);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ImeMode = ImeMode.On;
            Margin = new Padding(2);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cálculos Elétricos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnTensao;
        private Button BtnResistencia;
        private Button BtnCorrente;
        private Button BtnHistorico;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
