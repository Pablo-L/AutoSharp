<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="Interface_v2.LogIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .login-container {
            margin-top: 5%;
            margin-bottom: 5%;
        }

        .login-logo {
            position: relative;
            margin-left: -41.5%;
        }

        .login-logo img {
            position: absolute;
            width: 20%;
            margin-top: 19%;
            background: #282726;
            border-radius: 4.5rem;
            padding: 5%;
        }

        .login-form-1 {
            padding: 9%;
            background-image: url("../imagenes/login_page_background.jpg");
            background-size: 100%;
            /*background: #282726;*/
            box-shadow: 0 5px 8px 0 rgba(0, 0, 0, 0.2), 0 9px 26px 0 rgba(0, 0, 0, 0.19);
        }

            .login-form-1 h3 {
                text-align: center;
                margin-bottom: 12%;
                color: #000;
            }

        .login-form-2 {
            padding: 9%;
            background: #00cc88;
            box-shadow: 0 5px 8px 0 rgba(0, 0, 0, 0.2), 0 9px 26px 0 rgba(0, 0, 0, 0.19);
        }

        .login-form-2 h3 {
            text-align: center;
            margin-bottom: 12%;
            color: #fff;
        }

        .btnSubmit {
            font-weight: 600;
            width: 50%;
            color: #282726;
            background-color: #fff;
            border: none;
            border-radius: 1.5rem;
            padding: 2%;
        }

        .btnForgetPwd {
            color: #000;
            font-weight: 600;
            text-decoration: none;
        }

        .btnForgetPwd2 {
            color: #000;
            font-weight: 600;
            text-decoration: none;
        }

        .btnForgetPwd:hover {
            text-decoration: solid;
            color: #f05837;
        }

        .btnForgetPwd2:hover {
            text-decoration: solid;
            color: black;
        }
    </style>
    
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <!------ Include the above in your HEAD tag ---------->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <div class="container login-container">
        <div class="row">

            <div class="col-md-6 login-form-1">
                <h3>Inicio Empresas</h3>

                <div class="form-group">
                    <asp:TextBox ID="IDEmpresa" runat="server" CssClass="form-control" placeholder="CIF"></asp:TextBox>

                </div>

                <div class="form-group">
                    <asp:TextBox ID="PassEmpresa" runat="server" CssClass="form-control" placeholder="Contraseña"></asp:TextBox>

                </div>


                <div class="col-sm-12 text-center">
                    <asp:Button  CssClass="btnSubmit" ID="LogInEmpresa" runat="server" Text="Iniciar Sesión" OnClick ="LoginEmpresa" />
                    <br />
                </div>

                <div class="col-sm-12 text-center">
                    <br />
                    <asp:Button PostBackUrl="~/SignUpEmpresa.aspx" CssClass="btnSubmit" ID="SignUpEmpresa" runat="server" Text="Regístrate" />

                </div>



            </div>


            <div class="col-md-6 login-form-2">

                <h3>Inicio Particulares</h3>
                <div class="form-group">
                    <asp:TextBox ID="IDParticular" runat="server" CssClass="form-control" placeholder="NIF"></asp:TextBox>

                </div>
                <div class="form-group">
                    <asp:TextBox ID="PassParticular" runat="server" CssClass="form-control" placeholder="Contraseña"></asp:TextBox>

                </div>

                <div class="col-sm-12 text-center">
                    <asp:Button CssClass="btnSubmit" ID="Btnloginp" runat="server" Text="Iniciar Sesión" OnClick="Btnloginp_Click1" />
                    <br />
                </div>

                <div class="col-sm-12 text-center">
                    <br />
                    <asp:Button PostBackUrl="~/SignUpParticular.aspx" CssClass="btnSubmit" ID="SignUpParticular" runat="server" Text="Regístrate" />

                </div>
            </div>
        </div>
    </div>

</asp:Content>

