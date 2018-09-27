<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Novo_Pedido.aspx.cs" Inherits="CantinaTioWell.Pedidos.Novo_Pedido" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Novo Pedido</title>

    <!-- Bootstrap -->
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="/css/font-awesome.min.css">
    <link rel="stylesheet" href="/css/font-awesome.css">
    <link rel="stylesheet" href="/css/animate.css">
    <link href="../css/style.css" rel="stylesheet" />
    <!-- =======================================================
    Theme Name: Anyar
    Theme URL: https://bootstrapmade.com/anyar-free-multipurpose-one-page-bootstrap-theme/
    Author: BootstrapMade
    Author URL: https://bootstrapmade.com
  ======================================================= -->
</head>

<body>
    <header>
        <nav class="navbar navbar-default navbar-fixed-top" role="navigation">
            <div class="navigation">
                <div class="container">
                    <div class="navbar-header">
                        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target=".navbar-collapse.collapse">
                            <span class="sr-only">Toggle navigation</span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>
                        <div class="navbar-brand">
                            <a href="index.html">
                                <h1>Cantina do Tio Well</h1>
                            </a>
                        </div>
                    </div>

                    <div class="navbar-collapse collapse">
                        <div class="menu">
                            <ul class="nav nav-tabs" role="tablist">
                                <li role="presentation"><a href="#home">Home</a></li>
                                <li role="presentation"><a href="#about" class="active">Novo Pedido</a></li>
                                <li role="presentation"><a href="#services">Clientes</a></li>
                                <li role="presentation"><a href="#contact">Produtos</a></li>
                                <li role="presentation"><a href="#contact">Dívidas</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </nav>
    </header>

    <div id="services">
        <div class="container">
            <section id="contact-page">
                <div class="container">
                    <div class="center">
                        <h3>Novo Pedido</h3>
                    </div>
                    <div class="col-lg-4">
                        <div class="row" runat="server">
                            <form action="" method="post" role="form" class="contactForm" runat="server">
                                <div class="form-group">
                                    <label for="txtNumPed">Pedido #: </label>
                                    <asp:TextBox ID="txtNumPed" runat="server" ReadOnly="true" Width="50" CssClass="form-control" />
                                </div>
                                <div class="form-group">
                                    <label for="ddlNomeFunc">Nome do colaborador</label>
                                    <asp:DropDownList ID="ddlNomeFunc" runat="server" CssClass="form-control" />

                                    <div class="validation"></div>
                                </div>

                                <div class="form-group">
                                    <label for="ddlProdutos">Selecione os produtos</label>
                                    <asp:DropDownList ID="ddlProdutos" runat="server" ToolTip="Selecione os produtos" CssClass="form-control" />
                                    <br />
                                    <label for="txtqtd">Selecione a Quantidade</label>
                                    <asp:TextBox ID="txtqtd" runat="server" TextMode="Number" min="1" max="99" Text="1" Width="100px" CssClass="form-control" />
                                    <div class="row justify-content-start">
                                        <asp:Button runat="server" ID="btnInserir" Text="Inserir Item ASP" CssClass="btn btn-theme pull-left" OnClick="btnInserir_Click" />
                                        <%--<button type="button" class="btn btn-theme pull-left" runat="server" onclick="Additem();">Inserir Item</button>--%>
                                    </div>
                                    <div class="validation"></div>
                                </div>
                            </form>
                        </div>
                        <!--/.row-->
                    </div>
                    <div class="col-md-6" style="margin-left: 70px">
                        <table class="table table-hover table-bordered">
                            <thead class="thead-dark">
                                <tr>
                                    <th scope="col">#</th>
                                    <th scope="col">Produto</th>
                                    <th scope="col">Val. Unit. (R$)</th>
                                    <th scope="col">Qtd</th>
                                    <th scope="col">Val Total (R$)</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <th scope="row">1</th>
                                    <td>Água</td>
                                    <td>2,50</td>
                                    <td>1</td>
                                    <td>2,50</td>
                                </tr>
                                <tr>
                                    <th scope="row">2</th>
                                    <td>Bolo</td>
                                    <td>3,00</td>
                                    <td>2</td>
                                    <td>6,00</td>
                                </tr>
                                <tr>
                                    <th scope="row">3</th>
                                    <td>Sorvete</td>
                                    <td>2,80</td>
                                    <td>1</td>
                                    <td>2,80</td>
                                </tr>
                            </tbody>
                            <tfoot>
                                <tr>
                                    <th scope="row" colspan="4" style="text-align: center">TOTAL</th>
                                    <th scope="row">11,30</th>
                                </tr>
                            </tfoot>
                        </table>
                        <div class="col align-self-end">
                            <button type="submit" class="btn btn-theme pull-right">FINALIZAR PEDIDO</button>
                            <%-- btn btn-theme pull-left --%>
                        </div>


                    </div>
                </div>
                <!--/.container-->
            </section>
            <!--/#contact-page-->
        </div>
    </div>

    <footer>
        <div class="container">
            <div class="col-md-5 wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="300ms">
                <h4>Sobre nós</h4>
                <p>A cantina do Tio Well oferece os salgados e cafés mais gostosos do Brasil.</p>
                <div class="contact-info">
                    <ul>
                        <li><i class="fa fa-home fa"></i>Av. das Nações Unidas, 14171 - Marble Tower - 16º Andar</li>
                        <li><i class="fa fa-phone fa"></i>+55 (11) 3245-3200</li>
                        <li><i class="fa fa-envelope fa"></i>cantinatioWell@everis.com</li>
                    </ul>
                </div>
            </div>

            <div class="col-md-4 wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                <div class="text-center">
                    <h4>Galeria de fotos</h4>
                    <ul class="sidebar-gallery">
                        <li>
                            <a href="/img/gallery1.jpg">
                                <img src="/img/gallery1.jpg" alt="" width="107" height="63" />
                            </a>
                        </li>
                        <li>
                            <a href="/img/gallery5.jpg">
                                <img src="/img/gallery5.jpg" alt="" width="107" height="63" />
                            </a>
                        </li>
                        <li>
                            <a href="/img/gallery6.jpg">
                                <img src="/img/gallery6.jpg" alt="" width="107" height="63" />
                            </a>
                        </li>
                        <li>
                            <a href="/img/gallery4.jpg">
                                <img src="/img/gallery4.jpg" alt="" width="107" height="63" />
                            </a>
                        </li>
                        <li>
                            <a href="/img/gallery2.jpg">
                                <img src="/img/gallery2.jpg" alt="" width="107" height="63" />
                            </a>
                        </li>
                        <li>
                            <a href="/img/gallery3.jpg">
                                <img src="/img/gallery3.jpg" alt="" width="107" height="63" />
                            </a>
                        </li>
                    </ul>
                </div>
            </div>

        </div>
    </footer>

    <div class="sub-footer">
        <div class="container">
            <div class="social-icon">
                <div class="col-md-6">
                    <ul class="social-network">
                        <li><a href="https://www.facebook.com/everisdobrasil/" class="fb tool-tip" title="Facebook"><i class="fa fa-facebook"></i></a></li>
                        <li><a href="https://twitter.com/everisbrasil" class="twitter tool-tip" title="Twitter"><i class="fa fa-twitter"></i></a></li>
                        <li><a href="https://pt.linkedin.com/company/everis" class="linkedin tool-tip" title="Linkedin"><i class="fa fa-linkedin"></i></a></li>
                        <li><a href="https://www.youtube.com/channel/UC_HU6wJxGRbmA77khHSn9KQ" class="ytube tool-tip" title="You Tube"><i class="fa fa-youtube-play"></i></a></li>
                    </ul>
                </div>
            </div>

            <div class="col-md-6 ">
                <div class="copyright text-right">
                    &copy; Anyar Theme. All Rights Reserved.
                  <div class="credits">
                      <!--
                      All the links in the footer should remain intact.
                      You can delete the links only if you purchased the pro version.
                      Licensing information: https://bootstrapmade.com/license/
                      Purchase the pro version with working PHP/AJAX contact form: https://bootstrapmade.com/buy/?theme=Anyar
                    -->
                      Designed by <a href="https://bootstrapmade.com/">BootstrapMade</a>
                  </div>
                </div>
            </div>
        </div>
    </div>
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="/js/jquery.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="/js/bootstrap.min.js"></script>
    <script src="/https://maps.googleapis.com/maps/api/js?key=AIzaSyD8HeI8o-c1NppZA-92oYlXakhDPYR7XMY"></script>
    <script src="/js/wow.min.js"></script>
    <script src="/js/jquery.easing.min.js"></script>
    <script src="/js/jquery.isotope.min.js"></script>
    <script src="/js/functions.js"></script>
    <script src="/contactform/contactform.js"></script>
</body>

</html>

