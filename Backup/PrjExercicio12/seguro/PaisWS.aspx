<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaisWS.aspx.cs" Inherits="PrjExercicio12.seguro.PaisWS" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 300px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    
        <asp:Label ID="Label3" runat="server" 
            style="font-weight: 700; font-size: xx-large" Text="País WS"></asp:Label>
        <br />
        <table class="style1">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Código"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TXT_CdPais" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Descrição"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TXT_DsPais" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <table class="style1">
            <tr>
                <td>
                    <asp:Button ID="Btn_Selecionar" runat="server" onclick="Btn_Selecionar_Click" 
                        Text="Selecionar" />
                </td>
                <td>
                    <asp:Button ID="BTN_Incluir" runat="server" onclick="BTN_Incluir_Click" 
                        Text="Incluir" />
                </td>
                <td>
                    <asp:Button ID="BTN_Alterar" runat="server" onclick="BTN_Alterar_Click" 
                        Text="Alterar" />
                </td>
                <td>
                    <asp:Button ID="BTN_Excluir" runat="server" Text="Excluir" 
                        onclick="BTN_Excluir_Click" />
                </td>
                <td>
                    <asp:Button ID="BTN_LogOut" runat="server" Text="LogOut" 
                        onclick="BTN_LogOut_Click" />
                </td>
            </tr>
        </table>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="CdPais" HeaderText="Código" />
                <asp:BoundField DataField="DsPais" HeaderText="Descrição" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <br />
        <asp:Label ID="LBL_Mensagem" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
    
    </div>
    </form>
</body>
</html>
