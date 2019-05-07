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


<asp:Content ID="Content6" runat="server" ContentPlaceHolderID="dummy2">
    
<!--Login-->

    <div >
        
        <div style="align-content:center; vertical-align: middle; text-align: center; word-spacing: normal; letter-spacing: normal; position: relative;">
            <asp:Table runat="server" HorizontalAlign="Center">
                
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell><p></p></asp:TableHeaderCell>
                    <asp:TableHeaderCell>Log In</asp:TableHeaderCell>
                </asp:TableHeaderRow>

                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="right">
                        Usuario:
                    </asp:TableCell>
                    <asp:TableCell>
                         <asp:TextBox ID="TextBox4" runat="server" Text=""></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="right">
                        Contraseña:
                    </asp:TableCell>
                    <asp:TableCell>
                         <asp:TextBox ID="TextBox5" runat="server" Text=""></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <p></p>
                    </asp:TableCell>
                    
                    <asp:TableCell>
                         <asp:Button runat="server" Text="Entrar"/>
                    </asp:TableCell>
                </asp:TableRow>

            </asp:Table>
        </div>
    </div>
</asp:Content>