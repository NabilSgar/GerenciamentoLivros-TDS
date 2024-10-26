using System.Collections.Immutable;
using System.ComponentModel;

namespace TDSGerenciamentoLivros
{
    public partial class Form1 : Form


    {
        private static List<Livros> livros = new List<Livros>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                Livros livro = new Livros();

                livro.id = Convert.ToInt32(txtId.Text);
                livro.editora = txtEditora.Text;
                livro.autor = txtAutor.Text;
                livro.pagina = Convert.ToInt32(txtPagina.Text);
                livro.edicao = Convert.ToInt32(txtEdicao.Text);
                livro.ano = Convert.ToDateTime(txtAno.Text);
                livro.idioma = txtIdioma.Text;
                livro.genero = cbGenero.Text;
                livro.titulo = txtTitulo.Text;

                

                livros.Add(livro);

                dgvGerenciadorLivros.DataSource = livros;

                CarregaListaLivros();
            }
            catch (Exception ex)
            {

                MessageBox.Show("erro: Preencha todos os campos", ex.Message);
            }
        }

        private void CarregaListaLivros()
        {
            BindingList<Livros> listaLivros = new BindingList<Livros>();

            foreach (Livros livro in livros)
            {
                listaLivros.Add(livro);
            }

            dgvGerenciadorLivros.DataSource = listaLivros;
        }

        private void dgvGerenciadorLivros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int id = Convert.ToInt32(dgvGerenciadorLivros.Rows[e.RowIndex].Cells["id"].Value);
                string acontecimento = dgvGerenciadorLivros.Columns[e.ColumnIndex].Name;

                if (acontecimento == "btnExcluir")
                {
                    DialogResult result = MessageBox.Show("Confirma exclusão?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (result == DialogResult.Yes)
                    {
                        int idx = livros.FindIndex(x => x.id == id);
                        livros.RemoveAt(idx);

                        CarregaListaLivros();
                    }
                }


            }
        }
    }
}