<%@ Page Title="" Language="C#" MasterPageFile="~/Instagify/App/MasterPage.master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Instagify_App_Index" %>

<%-- Add content controls here --%>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <link href="../styles/main-content.css" type="text/css" rel="stylesheet" />
    <script src="../scripts/js/custom/Index.js"></script>
    <%--  <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
  <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>--%>
</asp:Content>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Main component for a primary marketing message or call to action -->
    <div class="container">
        <div class="row">
            <div class=" col-lg-12">
                <div class="title separarArriba separarAbajo">
                    <img src="../imagenes/comment.svg" width="30" />
                    <h1 style="display: inline"><b>¿ Qué es y como funciona Instagify ?</b></h1>
                </div>
            </div>

        </div>

        <div class="row">
            <div class="col-lg-12">
                <div class=" title-content">
                    <p>Instagify es la nueva forma de ganar de la manera mas sencilla en Republica Dominicana un monton de cosas chulas tales como cenas, entradas al cine, parques acuaticos, conciertos, helados, bonos de compra y otras cosas que todavía no se nos ocurren.</p>

                    <p>Las reglas para participar son bastante faciles, solo debes registrarte y etiquetar a 3 amigos que deben estar previamente registrados y poner un comentario de porque quieres este regalo.</p>

                    <p>Los ganadores serán seleccionados todos los sábados a las 9:00 AM, asi que todos los fines de semana abrá regalos para que tengas algo divertido que hacer.</p>

                </div>
            </div>
        </div>




        <div class="row">
            <div class=" col-md-6" style="position: relative">
                <!--Title-->
                <div class="titleCustom separarArriba">

                    <div class=" col-lg-offset-2">
                         <img src="../imagenes/like.PNG" width="50px" height="50px">
                        <h1 style="display:inline" id="m_lblTitle" class="AllwaysInMyHeart negrita"></h1>
                        <h3 id="m_lblSubTitle"></h3>
                    </div>
                </div>
                <div class="title-content">

                    <center>
                        <img id="m_imgPhoto"  />
                        </center>



                    <div class="col-lg-2">
                        <img src="../imagenes/like.PNG" width="50px" height="50px">
                        <label id="m_likesCount">a</label>
                    </div>
                    <div class="col-lg-2">
                        <img src="../imagenes/like.PNG" width="50px" height="50px">
                        <label id="m_commentsCount">b</label>
                    </div>

                    <div class="col-lg-2">
                        <img src="../imagenes/like.PNG" width="50px" height="50px">
                        <label id="m_contestParticipants">c</label>
                    </div>




                    <div class="row">
                        <div class="col-lg-10">
                            <span class="glyphicon glyphicon-map-marker" aria-hidden="true" style="float: left;"></span>
                            <label id="m_address"></label>
                        </div>

                        <div class="col-lg-10">
                            <span class="glyphicon glyphicon-earphone" aria-hidden="true"></span>
                            <label id="m_phone"></label>
                        </div>

                        <label id="m_time"></label>
                    </div>

                    <div>
                        <div id="timer">
                            <span id="days"></span>days
                    <span id="hours"></span>hours
                    <span id="minutes"></span>minutes
                    <span id="seconds"></span>seconds
                        </div>

                    </div>
                </div>
                <%--  <p>Instagify es la nueva forma de ganar de la manera mas sencilla en Republica Dominicana un monton de cosas chulas tales como cenas, entradas al cine, parques acuaticos, conciertos, helados, bonos de compra y otras cosas que todavía no se nos ocurren.</p>

            <p>Las reglas para participar son bastante faciles, solo debes registrarte y etiquetar a 3 amigos que deben estar previamente registrados y poner un comentario de porque quieres este regalo.</p>

            <p>Los ganadores serán seleccionados todos los sábados a las 9:00 AM, asi que todos los fines de semana abrá regalos para que tengas algo divertido que hacer.</p>--%>
            </div>

            <div class=" col-md-6">
                <div class="titleCustom separarArriba">
                    <h1 class="AllwaysInMyHeart negrita">Comentarios</h1>
                </div>
                <div class="title-content ">

                    <asp:TextBox ID="m_txtComment" runat="server" placeHolder="Escriba un comentario"></asp:TextBox>
                    <input type="button" value="Enviar" id="m_SendComment" />


                </div>
            </div>
        </div>
    </div>


</asp:Content>
