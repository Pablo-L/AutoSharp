<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Vehiculos.aspx.cs" Inherits="Interface_v2.Vehiculos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" id="bootstrap-css">
    <script src="https://code.jquery.com/jquery-3.4.1.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" ></script>    
    <link href="css/DataList.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <div class="container-fluid bg-light ">
        <div class="row align-items-center justify-content-center">
            <div class="col-md-2 pt-3">
                <div class="form-group ">
                    <select id="inputState " class="form-control">
                        <asp:DropDownList ID="marca" runat="server">

                        </asp:DropDownList>
                    </select>
                </div>
            </div>
            <div class="col-md-2 pt-3">
                <div class="form-group">
                    <select id="inputState" class="form-control">
                        <asp:DropDownList ID="modelo" runat="server">

                        </asp:DropDownList>
                    </select>
                </div>
            </div>
            <div class="col-md-2 pt-3">
                <div class="form-group">
                    <select id="inputState" class="form-control">
                        <asp:DropDownList ID="precio" runat="server">

                        </asp:DropDownList>
                    </select>
                </div>
            </div>
            <div class="col-md-2 pt-3">
                <div class="form-group">
                    <select id="inputState" class="form-control">
                        <asp:DropDownList ID="kilometros" runat="server">

                        </asp:DropDownList>
                    </select>
                </div>
            </div>
            <div class="col-md-2 pt-3">
                <div class="form-group">
                    <select id="inputState" class="form-control">
                        <asp:DropDownList ID="Anyo" runat="server">
                        </asp:DropDownList>
                    </select>
                </div>
            </div>
            <div class="col-md-2">
                <asp:Button Text="Buscar" runat="server" class="btn btn-primary btn-block"/>
            </div>
        </div>
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
                            <asp:HyperLink ID="CarDetails" runat="server" NavigateUrl="~/DetallesCoches.aspx" >
                                <%#Eval("marca")%>&nbsp<%#Eval("modelo")%>
                            </asp:HyperLink>
                        </h4>
                        <h6>Precio: <%#Eval("precio")%>€ Año: <%#Eval("anyo")%></h6>
                        <div>
                            <%#Eval("descripcion")%>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DataBaseConnection %>" SelectCommand="SELECT [imagen], [descripcion], [modelo], [marca], [precio], [anyo] FROM [Vehiculo]"></asp:SqlDataSource>
    </div>
</asp:Content>