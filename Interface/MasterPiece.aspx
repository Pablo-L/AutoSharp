<%
    @ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MasterPiece.aspx.cs" 
%>

<script runat="server">

    protected void selectButton_Click(object sender, EventArgs e)
    {

    }

    protected void Log_Click(object sender, EventArgs e)
    {

    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
</script>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<<<<<<< HEAD
    
=======

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="NavigationBar" runat="server">
    <link href="CSS/NavBar.css" rel="stylesheet"/>
    <link href="CSS/Buttons.css" rel="stylesheet"/>
    <div class="NavBar">
        <a class="logo"><img src="Imagenes/Logo/logo.jpg " style="height: 40px; width: 40px" /></a>
        <div class="Drop">
            <button class="dropbtn">Buscar</button>
            <div class="drop-content">
                <a href="#">Coches</a>
                <a href="#">Motos</a>
                <a href="#">Profesionales</a>
            </div>
        </div>
        <a href="#">Vender</a>
        <a href="#">Contacto</a>
        <div class="Drop" style="float:right ;">
            <button class="dropbtn">Mi AutoScout</button>
            <div class="drop-content">
                <a href="#">Mis vehículos guardados (0)</a>
                <a href="#">Mis búsquedas guardadas</a>
                <a href="#">Mis Anuncios</a>
                <div align="center">
                    <asp:Button OnClick="Log_Click" ID="Log" runat="server"  Text="Iniciar Sesión"/>
                </div>
                <p style="font-size:10px;"><br />¿Nuevo en AutoSharp? Registrate </p>
                <p style="font-size:10px;" onclick="RedirectToRegister">Aqui</p>
            </div>
        </div>
    </div>
>>>>>>> X8317572J
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ImagenesScroll" runat="server">

    <div class="slideshow">
        <ul class="slider">
            <li>
                <img src="Imagenes/Slider/1.jpg" alt="">
                <section class="caption">
                    <h1>Lorem ipsum 1</h1>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Adipisci quis ipsa, id quidem quisquam unde.</p>
                </section>
            </li>
            <li>
                <img src="Imagenes/Slider/2.jpg" alt="">
                <section class="caption">
                    <h1>Lorem ipsum 2</h1>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Adipisci quis ipsa, id quidem quisquam unde.</p>
                </section>
            </li>
            <li>
                <img src="Imagenes/Slider/3.jpg" alt="">
                <section class="caption">
                    <h1>Lorem ipsum 3</h1>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Adipisci quis ipsa, id quidem quisquam unde.</p>
                </section>
            </li>
        </ul>
        <ol class="pagination">
        </ol>
        <div class="left">
            <span class="fa fa-chevron-left"></span>
        </div>
        <div class="right">
            <span class="fa fa-chevron-right"></span>
        </div>
    </div>
    <script src="jQuery/jquery-3.1.0.min.js"></script>
    <script src="jQuery/main.js"></script>
    <link href="CSS/SlideShow.css" rel="stylesheet" />

</asp:Content>
