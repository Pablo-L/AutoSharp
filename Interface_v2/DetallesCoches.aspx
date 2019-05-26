<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="DetallesCoches.aspx.cs" Inherits="Interface_v2.DetallesCoches" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
    
    <style>
        .profile {
            background: #f9f9f9;
        }

        .profile .info_list li {
            width: 25%;
        }

        .specs_block {
            background: #fff;
            border-radius: 10px;
            border: 1px solid rgba(0, 0, 0, 0.125);
            overflow: hidden;
            float: left;
            width: 100%;
            margin: 15px 0px;
        }

        .specs_DB {
            float: left;
            width: 100%;
            position: relative;
            padding: 25px 30px 30px;
        }

        .margin-top--22 {
            margin-top: -22px;
        }

        .specs_block h4 {
            color: black;
        }

        .info_list img {
            width: 20px;
            padding-right: 5px;
        }

        .info_list {
            list-style: none;
            padding: 0;
            font-size: 16px;
        }

        .info_list li {
            padding: 6px 0;
            font-size: 15px;
            display: table;
            height: 100%;
            line-height: 21px;
            float: left;
            width: 50%;
            margin-bottom: 5px;
            font-weight: bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">                            
    <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1">
        <ItemTemplate>
            <div class="container">
                <div class="row">
                    <div class="col-md-8">
                        <div class="slider">
                            <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">

                                <ol class="carousel-indicators">
                                    <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
                                    <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
                                    <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
                                </ol>
                                <div style="border-radius: 0.25rem;" class="carousel-inner">
                                    <div class="carousel-item active">
                                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("imagen") %>' Width="100%"/>
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
                        </div>
   
                        <div class="specs_block">
                            <div class="specs_DB">
                                <h1>
                                    <asp:Label ID="marcaLabel" runat="server" Text='<%# Eval("marca") %>' />
                                    <asp:Label ID="modelLabel" runat="server" Text='<%# Eval("modelo") %>' />
                                    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                                    <asp:Label ID="precioLabel" runat="server" Text='<%# Eval("precio") + " €"%> ' ForeColor="Red" />
                                </h1>
                                <h4 class="pb-3">Especificaciones técnicas</h4>
                                <ul class="info_list ">
                                    <li>
                                       Año: <asp:Label ID="anyoLabel" runat="server" Text='<%# Eval("anyo") %>' />
                                    </li>
                                    <li>
                                        Kilómetros: <asp:Label ID="kmLabel" runat="server" Text='<%# Eval("km") %>' /> Km
                                    </li>
                                    <li>
                                        Potencia: <asp:Label ID="potenciaLabel" runat="server" Text='<%# Eval("potencia") %>' /> CV

                                    </li>
                                    <li>
                                        Combustible: <asp:Label ID="combustibleLabel" runat="server" Text='<%# Eval("combustible") %>' /> 
                                    </li>
                                    <li>
                                        Color: <asp:Label ID="colorLabel" runat="server" Text='<%# Eval("color") %>' />
                                    </li>
                                </ul>
                            </div>
                            <div class="specs_DB margin-top--22">
                                <h4 class="pb-3">Comentarios del anunciante</h4>
                                <asp:Label ID="descripcionLabel" runat="server" Text='<%# Eval("descripcion") %>' />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DataBaseConnection %>" SelectCommand="SELECT [modelo], [marca], [color], [anyo], [combustible], [potencia], [km], [precio], [imagen], [cif], [nif], [categoria], [descripcion], [matricula] FROM [Vehiculo] WHERE ([matricula] = @matricula)">
        <SelectParameters>
            <asp:QueryStringParameter Name="matricula" QueryStringField="matricula" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>


</asp:Content>