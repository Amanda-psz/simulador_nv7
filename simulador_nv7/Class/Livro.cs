using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace simulador_nv7.Class
{
    public class Livro
    {
        public Guid Id { get; set; } = Guid.NewGuid(); // Identificador único para cada livro
        public string Titulo { get; set; }
        public string Autor {  get; set; }
        public int ISBN { get; set; }
        public int NumerosPaginas { get; set; }
        public int Edicao { get; set; }
        public bool Disponibilidade { get; set; }


        public Livro(string titulo, string autor, int isbn, int numeroPaginas, int edicao, bool disponibilidade)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            NumerosPaginas = numeroPaginas;
            Edicao = edicao;
            Disponibilidade = disponibilidade;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Título: {Titulo}, Autor: {Autor}, ISBN: {ISBN}, Nº de páginas: {NumerosPaginas}, Edição: {Edicao}, Disponibilidade: {Disponibilidade}";
        }

    }
}