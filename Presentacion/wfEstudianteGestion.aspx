<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfEstudianteGestion.aspx.cs" Inherits="Presentacion.wfEstudianteGestion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
        <tr>
            <td style="text-align: right; width: 30%; height: 23px;"></td>
            <td style="text-align: center; width: 40%; height: 23px;">
                <asp:Label ID="lblId" runat="server" Text="ID" Visible="False"></asp:Label>
            </td>
            <td style="text-align: left; width: 30%; height: 23px;"></td>
        </tr>
        <tr>
            <td style="text-align: right; width: 30%">Nombre</td>
            <td style="text-align: center; width: 40%">
                <asp:TextBox ID="txbNombre" runat="server"></asp:TextBox>
            </td>
            <td style="text-align: left; width: 30%">&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; width: 30%; height: 26px;">CI</td>
            <td style="text-align: center; width: 40%; height: 26px;">
                <asp:TextBox ID="txbCI" runat="server"></asp:TextBox>
            </td>
            <td style="text-align: left; width: 30%; height: 26px;"></td>
        </tr>
        <tr>
            <td style="text-align: right; width: 30%; height: 22px;">Apellido Paterno</td>
            <td style="text-align: center; width: 40%; height: 22px;">
                <asp:TextBox ID="txbPaterno" runat="server"></asp:TextBox>
            </td>
            <td style="text-align: left; width: 30%; height: 22px;"></td>
        </tr>
        <tr>
            <td style="text-align: right; width: 30%; height: 26px;">Apellido Materno</td>
            <td style="text-align: center; width: 40%; height: 26px;">
                <asp:TextBox ID="txbMaterno" runat="server"></asp:TextBox>
            </td>
            <td style="text-align: left; width: 30%; height: 26px;"></td>
        </tr>
        <tr>
            <td style="text-align: right; width: 30%; height: 26px;">Correo </td>
            <td style="text-align: center; width: 40%; height: 26px;">
                <asp:TextBox ID="txbCorreo" runat="server"></asp:TextBox>
            </td>
            <td style="text-align: left; width: 30%; height: 26px;"></td>
        </tr>
        <tr>
            <td style="text-align: right; width: 30%; height: 26px;">Direccion </td>
            <td style="text-align: center; width: 40%; height: 26px;">
                <asp:TextBox ID="txbDireccion" runat="server"></asp:TextBox>
            </td>
            <td style="text-align: left; width: 30%; height: 26px;"></td>
        </tr>
        <tr>
            <td style="text-align: right; width: 30%">Telefono</td>
            <td style="text-align: center; width: 40%">
                <asp:TextBox ID="txbTelefono" runat="server"></asp:TextBox>
            </td>
            <td style="text-align: left; width: 30%">&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; width: 30%">RUDE</td>
            <td style="text-align: center; width: 40%">
                <asp:TextBox ID="txbRude" runat="server"></asp:TextBox>
            </td>
            <td style="text-align: left; width: 30%">&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; width: 30%">Promedio</td>
            <td style="text-align: center; width: 40%">
                <asp:TextBox ID="txbPromedio" runat="server"></asp:TextBox>
            </td>
            <td style="text-align: left; width: 30%">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
