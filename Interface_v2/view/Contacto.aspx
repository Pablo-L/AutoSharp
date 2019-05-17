<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="Interface_v2.view.Contacto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/Buttons.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">

    <p >
        Las casillas marcadas con un (*) son obligatorias.</p>
    <p>
        Nombre *</p>
    <p>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" Height="17px" Width="234px"></asp:TextBox>
    </p>
    <p>
        Apellidos *</p>
    <p>
        <asp:TextBox ID="TextBox2" runat="server" Height="17px" Width="234px"></asp:TextBox>
    </p>
    <p>
        Nombre de la compañia *</p>
    <p>
        <asp:TextBox ID="TextBox3" runat="server" Height="17px" Width="234px"></asp:TextBox>
    </p>
    <p>
        Email *</p>
    <p>
        <asp:TextBox ID="TextBox4" runat="server" Height="17px" Width="234px"></asp:TextBox>
    </p>
    <p>
        Pregunta</p>
    <p>
        <asp:TextBox ID="TextBox5" runat="server" Height="17px" Width="234px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="Contacto_Boton" runat="server" Height="50px" Text="Enviar" Width="169px"/>
    </p>
    <p>
        &nbsp;</p>

</asp:Content>
