<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="simulador_nv7.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Cadastro de Livros</h1>
        <label for="txtTitulo">Título:</label>
        <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox><br />

        <label for="txtAutor">Autor:</label>
        <asp:TextBox ID="txtAutor" runat="server"></asp:TextBox><br />

        <label for="txtISBN">ISBN:</label>
        <asp:TextBox ID="txtISBN" runat="server"></asp:TextBox><br />

        <label for="txtPaginas">Número de Páginas:</label>
        <asp:TextBox ID="txtPaginas" runat="server"></asp:TextBox><br />

        <label for="txtEdicao">Edição:</label>
        <asp:TextBox ID="txtEdicao" runat="server"></asp:TextBox><br />

        <label for="chkDisponibilidade">Disponível:</label>
        <asp:CheckBox ID="chkDisponibilidade" runat="server" /><br />

        <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar Livro" OnClick="botaoCadastrar" /><br /><br />

        <h2>Livros Cadastrados:</h2>
        <asp:Literal ID="litLivros" runat="server"></asp:Literal>

        <label for="txtConsultaId">Informe o título do livro:</label>
        <asp:TextBox ID="txtConsultaId" runat="server"></asp:TextBox><br />
        <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="botaoConsultar" /><br />
        <asp:Literal ID="litConsultaResultado" runat="server"></asp:Literal>

        <asp:Button ID="txtExcluirId" runat="server" Text="Excluir" OnClick="botaoExcluir" /><br /><br />
    </div>
</asp:Content>
