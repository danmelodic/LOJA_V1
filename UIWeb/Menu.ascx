<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu.ascx.cs" Inherits="UIWeb.Menu" %>
<asp:Menu ID="Menu1" runat="server" BackColor="#B5C7DE" 
    DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" 
    ForeColor="#284E98" Orientation="Horizontal" StaticSubMenuIndent="10px">
    <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <DynamicMenuStyle BackColor="#B5C7DE" />
    <DynamicSelectedStyle BackColor="#507CD1" />
    <Items>
        <asp:MenuItem Text="Cadastro" Value="Cadastro">
            <asp:MenuItem NavigateUrl="~/produtosWeb.aspx" Text="Produto" Value="Produto">
            </asp:MenuItem>
            <asp:MenuItem Text="Cliente" Value="Cliente"></asp:MenuItem>
            <asp:MenuItem NavigateUrl="~/produtosTeste.aspx" Text="Produto Test" 
                Value="Produto Test"></asp:MenuItem>
            <asp:MenuItem NavigateUrl="~/WebForm1.aspx" Text="Cliente Teste" 
                Value="Cliente Teste"></asp:MenuItem>
        </asp:MenuItem>
    </Items>
    <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <StaticSelectedStyle BackColor="#507CD1" />
</asp:Menu>

