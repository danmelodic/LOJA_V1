<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="produtosTeste.aspx.cs" Inherits="UIWeb.produtosTeste" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;</p>
    <p>
        Filtro de busca:
        <asp:TextBox ID="txt_Filtro" runat="server" Width="187px"></asp:TextBox>
        <asp:Button ID="Filtrar" runat="server" Text="Filtrar" Width="125px" />
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" 
            DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" 
            DataKeyNames="codigo">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" 
                    ShowEditButton="True" />
                <asp:BoundField DataField="codigo" HeaderText="Código do Produto" 
                    ReadOnly="True" SortExpression="codigo" />
                <asp:BoundField DataField="nome" HeaderText="Nome do Produto" 
                    SortExpression="nome" />
                <asp:BoundField DataField="preco" HeaderText="Preço" SortExpression="preco" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            DataObjectTypeName="Loja.Modelos.ProdutoInformation" DeleteMethod="ExcluircomClasse" 
            SelectMethod="Listagem" TypeName="Loja.DAL.ProdutoDAL" 
            UpdateMethod="Alterar">
            <SelectParameters>
                <asp:ControlParameter ControlID="txt_Filtro" DefaultValue="" Name="filtro" 
                    PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </p>
</asp:Content>
