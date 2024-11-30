using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simulador_nv7.Class;

namespace simulador_nv7.IClass
{
    public interface IBiblioteca
    {
        string CadastrarLivro(string titulo, string autor, int isbn, int numeroPaginas, int edicao, bool disponibilidade);
        Livro ConsultaLivro(string titulo);
        bool ExcluirLivro(string titulo);
        bool EmprestarLivro(string titulo);
        bool DevolverLivro(string titulo);
    }
}
