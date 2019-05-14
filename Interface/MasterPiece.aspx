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

<asp:Content ID="Content3" ContentPlaceHolderID="ImagenesScroll" runat="server">

    <div class="slideshow">
        <ul class="slider">
            <li>
                <img src="Imagenes/Slider/1.jpg" alt="">
                <section class="caption">
                    <h1>Lorem ipsum 1</h1>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Adipisci quis ipsa, id quidem quisquam unde.</p>
                </section>
            </li>
            <li>
                <img src="Imagenes/Slider/2.jpg" alt="">
                <section class="caption">
                    <h1>Lorem ipsum 2</h1>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Adipisci quis ipsa, id quidem quisquam unde.</p>
                </section>
            </li>
            <li>
                <img src="Imagenes/Slider/3.jpg" alt="">
                <section class="caption">
                    <h1>Lorem ipsum 3</h1>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Adipisci quis ipsa, id quidem quisquam unde.</p>
                </section>
            </li>
        </ul>
        <ol class="pagination">
        </ol>
        <div class="left">
            <span class="fa fa-chevron-left"></span>
        </div>
        <div class="right">
            <span class="fa fa-chevron-right"></span>
        </div>
    </div>
    <script src="jQuery/jquery-3.1.0.min.js"></script>
    <script src="jQuery/main.js"></script>
    <link href="CSS/SlideShow.css" rel="stylesheet" />

</asp:Content>
