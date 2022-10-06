<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Anonimo/Anonimo.Master" AutoEventWireup="true" CodeBehind="General.aspx.cs" Inherits="appShopplant.Presentacion.General" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentHeadAnonimo" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBodyAnonimo" runat="server">

    <body class="img js-fullheight" style="background-image: url(imagenes/mosaico.jpg);">
        <div
            id="carouselExampleCaptions"
            class="carousel slide"
            data-bs-ride="carousel">
            <div class="carousel-indicators">
                <button
                    type="button"
                    data-bs-target="#carouselExampleCaptions"
                    data-bs-slide-to="0"
                    class="active"
                    aria-current="true"
                    aria-label="Slide 1">
                </button>
                <button
                    type="button"
                    data-bs-target="#carouselExampleCaptions"
                    data-bs-slide-to="1"
                    aria-label="Slide 2">
                </button>
                <button
                    type="button"
                    data-bs-target="#carouselExampleCaptions"
                    data-bs-slide-to="2"
                    aria-label="Slide 3">
                </button>
            </div>
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <img src="imagenes/SIEMBRA-ARBOLES.jpg" class="d-block w-100" alt="..." />
                    <div class="carousel-caption d-none d-md-block">
                    </div>
                </div>
                <div class="carousel-item">
                    <img src="imagenes/BANNER-2.jpg" class="d-block w-100" alt="..." />
                    <div class="carousel-caption d-none d-md-block">
                    </div>
                </div>
                <div class="carousel-item">
                    <img src="imagenes/BANNER-.jpg" class="d-block w-100" alt="..." />
                    <div class="carousel-caption d-none d-md-block">
                    </div>
                </div>
            </div>
            <button
                class="carousel-control-prev"
                type="button"
                data-bs-target="#carouselExampleCaptions"
                data-bs-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Previous</span>
            </button>
            <button
                class="carousel-control-next"
                type="button"
                data-bs-target="#carouselExampleCaptions"
                data-bs-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Next</span>
            </button>
        </div>
    </body>

</asp:Content>
