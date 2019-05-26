<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="OnlineQueryP.aspx.cs" Inherits="Interface_v2.OnlineQueryP1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <div style="width: 44%; margin: 0 auto;">
        <div style="float: left; padding:10px; margin-top: 50px; margin-bottom: 50px">
            <asp:ImageButton ImageUrl="~/imagenes/query/query2.png" runat="server" PostBackUrl="~/NewQuery.aspx" />
            <div style="margin: 0 auto; width: 60%; text-align: center; margin-top: 10px; font-family: Lucida Console, Times, serif; color: #003322; border: 1px solid orange; padding: 2px;">Nueva consulta</div>
        </div>
        <div style="float: right; padding: 10px; margin-top: 50px; margin-bottom: 50px">
            <asp:ImageButton ImageUrl="~/imagenes/query/query1.png" runat="server" AlternateText="Image text" PostBackUrl="~/SeeQuery.aspx"/>
            <div style="margin: 0 auto; width: 60%; text-align: center; margin-top: 10px; font-family: Lucida Console, Times, serif; color: #003322; border: 1px solid orange; padding: 2px;">Ver consultas</div>
        </div>
    </div>
</asp:Content>
