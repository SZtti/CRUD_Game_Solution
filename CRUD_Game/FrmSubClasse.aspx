<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmSubClasse.aspx.cs" Inherits="CRUD_Game.FrmSubClasse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Gerenciar SubClasse</title>
    <link href="css/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="Default.aspx">Inicio</a>
            <fieldset>
            <legend>
                Criar nova SubClasse
            </legend>
            <p>
                <label>Selecione a classe que a subclasse esta associada: </label>
                <asp:DropDownList ID="DDLClasse" runat="server"></asp:DropDownList>
            </p>
        
            <p>
                <label>Nome da Subclasse:</label>
                <asp:TextBox runat="server" id="txtDescrição" required/>
            </p>
            <p> 
                <asp:Button Text="Cadastrar" runat="server" id="btnConfirmar" OnClick="btnConfirmar_Click1"/>
            </p>
            <p>
                <label id="lblMensagem" runat="server"></label>
            </p>
        </fieldset>

        <h2>SubClasses cadastradas</h2>
        <table border="1" class="tabela">
            <tr>
                <td>Código</td>
                <td>Descrição</td>
                <td>Classe</td>
                <th>Visualizar</th>
                <th>Editar</th>
                <th>Deletar</th>
                
            </tr>
        
                <asp:ListView runat="server" ID="lvSubClasses">
                    <ItemTemplate>
                        <tr>
                            <td>
                               <%# Eval("IdSubclasse") %>
                            </td>
                            <td> 
                           <%# Eval("Descricao") %> 
                            </td>
                            <td> 
                           <%# Eval("GetClasse.Descricao") %> 
                            </td>
                             <td>
                               <asp:ImageButton ID="btnView" runat="server" ImageUrl="img/view.svg"/>
                            </td>
                            <td>
                               <asp:ImageButton ID="btnEdit" runat="server" ImageUrl="img/edit.svg"/>
                            </td>
                            <td>
                                <asp:ImageButton ID="btnDelete" runat="server" ImageUrl="img/delete.svg"/>
                            </td>
                             
                       </tr>
                    </ItemTemplate>
                </asp:ListView>
        </table>
        </div>
    </form>
</body>
</html>
