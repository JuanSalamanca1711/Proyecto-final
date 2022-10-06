<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="appShopplant.Presentacion.Anonimo.Home" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta content="width=device-width, initial-scale=1.0" name="viewport">

    <title>SHOPPLANT - Index</title>
    <meta content="" name="description">
    <meta content="" name="keywords">

    <!-- Favicons -->
    <link href="assets/img/logoShop.png" rel="icon">
    <link href="assets/img/apple-touch-icon.png" rel="apple-touch-icon">

    <!-- Google Fonts -->
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i|Raleway:300,300i,400,400i,500,500i,600,600i,700,700i|Poppins:300,300i,400,400i,500,500i,600,600i,700,700i" rel="stylesheet">

    <!-- Vendor CSS Files -->
    <link href="assets/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <link href="assets/vendor/bootstrap-icons/bootstrap-icons.css" rel="stylesheet">
    <link href="assets/vendor/boxicons/css/boxicons.min.css" rel="stylesheet">
    <link href="assets/vendor/glightbox/css/glightbox.min.css" rel="stylesheet">
    <link href="assets/vendor/remixicon/remixicon.css" rel="stylesheet">
    <link href="assets/vendor/swiper/swiper-bundle.min.css" rel="stylesheet">

    <!-- Template Main CSS File -->
    <link href="assets/css/style.css" rel="stylesheet">

    <!-- =======================================================
  * Template Name: KnightOne - v4.9.0
  * Template URL: https://bootstrapmade.com/knight-simple-one-page-bootstrap-template/
  * Author: BootstrapMade.com
  * License: https://bootstrapmade.com/license/
  ======================================================== -->
</head>

