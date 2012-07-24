<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="UIWeb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1">
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        DataObjectTypeName="Loja.Modelos.ClienteInformation" DeleteMethod="Excluir" 
        SelectMethod="Listagem" TypeName="Loja.DAL.ClienteDAL" UpdateMethod="Alterar">
        <DeleteParameters>
            <asp:Parameter Name="codigo" Type="Int32" />
        </DeleteParameters>
        <SelectParameters>
            <asp:Parameter Name="filtro" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <p>
    </p>
</asp:Content>
