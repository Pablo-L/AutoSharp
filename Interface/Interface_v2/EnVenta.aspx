<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="EnVenta.aspx.cs" Inherits="Interface_v2.EnVenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .listaVehiculos {
            border: 1px solid;
            width: 270px;
            float: left;
            margin:30px;
            padding: 1em;
            text-align: center;
            font-family: Lucida Console, Times, serif; 
            color: #003322;
            border-radius: 5px;
        }

        .buttonVehiculo
        {
            border-radius: 10px;
            font-family: Lucida Console, Times, serif; 
            color: #003322;
            background-color: white;
            padding: 0.4em;
            margin: 5px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <div style="width: 85%; margin: 0 auto; clear: left; border-color: #003322;">  
        <div style="color: red; text-align:center; font-family: Lucida Console, Times, serif;">
            <asp:Label ID="txtmessage" runat="server" Text="" />
        </div>
        <asp:ListView ID="ListView1" runat="server" OnItemCommand="ListView1_ItemCommand" OnSelectedIndexChanged="ListView1_SelectedIndexChanged">  
            <ItemTemplate>
                <div class="listaVehiculos">
                    <div style="margin-bottom: 10px; border-color: #003322; background-color: #00cc88;"><p><%# Eval("marca")%></p></div>
                    <p><img style="border-radius: 5px;" alt="" height="150" width="180" src='<%#Eval("imagen")%>' /></p>
                    <p>Matricula: <asp:TextBox runat="server" required="required" Id="matricula" Text='<%# Eval("matricula")%>'></asp:TextBox></p>
                    <p>Marca: <asp:TextBox runat="server" required="required" Text='<%# Eval("marca")%>' id="marca"></asp:TextBox></p>
                    <p>Modelo: <asp:TextBox runat="server" required="required" id="modelo" Text='<%# Eval("modelo")%>'></asp:TextBox></p>
                    <p>Año: <asp:TextBox runat="server" required="required" id="año" Text='<%# Eval("anyo")%>'></asp:TextBox></p>
                    <p>Color: <asp:TextBox runat="server" required="required" id="color" Text='<%# Eval("color")%>'></asp:TextBox></p>
                    <p>Combustible: <asp:TextBox runat="server" required="required" id="combustible" Text='<%# Eval("combustible")%>'></asp:TextBox></p>
                    <p>Kilometros: <asp:TextBox runat="server" required="required" id="km" Text='<%# Eval("km")%>'></asp:TextBox></p>
                    <p>Precio: <asp:TextBox runat="server" required="required" id="precio" Text='<%# Eval("precio")%>'></asp:TextBox></p>
                    <p>Potencia: <asp:TextBox runat="server" required="required"  id="potencia" Text='<%# Eval("potencia")%>'></asp:TextBox></p>
                    <div><asp:Button class="buttonVehiculo" ID="Actualizar" Text="Actualizar" runat="server" CommandName="ActualizarCommand" CommandArgument="ActualizarArgument"/></div>
                    <div><asp:Button class="buttonVehiculo" Text="Borrar" id="Borrar" runat="server" CommandName="BorrarCommand" CommandArgument="BorrarArgument"  /></div>
                </div>
            </ItemTemplate>  
        </asp:ListView> 
    </div>
</asp:Content>