<body>

    <!-- ======= Header ======= -->
    <header id="header" class="fixed-top ">
        <div class="container-fluid">

            <div class="row justify-content-center">
                <div class="col-xl-9 d-flex align-items-center justify-content-lg-between">
                    <h1 class="logo me-auto me-lg-0"><a href="index.html">ShopPlant</a></h1>
                    <!-- Uncomment below if you prefer to use an image logo -->
                    <!-- <a href="index.html" class="logo me-auto me-lg-0"><img src="assets/img/logo.png" alt="" class="img-fluid"></a>-->

                    <nav id="navbar" class="navbar order-last order-lg-0">
                        <ul>
                            <li><a class="nav-link scrollto active" href="#hero">Inicio</a></li>
                            <li><a class="nav-link scrollto" href="#about">Nosotros</a></li>
                            <li><a class="nav-link scrollto " href="#portfolio">Productos</a></li>
                            <li class="dropdown"><a href="#"><span>Desplegable</span> <i class="bi bi-chevron-down"></i></a>
                                <ul>
                                    <li><a href="#">Drop Down 1</a></li>
                                    <li class="dropdown"><a href="#"><span>Deep Drop Down</span> <i class="bi bi-chevron-right"></i></a>
                                        <ul>
                                            <li><a href="#">Deep Drop Down 1</a></li>
                                            <li><a href="#">Deep Drop Down 2</a></li>
                                            <li><a href="#">Deep Drop Down 3</a></li>
                                            <li><a href="#">Deep Drop Down 4</a></li>
                                            <li><a href="#">Deep Drop Down 5</a></li>
                                        </ul>
                                    </li>
                                    <li><a href="#">Drop Down 2</a></li>
                                    <li><a href="#">Drop Down 3</a></li>
                                    <li><a href="#">Drop Down 4</a></li>
                                </ul>
                            </li>
                            <li><a class="nav-link scrollto" href="#contact">Contacto</a></li>
                        </ul>
                        <i class="bi bi-list mobile-nav-toggle"></i>
                    </nav>
                    <!-- .navbar -->

                    <a href="Login.aspx" class="get-started-btn scrollto">INICIAR SESION </a>
                </div>
            </div>

        </div>
    </header>
    <!-- End Header -->

    <!-- ======= Hero Section ======= -->
    <section id="hero" class="d-flex flex-column justify-content-center">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-xl-8">
                    <h1>SHOPPLANT 
                        <br />
                        SIEMBRA LA FELICIDAD</h1>
                    <h2>Planta tu propio jardín y decora tu alma, en lugar de esperar a que alguien te traiga flores</h2>

                </div>
            </div>
        </div>
    </section>
    <!-- End Hero -->

    <main id="main">

        <!-- ======= About Us Section ======= -->
        <section id="about" class="about">
            <div class="container">
                <div class="section-title">
                    <h2>NOSOTROS</h2>
                    <p>En SHOPPLANT queremos inspirar a otras personas con nuestro amor por las plantas, porque sabemos que el poder de la inspiración es exponencial.
                        <br />
                        A partir de una pequeña acción consciente podemos sembrar semillas en la tierra y en los demás. Todas nuestras plantas van sembradas en
                        <br />
                        macetas adecuadas a su tamaño, con sustratos especialmente formulados para cada una de ellas y con una guía de cuidados que encontrarás 
                        <br />
                        en cada producto de nuestra página web nos aseguramos de que tus plantas estén en óptimas condiciones en su nuevo hogar por mucho más tiempo.
                        <br />
                        Además, pensando en un producto útil, ecológico, decorativo y que participe de un impacto social importante y duradero hemos diseñado.
                    </p> 
                   <%-- <img src="assets/img/logoShop.png" />--%>
                </div>
            </div>
        </section>
        <!-- End About Us Section -->

       

        <!-- ======= Cta Section ======= -->
        <section id="cta" class="cta">
            <div class="container">

                <div class="row">
                    <div class="col-lg-9 text-center text-lg-start">
                        <h3>Siembra con nosotros</h3>
                        <p>Compra plantas en línea y recibe tu pedido en casa o en el destino que elijas entre 2 y 5 días hábiles después de concretar la compra. Hacemos envíos a todo Colombia</p>
                    </div>
                    <div class="col-lg-3 cta-btn-container text-center">
                        <a class="cta-btn align-middle" href="#">Contacta con nosotros</a>
                    </div>
                </div>

            </div>
        </section>
        <!-- End Cta Section -->

        <!-- ======= Features Section ======= -->
        <section id="features" class="features">
            <div class="container">

                <div class="row">
                    <div class="col-lg-6 order-2 order-lg-1">
                        <div class="icon-box mt-5 mt-lg-0">
                            <i class="bx bx-receipt"></i>
                            <h4>Est labore ad</h4>
                            <p>Consequuntur sunt aut quasi enim aliquam quae harum pariatur laboris nisi ut aliquip</p>
                        </div>
                        <div class="icon-box mt-5">
                            <i class="bx bx-cube-alt"></i>
                            <h4>Harum esse qui</h4>
                            <p>Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt</p>
                        </div>
                        <div class="icon-box mt-5">
                            <i class="bx bx-images"></i>
                            <h4>Aut occaecati</h4>
                            <p>Aut suscipit aut cum nemo deleniti aut omnis. Doloribus ut maiores omnis facere</p>
                        </div>
                        <div class="icon-box mt-5">
                            <i class="bx bx-shield"></i>
                            <h4>Beatae veritatis</h4>
                            <p>Expedita veritatis consequuntur nihil tempore laudantium vitae denat pacta</p>
                        </div>
                    </div>
                    <div class="image col-lg-6 order-1 order-lg-2" style='background-image: url("assets/img/features.jpg");'></div>
                </div>

            </div>
        </section>
        <!-- End Features Section -->



        <!-- ======= Counts Section ======= -->
        <section id="counts" class="counts">
            <div class="container">

                <div class="text-center title">
                    <h3>What we have achieved so far</h3>
                    <p>Iusto et labore modi qui sapiente xpedita tempora et aut non ipsum consequatur illo.</p>
                </div>

                <div class="row counters position-relative">

                    <div class="col-lg-3 col-6 text-center">
                        <span data-purecounter-start="0" data-purecounter-end="232" data-purecounter-duration="1" class="purecounter"></span>
                        <p>Clients</p>
                    </div>

                    <div class="col-lg-3 col-6 text-center">
                        <span data-purecounter-start="0" data-purecounter-end="521" data-purecounter-duration="1" class="purecounter"></span>
                        <p>Projects</p>
                    </div>

                    <div class="col-lg-3 col-6 text-center">
                        <span data-purecounter-start="0" data-purecounter-end="1463" data-purecounter-duration="1" class="purecounter"></span>
                        <p>Hours Of Support</p>
                    </div>

                    <div class="col-lg-3 col-6 text-center">
                        <span data-purecounter-start="0" data-purecounter-end="15" data-purecounter-duration="1" class="purecounter"></span>
                        <p>Hard Workers</p>
                    </div>

                </div>

            </div>
        </section>
        <!-- End Counts Section -->

        <!-- ======= Portfolio Section ======= -->
        <section id="portfolio" class="portfolio">
            <div class="container">

                <div class="section-title">
                    <h2>Nuestros productos</h2>
                    
                    <p>Producimos todos los productos que puedes encontrar en esta página web, teniendo así un estricto control de calidad de todos los procesos, desde la plantación a la entrega al cliente.</p>
                </div>

                <div class="row">
                    <div class="col-lg-12 d-flex justify-content-center">
                        <ul id="portfolio-flters">
                            <li data-filter="*" class="filter-active">Todo</li>
                            <li data-filter=".filter-pinterior">Plantas de Interior</li>
                            <li data-filter=".filter-pexterior">Plantas de Exterior</li>
                        </ul>
                    </div>
                </div>

                <div class="row portfolio-container">

                    <div class="col-lg-4 col-md-6 portfolio-item filter-pexterior">
                        <img src="../Productos/imagenes/ÁrbolPitanga.jpg" class="img-fluid" alt="">
                        <div class="portfolio-info">
                            <h4>Arbol Pitanga</h4>
                            <a href="../Productos/imagenes/ÁrbolPitanga.jpg" data-gallery="portfolioGallery" class="portfolio-lightbox preview-link" title="Arbol Pitanga"><i class="bx bx-plus"></i></a>
         
                        </div>
                    </div>

                    <div class="col-lg-4 col-md-6 portfolio-item filter-pexterior">
                        <img src="../Productos/imagenes/CactusArizona.png" class="img-fluid" alt="">
                        <div class="portfolio-info">
                            <h4>Cactus Arizona</h4>
                            <a href="../Productos/imagenes/CactusArizona.png" data-gallery="portfolioGallery" class="portfolio-lightbox preview-link" title="Cactus Arizona"><i class="bx bx-plus"></i></a>
             
                        </div>
                    </div>

                    <div class="col-lg-4 col-md-6 portfolio-item filter-pinterior">
                        <img src="../Productos/imagenes/CarnívoraAtrapamoscasPequeña.jpg" class="img-fluid" alt="">
                        <div class="portfolio-info">
                            <h4>Carnivora Atrapamoscas Pequeña</h4>
                            <a href="../Productos/imagenes/CarnívoraAtrapamoscasPequeña.jpg" data-gallery="portfolioGallery" class="portfolio-lightbox preview-link img-fluid" title="Carnivora Atrapamoscas Pequeña"><i class="bx bx-plus"></i></a>
                           
                        </div>
                    </div>

                    <div class="col-lg-4 col-md-6 portfolio-item filter-pinterior">
                        <img src="../Productos/imagenes/LenguaSuegra.jpg" class="img-fluid" alt="">
                        <div class="portfolio-info">
                            <h4>Lengua de Suegra</h4>
                            <a href="../Productos/imagenes/LenguaSuegra.jpg" data-gallery="portfolioGallery" class="portfolio-lightbox preview-link" title="Lengua de Suegra"><i class="bx bx-plus"></i></a>
                          
                        </div>
                    </div>

                    <div class="col-lg-4 col-md-6 portfolio-item filter-pexterior">
                        <img src="../Productos/imagenes/PrimaveraNaranja.png" class="img-fluid" alt="">
                        <div class="portfolio-info">
                            <h4>Primavera Naranja</h4>
                            <a href="../Productos/imagenes/PrimaveraNaranja.png" data-gallery="portfolioGallery" class="portfolio-lightbox preview-link" title="Primavera Naranja"><i class="bx bx-plus"></i></a>
            
                        </div>
                    </div>

                    <div class="col-lg-4 col-md-6 portfolio-item filter-pexterior">
                        <img src="../Productos/imagenes/SuculentaRomeo.jpg" class="img-fluid" alt="">
                        <div class="portfolio-info">
                            <h4>Suculenta Romeo</h4>
                            <a href="../Productos/imagenes/SuculentaRomeo.jpg" data-gallery="portfolioGallery" class="portfolio-lightbox preview-link" title="Suculenta Romeo"><i class="bx bx-plus"></i></a>
                            
                        </div>
                    </div>

                    
                    <div class="col-lg-4 col-md-6 portfolio-item filter-pexterior">
                        <img src="../Productos/imagenes/ÁrbolEugenio.jpg" class="img-fluid" alt="">
                        <div class="portfolio-info">
                            <h4>Arbol Eugenio</h4>
                            <a href="../Productos/imagenes/ÁrbolEugenio.jpg" data-gallery="portfolioGallery" class="portfolio-lightbox preview-link" title="App 3"><i class="bx bx-plus"></i></a>
                            <a href="portfolio-details.html" class="details-link" title="More Details"><i class="bx bx-link"></i></a>
                        </div>
                    </div>

                    
                    <div class="col-lg-4 col-md-6 portfolio-item filter-pexterior">
                        <img src="../Productos/imagenes/GerberaAmarilla.png" class="img-fluid" alt="">
                        <div class="portfolio-info">
                            <h4>Gerbera Amarilla</h4>
                            <a href="../Productos/imagenes/GerberaAmarilla.png" data-gallery="portfolioGallery" class="portfolio-lightbox preview-link" title="Gerbera Amarilla"><i class="bx bx-plus"></i></a>
                            
                        </div>
                    </div>

                    <div class="col-lg-4 col-md-6 portfolio-item filter-pinterior">
                        <img src="../Productos/imagenes/KalanchoeRosado.png" class="img-fluid" alt="">
                        <div class="portfolio-info">
                            <h4>Kalanchoe Rosado</h4>
                            <a href="../Productos/imagenes/KalanchoeRosado.png" data-gallery="portfolioGallery" class="portfolio-lightbox preview-link" title="Kalanchoe Rosado"><i class="bx bx-plus"></i></a>
                           
                        </div>
                    </div>

                </div>

            </div>
        </section>
        <!-- End Portfolio Section -->





        <!-- ======= Contact Section ======= -->
        <section id="contact" class="contact">
            <div class="container">

                <div class="section-title">
                    <h2>Contactanos</h2>
                    <p>Con nosotros podras encontrar las plantas ideales para cada espacio, recíbelas en la puerta de tu casa y aprende a cuidarlas con ShopPlant, contactanos.</p>
                </div>
            </div>

            <div>
                <iframe style="border: 0; width: 100%; height: 350px;" src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3970.074644257875!2d-72.94708498479132!3d5.702356095866904!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x8e6a45b57c123711%3A0xd2de5a0c6786d44d!2sCl.%206%20Sur%2C%20Sogamoso%2C%20Boyac%C3%A1!5e0!3m2!1ses!2sco!4v1663962540834!5m2!1ses!2sco" width="800" height="600" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe></iframe>
            </div>

            <div class="container justify-content-center">

                <div class="row mt-4 justify-content-center">

                    <div class="col-lg-4">
                        <div class="info">
                            <div class="address">
                                <i class="ri-map-pin-line"></i>
                                <h4>Localizacion:</h4>
                                <p>Calle 6 Sur, COLOMBIA, COL 153610</p>
                            </div>

                            <div class="email">
                                <i class="ri-mail-line"></i>
                                <h4>Email:</h4>
                                <p>shopplant2022@gmail.com</p>
                            </div>

                            <div class="phone">
                                <i class="ri-phone-line"></i>
                                <h4>Celular:</h4>
                                <p>+57 310 502 1357</p>
                            </div>

                        </div>

                    </div>



                </div>

            </div>
        </section>
        <!-- End Contact Section -->

    </main>
    <!-- End #main -->

    <!-- ======= Footer ======= -->
    <footer id="footer">
        <div class="container">
            <h3>ShopPlant</h3>
            <p>Si no te gusta lo que cosechas, analiza y cambia lo que siembras.</p>
            <div class="social-links">
                <a href="#" class="twitter"><i class="bx bxl-twitter"></i></a>
                <a href="#" class="facebook"><i class="bx bxl-facebook"></i></a>
                <a href="#" class="instagram"><i class="bx bxl-instagram"></i></a>
            </div>
            <div class="copyright">
                &copy; Copyright <strong><span>ShopPlant</span></strong>. All Rights Reserved
            </div>
            <div class="credits">
                <!-- All the links in the footer should remain intact. -->
                <!-- You can delete the links only if you purchased the pro version. -->
                <!-- Licensing information: https://bootstrapmade.com/license/ -->
                <!-- Purchase the pro version with working PHP/AJAX contact form: https://bootstrapmade.com/knight-simple-one-page-bootstrap-template/ -->
                Designed by <a href="https://www.sena.edu.co/es-co/Paginas/default.aspx">SENA</a>
            </div>
        </div>
    </footer>
    <!-- End Footer -->

    <div id="preloader"></div>
    <a href="#" class="back-to-top d-flex align-items-center justify-content-center"><i class="bi bi-arrow-up-short"></i></a>

    <!-- Vendor JS Files -->
    <script src="assets/vendor/purecounter/purecounter_vanilla.js"></script>
    <script src="assets/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <script src="assets/vendor/glightbox/js/glightbox.min.js"></script>
    <script src="assets/vendor/isotope-layout/isotope.pkgd.min.js"></script>
    <script src="assets/vendor/swiper/swiper-bundle.min.js"></script>
    <script src="assets/vendor/php-email-form/validate.js"></script>

    <!-- Template Main JS File -->
    <script src="assets/js/main.js"></script>

</body>

</html>
