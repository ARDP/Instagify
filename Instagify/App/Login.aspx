<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Instagify_App_Login" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <meta name="description" content="">
    <meta name="author" content="">
    <title>Static Top Navbar Example for Bootstrap</title>

    <%--<asp:ContentPlaceHolder ID="ContentPlaceHolderHeader" runat="server" ></asp:ContentPlaceHolder>--%>
</head>


<body>
    <form runat="server">
        <!-- Static navbar -->
        <nav class="navbar navbar-default navbar-static-top">

            <div class="container-fluid">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="#">Instagify</a>
                </div>
                <div id="navbar" class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                    </ul>


                    <ul class="nav navbar-nav navbar-right">
                        <li><a class="customLinks" href="../App/Index.aspx?">INICIO</a></li>  
                        <li><a class="customLinks" href="#">GANADORES</a></li>
                        <li id="m_liIn" runat="server"><a class="customLinks" href="../App/Login.aspx?">ENTRAR</a></li>
                     
                    </ul>

                </div>
                <!--/.nav-collapse -->

            </div>
            <div id="m_barra" runat="server" class="row">
                <div class=" barraItem orange">&nbsp</div>
                 <div class="barraItem pink">&nbsp</div>
                <div class="barraItem violet">&nbsp</div>
                <div class="barraItem purple">&nbsp</div>
               
                <div class="barraItem darkBlue">&nbsp</div>
                <div class="barraItem skyBlue">&nbsp</div>

                <div class="barraItem orange">&nbsp</div>
                   <div class="barraItem pink">&nbsp</div>
                <div class="barraItem violet">&nbsp</div>
                <div class="barraItem purple">&nbsp</div>
                <div class="barraItem yellow">&nbsp</div>
                <div class="barraItem orange">&nbsp</div>
                 <div class="barraItem pink">&nbsp</div>
                <div class="barraItem violet">&nbsp</div>
                   <div class="barraItem purple">&nbsp</div>
               
                <div class="barraItem darkBlue">&nbsp</div>
                <div class="barraItem skyBlue">&nbsp</div>
                  <div class=" barraItem orange">&nbsp</div>
                 <div class="barraItem pink">&nbsp</div>
                 <div class="barraItem violet">&nbsp</div>
                &nbsp
            </div>
        </nav>


        <div id="logContainer" class="row">

            <div>
                <div class="box">
                    <div class="container-small logContainer">
                        <h1 class=" AllwaysInMyHeart">Iniciar Sesión</h1>
                        <%-- <input type="text" placeholder="Username" />--%>
                        <asp:TextBox runat="server" ID="m_txtUserName" placeholder="Nombre de Usuario" CssClass="inputCustom"></asp:TextBox>
                        <%-- <input type="text" placeholder="Password" />--%>
                        <asp:TextBox runat="server" ID="m_txtPassWord" placeholder="Contraseña" CssClass="inputCustom"></asp:TextBox>
                        <%-- <button>Login</button>--%>
                        <asp:Button runat="server" Text="Iniciar Sesión" OnClick="Login_Click" AutoPostBack="true" class="btn btn-primary inputButton" />
                        <p>¿No eres un miembro? <span><a href="../App/SignUp.aspx?">Registrate</a></span></p>
                    </div>
                </div>
            </div>
        </div>
        <div class=" footer">
            <img src="../imagenes/camera.svg" alt="camera" class="pic">
            <img src="../imagenes/ball.svg" alt="ball" class="moveUp pic">
            <img src="../imagenes/star.svg" alt="star" class="pic">
            <img src="../imagenes/globe.svg" alt="globe" class="moveUp pic">
            <img src="../imagenes/rocket.svg" alt="rocket" class="pic">
            <img src="../imagenes/sun.svg" alt="sun" class="moveUp pic">
            <img src="../imagenes/worldmap.svg" alt="worldmap" class="pic">
            <img src="../imagenes/apple.svg" alt="apple" class="moveUp pic">
            <img src="../imagenes/heart.svg" alt="heart" class="pic">
            <img src="../imagenes/glasses.svg" alt="glasses" class="moveUp pic">
            <img src="../imagenes/bigHeart.svg" alt="bigHeart" class="pic">
            <img src="../imagenes/ship.svg" alt="ship" class="moveUp pic">
            <img src="../imagenes/paperPlane.svg" alt="paperPlane" class="pic">
            <img src="../imagenes/trophy.svg" alt="trophy" class="moveUp pic">
        </div>
        <!-- /container -->


        <!-- Bootstrap core JavaScript
    ================================================== -->
        <!-- Placed at the end of the document so the pages load faster -->

        <link href="../../packages/bootstrap.3.3.7/content/Content/bootstrap-theme.css" rel="stylesheet" type="text/css" />
        <link href="../Content/bootstrap-theme.min.css" rel="stylesheet" type="text/css" />
        <link href="../../packages/bootstrap.3.3.7/content/Content/bootstrap.min.css" rel="stylesheet" type="text/css" />

        <link href="../styles/login.css" type="text/css" rel="stylesheet" />
        <link href="../styles/main-content.css" type="text/css" rel="stylesheet" />
        <link rel="icon" href="../../favicon.ico">


        <script src="../../packages/jQuery.3.1.0/Content/Scripts/jquery-3.1.0.min.js"></script>

        <script src="../../packages/bootstrap.3.3.7/content/Scripts/bootstrap.min.js"></script>
        <script src="../../packages/bootstrap.3.3.7/content/Scripts/bootstrap.js"></script>

        <script src="../scripts/bootstrap.min.js"></script>
        <script src="../scripts/jquery-3.1.0.min.js"></script>
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
        <script>window.jQuery || document.write('<script src="../../assets/js/vendor/jquery.min.js"><\/script>')</script>
        <script src="../scripts/js/custom/MasterPage.js"></script>

        <%--    <asp:ContentPlaceHolder ID="ContentPlaceHolder2" runat="server" ></asp:ContentPlaceHolder>
        --%>
    </form>
</body>
</html>
