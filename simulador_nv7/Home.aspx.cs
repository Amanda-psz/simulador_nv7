using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using simulador_nv7.Class;

namespace simulador_nv7
{
    public partial class Home : System.Web.UI.Page
    {
        private static Biblioteca biblioteca = new Biblioteca(); // Instância compartilhada

        protected void botaoCadastrar(object sender, EventArgs e) // Nome do método corrigido
        {
            // Capturar os valores dos controles
            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;
            int isbn = int.Parse(txtISBN.Text);
            int numeroPaginas = int.Parse(txtPaginas.Text);
            int edicao = int.Parse(txtEdicao.Text);
            bool disponibilidade = chkDisponibilidade.Checked;

            // Cadastrar o livro
            string mensagem = biblioteca.CadastrarLivro(titulo, autor, isbn, numeroPaginas, edicao, disponibilidade);

            // Atualizar a lista de livros cadastrados
            AtualizarListaLivros();

            // Exibir mensagem de sucesso
            Response.Write("<script>alert('" + mensagem + "');</script>");
        }

        private void AtualizarListaLivros()
        {
            // Gerar a lista de livros cadastrados
            StringBuilder sb = new StringBuilder();
            foreach (var livro in biblioteca.LivrosCadastrados) // Acessar a lista de livros
            {
                sb.Append($"<p>{livro}</p>");
            }

            // Atualizar o Literal com a lista de livros
            litLivros.Text = sb.ToString();
        }

        protected void botaoConsultar(object sender, EventArgs e)
        {
            // Capturar o título do TextBox
            string tiulo = txtConsultaId.Text;

            // Consultar o livro pelo título
            Livro livro = biblioteca.ConsultaLivro(tiulo);

            // Verificar se o livro foi encontrado
            if (livro != null)
            {
                // Exibir informações do livro
                litConsultaResultado.Text = livro.ToString();
            }
            else
            {
                // Exibir mensagem de livro não encontrado
                litConsultaResultado.Text = "Livro não encontrado.";
            }
        }
        protected void botaoExcluir(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(txtExcluirId.Text);
            string mensagem = biblioteca.RemoverLivro(id);
            Response.Write("<script>alert('" + mensagem + "');</script>");
        }
    }
}
