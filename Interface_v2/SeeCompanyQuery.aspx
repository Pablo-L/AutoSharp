<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="SeeCompanyQuery.aspx.cs" Inherits="Interface_v2.SeeCompanyQuery" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        p {
            font-family: "Lucida Console, Times, serif"; 
            color: #003322;
        }
        #accpanel {
            margin: 0 auto;
            width: 600px;
        }
        .accheader {
            background-color: #00cc88;
            text-align: center;
            padding: 10px;
        }
        .acccontent {
            background-color: #DDE4E1;
            padding: 10px;
            border: 0.5px solid #003322;
        }
        .QueryForm {
            font-family: "Lucida Console, Times, serif";
            color: #003322;
            padding: 0.5em;
            border-radius: 5px;
        }
        .SendQuery {
            padding: 0.5em;
            border-radius: 10px; 
            border: 1px solid #003322;
            background-color: white;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <div style="width: 100%;">
        <div style="margin-top: 50px;">
            <asp:ScriptManager ID="asm" runat="server">
            </asp:ScriptManager>
            <div id="accpanel">
                <div style="float: left; margin-bottom: 50px;">
                    <p>Fecha:</p>
                    <asp:DropDownList CssClass="QueryForm" Required="required" runat="server" ID="listOfDates" style="height: 31px" OnSelectedIndexChanged="listOfDates_SelectedIndexChanged" />
                    <br />
                    <br />
                    <asp:Button CssClass="SendQuery" Text="Filtrar" id="Filter" runat="server" OnClick="FilterQuery_Click" />
                </div>
                <div style="float: right; margin-bottom: 50px; font-family: Lucida Console, Times, serif;">
                    <ajaxtoolkit:accordion ID="acc1" runat="server" HeaderCssClass="accheader" ContentCssClass="acccontent"  Width="450px" FramesPerSecond="30" FadeTransitions="true" TransitionDuration="350" AutoSize="None">
                    </ajaxtoolkit:accordion>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

