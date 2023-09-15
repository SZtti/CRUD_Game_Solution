<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmPersonagem.aspx.cs" Inherits="CRUD_Game.FrmPersonagm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>Gerenciar Personagem</h1>
    <form id="form1" runat="server">
        <div>
            <a href="Default.aspx">Inicio</a>
        </div>

        <fieldset>
            <legend>
                Criar novo Personagem
            </legend>
            <p>
                <label>Nome do Personagem:</label>
                <asp:TextBox runat="server" id="txtDescrição"/>
            </p>
            <p>
                <label>Data de nascimento:</label>
                <asp:TextBox runat="server" id="TextBox1" TextMode="Date"/>
            </p>
            <p>
                <label>Nível:</label>
                <asp:TextBox runat="server" id="TextBox2"/>
            </p>
            <p>
                <label>Sexo:</label>
                <asp:TextBox runat="server" id="TextBox3"/>
            </p>
            <p> 
                <asp:Button Text="Cadastrar" runat="server" id="btnConfirmar" OnClick="btnConfirmar_Click"/>
            </p>
            <p>
                <label id="lblMensagem" runat="server"></label>
            </p>
            <p>
                <label>Selecione a Aparência: </label>
                <asp:DropDownList ID="DropDownList0" runat="server" ></asp:DropDownList>
            </p>
            <p>
                <label>Selecione a Atributo: </label>
                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            </p>
            <p>
                <label>Selecione a SubClasse: </label>
                <asp:DropDownList ID="DropDownList3" runat="server"></asp:DropDownList>
            </p>
            <p>
                <label>Selecione a Raça: </label>
                <asp:DropDownList ID="DropDownList4" runat="server"></asp:DropDownList>
            </p>
          
        </fieldset>
    </form>
</body>
</html>
