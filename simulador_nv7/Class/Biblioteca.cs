using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using simulador_nv7.IClass;

namespace simulador_nv7.Class
{
    public class Biblioteca
    {

        public List<Livro> livrosCadastrados = new List<Livro>();

        public List<Livro> LivrosCadastrados => livrosCadastrados; // Propriedade para acessar a lista

        public string CadastrarLivro(string titulo, string autor, int isbn, int numeroPaginas, int edicao, bool disponibilidade)
        {
            Livro livroNovo = new Livro(titulo, autor, isbn, numeroPaginas, edicao, disponibilidade);
            livrosCadastrados.Add(livroNovo);
            return "Cadastro do novo livro concluído com sucesso!";
        }

        public Livro ConsultaLivro(string titulo)
        {
            return livrosCadastrados.FirstOrDefault(livro => livro.Titulo == titulo);
        }

        public string EditaLivro(Guid id, string titulo, string autor, int isbn, int numeroPaginas, int edicao, bool disponibilidade)
        {
            var livro = livrosCadastrados.FirstOrDefault(l => l.Id == id);
            if (livro == null)
            {
                livro.Titulo = titulo;
                livro.Autor = autor;
                livro.ISBN = isbn;
                livro.NumerosPaginas = numeroPaginas;
                livro.Edicao = edicao;
                return "O livro foi editado com sucesso!";
            }
            return "Livro não encontrado.";
        }

        public string RemoverLivro(Guid id)
        {
            var livro = livrosCadastrados.FirstOrDefault(l => l.Id == id);
            if (livro == null)
            {
                livrosCadastrados.Remove(livro);
                return "O livro foi excluído com sucesso!";
            }
            return "Livro não encontrado.";
        }

        public string EmprestarLivro(Guid id)
        {
            var livro = livrosCadastrados.FirstOrDefault(l => l.Id == id);
            if (livro != null)
            {
                if (livro.Disponibilidade)
                {
                    livro.Disponibilidade = false;
                    return "O livro foi emprestado com sucesso!";
                }
                return "O livro em emprestimo, não está disponível no momento.";
            }
            return "O livro não foi encontrado.";
        }

        public string DevolverLivro(Guid id)
        {
            var livro = livrosCadastrados.FirstOrDefault(l => l.Id == id);
            if (livro != null)
            {
                if (livro.Disponibilidade)
                {
                    livro.Disponibilidade = true;
                    return "Devolção do livro efetuada com sucesso!";
                }
                return "O livro está disponível.";
            }
            return "O livro não foi encontrado.";
        }

    }

}