<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ListaOferta.aspx.cs" Inherits="Interface_v2.ListaOferta" %>
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
                    <p>Matricula: <asp:TextBox runat="server" required="required" readonly="true" Id="matricula" Text='<%# Eval("matricula")%>'></asp:TextBox></p>
                    <p>Marca: <asp:TextBox runat="server" required="required" readonly="true" Text='<%# Eval("marca")%>' id="marca"></asp:TextBox></p>
                    <p>Modelo: <asp:TextBox runat="server" required="required" id="modelo" readonly="true" Text='<%# Eval("modelo")%>'></asp:TextBox></p>
                    <p>Oferta: <asp:TextBox style="color: red" runat="server" required="required" readonly="true" id="oferta" Text='<%# Eval("descripcion")%>'></asp:TextBox></p>
                    <p>Desde: <asp:TextBox style="color: red" runat="server" required="required" readonly="true" id="inicio" Text='<%# Eval("fecha_inicio")%>'></asp:TextBox></p>
                    <p>Hasta: <asp:TextBox style="color: red" runat="server" required="required" id="fin" Text='<%# Eval("fecha_fin")%>'></asp:TextBox></p>
                    <div><asp:Button class="buttonVehiculo" ID="Prorrogar" Text="Actualizar" runat="server" CommandName="ActualizarCommand" CommandArgument="ActualizarArgument"/></div>
                    <div><asp:Button class="buttonVehiculo" Text="Borrar" id="Borrar" runat="server" CommandName="BorrarCommand" CommandArgument="BorrarArgument"  /></div>
                </div>
            </ItemTemplate>  
        </asp:ListView> 
    </div>
</asp:Content>
