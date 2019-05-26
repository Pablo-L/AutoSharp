<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ListaOferta.aspx.cs" Inherits="Interface_v2.ListaOferta" %>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" id="bootstrap-css">
    <script src="https://code.jquery.com/jquery-3.4.1.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" ></script>    
    <link href="css/DataList.css" rel="stylesheet" />
    <style>
        .listaVehiculos {
            border: 1px solid;
            width: 270px;
            float: left;
            margin:30px;
            padding: 1em;
            text-align: center;
            font-family: Lucida Console, Times, serif; 
            color: #003322;
            border-radius: 5px;
        }

        .buttonVehiculo
        {
            border-radius: 10px;
            font-family: Lucida Console, Times, serif; 
            color: #003322;
            background-color: white;
            padding: 0.4em;
            margin: 5px;
        }
        .filters 
        {
            font-family: Lucida Console, Times, serif;             
            color: #003322;
            border-radius: 10px;
            padding: 0.4em;
            border-bottom: 20px;
            margin-top: 10px;
        }

        .dropDownFilter
        {
            margin: 10px;
            width: 20%;
            float: left;
        }
        .titulo 
        {
            font-family: Lucida Console, Times, serif;
            padding-top: 50px;
            font-weight:bold;
            text-align:left;

        }
    </style>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Inicio" runat="server">
    <div style="width: 85%; margin: 0 auto; clear: left; border-top: 1px solid; border-color: #003322;">
        <asp:ListView ID="ListView1" runat="server"  DataSourceID="SqlDataSource1">
            <ItemTemplate>
                <h1 class="titulo">Mi Lista De Ofertas:</h1> 
                <div class="listaVehiculos">
                    <div style="margin-bottom: 10px; border-bottom: 1px solid; border-color: #003322; background-color: #00cc88;">
                        <p><%# Eval("marca")%></p>
                    </div>
                    <p><img style="border-radius: 5px;" alt="" height="150" width="180" src='<%#Eval("imagen")%>' /></p>
                    <p>Marca: <%# Eval("marca")%></p>
                    <p>Modelo: <%# Eval("modelo")%></p>
                    <p>Año: <%# Eval("anyo")%></p>
                    <div style="float: left;">
                        <asp:Button ID="detalles_ofertas" Text="Detalles" CssClass="buttonVehiculo" runat="server" OnCommand="CarDetails_Command" CommandArgument='<%#Eval("matricula")%>' CommandName="viewdetails"></asp:Button>
                    <div style="float: right;">
                        <asp:Button ID="borrar_ofertas" Text="Borrar" CssClass="buttonVehiculo" runat="server" ></asp:Button></div>
                </div>
            </ItemTemplate>
        </asp:ListView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DataBaseConnection %>" SelectCommand="SELECT Oferta.descuento, Vehiculo.precio, Vehiculo.km, Vehiculo.marca, Vehiculo.modelo, Vehiculo.imagen, Vehiculo.matricula, Vehiculo.anyo,Vehiculo.descripcion FROM Vehiculo INNER JOIN Oferta ON Vehiculo.matricula = Oferta.matricula"></asp:SqlDataSource>
    </div>
</asp:Content>