namespace CalculadoraWF
{
    partial class Calculadora
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
            lblResultado = new Label();
            btnSete = new Button();
            btnOito = new Button();
            btnNove = new Button();
            btnQuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnUm = new Button();
            btnDois = new Button();
            btnTres = new Button();
            btnZero = new Button();
            btnIgual = new Button();
            btnCE = new Button();
            btnSoma = new Button();
            btnSubtracao = new Button();
            lblOperacao = new Label();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Verdana", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(74, 51);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(228, 45);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Resultado";
            // 
            // btnSete
            // 
            btnSete.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSete.Location = new Point(64, 218);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(75, 60);
            btnSete.TabIndex = 1;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // btnOito
            // 
            btnOito.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOito.Location = new Point(150, 218);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(75, 60);
            btnOito.TabIndex = 2;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += btnOito_Click;
            // 
            // btnNove
            // 
            btnNove.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNove.Location = new Point(236, 218);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(75, 60);
            btnNove.TabIndex = 3;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = true;
            btnNove.Click += btnNove_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuatro.Location = new Point(64, 284);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(75, 60);
            btnQuatro.TabIndex = 4;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = true;
            btnQuatro.Click += btnQuatro_Click_1;
            // 
            // btnCinco
            // 
            btnCinco.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCinco.Location = new Point(150, 284);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(75, 60);
            btnCinco.TabIndex = 5;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnSeis
            // 
            btnSeis.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeis.Location = new Point(236, 284);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(75, 60);
            btnSeis.TabIndex = 6;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnUm
            // 
            btnUm.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUm.Location = new Point(64, 350);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(75, 60);
            btnUm.TabIndex = 7;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // btnDois
            // 
            btnDois.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDois.Location = new Point(150, 350);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(75, 60);
            btnDois.TabIndex = 8;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += btnDois_Click;
            // 
            // btnTres
            // 
            btnTres.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTres.Location = new Point(236, 350);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(75, 60);
            btnTres.TabIndex = 9;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click;
            // 
            // btnZero
            // 
            btnZero.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnZero.Location = new Point(150, 416);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(75, 60);
            btnZero.TabIndex = 10;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.RoyalBlue;
            btnIgual.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
            btnIgual.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIgual.ForeColor = SystemColors.HighlightText;
            btnIgual.Location = new Point(236, 416);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(75, 60);
            btnIgual.TabIndex = 11;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnCE
            // 
            btnCE.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCE.Location = new Point(64, 159);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(75, 53);
            btnCE.TabIndex = 12;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += btnCE_Click;
            // 
            // btnSoma
            // 
            btnSoma.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSoma.Location = new Point(150, 159);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(75, 53);
            btnSoma.TabIndex = 13;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubtracao.Location = new Point(236, 160);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(75, 53);
            btnSubtracao.TabIndex = 14;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOperacao.Location = new Point(101, 96);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(168, 35);
            lblOperacao.TabIndex = 15;
            lblOperacao.Text = "Operacao";
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 508);
            Controls.Add(lblOperacao);
            Controls.Add(btnSubtracao);
            Controls.Add(btnSoma);
            Controls.Add(btnCE);
            Controls.Add(btnIgual);
            Controls.Add(btnZero);
            Controls.Add(btnTres);
            Controls.Add(btnDois);
            Controls.Add(btnUm);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(lblResultado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Calculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += Calculadora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private Button btnSete;
        private Button btnOito;
        private Button btnNove;
        private Button btnQuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnUm;
        private Button btnDois;
        private Button btnTres;
        private Button btnZero;
        private Button btnIgual;
        private Button btnCE;
        private Button btnSoma;
        private Button btnSubtracao;
        private Label lblOperacao;
    }
}
