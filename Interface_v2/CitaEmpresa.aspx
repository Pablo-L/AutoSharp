<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="CitaEmpresa.aspx.cs" Inherits="Interface_v2.CitaEmpresa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <div style="width: 25%; margin: 0 auto;">
        <div style="float: right; padding: 10px; margin: 50px 0 50px 0;">
            <asp:ImageButton ImageUrl="~/imagenes/cita/verCita.png" runat="server" AlternateText="Image text" PostBackUrl="~/VerCitaEmpresa.aspx"/>
            <div style="margin: 0 auto; width: 60%; text-align: center; margin-top: 10px; font-family: Lucida Console, Times, serif; color: #003322; border: 1px solid orange; padding: 2px;">Ver citas</div>
        </div>
    </div>
</asp:Content>
