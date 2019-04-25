<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MasterPiece.aspx.cs" Inherits="Interface.MasterPiece" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
                <div align="center"><asp:Button ID="Log" runat="server"  Text="Iniciar Sesión"/></div>
                <p style="font-size:10px;"><br />¿Nuevo en AutoSharp? Registrate Aquí </p>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ImagenesScroll" runat="server">
    <link href="CSS/SlideShow.css" rel="stylesheet" />
    <div class="slideshow-container">

        <!-- Full-width images with number and caption text -->
        <div class="mySlides fade">
            <div class="numbertext">1 / 3</div>
            <img src="img1.jpg" style="width: 100%">
            <div class="text">Caption Text</div>
        </div>

        <div class="mySlides fade">
            <div class="numbertext">2 / 3</div>
            <img src="img2.jpg" style="width: 100%">
            <div class="text">Caption Two</div>
        </div>

        <div class="mySlides fade">
            <div class="numbertext">3 / 3</div>
            <img src="img3.jpg" style="width: 100%">
            <div class="text">Caption Three</div>
        </div>

        <!-- Next and previous buttons -->
        <a class="prev" onclick="plusSlides(-1)">&#10094;</a>
        <a class="next" onclick="plusSlides(1)">&#10095;</a>
    </div>
    <br>

<!-- The dots/circles -->
    <div style="text-align: center">
        <span class="dot" onclick="currentSlide(1)"></span>
        <span class="dot" onclick="currentSlide(2)"></span>
        <span class="dot" onclick="currentSlide(3)"></span>
    </div>
</asp:Content>
