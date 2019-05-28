<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="Interface_v2.Contacto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        p {
            font-family: "Lucida Console, Times, serif"; 
            color: #003322;
        }

        .QueryForm {
            font-family: "Lucida Console, Times, serif"; 
            color: #003322;
            padding: 0.5em;
            border-radius: 5px;
        }

        #DivQueryForm {
            margin: 0 auto;
            width: 50%;
            padding: 10px;
            background-color: #DDE4E1;
        }

        #QueryTitle {
            margin: 0 auto;
            width: 50%;
            padding: 10px;
            text-align: center;
            font-family: "Lucida Console, Times, serif"; 
            color: #003322;
            background-color: #00cc88;
        }

        .SendQuery {
            padding: 0.5em;
            border-radius: 10px; 
            border: 1px solid #003322;
            background-color: white;
        }

        .ProgressTemplate {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <div style="width: 44%; margin: 0 auto; margin-top: 50px; margin-bottom: 50px;">
        <div id="QueryTitle">Contáctanos</div>
        <div id="DivQueryForm">
            <p>Nombre:</p>
            <asp:TextBox CssClass="QueryForm" Required="required" id="TextBox2"  Text="" runat="server" />
            <p>Apellidos:</p>
            <asp:TextBox CssClass="QueryForm" Required="required" id="TextBox1"  Text="" runat="server" />
            <p>Compañía:</p>
            <asp:TextBox CssClass="QueryForm" Required="required" id="TextBox3"  Text="" runat="server" />
            <p>Pregunta:</p>
            <asp:TextBox CssClass="QueryForm" Required="required" id="Pregunta" TextMode="MultiLine" Columns="30" Rows="10" Text="" runat="server" />
            <br />
            <br />
            <asp:Button CssClass="SendQuery" Text="Enviar" id="Enviar" runat="server" />
        </div>
    </div>
</asp:Content>