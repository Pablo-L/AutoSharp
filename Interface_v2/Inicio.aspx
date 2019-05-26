<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Interface_v2.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" id="bootstrap-css">
    <script src="https://code.jquery.com/jquery-3.4.1.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" ></script>    
    <link href="css/DataList.css" rel="stylesheet" />
 </asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
        <ol class="carousel-indicators">
            <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
            <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
            <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
        </ol>
        <div class="carousel-inner">
            <div class="carousel-item active">
                <img class="d-block w-100" height="500" src="imagenes/carrousel/used-car-sales.jpg" alt="First slide">
                <div class="carousel-caption d-none d-md-block">
                    <h5 >Venta de Coches de Segunda Mano</h5>
                    <p> Más de 1000 empresas se han registrado en nuestra Web</p>
                </div>
            </div>
            <div class="carousel-item">
                <img class="d-block w-100" height="500" src="imagenes/carrousel/thumb_dealer.jpg" alt="Second slide">
                <div class="carousel-caption d-none d-md-block">
                    <h5>Rápida Respuesta por Parte Nuestros Anunciantes</h5>
                    <p>Podrás contactar con nuestras empresas filiales por mensajes directo</p>
                </div>
            </div>
            <div class="carousel-item">
                <img class="d-block w-100" height="500" src="imagenes/carrousel/Car Sales - Credit Unions.png" alt="Third slide">
                <div class="carousel-caption d-none d-md-block">
                    <h5>Facilidades para nuestros clientes</h5>
                    <p>Si te has decidido por un coche te damos la oportunidad de probarlo</p>
                </div>
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
    
    <div class="container py-4">
        <asp:DataList ID="InitialDataList" runat="server" CssClass="row" DataSourceID="SqlDataSource1">
            <ItemTemplate>
                <div class="row productList">
                    <div class="col-4">
                        <img alt="" width="250" src='<%#Eval("imagen")%>' />
                    </div>
                    <div class="col-8">
                        <h4>
                            <asp:LinkButton ID="CarDetails" runat="server" OnCommand="CarDetails_Command" CommandArgument='<%#Eval("matricula")%>' CommandName="viewdetails">
                                <%#Eval("marca")%>&nbsp<%#Eval("modelo")%>
                            </asp:LinkButton>
                        </h4>
                        <h6>Precio: <%#Eval("precio")%>€ Año: <%#Eval("anyo")%></h6>
                        <div>
                            <%#Eval("descripcion")%>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DataBaseConnection %>" SelectCommand="SELECT [imagen], [descripcion], [modelo], [marca], [precio], [anyo], [matricula] FROM [Vehiculo]"></asp:SqlDataSource>
    </div>
</asp:Content>
