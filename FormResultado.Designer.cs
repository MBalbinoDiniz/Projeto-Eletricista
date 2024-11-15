namespace ProjetoEletricista
{
    partial class FormResultado
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
            BtnVoltarFormResultado = new Button();
            BtnSairFormResultado = new Button();
            LblResultado = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnVoltarFormResultado
            // 
            BtnVoltarFormResultado.Cursor = Cursors.Hand;
            BtnVoltarFormResultado.FlatAppearance.BorderColor = Color.Black;
            BtnVoltarFormResultado.FlatAppearance.BorderSize = 3;
            BtnVoltarFormResultado.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            BtnVoltarFormResultado.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            BtnVoltarFormResultado.FlatStyle = FlatStyle.Flat;
            BtnVoltarFormResultado.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVoltarFormResultado.Image = Properties.Resources.voltar;
            BtnVoltarFormResultado.ImageAlign = ContentAlignment.MiddleLeft;
            BtnVoltarFormResultado.Location = new Point(196, 348);
            BtnVoltarFormResultado.Margin = new Padding(2);
            BtnVoltarFormResultado.Name = "BtnVoltarFormResultado";
            BtnVoltarFormResultado.Size = new Size(150, 50);
            BtnVoltarFormResultado.TabIndex = 0;
            BtnVoltarFormResultado.Text = "Voltar";
            BtnVoltarFormResultado.UseVisualStyleBackColor = true;
            BtnVoltarFormResultado.Click += BtnVoltarFormResultado_Click;
            // 
            // BtnSairFormResultado
            // 
            BtnSairFormResultado.Cursor = Cursors.Hand;
            BtnSairFormResultado.FlatAppearance.BorderColor = Color.Black;
            BtnSairFormResultado.FlatAppearance.BorderSize = 3;
            BtnSairFormResultado.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            BtnSairFormResultado.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            BtnSairFormResultado.FlatStyle = FlatStyle.Flat;
            BtnSairFormResultado.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSairFormResultado.Image = Properties.Resources.sair2;
            BtnSairFormResultado.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSairFormResultado.Location = new Point(473, 348);
            BtnSairFormResultado.Margin = new Padding(2);
            BtnSairFormResultado.Name = "BtnSairFormResultado";
            BtnSairFormResultado.Size = new Size(150, 50);
            BtnSairFormResultado.TabIndex = 1;
            BtnSairFormResultado.Text = "Sair";
            BtnSairFormResultado.UseVisualStyleBackColor = true;
            BtnSairFormResultado.Click += BtnSairFormResultado_Click;
            // 
            // LblResultado
            // 
            LblResultado.AutoSize = true;
            LblResultado.BackColor = SystemColors.Window;
            LblResultado.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblResultado.ForeColor = Color.Black;
            LblResultado.Location = new Point(196, 169);
            LblResultado.Margin = new Padding(2, 0, 2, 0);
            LblResultado.Name = "LblResultado";
            LblResultado.Size = new Size(192, 40);
            LblResultado.TabIndex = 2;
            LblResultado.Text = "Resultado:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Eletrica;
            pictureBox1.Location = new Point(1, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(781, 458);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FormResultado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(LblResultado);
            Controls.Add(BtnSairFormResultado);
            Controls.Add(BtnVoltarFormResultado);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "FormResultado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resultado";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnVoltarFormResultado;
        private Button BtnSairFormResultado;
        private Label LblResultado;
        private PictureBox pictureBox1;
    }
}