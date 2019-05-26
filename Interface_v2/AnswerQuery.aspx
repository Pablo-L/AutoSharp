<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AnswerQuery.aspx.cs" Inherits="Interface_v2.AnswerQuery" %>
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
        <div id="QueryTitle"> Responder consulta</div>
        <div id="DivQueryForm">
            <div style="text-align: center; color: red; margin-bottom: 20px;">
                <asp:Label Text="" ID="textAnswerQuery" runat="server" />
            </div>
            <p>Id. Consulta:</p>
            <asp:TextBox CssClass="QueryForm" Required="required" readonly="true" runat="server" ID="Id" />
            <p>Para:</p>
            <asp:TextBox CssClass="QueryForm" Required="required" readonly="true" runat="server" ID="Cliente" />
            <p>Fecha:</p>
            <asp:TextBox CssClass="QueryForm" Required="required" readonly="true" id="Fecha" Text="" Columns="30" Rows="10" runat="server" AutoPostBack="True" />
            <p>Pregunta:</p>
            <asp:TextBox CssClass="QueryForm" Required="required" id="Pregunta" readonly="true" TextMode="MultiLine" Columns="30" Rows="10" Text="" runat="server" />
            <p>Respuesta:</p>
            <asp:TextBox CssClass="QueryForm" id="Respuesta" TextMode="MultiLine" Columns="30" Rows="10" Text="" runat="server"  />
            <br />
            <br />
            <div style="margin-bottom: 50px;">
                <div style="float: left;">
                    <asp:Button CssClass="SendQuery" Text="Responder" id="SendQuery" runat="server" OnClick="ResponderConsulta_Click" />
                </div>
                <div style="float: left; margin-left: 20px; margin-top: 2px;">
                    <asp:ImageButton ImageUrl="~/imagenes/query/left.png" runat="server" OnClick="ReadPrev_Click" />
                </div>
                <div style="float: left; margin-left: 10px; margin-top: 2px;">
                    <asp:ImageButton ImageUrl="~/imagenes/query/right.png" runat="server" OnClick="ReadNext_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
