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
            <p>
                <label>Selecione uma classe: </label>
                <asp:DropDownList ID="DDLClasse" runat="server"></asp:DropDownList>
            </p>
        </div>
    </form>
</body>
</html>
