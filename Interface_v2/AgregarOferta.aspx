<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AgregarOferta.aspx.cs" Inherits="Interface_v2.imagenes.AgregarOferta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
        <div class="container" style="">
        <div class="row">
            <div class="col-md-9">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col-md-12">
                                <h3>Seleccion un coche para añadir </h3>
            
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <div class="form-group row">
                                    <label for="name" class="col-4 col-form-label">Matricula</label>
                                    <div class="col-8">
                                        <asp:DropDownList ID="matricula_ofertas" runat="server" CssClass="form-control here" required="required" placeholder="Selecciona">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <hr>
                                <div class="form-group row">
                                    <label for="marca" class="col-4 col-form-label">Marca</label>
                                    <div class="col-8">
                                        <asp:TextBox runat="server" ID="marca" name="marca" placeholder="Marca" CssClass="form-control here" required="required"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <label for="lastname" class="col-4 col-form-label">Modelo</label>
                                    <div class="col-8">
                                        <asp:TextBox runat="server" ID="modelo" name="size" placeholder="Modelo" CssClass="form-control here" required="required"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <label for="text" class="col-4 col-form-label">Color</label>
                                    <div class="col-8">
                                        <asp:TextBox runat="server" ID="color" name="color" placeholder="Color" CssClass="form-control here" required="required"></asp:TextBox>

                                    </div>
                                </div>
                                <div class="form-group row">
                                    <label for="text" class="col-4 col-form-label">Precio</label>
                                    <div class="col-8">
                                        <asp:TextBox runat="server" ID="precio" name="precio" placeholder="Precio" CssClass="form-control here" required="required"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <label for="email" class="col-4 col-form-label">Año</label>
                                    <div class="col-8">
                                        <asp:TextBox runat="server" ID="anyo" name="anyo" placeholder="Año" CssClass="form-control here" required="required"> </asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <label for="website" class="col-4 col-form-label">Kilometros</label>
                                    <div class="col-8">
                                        <asp:TextBox runat="server" ID="km" name="km" placeholder="Km" CssClass="form-control here" required="required"></asp:TextBox>
                                    </div>
                                </div>
                                </div>
                                <div class="form-group row">
                                    <div class="offset-3 col-8">
                                        <asp:Button runat="server" name="submit" class="btn btn-primary" ID="submit" Text="Añadir coche" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
