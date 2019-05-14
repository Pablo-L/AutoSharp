<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Interface.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="login_page" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/Login_Page.css" />
    <div id="login_box">
        <div class="left_side">
            <h1>Iniciar Sesión</h1>
            <input type="text" name="nombre de usuario" placeholder="nombre de usuario" id="input_username" />
            <input type="password" name="contraseña" placeholder="contraseña" id="input_password" />
            <asp:Button ID="log_in" Text="Iniciar Sesion" OnClick="log_in_button" runat="server" />
        </div>
        <div class="right_side">
            <h1>Registrate</h1>  
            <asp:Button ID="sign_particular" Text="Como Particular" OnClick="log_in_button_part" runat="server" />
            <asp:Button ID="sign_empresario" Text="Como Empresario" OnClick="log_in_button_empre" runat="server" />
        </div>
        <div class="or">OR</div>
    </div>
</asp:Content>
