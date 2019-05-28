<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="VehiculosEmpresa.aspx.cs" Inherits="Interface_v2.VehiculosEmpresa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <div style="width: 90%; margin: 0 auto;">
        <div style="float: left; padding:10px; margin-top: 50px; margin-bottom: 10px">
            <asp:ImageButton ImageUrl="~/imagenes/vender/vender.png" runat="server" PostBackUrl="~/SignUpCar.aspx" />
            <div style="margin: 0 auto; width: 60%; text-align: center; margin-top: 10px; font-family: Lucida Console, Times, serif; color: #003322; border: 1px solid orange; padding: 2px;">Vender nuevo</div>
        </div>
        <div style="float: left; padding: 10px; margin-top: 50px; margin-bottom: 10px">
            <asp:ImageButton ImageUrl="~/imagenes/vender/enventa.png" runat="server" AlternateText="Image text" PostBackUrl="~/EnVenta.aspx"/>
            <div style="margin: 0 auto; width: 60%; text-align: center; margin-top: 10px; font-family: Lucida Console, Times, serif; color: #003322; border: 1px solid orange; padding: 2px;">En venta</div>
        </div>
        <div style="float: left; padding:10px; margin-top: 50px; margin-bottom: 50px">
            <asp:ImageButton ImageUrl="~/imagenes/vender/ofertar.png" runat="server" PostBackUrl="~/AgregarOferta.aspx" />
            <div style="margin: 0 auto; width: 60%; text-align: center; margin-top: 10px; font-family: Lucida Console, Times, serif; color: #003322; border: 1px solid orange; padding: 2px;">Nueva oferta</div>
        </div>
        <div style="float: left; padding: 10px; margin-top: 50px; margin-bottom: 50px">
            <asp:ImageButton ImageUrl="~/imagenes/vender/enoferta.png" runat="server" AlternateText="Image text" PostBackUrl="~/ListaOferta.aspx"/>
            <div style="margin: 0 auto; width: 60%; text-align: center; margin-top: 10px; font-family: Lucida Console, Times, serif; color: #003322; border: 1px solid orange; padding: 2px;">En oferta</div>
        </div>
    </div>
</asp:Content>
