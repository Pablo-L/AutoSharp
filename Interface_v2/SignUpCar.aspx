<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="SignUpCar.aspx.cs" Inherits="Interface_v2.SignUpCar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <!------ Include the above in your HEAD tag ---------->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <div class="container" style="">
        <div class="row">
            <!--
            Matricula
            Marca 
            Modelo
            Color
            Precio

            Año
            Km
            Combustible 
            Potencia
            Descripcion
            -->
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
                                  Matricula
                                -->
                                <div class="form-group row">
                                    <label for="name" class="col-4 col-form-label">Matricula</label>
                                    <div class="col-8">
                                        <asp:TextBox runat="server" ID="matricula" name="matricula" placeholder="Matricula" CssClass="form-control here" required="required"></asp:TextBox>
                                    </div>
                                </div>

                                <!--
                                  Marca
                                -->
                                <div class="form-group row">
                                    <label for="marca" class="col-4 col-form-label">Marca</label>
                                    <div class="col-8">
                                        <asp:TextBox runat="server" ID="marca" name="marca" placeholder="Marca" CssClass="form-control here" required="required"></asp:TextBox>
                                    </div>
                                </div>

                                <!--
                                  Imagen
                                -->
                                <div class="form-group row">
                                    <label for="imagen" class="col-4 col-form-label">Imagen</label>
                                    <div class="col-8">
                                        <asp:TextBox Visible="true" runat="server" ID="TextBox1" name="marca" placeholder="Imagen" CssClass="form-control here" required="required"></asp:TextBox>
                                        <asp:LinkButton runat="server" ID="btnDocumentLocation" OnClientClick="return GetFile();">Browse...</asp:LinkButton>
                                        <asp:FileUpload runat="server" ID="fuDocumentLocation" OnChange="ChangeText(this.value);" Style="display: none" />


                                        <script type="text/javascript">
                                            function ChangeText(selectedPath) {
                                                document.getElementById('<%=TextBox1.ClientID %>').value = selectedPath;
                                                //TextBox1.text = selectedPath;
                                                //$('#' + '<%=TextBox1.ClientID%>').text(selectedPath);
                                            }

                                            function GetFile() {
                                                $('#' + '<%=fuDocumentLocation.ClientID%>').click();
                                                return false;
                                            }
                                        </script>
                                    </div>
                                </div>

                                <!--
                                  Modelo
                                -->

                                <div class="form-group row">
                                    <label for="lastname" class="col-4 col-form-label">Modelo</label>
                                    <div class="col-8">
                                        <asp:TextBox runat="server" ID="modelo" name="size" placeholder="Modelo" CssClass="form-control here" required="required"></asp:TextBox>
                                    </div>
                                </div>



                                <!--
                                  Color
                                -->
                                <div class="form-group row">
                                    <label for="text" class="col-4 col-form-label">Color</label>
                                    <div class="col-8">
                                        <asp:TextBox runat="server" ID="color" name="color" placeholder="Color" CssClass="form-control here" required="required"></asp:TextBox>

                                    </div>
                                </div>
                                <!--
                                  Precio
                                -->
                                <div class="form-group row">
                                    <label for="text" class="col-4 col-form-label">Precio</label>
                                    <div class="col-8">
                                        <asp:TextBox TextMode="Number" runat="server" ID="precio" name="precio" placeholder="Precio" CssClass="form-control here" required="required"></asp:TextBox>

                                    </div>
                                </div>




                                <div class="form-group row">
                                    <label for="email" class="col-4 col-form-label">Año</label>
                                    <div class="col-8">
                                        <asp:TextBox TextMode="Number" runat="server" ID="anyo" name="anyo" placeholder="Año" CssClass="form-control here" required="required"></asp:TextBox>
                                    </div>
                                </div>

                                <!--
                                  KM
                              -->
                                <div class="form-group row">
                                    <label for="website" class="col-4 col-form-label">Kilometros</label>
                                    <div class="col-8">
                                        <asp:TextBox runat="server" ID="km" name="km" placeholder="Km" CssClass="form-control here" required="required"></asp:TextBox>
                                    </div>
                                </div>

                                <!--
                                  Combustible
                                -->
                                <div class="form-group row">
                                    <label for="publicinfo" class="col-4 col-form-label">Tipo Combustible</label>
                                    <div class="col-8">
                                        <asp:TextBox runat="server" ID="combustible" name="combustible" placeholder="Combustible" CssClass="form-control here" required="required"></asp:TextBox>

                                    </div>
                                </div>

                                <!--
                               Potencia
                             -->
                                <div class="form-group row">
                                    <label for="publicinfo" class="col-4 col-form-label">Potencia</label>
                                    <div class="col-8">
                                        <asp:TextBox runat="server" ID="power" name="power" placeholder="Potencia" CssClass="form-control here" required="required"></asp:TextBox>

                                    </div>
                                </div>

                                <!--
                                  Decripcion
                                  -->
                                <div class="form-group row">
                                    <label for="publicinfo" class="col-4 col-form-label">Descripcion </label>
                                    <div class="col-8">
                                        <asp:TextBox runat="server" ID="description" name="description" placeholder="Descripcion" CssClass="form-control here" required="required"></asp:TextBox>

                                    </div>
                                </div>

                                <!--
                                  Imagen
                                  -->
                                <div class="form-group row">
                                    <label for="publicinfo" class="col-4 col-form-label">URL Imagen </label>
                                    <div class="col-8">
                                        <asp:TextBox runat="server" ID="image" name="image" placeholder="Enlace Imagens" CssClass="form-control here" required="required"></asp:TextBox>

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
    </div>
</asp:Content>
