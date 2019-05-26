<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="NuevaCita.aspx.cs" Inherits="Interface_v2.NuevaCita" %>
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
        <div id="QueryTitle"> Nueva cita</div>
        <div id="DivQueryForm">
            <div style="color: red; text-align:center; font-family: Lucida Console, Times, serif;">
                <asp:Label ID="txtsubmitquery" runat="server" Text="" />
            </div>
            <p>Para:</p>
            <asp:DropDownList CssClass="QueryForm" Required="required" runat="server" ID="listOfCompanies" />
            <p>Fecha:</p>
            <div>
                <asp:Calendar CssClass="QueryForm" ID="Calendar" runat="server" BackColor="White" BorderStyle="Solid" OnSelectionChanged="Calendar_SelectionChanged" VisibleDate="2019-05-25">
                    <TitleStyle BackColor="#00CC88" />
                </asp:Calendar>
            </div>
            <br />
            <asp:TextBox CssClass="QueryForm" Required="required" readonly="true" id="Fecha" Text="" Columns="30" Rows="10" runat="server" />
            <p>Motivo:</p>
            <asp:TextBox CssClass="QueryForm" Required="required" id="Pregunta" TextMode="MultiLine" Columns="30" Rows="5" Text="" runat="server" />
            <br />
            <br />
            <asp:Button CssClass="SendQuery" Text="Solicitar" id="SendQuery" runat="server" OnClick="SolicitarCita_Click"  />
        </div>
    </div>
</asp:Content>
