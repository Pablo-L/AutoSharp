<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Vehiculos.aspx.cs" Inherits="Interface_v2.Vehiculos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" id="bootstrap-css">
    <script src="https://code.jquery.com/jquery-3.4.1.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" ></script>    
    <link href="css/DataList.css" rel="stylesheet" />
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
        .filters 
        {
            font-family: Lucida Console, Times, serif;             
            color: #003322;
            border-radius: 10px;
            padding: 0.4em;
            border-bottom: 20px;
            margin-top: 10px;
        }

        .dropDownFilter
        {
            margin: 10px;
            width: 20%;
            float: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <div>
        <div style="margin: 10px auto 10px auto; width: 80%;">
            <div class="dropDownFilter">
                <asp:DropDownList class="filters" ID="Marca" runat="server">
                </asp:DropDownList>
            </div>
            <div class="dropDownFilter">
                <asp:DropDownList class="filters" ID="Modelo" runat="server">
                </asp:DropDownList>
            </div>
            <div class="dropDownFilter">
                <asp:DropDownList class="filters" ID="Año" runat="server">
                </asp:DropDownList>
            </div >
            <div style="margin: 0 auto; width: 15%; margin-top: 18px; float: left;">
                <asp:Button Text="Filtrar" OnClick="FiltrarVehiculo_Click" runat="server" class="btn btn-primary btn-block"/>
            </div>
        </div>
    </div>
    <div style="width: 85%; margin: 0 auto; clear: left; border-top: 1px solid; border-color: #003322;">  
        <asp:ListView ID="ListView1" runat="server" OnSelectedIndexChanged="ListView1_SelectedIndexChanged">  
            <ItemTemplate>
                <div class="listaVehiculos">
                    <div style="margin-bottom: 10px; border-bottom: 1px solid; border-color: #003322; background-color: #00cc88;">
                        <asp:LinkButton ID="CarDetails" runat="server" OnCommand="CarDetails_Command" CommandArgument='<%#Eval("matricula")%>' CommandName="viewdetails">
                        <p><%# Eval("marca")%></p>
                        </asp:LinkButton>
                    </div>
                    <asp:LinkButton ID="Car_Details" runat="server" OnCommand="CarDetails_Command" CommandArgument='<%#Eval("matricula")%>' CommandName="viewdetails">
                        <p><img style="border-radius: 5px;" alt="" height="150" width="180" src='<%#Eval("imagen")%>' /></p>
                    </asp:LinkButton>
                    <p>Marca: <%# Eval("marca")%></p>
                    <p>Modelo: <%# Eval("modelo")%></p>
                    <p>Año: <%# Eval("anyo")%></p>
                    <div style="float: left;"><asp:Button class="buttonVehiculo" Text="Comprar" id="Comprar" runat="server" OnClick="ComprarVehiculo_Click"  /></div>
                    <div style="float: right;"><asp:Button class="buttonVehiculo" Text="Reservar" id="Reservar" runat="server" OnClick="ReservarVehiculo_Click"  /></div>
                </div>
            </ItemTemplate>  
        </asp:ListView>  
    </div>  
</asp:Content>
