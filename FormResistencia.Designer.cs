namespace ProjetoEletricista
{
    partial class FormResistencia
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
            TxtCorrenteFormResistencia = new TextBox();
            TxtTensaoFormResistencia = new TextBox();
            LblTensaoFormResistencia = new Label();
            LblCorrenteFormResistencia = new Label();
            BtnCalcularFormResistecia = new Button();
            pictureBox1 = new PictureBox();
            BtnSairFormCalculoResistencia = new Button();
            BtnVoltarFormCalculoResistencia = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TxtCorrenteFormResistencia
            // 
            TxtCorrenteFormResistencia.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtCorrenteFormResistencia.Location = new Point(386, 192);
            TxtCorrenteFormResistencia.Margin = new Padding(2);
            TxtCorrenteFormResistencia.Name = "TxtCorrenteFormResistencia";
            TxtCorrenteFormResistencia.Size = new Size(150, 30);
            TxtCorrenteFormResistencia.TabIndex = 2;
            // 
            // TxtTensaoFormResistencia
            // 
            TxtTensaoFormResistencia.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtTensaoFormResistencia.Location = new Point(386, 123);
            TxtTensaoFormResistencia.Margin = new Padding(2);
            TxtTensaoFormResistencia.Name = "TxtTensaoFormResistencia";
            TxtTensaoFormResistencia.Size = new Size(150, 30);
            TxtTensaoFormResistencia.TabIndex = 3;
            // 
            // LblTensaoFormResistencia
            // 
            LblTensaoFormResistencia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblTensaoFormResistencia.AutoSize = true;
            LblTensaoFormResistencia.BackColor = Color.White;
            LblTensaoFormResistencia.FlatStyle = FlatStyle.Flat;
            LblTensaoFormResistencia.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTensaoFormResistencia.Location = new Point(233, 123);
            LblTensaoFormResistencia.Margin = new Padding(2, 0, 2, 0);
            LblTensaoFormResistencia.Name = "LblTensaoFormResistencia";
            LblTensaoFormResistencia.Size = new Size(112, 28);
            LblTensaoFormResistencia.TabIndex = 5;
            LblTensaoFormResistencia.Text = "Tensão (V)";
            LblTensaoFormResistencia.TextAlign = ContentAlignment.MiddleCenter;
            LblTensaoFormResistencia.UseCompatibleTextRendering = true;
            // 
            // LblCorrenteFormResistencia
            // 
            LblCorrenteFormResistencia.AutoSize = true;
            LblCorrenteFormResistencia.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCorrenteFormResistencia.Location = new Point(219, 192);
            LblCorrenteFormResistencia.Margin = new Padding(2, 0, 2, 0);
            LblCorrenteFormResistencia.Name = "LblCorrenteFormResistencia";
            LblCorrenteFormResistencia.Size = new Size(126, 24);
            LblCorrenteFormResistencia.TabIndex = 6;
            LblCorrenteFormResistencia.Text = "Corrente (A)";
            // 
            // BtnCalcularFormResistecia
            // 
            BtnCalcularFormResistecia.Cursor = Cursors.Hand;
            BtnCalcularFormResistecia.FlatAppearance.BorderColor = Color.Black;
            BtnCalcularFormResistecia.FlatAppearance.BorderSize = 3;
            BtnCalcularFormResistecia.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            BtnCalcularFormResistecia.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            BtnCalcularFormResistecia.FlatStyle = FlatStyle.Flat;
            BtnCalcularFormResistecia.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCalcularFormResistecia.Image = Properties.Resources.resistência;
            BtnCalcularFormResistecia.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCalcularFormResistecia.Location = new Point(299, 333);
            BtnCalcularFormResistecia.Margin = new Padding(2);
            BtnCalcularFormResistecia.Name = "BtnCalcularFormResistecia";
            BtnCalcularFormResistecia.Size = new Size(150, 50);
            BtnCalcularFormResistecia.TabIndex = 8;
            BtnCalcularFormResistecia.Text = "   Calcular";
            BtnCalcularFormResistecia.UseVisualStyleBackColor = true;
            BtnCalcularFormResistecia.Click += BtnCalcularFormResistecia_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Eletrica;
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(783, 455);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // BtnSairFormCalculoResistencia
            // 
            BtnSairFormCalculoResistencia.Cursor = Cursors.Hand;
            BtnSairFormCalculoResistencia.FlatAppearance.BorderColor = Color.Black;
            BtnSairFormCalculoResistencia.FlatAppearance.BorderSize = 3;
            BtnSairFormCalculoResistencia.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            BtnSairFormCalculoResistencia.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            BtnSairFormCalculoResistencia.FlatStyle = FlatStyle.Flat;
            BtnSairFormCalculoResistencia.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSairFormCalculoResistencia.Image = Properties.Resources.sair2;
            BtnSairFormCalculoResistencia.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSairFormCalculoResistencia.Location = new Point(499, 333);
            BtnSairFormCalculoResistencia.Margin = new Padding(2);
            BtnSairFormCalculoResistencia.Name = "BtnSairFormCalculoResistencia";
            BtnSairFormCalculoResistencia.Size = new Size(150, 50);
            BtnSairFormCalculoResistencia.TabIndex = 12;
            BtnSairFormCalculoResistencia.Text = "Sair";
            BtnSairFormCalculoResistencia.UseVisualStyleBackColor = true;
            BtnSairFormCalculoResistencia.Click += BtnSairFormCalculoResistencia_Click;
            // 
            // BtnVoltarFormCalculoResistencia
            // 
            BtnVoltarFormCalculoResistencia.Cursor = Cursors.Hand;
            BtnVoltarFormCalculoResistencia.FlatAppearance.BorderColor = Color.Black;
            BtnVoltarFormCalculoResistencia.FlatAppearance.BorderSize = 3;
            BtnVoltarFormCalculoResistencia.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            BtnVoltarFormCalculoResistencia.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            BtnVoltarFormCalculoResistencia.FlatStyle = FlatStyle.Flat;
            BtnVoltarFormCalculoResistencia.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVoltarFormCalculoResistencia.Image = Properties.Resources.voltar;
            BtnVoltarFormCalculoResistencia.ImageAlign = ContentAlignment.MiddleLeft;
            BtnVoltarFormCalculoResistencia.Location = new Point(104, 333);
            BtnVoltarFormCalculoResistencia.Margin = new Padding(2);
            BtnVoltarFormCalculoResistencia.Name = "BtnVoltarFormCalculoResistencia";
            BtnVoltarFormCalculoResistencia.Size = new Size(150, 50);
            BtnVoltarFormCalculoResistencia.TabIndex = 11;
            BtnVoltarFormCalculoResistencia.Text = "Voltar";
            BtnVoltarFormCalculoResistencia.UseVisualStyleBackColor = true;
            BtnVoltarFormCalculoResistencia.Click += BtnVoltarFormCalculoResistencia_Click;
            // 
            // FormResistencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(BtnSairFormCalculoResistencia);
            Controls.Add(BtnVoltarFormCalculoResistencia);
            Controls.Add(BtnCalcularFormResistecia);
            Controls.Add(LblCorrenteFormResistencia);
            Controls.Add(LblTensaoFormResistencia);
            Controls.Add(TxtTensaoFormResistencia);
            Controls.Add(TxtCorrenteFormResistencia);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "FormResistencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cálculo de Resistencia";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TxtCorrenteFormResistencia;
        private TextBox TxtTensaoFormResistencia;
        private Label LblTensaoFormResistencia;
        private Label LblCorrenteFormResistencia;
        private Button BtnCalcularFormResistecia;
        private PictureBox pictureBox1;
        private Button BtnSairFormCalculoResistencia;
        private Button BtnVoltarFormCalculoResistencia;
    }
}