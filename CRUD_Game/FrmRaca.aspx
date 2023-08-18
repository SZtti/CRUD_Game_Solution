<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmRaca.aspx.cs" Inherits="CRUD_Game.FrmRaca" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>Gerenciar Raças</h1>
    <form id="form1" runat="server">
        <div>
            <a href="Default.aspx">Inicio</a>
        </div>

        <fieldset>
            <legend>
                Criar nova Raça
            </legend>
            <p>
                <label>Nome da Raça:</label>
                <asp:TextBox runat="server" id="txtDescrição"/>
            </p>
            <p> 
                <asp:Button Text="Cadastrar" runat="server" id="btnConfirmar" OnClick="btnConfirmar_Click"/>
            </p>
            <p>
                <label id="lblMensagem" runat="server"></label>
            </p>
        </fieldset>

    </form>
</body>
</html>
