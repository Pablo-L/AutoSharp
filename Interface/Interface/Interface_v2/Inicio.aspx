<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Interface_v2.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
                height: 500px;
            }
        </style>
 </asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <div id="carouselExampleIndicators" style="margin: 0 auto; width: 80%" class="carousel slide" data-ride="carousel">
        <ol class="carousel-indicators">
            <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
            <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
            <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
        </ol>
        <div class="carousel-inner">
            <div class="carousel-item active">
                <img class="d-block w-100" style="height: 480px;" src="imagenes/carrousel/carr1.jpg" alt="First slide">
            </div>
            <div class="carousel-item">
                <img class="d-block w-100" style="height: 480px;" src="imagenes/carrousel/carr2.jpg" alt="Second slide">
            </div>
            <div class="carousel-item">
                <img class="d-block w-100" style="height: 480px;" src="imagenes/carrousel/carr3.jpg" alt="Third slide">
            </div>
        </div>
        <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
        </a>
    </div>
    <div style="margin: 20px; border-top: 1px solid; padding: 1em; border-bottom: 1px solid; border-color: #003322">
        <h1 style="font-family: Lucida Console, Times, serif; color: #003322;">Ofertas</h1>
    </div>
    <div style="width: 85%; margin: 0 auto; clear: left;">  
        <asp:ListView ID="ListView1" runat="server">  
            <ItemTemplate>
                <div class="listaVehiculos">
                    <div style="margin-bottom: 10px; border-color: #003322; background-color: #00cc88;"><p><%# Eval("marca")%></p></div>
                    <p><img style="border-radius: 5px;" alt="" height="150" width="180" src='<%#Eval("imagen")%>' /></p>
                    <p>Matricula: <%# Eval("matricula")%></p>
                    <p>Marca: <%# Eval("marca")%></p>
                    <p>Modelo: <%# Eval("modelo")%></p>
                    <p>Oferta: <%# Eval("descripcion")%></p>
                    <p>Desde: <%# Eval("fecha_inicio")%></p>
                    <p>Hasta: <%# Eval("fecha_fin")%></p>
                </div>
            </ItemTemplate>  
        </asp:ListView> 
    </div>
</asp:Content>
