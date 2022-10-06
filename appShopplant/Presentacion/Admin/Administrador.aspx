<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Admin/Administrador.Master" AutoEventWireup="true" CodeBehind="Administrador.aspx.cs" Inherits="appShopplant.Presentacion.prrunchis" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentHeadAdministrador" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentBodyAdministrador" runat="server">

   <body class="img js-fullheight" style="background-image: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)), url(imagenes/admin.jpg); background-repeat: no-repeat; background-attachment: fixed; background-size: cover;">
            <style>
            .traslucido {
                background: rgba(0, 0, 0,0.5)
            }
        </style>
             <div class="container-fluid bg-black tarslucido">
                    <div class="container">
                        <nav class="navbar navbar-expand-lg navbar-dark traslucido">
                            <a class="navbar-brand" href="#">Administrador</a>
                            
                        </nav>
                    </div>
                </div>

        </body>

</asp:Content>
