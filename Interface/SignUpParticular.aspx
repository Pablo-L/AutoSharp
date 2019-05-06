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
  
    <!-- Este es el registro para la empresa-->

    <div style="align-content:center">
        <asp:Label ID="Label1" runat="server" Text="Se va a registrar como particular, si es una empresa pulse el boton cambiar. "></asp:Label>
        &nbsp
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
