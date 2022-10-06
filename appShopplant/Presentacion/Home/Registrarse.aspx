<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="appShopplant.Presentacion.Registrarse" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Register - SB Admin</title>
    <link href="css/styles.css" rel="stylesheet" />
    <script src="https://use.fontawesome.com/releases/v6.1.0/js/all.js" crossorigin="anonymous"></script>
</head>
<body class="img js-fullheight" style="background-image:linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)), url(imagenes/f.jpg); background-repeat:no-repeat; background-attachment:fixed; background-size:cover;">
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
                        <div class="col-lg-7">
                            <div class="card shadow-lg border-0 rounded-lg mt-5 traslucido">
                                <div class="card-header">
                                    <h3 class="text-center font-weight-light text-light my-4">Crear Cuenta</h3>
                                </div>
                                <div class="card-body">
                                    <form runat="server">
                                        <div class="row mb-3">
                                            <div class="col-md-6">
                                                <div class="form-floating mb-3 mb-md-0">
                                                    <asp:TextBox ID="txtNombre" runat="server" class="form-control" placeholder="Ingrese su nombre" TextMode="SingleLine"></asp:TextBox>
                                                    <label for="txtNombre">Nombre</label>
                                                </div>
                                            </div>
                                            <div class="col-md-6">
                                                <div class="form-floating">
                                                    <asp:TextBox ID="txtApellido" runat="server" class="form-control" placeholder="Ingrese su apellido" TextMode="SingleLine"></asp:TextBox>
                                                    <label for="txtApellido">Apellido</label>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="form-floating mb-3 ">
                                            <asp:TextBox ID="txtNroTelefono" runat="server" class="form-control" placeholder="Ingrese su Nro de teléfono" TextMode="Number"></asp:TextBox>
                                            <label for="txtNroTelefono">Nro de Teléfono</label>
                                        </div>
                                        <div class="form-floating mb-3 ">
                                            <asp:TextBox ID="txtDocumento" runat="server" class="form-control" placeholder="Ingrese su Nro de Documento" TextMode="Number"></asp:TextBox>
                                            <label for="txtDocumento">Nro de Documento</label>
                                        </div>
                                        <div class="form-floating mb-3 ">
                                            <asp:TextBox ID="txtEmail" runat="server" class="form-control" placeholder="Ingrese su correo electronico" TextMode="Email"></asp:TextBox>
                                            <label for="txtEmail">Correo Electronico</label>
                                        </div>
                                        <div class="form-floating mb-3">
                                            <asp:TextBox ID="txtClave" runat="server" class="form-control" placeholder="Ingrese su contraseña" TextMode="Password"></asp:TextBox>
                                            <label for="inputPassword">Contraseña</label>
                                        </div>
                                        <div class="form-floating mb-3">
                                            <asp:TextBox ID="txtCiudad" runat="server" class="form-control" placeholder="Ingrese el numero de su ciudad de residencia (Sog=1, Dui=2, Tunj=3, Yop=4, Mani=5)" TextMode="SingleLine"></asp:TextBox>
                                            <label for="txtCiudad">Ingrese el numero de su ciudad de residencia (Sog=1, Dui=2, Tunj=3, Yop=4, Mani=5)</label>
                                        </div>
                                        <div class="mt-4 mb-0">

                                            <div class="d-grid">
                                                <asp:Button ID="btnCrearCuenta" runat="server" Text="Crear Cuenta!!" class="btn btn-outline-success btn-block" OnClick="btnCrearCuenta_Click" />
                                            </div>

                                        </div>
                                    </form>
                                </div>
                                <div class="card-footer text-center py-3">
                                    <div class="small"><a href="Login.aspx">¿Ya tienes una cuenta? Ingresa!!</a></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </main>
        </div>
        <div id="layoutAuthentication_footer">
            <footer class="py-4 mt-auto traslucido">
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
