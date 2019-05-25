<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Empresa.aspx.cs" Inherits="Interface_v2.Empresa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js"></script>
    <script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
    <style>
        .productList {
            border: 1px solid #6c757d;
            margin-top: 10px;
            margin-bottom: 10px;
            margin-left: 50px;
            padding: 15px;
            border-radius: 3px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server" >
  <div class="container py-4">
        <asp:DataList ID="InitialDataList" runat="server" CssClass="row" DataSourceID="SqlDataSource1" RepeatLayout="Table" RepeatColumns="2">
            <ItemTemplate>
                <div class="row productList">
                    <div class="col-4">
                        <img alt="" width="200" height="200"  src='<%#Eval("imagen")%>' />
                    </div>
                    <div class="col-8">
                        <h4>
                            <%#Eval("nombre")%>           
                        </h4>
                        <h6>Email: <%#Eval("email")%></h6>
                        <h7>Direccion: <%#Eval("direccion")%><br /></h7>
                        <h8></id>Teléfono: <%#Eval("telefono")%></h8>  
                </div>
            </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DataBaseConnection %>" SelectCommand="SELECT [nombre], [email], [direccion], [telefono], [imagen] FROM [Empresa]"></asp:SqlDataSource>
    </div>
</asp:Content>