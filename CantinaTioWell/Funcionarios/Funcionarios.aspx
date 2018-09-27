<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Funcionarios.aspx.cs" Inherits="CantinaTioWell.Funcionarios.Funcionarios" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Funcionários - Cantina do Tio Well</title>

    <!-- Bootstrap -->
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <link href="../css/font-awesome.min.css" rel="stylesheet" />
    <link href="../css/font-awesome.css" rel="stylesheet" />
    <link href="../css/animate.css" rel="stylesheet" />
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
                                <li role="presentation"><a href="Pedidos/Novo_Pedido.aspx">Pedidos/Novo Pedido</a></li>
                                <li role="presentation"><a href="Funcionarios/ConsultaFunc.aspx" class="active">Funcionários</a></li>
                                <li role="presentation"><a href="#contact">Produtos</a></li>
                                <li role="presentation"><a href="ConsultaDividas.aspx">Dívidas</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </nav>
    </header>

    <div id="services">
        <div class="row">
            <div class="col-md-7">
                <h3>Lista de Funcionários</h3>
                <%-- Grid Consulta Funcionarios --%>
                <table class="table table-hover">
                    <thead class="thead-dark">
                        <tr>
                            <th scope="col">ID</th>
                            <th scope="col">Nome</th>
                            <th scope="col">E-mail</th>
                            <th scope="col">Celular</th>
                        </tr>
                    </thead>
                    <tbody id="tabfuncionarios" runat="server">
                    </tbody>
                </table>
            </div>
            <%-- Fim Grid consulta --%>

            <%-- Formulário Cadastro Funcionário --%>
            <div class="col-md-5" id="cadFunc">
                <h3>Pesquisa/Cadastro de funcionários</h3>
                <p>Use o formulário abaixo para cadastrar, pesquisar e atualizar funcionários.</p>
                <form action="" method="post" role="form" class="contactForm" runat="server">
                    <div class="form-group">
                        <label for="txtID">ID </label>
                        <asp:TextBox runat="server" ID="txtID" TextMode="Number" min="1" max="999999" Width="80" CssClass="form-control" />
                        <asp:Button runat="server" ID="btnConsultaID" Text="Consultar ID" CssClass="btn btn-default" OnClick="btnConsultaID_Click" />
                        <%--<asp:ImageButton runat="server" ID="btnConsID" ImageUrl="~/Images/lupa.png" Height="28" Width="28" BorderWidth="1" ImageAlign="AbsMiddle" OnClick="btnConsID_Click" />--%>
                    </div>
                    <div class="alert alert-warning" role="alert" id="alertaid" runat="server" hidden="hidden">
                        O ID informado não foi encontrado. :(
                    </div>

                    <div class="form-group">
                        <label for="txtNome">Nome* </label>
                        <asp:TextBox ID="txtNome" runat="server" MaxLength="40" CssClass="form-control" />
                        <asp:Button runat="server" ID="btnConsultaNome" Text="Consultar Nome" CssClass="btn btn-default" OnClick="btnConsultaNome_Click" />
                    </div>
                    <div class="alert alert-warning" role="alert" id="alertnome" runat="server" hidden="hidden">
                        O nome informado não foi encontrado. :(
                    </div>

                    <div class="form-group">
                        <label for="txtEmail">E-mail* </label>
                        <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" CssClass="form-control" />
                    </div>

                    <div class="form-group">
                        <label for="txtCel">Celular</label>
                        <asp:TextBox ID="TxtCel" runat="server" Width="200" TextMode="Phone" placeholder="(xx) 9xxxx-xxxx" CssClass="form-control" />
                    </div>

                    <div class="content align-center">

                        <div class="form-group" id="botaocadastro" runat="server" hidden="hidden">
                            <asp:Button runat="server" ID="btnEnviaCad" Text="Cadastrar Funcionário" CssClass="btn btn-default" OnClick="btnEnviaCad_Click" />
                        </div>

                        <div class="form-group" id="botoeseditar" runat="server" hidden="hidden">
                            <asp:Button runat="server" ID="btnUpdFunc" Text="Atualizar Funcionário" CssClass="btn btn-default" OnClick="btnUpdFunc_Click" />
                            <asp:Button runat="server" ID="btnDeleta" Text="Deletar Funcionário" CssClass="btn btn-default" OnClick="btnDeleta_Click" />
                        </div>

                        <div class="form-group" id="botaolimpar">
                            <asp:Button runat="server" ID="btnLimpar" Text="Limpar" CssClass="btn btn-default" OnClick="btnLimpar_Click" />
                        </div>

                        <div class="alert alert-success" role="alert" id="msgsucesso" runat="server" hidden="hidden">
                            <h4 class="alert-heading">Feito!</h4>
                            <hr>
                            <p class="mb-0" id="txtsucesso" runat="server"></p>
                        </div>

                        <div class="alert alert-danger" role="alert" hidden="hidden" id="msgerro" runat="server">
                            Houve um erro. :(
                        </div>
                    </div>

                </form>
            </div>
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
    <script src="js/jquery.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyD8HeI8o-c1NppZA-92oYlXakhDPYR7XMY"></script>
    <script src="js/wow.min.js"></script>
    <script src="js/jquery.easing.min.js"></script>
    <script src="js/jquery.isotope.min.js"></script>
    <script src="js/functions.js"></script>
    <script src="contactform/contactform.js"></script>

</body>

</html>
