namespace TDSGerenciamentoLivros
{
    partial class Form1
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
            lblTitulo = new Label();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            lblAutor = new Label();
            txtId = new TextBox();
            lblId = new Label();
            txtEditora = new TextBox();
            lblEditora = new Label();
            txtAno = new TextBox();
            lblAno = new Label();
            txtEdicao = new TextBox();
            lblEdicao = new Label();
            txtPagina = new TextBox();
            lblPagina = new Label();
            txtIdioma = new TextBox();
            lblIdioma = new Label();
            lblGenero = new Label();
            cbGenero = new ComboBox();
            btnAdicionar = new Button();
            dgvGerenciadorLivros = new DataGridView();
            btnEditar = new DataGridViewButtonColumn();
            btnExcluir = new DataGridViewButtonColumn();
            titulo = new DataGridViewTextBoxColumn();
            autor = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            editora = new DataGridViewTextBoxColumn();
            ano = new DataGridViewTextBoxColumn();
            edicao = new DataGridViewTextBoxColumn();
            pagina = new DataGridViewTextBoxColumn();
            idioma = new DataGridViewTextBoxColumn();
            genero = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvGerenciadorLivros).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(37, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Título";
            // 
            // txtTitulo
            // 
            txtTitulo.AcceptsReturn = true;
            txtTitulo.Location = new Point(12, 27);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(100, 23);
            txtTitulo.TabIndex = 1;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(118, 27);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(100, 23);
            txtAutor.TabIndex = 3;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(118, 9);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(37, 15);
            lblAutor.TabIndex = 2;
            lblAutor.Text = "Autor";
            // 
            // txtId
            // 
            txtId.Location = new Point(224, 27);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 5;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(224, 9);
            lblId.Name = "lblId";
            lblId.Size = new Size(74, 15);
            lblId.TabIndex = 4;
            lblId.Text = "Identificador";
            // 
            // txtEditora
            // 
            txtEditora.Location = new Point(330, 27);
            txtEditora.Name = "txtEditora";
            txtEditora.Size = new Size(100, 23);
            txtEditora.TabIndex = 7;
            // 
            // lblEditora
            // 
            lblEditora.AutoSize = true;
            lblEditora.Location = new Point(330, 9);
            lblEditora.Name = "lblEditora";
            lblEditora.Size = new Size(44, 15);
            lblEditora.TabIndex = 6;
            lblEditora.Text = "Editora";
            // 
            // txtAno
            // 
            txtAno.Location = new Point(330, 75);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(100, 23);
            txtAno.TabIndex = 9;
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Location = new Point(330, 57);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(29, 15);
            lblAno.TabIndex = 8;
            lblAno.Text = "Ano";
            // 
            // txtEdicao
            // 
            txtEdicao.Location = new Point(12, 75);
            txtEdicao.Name = "txtEdicao";
            txtEdicao.Size = new Size(100, 23);
            txtEdicao.TabIndex = 11;
            // 
            // lblEdicao
            // 
            lblEdicao.AutoSize = true;
            lblEdicao.Location = new Point(12, 57);
            lblEdicao.Name = "lblEdicao";
            lblEdicao.Size = new Size(42, 15);
            lblEdicao.TabIndex = 10;
            lblEdicao.Text = "Edição";
            // 
            // txtPagina
            // 
            txtPagina.Location = new Point(118, 75);
            txtPagina.Name = "txtPagina";
            txtPagina.Size = new Size(100, 23);
            txtPagina.TabIndex = 13;
            // 
            // lblPagina
            // 
            lblPagina.AutoSize = true;
            lblPagina.Location = new Point(118, 57);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(48, 15);
            lblPagina.TabIndex = 12;
            lblPagina.Text = "Páginas";
            // 
            // txtIdioma
            // 
            txtIdioma.Location = new Point(224, 75);
            txtIdioma.Name = "txtIdioma";
            txtIdioma.Size = new Size(100, 23);
            txtIdioma.TabIndex = 15;
            // 
            // lblIdioma
            // 
            lblIdioma.AutoSize = true;
            lblIdioma.Location = new Point(224, 57);
            lblIdioma.Name = "lblIdioma";
            lblIdioma.Size = new Size(44, 15);
            lblIdioma.TabIndex = 14;
            lblIdioma.Text = "Idioma";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(436, 10);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(50, 15);
            lblGenero.TabIndex = 16;
            lblGenero.Text = "Gêneros";
            // 
            // cbGenero
            // 
            cbGenero.AllowDrop = true;
            cbGenero.FormattingEnabled = true;
            cbGenero.Items.AddRange(new object[] { "Romance", "Fantasia", "Suspense", "Ficção científica", "Autoajuda" });
            cbGenero.Location = new Point(436, 28);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(121, 23);
            cbGenero.TabIndex = 17;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(437, 69);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(120, 32);
            btnAdicionar.TabIndex = 18;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // dgvGerenciadorLivros
            // 
            dgvGerenciadorLivros.AllowUserToAddRows = false;
            dgvGerenciadorLivros.AllowUserToDeleteRows = false;
            dgvGerenciadorLivros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgvGerenciadorLivros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGerenciadorLivros.Columns.AddRange(new DataGridViewColumn[] { btnEditar, btnExcluir, titulo, autor, id, editora, ano, edicao, pagina, idioma, genero });
            dgvGerenciadorLivros.Location = new Point(12, 107);
            dgvGerenciadorLivros.Name = "dgvGerenciadorLivros";
            dgvGerenciadorLivros.ReadOnly = true;
            dgvGerenciadorLivros.RowHeadersVisible = false;
            dgvGerenciadorLivros.RowTemplate.Height = 25;
            dgvGerenciadorLivros.Size = new Size(978, 148);
            dgvGerenciadorLivros.TabIndex = 20;
            dgvGerenciadorLivros.CellClick += dgvGerenciadorLivros_CellClick;
            // 
            // btnEditar
            // 
            btnEditar.HeaderText = "Editar";
            btnEditar.Name = "btnEditar";
            btnEditar.ReadOnly = true;
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            btnEditar.Width = 70;
            // 
            // btnExcluir
            // 
            btnExcluir.HeaderText = "Excluir";
            btnExcluir.Name = "btnExcluir";
            btnExcluir.ReadOnly = true;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseColumnTextForButtonValue = true;
            btnExcluir.Width = 70;
            // 
            // titulo
            // 
            titulo.DataPropertyName = "titulo";
            titulo.HeaderText = "Título";
            titulo.Name = "titulo";
            titulo.ReadOnly = true;
            titulo.Width = 120;
            // 
            // autor
            // 
            autor.DataPropertyName = "autor";
            autor.HeaderText = "Autor";
            autor.Name = "autor";
            autor.ReadOnly = true;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "Identificador";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 90;
            // 
            // editora
            // 
            editora.DataPropertyName = "editora";
            editora.HeaderText = "Editora";
            editora.Name = "editora";
            editora.ReadOnly = true;
            // 
            // ano
            // 
            ano.DataPropertyName = "ano";
            ano.HeaderText = "Ano";
            ano.Name = "ano";
            ano.ReadOnly = true;
            ano.Width = 50;
            // 
            // edicao
            // 
            edicao.DataPropertyName = "edicao";
            edicao.HeaderText = "Edição";
            edicao.Name = "edicao";
            edicao.ReadOnly = true;
            edicao.Width = 50;
            // 
            // pagina
            // 
            pagina.DataPropertyName = "pagina";
            pagina.HeaderText = "Páginas";
            pagina.Name = "pagina";
            pagina.ReadOnly = true;
            // 
            // idioma
            // 
            idioma.DataPropertyName = "idioma";
            idioma.HeaderText = "Idiomas";
            idioma.Name = "idioma";
            idioma.ReadOnly = true;
            // 
            // genero
            // 
            genero.DataPropertyName = "genero";
            genero.HeaderText = "Gêneros";
            genero.Name = "genero";
            genero.ReadOnly = true;
            genero.Width = 120;
            // 
            // Form1
            // 
            AcceptButton = btnAdicionar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 450);
            Controls.Add(dgvGerenciadorLivros);
            Controls.Add(btnAdicionar);
            Controls.Add(cbGenero);
            Controls.Add(lblGenero);
            Controls.Add(txtIdioma);
            Controls.Add(lblIdioma);
            Controls.Add(txtPagina);
            Controls.Add(lblPagina);
            Controls.Add(txtEdicao);
            Controls.Add(lblEdicao);
            Controls.Add(txtAno);
            Controls.Add(lblAno);
            Controls.Add(txtEditora);
            Controls.Add(lblEditora);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(txtAutor);
            Controls.Add(lblAutor);
            Controls.Add(txtTitulo);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvGerenciadorLivros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private Label lblAutor;
        private TextBox txtId;
        private Label lblId;
        private TextBox txtEditora;
        private Label lblEditora;
        private TextBox txtAno;
        private Label lblAno;
        private TextBox txtEdicao;
        private Label lblEdicao;
        private TextBox txtPagina;
        private Label lblPagina;
        private TextBox txtIdioma;
        private Label lblIdioma;
        private Label lblGenero;
        private ComboBox cbGenero;
        private Button btnAdicionar;
        private DataGridView dgvGerenciadorLivros;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewButtonColumn btnExcluir;
        private DataGridViewTextBoxColumn titulo;
        private DataGridViewTextBoxColumn autor;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn editora;
        private DataGridViewTextBoxColumn ano;
        private DataGridViewTextBoxColumn edicao;
        private DataGridViewTextBoxColumn pagina;
        private DataGridViewTextBoxColumn idioma;
        private DataGridViewTextBoxColumn genero;
    }
}