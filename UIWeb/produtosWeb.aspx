<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="produtosWeb.aspx.cs" Inherits="UIWeb.produtosWeb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
            border-style: solid;
            border-width: 1px;
        }
        .style2
        {
            width: 94px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style1">
        <tr>
            <td class="style2">
                Nome:</td>
            <td>
                <asp:TextBox ID="nomeTexteBox" runat="server" Width="245px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Preço:</td>
            <td>
                <asp:TextBox ID="precoTextBox" runat="server" Width="242px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Estoque:</td>
            <td>
                <asp:TextBox ID="estoqueTextBox" runat="server" Width="240px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                <asp:Button ID="incluirButton" runat="server" onclick="incluirButton_Click" 
                    Text="Incluir" Width="126px" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                <asp:Label ID="Mensagem" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
