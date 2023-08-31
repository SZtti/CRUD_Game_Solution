<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmSubClasse.aspx.cs" Inherits="CRUD_Game.FrmSubClasse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Gerenciar SubClasse</title>
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
        </div>
    </form>
</body>
</html>
