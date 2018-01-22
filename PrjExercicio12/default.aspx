<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="PrjExercicio12._default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 233px;
        }
        .style2
        {
            text-align: right;
        }
        .style3
        {
            width: 219px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    
        <asp:Label ID="Label1" runat="server" 
            style="font-weight: 700; text-align: center; font-size: xx-large" 
            Text="Seja bem vindo!"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Usuário: Visitante; Senha: 1234"></asp:Label>
        <br />
        <table class="style1">
            <tr>
                <td class="style2">
                    <asp:Label ID="Label2" runat="server" Text="Usuário"></asp:Label>
                </td>
                <td class="style3">
                    <asp:TextBox ID="TXT_Login" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="Label3" runat="server" Text="Senha"></asp:Label>
                </td>
                <td class="style3">
                    <asp:TextBox ID="TXT_Senha" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    <asp:Button ID="LoginDB" runat="server" onclick="LoginDB_Click" 
                        Text="Login DB" />
                &nbsp;<asp:Button ID="LoginWS" runat="server" onclick="Login_Click" 
                        Text="Login WS" />
                </td>
            </tr>
        </table>
    
        <asp:Label ID="LBL_Mensagem" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
    
    </div>
    </form>
</body>
</html>
