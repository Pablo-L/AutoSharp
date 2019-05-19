<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Empresas.aspx.cs" Inherits="Interface_v2.view.Empresas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" ></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" ></script>    
    <link href="css/DataList.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server" >
    <div class="container py-4">
        <asp:DataList ID="InitialDataList" runat="server" CssClass="row" DataSourceID="SqlDataSource1">
            <ItemTemplate>
                <div class="dataList">
                    <div class="col-4">
                        <img alt="" width="250" src='<%#Eval("imagen")%>' />
                    </div>
                    <div class="col-8">
                        <h4><%#Eval("nombre")%></h4>
                        <h6><%#Eval("telefono")%></h6>
                        <div>
                            <%#Eval("email")%>
                            <%#Eval("direccion")%>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DataBaseConnection %>" SelectCommand="SELECT [nombre], [email], [direccion], [telefono], [imagen] FROM [Empresa]"></asp:SqlDataSource>
    </div>
</asp:Content>
