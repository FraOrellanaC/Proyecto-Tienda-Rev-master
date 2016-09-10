<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="WebTienda.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel2" runat="server">
        <br />
    Bienvenidos a Next Gen Games!!!<br /> Ingrese Juego:<br />
    <table style="width:100%;">
        <tr>
            <td class="auto-style1">Plataforma:</td>
            <td id="ddlPlat" class="auto-style2">
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Nombre del juego:</td>
            <td class="auto-style2">
                <asp:TextBox ID="tbNombre" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Stock</td>
            <td class="auto-style2">
                <asp:TextBox ID="tbStock" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Certificación de edad:</td>
            <td class="auto-style2">
                <asp:TextBox ID="tbEdad" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Precio:</td>
            <td class="auto-style2">
                <asp:TextBox ID="tbPrecio" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Idioma:</td>
            <td class="auto-style2">
                <asp:DropDownList ID="ddlIdioma" runat="server">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />
        <asp:Button ID="BtnIngresar" runat="server" Text="Ingresar" />
    </asp:Panel>
</asp:Content>
