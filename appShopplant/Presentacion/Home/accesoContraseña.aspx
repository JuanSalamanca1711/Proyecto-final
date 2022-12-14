<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="accesoContraseña.aspx.cs" Inherits="appShopplant.Presentacion.Home.accesoContraseña" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Recordar datos - Cliente</title>
    <link href="css/styles.css" rel="stylesheet" />
    <script src="https://use.fontawesome.com/releases/v6.1.0/js/all.js" crossorigin="anonymous"></script>
</head>
<body class="img js-fullheight" style="background-image: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)), url(imagenes/fondoRecordarDatos.jpg); background-repeat: no-repeat; background-attachment: fixed; background-size: cover;">
    <style>
        .traslucido {
            background: rgba(0, 0, 0,0.3)
        }
    </style>
    <div id="layoutAuthentication">
        <div id="layoutAuthentication_content">
            <main>
                <div class="container ">
                    <div class="row justify-content-center">
                        <div class="col-lg-5 ">
                            <div class="card shadow-lg border-0 rounded-lg mt-5 traslucido b">
                                <div class="card-header">
                                    <h3 class="text-center text-light my-4">ACCESO - RECORDAR CONTRASEÑA</h3>
                                </div>
                                <div class="card-body">
                                    <form runat="server">
                                        <div class="form-floating mb-3 ">
                                            <asp:TextBox ID="txtEmail" runat="server" class="form-control" placeholder="Escriba su correo electronico" TextMode="Email"></asp:TextBox>
                                            <label for="txtEmail">Escriba su correo electrónico para recuperar sus datos</label>
                                        </div>

                                        <div class="mt-4 mb-4">
                                            <div class="d-grid">
                                                <asp:Button ID="btnEnviarCorreo" runat="server" Text="ENVIAR CORREO" class="btn btn-outline-success btn-block" OnClick="btnEnviarCorreo_Click" />
                                            </div>
                                        </div>

                                        <div class="form-floating mb-3">
                                            <asp:TextBox ID="txtCodigo" runat="server" class="form-control" placeholder="Ingrese el codigo" TextMode="Number"></asp:TextBox>
                                            <label for="inputPassword">Codigo de seguridad</label>
                                        </div>

                                        <div class="mt-4 mb-0">
                                            <div class="d-grid">
                                                <asp:Button ID="btnCodigo" runat="server" Text="ENVIAR CODIGO" class="btn btn-outline-success btn-block" OnClick="btnCodigo_Click" />
                                            </div>
                                        </div>


                                    </form>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </main>
        </div>
        <div id="layoutAuthentication_footer">
            <footer class="py-4  mt-auto traslucido">
                <div class="container-fluid px-4">
                    <div class="d-flex align-items-center justify-content-between small">
                        <div class="text-muted">Copyright &copy; Your Website 2022</div>
                        <div>
                            <a href="#">Privacy Policy</a>
                            &middot;
                                <a href="#">Terms &amp; Conditions</a>
                        </div>
                    </div>
                </div>
            </footer>
        </div>
    </div>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" crossorigin="anonymous"></script>
    <script src="js/scripts.js"></script>
</body>
</html>
