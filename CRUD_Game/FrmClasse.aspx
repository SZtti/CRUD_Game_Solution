<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmClasse.aspx.cs" Inherits="CRUD_Game.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>Gerenciar Classes</h1>
    <form id="form1" runat="server">
        <div>
            <a href="Default.aspx">Inicio</a>
        </div>

        <fieldset>
            <legend>
                Criar nova Classe
            </legend>
            <p>
                <label>Nome da Classe:</label>
                <asp:TextBox runat="server" id="txtDescrição"/>
            </p>
            <p> 
                <asp:Button Text="Cadastrar" runat="server" id="btnConfirmar" OnClick="btnConfirmar_Click"/>
            </p>
            <p>
                <label id="lblMensagem"></label>
            </p>
        </fieldset>

    </form>
</body>
</html>
