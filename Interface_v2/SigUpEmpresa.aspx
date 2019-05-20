<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="SigUpEmpresa.aspx.cs" Inherits="Interface_v2.SigUpEmpresa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <!------ Include the above in your HEAD tag ---------->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <div class="container">
        <div class="row">

            <div class="col-md-9">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col-md-12">
                                <h3>Registro Particular</h3>
                                <hr>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <!--
                                  NIF
                                -->
                                <div class="form-group row">
                                    <label for="NIF" class="col-4 col-form-label">NIF</label>
                                    <div class="col-8">
                                        <asp:TextBox runat="server" ID="NIF" name="NIF" placeholder="NIF" CssClass="form-control here" required="required"></asp:TextBox>
                                    </div>
                                </div>

                                <!--
                                  Nombre
                                -->
                                <div class="form-group row">
                                    <label for="name" class="col-4 col-form-label">Nombre</label>
                                    <div class="col-8">
                                        <asp:TextBox runat="server" ID="name" name="name" placeholder="Name" CssClass="form-control here" required="required"></asp:TextBox>
                                    </div>
                                </div>
                                <!--
                                  Apellidos
                                -->

                                <div class="form-group row">
                                    <label for="lastname" class="col-4 col-form-label">Apellidos</label>
                                    <div class="col-8">
                                        <asp:TextBox runat="server" ID="lastname" name="lastname" placeholder="Apellidos" CssClass="form-control here" required="required"></asp:TextBox>
                                    </div>
                                </div>
                                <!--
                                  Direccion
                                -->
                                <div class="form-group row">
                                    <label for="text" class="col-4 col-form-label">Direccion</label>
                                    <div class="col-8">
                                        <asp:TextBox runat="server" ID="direction" name="direction" placeholder="Direccion" CssClass="form-control here" required="required"></asp:TextBox>

                                    </div>
                                </div>
                                <!--
                                  Telefono
                                -->
                                <div class="form-group row">
                                    <label for="text" class="col-4 col-form-label">Telefono</label>
                                    <div class="col-8">
                                        <asp:TextBox TextMode="Number" runat="server" ID="telefono" name="telefono" placeholder="Teléfono" CssClass="form-control here" required="required"></asp:TextBox>

                                    </div>
                                </div>

                                <!--
                                  Email
                                -->
                                <div class="form-group row">
                                    <label for="email" class="col-4 col-form-label">Email</label>
                                    <div class="col-8">
                                        <asp:TextBox TextMode="Email" runat="server" ID="TextBox1" name="email" placeholder="Email" CssClass="form-control here" required="required"></asp:TextBox>
                                    </div>
                                </div>

                                <!--
                                  IBAN
                              -->
                                <div class="form-group row">
                                    <label for="website" class="col-4 col-form-label">IBAN</label>
                                    <div class="col-8">
                                        <asp:TextBox runat="server" ID="iban" name="email" placeholder="IBAN" CssClass="form-control here" required="required"></asp:TextBox>
                                    </div>
                                </div>

                                <!--
                                  Contraseña
                                -->
                                <div class="form-group row">
                                    <label for="publicinfo" class="col-4 col-form-label">Contraseña</label>
                                    <div class="col-8">
                                        <asp:TextBox TextMode="Password" runat="server" ID="pswd" name="pswd" placeholder="Contraseña" CssClass="form-control here" required="required"></asp:TextBox>

                                    </div>
                                </div>




                                <div class="form-group row">
                                    <label for="publicinfo" class="col-4 col-form-label">Repetir Contraseña</label>
                                    <div class="col-8">
                                        <asp:TextBox TextMode="Password" runat="server" ID="pswd2" name="pswd2" placeholder="Repetir Contraseña" CssClass="form-control here" required="required"></asp:TextBox>

                                    </div>
                                </div>


                                <div class="form-group row">
                                    <div class="offset-3 col-8">
                                        <asp:Button runat="server" name="submit" class="btn btn-primary" ID="submit" Text="Registrarse" />

                                    </div>
                                </div>

                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
