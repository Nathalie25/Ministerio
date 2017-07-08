<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfColegioGestion.aspx.cs" Inherits="Presentacion.wfColegioGestion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <table class="nav-justified">
        <tr>
            <td style="text-align: right; width: 30%;  "></td>
            <td style="text-align: center; width: 40%;  ">
                <asp:Label ID="lblID" runat="server" Text="ID" Visible="False"></asp:Label>
            </td>
            <td style="text-align: left; width: 30%;  "></td>
        </tr>
        <tr>
            <td style="text-align: right; width: 30%;  ">SIE</td>
            <td style="text-align: center; width: 40%;  ">
                <asp:TextBox ID="txbSIE" runat="server"></asp:TextBox>
            </td>
            <td style="text-align: left; width: 30%;  "></td>
        </tr>
        <tr>
            <td style="text-align: right; width: 30%;  ">Nombre</td>
            <td style="text-align: center; width: 40%;  ">
                <asp:TextBox ID="txbNombre" runat="server"></asp:TextBox>
            </td>
            <td style="text-align: left; width: 30%;  "></td>
        </tr>
        <tr>
            <td style="text-align: right; width: 30%;  ">Resolucion</td>
            <td style="text-align: center; width: 40%;  ">
                <asp:TextBox ID="txbResolucion" runat="server"></asp:TextBox>
            </td>
            <td style="text-align: left; width: 30%;  "></td>
        </tr>
        <tr>
            <td style="text-align: right; width: 30%;  ">Fecha Resolucion</td>
            <td style="text-align: center; width: 40%;  ">
                <asp:TextBox ID="txbFechaRes" runat="server"></asp:TextBox>
            </td>
            <td style="text-align: left; width: 30%;  "></td>
        </tr>
        <tr>
            <td style="text-align: right; width: 30%;  ">Direccion </td>
            <td style="text-align: center; width: 40%;  ">
                <asp:TextBox ID="txbDireccion" runat="server"></asp:TextBox>
            </td>
            <td style="text-align: left; width: 30%;  "></td>
        </tr>
        <tr>
            <td style="text-align: right; width: 30%;  ">Telefono</td>
            <td style="text-align: center; width: 40%;  ">
                <asp:TextBox ID="txbTelefono" runat="server"></asp:TextBox>
            </td>
            <td style="text-align: left; width: 30%;  "></td>
        </tr>
        <tr>
            <td style="text-align: right; width: 30%;  ">Detalle</td>
            <td style="text-align: center; width: 40%;  ">
                <asp:TextBox ID="txbDetalle" runat="server"></asp:TextBox>
            </td>
            <td style="text-align: left; width: 30%;  "></td>
        </tr>
        <tr>
            <td style="text-align: right; width: 30%;  ">Distrito</td>
            <td style="text-align: center; width: 40%;  ">
                <asp:DropDownList ID="ddlDistrito" runat="server">
                </asp:DropDownList>
            </td>
            <td style="text-align: left; width: 30%;  ">&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; width: 30%;  ">Tipo de Colegio</td>
            <td style="text-align: center; width: 40%;  ">
                <asp:DropDownList ID="ddlTipo" runat="server">
                </asp:DropDownList>
            </td>
            <td style="text-align: left; width: 30%;  ">&nbsp;</td>
        </tr>
           
        <tr>
            <td style="text-align: right; width: 30%;  ">Logo</td>
            <td style="text-align: center; width: 40%;  ">
                <asp:FileUpload ID="fuLogo" runat="server" />
            </td>
            <td style="text-align: left; width: 30%;  ">&nbsp;</td>
        </tr>
           
        <tr>
            <td style="text-align: right; width: 30%;  ">Turno</td>
            <td style="text-align: center; width: 40%;  ">
                <asp:DropDownList ID="ddlTurno" runat="server">
                </asp:DropDownList>
            </td>
            <td style="text-align: left; width: 30%;  ">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
