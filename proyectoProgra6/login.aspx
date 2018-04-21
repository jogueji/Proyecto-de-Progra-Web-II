<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="proyectoProgra6.login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ingreso | J y J Restaurante</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1" />
    <link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
    <link href="css/slider.css" rel="stylesheet" type="text/css" media="all" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/jquery.min.js" type="text/javascript"></script>
    <script src="js/slidermodernizr.custom.js"></script>
</head>

<body>
    <form id="form" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <!------ Background slider ------->
        <div class="slider">
            <ul id="cbp-bislideshow" class="cbp-bislideshow">
                <li>
                    <img src="images/1.jpg" alt="image01" /></li>
                <li>
                    <img src="images/2.jpg" alt="image02" /></li>
                <li>
                    <img src="images/3.jpg" alt="image03" /></li>
                <li>
                    <img src="images/4.jpg" alt="image04" /></li>
                <li>
                    <img src="images/5.jpg" alt="image05" /></li>
                <li>
                    <img src="images/6.jpg" alt="image06" /></li>
            </ul>
            <script src="js/jquery.imagesloaded.min.js"></script>
            <script src="js/cbpBGSlideshow.min.js"></script>
            <script>
                $(function () {
                    cbpBGSlideshow.init();
                });
            </script>
        </div>

        <!------ Header ------->
        <div class="header_top">
            <div class="wrap">
                <div class="logo1">
                    <a href="#">
                        <img style="width: 70%" src="images/logo.png" /></a>
                </div>
                <div class="clear"></div>
            </div>
        </div>
        <!------ Main ------->

        <div class="wrap">
            <div class="main">
                <div class="section group">
                    <div class="col_1_of_3 contact_1_of_3">
                        <div class="contact-form"></div>
                    </div>
                    <div class="col_1_of_3 contact_1_of_3">
                        <div class="contact-form">
                            <h3>Ingreso al Sistema</h3>
                            <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
                                <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                                <strong id="textoMensajeError" runat="server"></strong>
                            </div>
                            <div>
                                <span>
                                    <asp:TextBox ID="txtNombre" placeholder="Nombre usuario" runat="server"></asp:TextBox>
                                    
                            </div>
                            
                            <div>
                                <span>
                                    <asp:TextBox ID="txtContrasenna" placeholder="Contraseña" runat="server" TextMode="Password" ></asp:TextBox>
                                </span>
                            </div>
                            
                            <div>
                                <span>
                                    <center>
                                        <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" />
                                    </center>
                                </span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!------ Footer ------->
        <div class="copy_right">
            <div class="wrap">
                <p>&copy; <%: DateTime.Now.Year %> - Programación Web II</p>
            </div>
        </div>

    </form>
</body>
</html>

