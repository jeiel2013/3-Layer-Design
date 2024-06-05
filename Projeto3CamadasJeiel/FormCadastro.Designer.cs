namespace Projeto3CamadasJeiel
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
            labelCodigo = new Label();
            textBoxNome = new TextBox();
            labelNome = new Label();
            labelCadastro = new Label();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            buttonInserir = new Button();
            dataGridView1 = new DataGridView();
            buttonExcluir = new Button();
            buttonAlterar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxId
            // 
            textBoxId.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxId.Location = new Point(12, 78);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(240, 33);
            textBoxId.TabIndex = 0;
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Font = new Font("Segoe UI", 14F);
            labelCodigo.Location = new Point(7, 50);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(73, 25);
            labelCodigo.TabIndex = 1;
            labelCodigo.Text = "Código";
            // 
            // textBoxNome
            // 
            textBoxNome.Font = new Font("Segoe UI", 14F);
            textBoxNome.Location = new Point(324, 78);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(464, 32);
            textBoxNome.TabIndex = 2;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 14F);
            labelNome.Location = new Point(318, 50);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(63, 25);
            labelNome.TabIndex = 3;
            labelNome.Text = "Nome";
            // 
            // labelCadastro
            // 
            labelCadastro.AutoSize = true;
            labelCadastro.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCadastro.Location = new Point(336, 4);
            labelCadastro.Name = "labelCadastro";
            labelCadastro.Size = new Size(99, 30);
            labelCadastro.TabIndex = 4;
            labelCadastro.Text = "Cadastro";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 14F);
            labelEmail.Location = new Point(6, 140);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(58, 25);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 14F);
            textBoxEmail.Location = new Point(12, 168);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(776, 32);
            textBoxEmail.TabIndex = 6;
            // 
            // buttonInserir
            // 
            buttonInserir.Font = new Font("Segoe UI", 14F);
            buttonInserir.Location = new Point(684, 400);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Size = new Size(104, 38);
            buttonInserir.TabIndex = 10;
            buttonInserir.Text = "Inserir";
            buttonInserir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 206);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(776, 188);
            dataGridView1.TabIndex = 11;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Font = new Font("Segoe UI", 14F);
            buttonExcluir.Location = new Point(574, 400);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(104, 38);
            buttonExcluir.TabIndex = 12;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // buttonAlterar
            // 
            buttonAlterar.Font = new Font("Segoe UI", 14F);
            buttonAlterar.Location = new Point(464, 400);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(104, 38);
            buttonAlterar.TabIndex = 13;
            buttonAlterar.Text = "Alterar";
            buttonAlterar.UseVisualStyleBackColor = true;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAlterar);
            Controls.Add(buttonExcluir);
            Controls.Add(dataGridView1);
            Controls.Add(buttonInserir);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(labelCadastro);
            Controls.Add(labelNome);
            Controls.Add(textBoxNome);
            Controls.Add(labelCodigo);
            Controls.Add(textBoxId);
            Name = "FormCadastro";
            Text = "Projeto 3 Camadas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxId;
        private Label labelCodigo;
        private TextBox textBoxNome;
        private Label labelNome;
        private Label labelCadastro;
        private Label labelEmail;
        private TextBox textBoxEmail;

        public Button btnAlterar { get; private set; }

        private Button button1;
        private Button button2;
        private Button button3;
        private Button buttonInserir;
        private DataGridView dataGridView1;
        private Button buttonExcluir;
        private Button buttonAlterar;

        public Control btnExcluir { get; private set; }
    }
}
