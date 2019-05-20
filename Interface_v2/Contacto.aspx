<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="Interface_v2.view.Contacto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="view/css/Buttons.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" id="bootstrap-css">
    <script src="https://code.jquery.com/jquery-3.4.1.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" ></script> 
    <style>
        .auto-style6 {
            position: relative;
            right: 0px;
            top: 5px;
            font-family:sans-serif;
            font-weight: bold;

        }
        .ContactUs{
            font-weight: bold;
            font-family: sans-serif;
        }

    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <div class="ContactUs">
        <p>
            &nbsp;
            Las casillas marcadas con un (*) son obligatorias.
        </p>
        <p>
            &nbsp;
        Nombre *
        </p>
        <p>
            &nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Height="21px" Width="235px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <p>
            &nbsp;
        Apellidos *
        </p>
        <p>
            &nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Height="21px" Width="235px"></asp:TextBox>
        </p>
        <p>
            &nbsp;
        Nombre de la compañia *
        </p>
        <p>
            &nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Height="21px" Width="235px"></asp:TextBox>
        </p>
        <p>
            &nbsp;
        Email *
        </p>
        <p>
            &nbsp;
        <asp:TextBox ID="TextBox4" runat="server" Height="21px" Width="235px"></asp:TextBox>
        </p>
        <p>
            &nbsp;
        Pregunta
        </p>
        <p>
            &nbsp;
        <asp:TextBox ID="TextBox5" runat="server" Height="21px" Width="235px"></asp:TextBox>
        </p>
        <p>
            &nbsp;
            <asp:Button ID="Contacto_Boton" runat="server" Height="50px" Text="Enviar" Width="170px" CssClass="auto-style6" />
        </p>
        <p>
            &nbsp;</p>
    </div>

 
</asp:Content>
