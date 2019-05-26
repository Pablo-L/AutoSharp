<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="NewQuery.aspx.cs" Inherits="Interface_v2.NewQuery" %>
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
        <div id="QueryTitle"> Nueva consulta</div>
        <div id="DivQueryForm">
            <div style="color: red; text-align:center; font-family: Lucida Console, Times, serif;">
                <asp:Label ID="txtsubmitquery" runat="server" Text="" />
            </div>
            <p>Para:</p>
            <asp:DropDownList CssClass="QueryForm" Required="required" runat="server" ID="listOfCompanies" />
            <p>Fecha:</p>
            <asp:TextBox CssClass="QueryForm" Required="required" readonly="true" id="Fecha" Text="" Columns="30" Rows="10" runat="server" />
            <p>Pregunta:</p>
            <asp:TextBox CssClass="QueryForm" Required="required" id="Pregunta" TextMode="MultiLine" Columns="30" Rows="10" Text="" runat="server" />
            <br />
            <br />
            <asp:Button CssClass="SendQuery" Text="Enviar" id="SendQuery" runat="server" OnClick="EnviarConsulta_Click" />
        </div>
    </div>
</asp:Content>

