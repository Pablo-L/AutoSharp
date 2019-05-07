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
</asp:Content>

<asp:Content ID="Formulario" ContentPlaceHolderID="PageBody" runat="server">
    <!--Registro para un particular-->
    <div style="align-content:center">
        <asp:Label ID="selectButtonLabel" runat="server" Text="Se va a registrar como empresa, si es un particular pulse el boton cambiar. "></asp:Label>
        &nbsp
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
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <option value="Grande">Grande</option>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <option value="Mediana">Mediana</option>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <option value="Pequeña">Pequeña</option>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </select>
               
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