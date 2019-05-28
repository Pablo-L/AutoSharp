<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AgregarOferta.aspx.cs" Inherits="Interface_v2.AgregarOferta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        p {
            font-family: "Lucida Console, Times, serif"; 
            color: #003322;
        }

        .QueryForm {
            font-family: "Lucida Console, Times, serif"; 
            color: #003322;
            padding: 0.5em;
            border-radius: 5px;
        }

        #DivQueryForm {
            margin: 0 auto;
            width: 50%;
            padding: 10px;
            background-color: #DDE4E1;
        }

        #QueryTitle {
            margin: 0 auto;
            width: 50%;
            padding: 10px;
            text-align: center;
            font-family: "Lucida Console, Times, serif"; 
            color: #003322;
            background-color: #00cc88;
        }

        .SendQuery {
            padding: 0.5em;
            border-radius: 10px; 
            border: 1px solid #003322;
            background-color: white;
        }

        .ProgressTemplate {
            text-align: center;
        }

        .listaVehiculos {
            border: 1px solid;
            width: 270px;
            float: left;
            padding: 1em;
            text-align: center;
            font-family: Lucida Console, Times, serif; 
            color: #003322;
            border-radius: 5px;
            background-color: #00cc88;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <div style="width: 70%; margin: 0 auto; margin-top: 50px; margin-bottom: 50px;">
        <div style="width: 50%; float:left;">
            <div id="QueryTitle"> Nueva oferta</div>
            <div id="DivQueryForm">
                <div style="color: red; text-align:center; font-family: Lucida Console, Times, serif;">
                    <asp:Label ID="txtmssg" runat="server" Text="" />
                </div>
                <p>Vehiculo:</p>
                <asp:DropDownList CssClass="QueryForm" Required="required" runat="server" ID="listOfVehicles" AutoPostBack="True" />
                <p>Oferta:</p>
                <asp:DropDownList CssClass="QueryForm" Required="required" runat="server" ID="listOfOferts" />
                <p>Fecha inicio:</p>
                <asp:TextBox CssClass="QueryForm" Required="required" id="fechaIni" Text="" runat="server" />
                <p>Fecha fin:</p>
                <asp:TextBox CssClass="QueryForm" Required="required" id="fechaFin" Text="" runat="server" />
                <br />
                <br />
                <asp:Button CssClass="SendQuery" Text="Ofertar" id="SendQuery" runat="server" OnClick="AgregarOferta_Click" />
            </div> 
        </div>
        <div style="width: 40%; float:right; margin-bottom: 50px;">
            <div class="listaVehiculos">
                <p>Matricula: <asp:Label runat="server" Id="matricula" Text=""></asp:Label></p>
                <p><asp:Image runat="server" style="border-radius: 5px;" alt="" height="150" width="180" Id="imgAuto" src="imagenes/coches_bd/default.png"/></p>
                <p>Marca: <asp:Label runat="server" Id="marca" Text=""></asp:Label></p>
                <p>Modelo: <asp:Label runat="server" Id="modelo" Text=""></asp:Label></p>
                <p>Año: <asp:Label runat="server" Id="año" Text=""></asp:Label></p>
                <p>Color: <asp:Label runat="server" Id="color" Text=""></asp:Label></p>
                <p>Combusitble: <asp:Label runat="server" Id="combustible" Text=""></asp:Label></p>
                <p>Km: <asp:Label runat="server" Id="km" Text=""></asp:Label></p>
                <p>Precio: <asp:Label runat="server" Id="precio" Text=""></asp:Label></p>
                <p>Potencia: <asp:Label runat="server" Id="potencia" Text=""></asp:Label></p>
            </div>
        </div>
    </div>
</asp:Content>
