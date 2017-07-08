<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfEstudiante.aspx.cs" Inherits="Presentacion.wfEstudiante" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div style="text-align: center">
        <h1>Administrar Estudiantes</h1>
    </div>

    <hr>

    <asp:GridView ID="gvEstudiantes" runat="server" CellPadding="4" ForeColor="Black" GridLines="Horizontal" Width="100%" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" OnRowDeleting="gvEstudiantes_RowDeleting" OnSelectedIndexChanging="gvEstudiantes_SelectedIndexChanging">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#242121" />
    </asp:GridView>

    <hr>

    <div style="text-align: right">
        <asp:Button ID="btnNuevoEstudiante" runat="server" Text="Nuevo Estudiante" OnClick="btnNuevoEstudiante_Click" />
    </div>

</asp:Content>
