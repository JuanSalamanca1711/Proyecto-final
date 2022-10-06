<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Admin/Administrador.Master" AutoEventWireup="true" CodeBehind="RegistroP.aspx.cs" Inherits="appShopplant.Presentacion.Admin.RegistrarP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentHeadAdministrador" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentBodyAdministrador" runat="server">
    <body class="img js-fullheight" style="background-image: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)), url(imagenes/regg.jpg);">
        <style>
            .traslucido {
                background: rgba(0, 0, 0,0.5)
            }
        </style>

        <div id="layoutAuthentication">

            <div id="layoutAuthentication_content">
                <main>
                    <div class="container">
                        <div class="row justify-content-center">
                            <div class="col-lg-5">
                                <div class="card shadow-lg border-0 rounded-lg mt-5 traslucido">

                                    <div class="card-header">
                                        <h3 class="text-center text-light my-4">REGISTRAR PRODUCTOS</h3>
                                    </div>

                                    <div class="container mt-3">
                                        <form runat="server">
                                            <div class="mb-3">
                                                <label for="txtImagen" class="form-label text-light">imagen:</label>
                                                <div>
                                                    <div>
                                                        <asp:Image CssClass="rounded-circle" ID="imgFoto" runat="server" Height="150px" ImageUrl="~/Presentacion/Imagenes/imgXD.jpg" BorderStyle="Dotted" />
                                                    </div>
                                                    <asp:FileUpload ID="fluImg" runat="server" />
                                                    <asp:Button ID="btnImg" runat="server" Text="Subir" OnClick="btnImg_Click" />
                                                </div>
                                            </div>



                                            <div class="mb-3">
                                                <label for="txtDescripcion" class="form-label text-light">Descripción</label>
                                                <asp:TextBox ID="txtDescripcion" runat="server" class="form-control"></asp:TextBox>
                                            </div>

                                            <div class="mb-3">
                                                <label for="txtCuidados" class="form-label text-light">Cuidados</label>
                                                <asp:TextBox ID="txtCuidados" runat="server" class="form-control"></asp:TextBox>
                                            </div>

                                            <div class="mb-3">
                                                <label for="txtPrecio" class="form-label text-light">Precio</label>
                                                <asp:TextBox ID="txtPrecio" runat="server" class="form-control"></asp:TextBox>
                                            </div>

                                            <div class="mb-3">
                                                <label for="txtCantidad" class="form-label text-light">Cantidad</label>
                                                <asp:TextBox ID="txtCantidad" runat="server" class="form-control"></asp:TextBox>
                                            </div>

                                            <div class="mb-3">
                                                <label for="txtNombre" class="form-label text-light">Nombre</label>
                                                <asp:TextBox ID="txtNombre" runat="server" class="form-control"></asp:TextBox>
                                            </div>

                                            <div class="mb-3">
                                                <label for="txtEstado" class="form-label text-light">Estado</label>
                                                <asp:TextBox ID="txtEstado" runat="server" class="form-control"></asp:TextBox>
                                            </div>
                                            <div>
                                                <asp:Button ID="btnRegistrarP" class="btn btn-outline-success mb-5" runat="server" Text="Registar Producto" OnClick="btnRegistrarP_Click" />
                                            </div>

                                        </form>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </main>
            </div>

        </div>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" crossorigin="anonymous"></script>
        <script src="js/scripts.js"></script>
    </body>

</asp:Content>
