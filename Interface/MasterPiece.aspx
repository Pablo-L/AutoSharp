<%
    @ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MasterPiece.aspx.cs" 
%>

<script runat="server">

    protected void selectButton_Click(object sender, EventArgs e)
    {

    }
</script>


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


<asp:Content ID="Content4" ContentPlaceHolderID="PageBody" runat="server">
    <div style="align-content:center">
        <asp:Label ID="selectButtonLabel" runat="server" Text="Se va a registrar como particular, si es una empresa pulse el boton cambiar. "></asp:Label>
        <br />
        <asp:Button  ID="selectButton" runat="server" Text="Cambiar" OnClick="selectButton_Click"/>
    </div>
    <asp:Table ID="tablaLogin" runat="server">

        <asp:TableHeaderRow>
            <asp:TableHeaderCell VerticalAlign="Bottom" HorizontalAlign="Center">Registro</asp:TableHeaderCell>
        </asp:TableHeaderRow>

        <asp:TableRow>
            <asp:TableCell>Nombre:</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox0" runat="server" Text=""></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>Email:</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox1" runat="server" Text=""></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>CIF:</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox2" runat="server" Text=""></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>Telefono:</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox3" runat="server" Text=""></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>Tamaño:</asp:TableCell>
            <asp:TableCell>
            
            <select name="size">
                <option value="Grande">Grande</option>
                <option value="Mediana">Mediana</option>
                <option value="Pequeña">Pequeña</option>
                
            </select>
               
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>Contraseña:</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox8" runat="server" Text=""></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>Repetir Contraseña:</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="nombre" runat="server" Text=""></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

    </asp:Table>

</asp:Content>

<asp:Content ID="Content5" ContentPlaceHolderID="dummy" runat="server">
    <div style="align-content:center">
        <asp:Label ID="Label1" runat="server" Text="Se va a registrar como particular, si es una empresa pulse el boton cambiar. "></asp:Label>
        <br />
        <asp:Button  ID="Button1" runat="server" Text="Cambiar" OnClick="selectButton_Click"/>
    </div>
    <asp:Table ID="Table1" runat="server">

        <asp:TableHeaderRow>
            <asp:TableHeaderCell VerticalAlign="Bottom" HorizontalAlign="Center">Registro</asp:TableHeaderCell>
        </asp:TableHeaderRow>

        <asp:TableRow>
            <asp:TableCell>Nombre:</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox9" runat="server" Text=""></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>Apellidos:</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox10" runat="server" Text=""></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>NIF:</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox11" runat="server" Text=""></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>Email:</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox12" runat="server" Text=""></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>Telefono:</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox13" runat="server" Text=""></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>Direccion:</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox14" runat="server" Text=""></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>IBAN:</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox15" runat="server" Text=""></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>Nombre:</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox16" runat="server" Text=""></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>Contraseña:</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox17" runat="server" Text=""></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>Repetir Contraseña:</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox18" runat="server" Text=""></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

    </asp:Table>
</asp:Content>