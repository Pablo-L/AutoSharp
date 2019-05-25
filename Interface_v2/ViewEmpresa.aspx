<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ViewEmpresa.aspx.cs" Inherits="Interface_v2.ViewEmpresa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <!------ Include the above in your HEAD tag ---------->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <div class="container" style="">
        <div class="row">

            <div class="col-md-9">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col-md-12">
                                <h3>Información actual de tu perfil</h3>
                                <hr>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <!--
                                  CIF
                                -->
                                <div class="form-group row">
                                    <label for="CIF" class="col-4 col-form-label">CIF</label>
                                    <div class="col-8">
                                        <asp:TextBox runat="server" ID="CIF" name="CIF" placeholder="CIF" CssClass="form-control here"></asp:TextBox>
                                    </div>
                                </div>

                                <!--
                                  Nombre
                                -->
                                <div class="form-group row">
                                    <label for="name" class="col-4 col-form-label">Nombre</label>
                                    <div class="col-8">
                                        <asp:TextBox runat="server" ID="name" name="name" placeholder="Name" CssClass="form-control here"></asp:TextBox>
                                    </div>
                                </div>
                                <!--
                                  Tamaño
                                -->

                                <div class="form-group row">
                                    <label for="lastname" class="col-4 col-form-label">Tamaño</label>
                                    <div class="col-8">
                                        <asp:TextBox runat="server" ID="size" name="size" placeholder="Tamaño" CssClass="form-control here"></asp:TextBox>
                                    </div>
                                </div>
                                <!--
                                  Direccion
                                -->
                                <div class="form-group row">
                                    <label for="text" class="col-4 col-form-label">Direccion</label>
                                    <div class="col-8">
                                        <asp:TextBox runat="server" ID="direction" name="direction" placeholder="Direccion" CssClass="form-control here"></asp:TextBox>

                                    </div>
                                </div>
                                <!--
                                  Telefono
                                -->
                                <div class="form-group row">
                                    <label for="text" class="col-4 col-form-label">Telefon</label>
                                    <div class="col-8">
                                        <asp:TextBox runat="server" ID="telefono" name="telefono" placeholder="Teléfono" CssClass="form-control here"></asp:TextBox>

                                    </div>
                                </div>
                                <!--
                                  Contraseña
                                -->
                                <div class="form-group row">
                                    <label for="publicinfo" class="col-4 col-form-label">Contraseña</label>
                                    <div class="col-8">
                                        <asp:TextBox runat="server" ID="pswd" name="pswd" placeholder="Contraseña" CssClass="form-control here"></asp:TextBox>

                                    </div>
                                </div>


                                <div class="form-group row">
                                    <div class="offset-3 col-8">
                                        <asp:Button runat="server" name="submit" class="btn btn-primary" ID="submit" Text="Ver mis Vehiculos" />

                                        &nbsp
                                        <asp:Button PostBackUrl="~/SignUpCar.aspx" runat="server" name="submit" class="btn btn-primary" ID="Button1" Text="Añadir Vehiculo" />
                                    </div>

                                </div>
                                <!--
                                  -->

                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>