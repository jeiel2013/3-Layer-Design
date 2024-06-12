namespace _3CamadasJeiel
{
    partial class FormCadastro
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
            textBoxId = new TextBox();
            labelId = new Label();
            labelNome = new Label();
            textBoxNome = new TextBox();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            buttonInserir = new Button();
            buttonExcluir = new Button();
            buttonAlterar = new Button();
            gridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            SuspendLayout();
            // 
            // textBoxId
            // 
            textBoxId.Font = new Font("Segoe UI", 14F);
            textBoxId.Location = new Point(34, 55);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(128, 32);
            textBoxId.TabIndex = 0;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 14F);
            labelId.Location = new Point(29, 27);
            labelId.Name = "labelId";
            labelId.Size = new Size(30, 25);
            labelId.TabIndex = 1;
            labelId.Text = "ID";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 14F);
            labelNome.Location = new Point(199, 27);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(63, 25);
            labelNome.TabIndex = 2;
            labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            textBoxNome.Font = new Font("Segoe UI", 14F);
            textBoxNome.Location = new Point(205, 55);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(409, 32);
            textBoxNome.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 14F);
            textBoxEmail.Location = new Point(34, 128);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(580, 32);
            textBoxEmail.TabIndex = 4;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 14F);
            labelEmail.Location = new Point(29, 100);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(58, 25);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email";
            // 
            // buttonInserir
            // 
            buttonInserir.Font = new Font("Segoe UI", 14F);
            buttonInserir.Location = new Point(501, 171);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Size = new Size(113, 38);
            buttonInserir.TabIndex = 6;
            buttonInserir.Text = "Inserir";
            buttonInserir.UseVisualStyleBackColor = true;
            buttonInserir.Click += buttonInserir_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Font = new Font("Segoe UI", 14F);
            buttonExcluir.Location = new Point(382, 170);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(113, 38);
            buttonExcluir.TabIndex = 7;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonAlterar
            // 
            buttonAlterar.Font = new Font("Segoe UI", 14F);
            buttonAlterar.Location = new Point(263, 169);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(113, 38);
            buttonAlterar.TabIndex = 8;
            buttonAlterar.Text = "Alterar";
            buttonAlterar.UseVisualStyleBackColor = true;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // gridView
            // 
            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = false;
            gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView.Location = new Point(34, 220);
            gridView.Name = "gridView";
            gridView.ReadOnly = true;
            gridView.Size = new Size(580, 289);
            gridView.TabIndex = 9;
            gridView.CellContentClick += gridView_CellContentClick;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 521);
            Controls.Add(gridView);
            Controls.Add(buttonAlterar);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonInserir);
            Controls.Add(labelEmail);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxNome);
            Controls.Add(labelNome);
            Controls.Add(labelId);
            Controls.Add(textBoxId);
            Name = "FormCadastro";
            Text = "Projeto 3 Camadas";
            Load += FormCadastro_Load;
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxId;
        private Label labelId;
        private Label labelNome;
        private TextBox textBoxNome;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private Button buttonInserir;
        private Button buttonExcluir;
        private Button buttonAlterar;
        private DataGridView gridView;
    }
}
