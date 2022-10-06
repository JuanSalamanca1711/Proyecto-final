<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Admin/Administrador.Master" AutoEventWireup="true" CodeBehind="RegistroTareas.aspx.cs" Inherits="appShopplant.Presentacion.Admin.RegistroTareas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentHeadAdministrador" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentBodyAdministrador" runat="server">

    <body class="img js-fullheight" style="background-image:linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)), url(imagenes/c.jpg); background-repeat:no-repeat; background-attachment:fixed; background-size:cover;">
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
                                    <h3 class="text-center text-light my-4">REGISTRAR TAREAS</h3>
                                   </div>

                                    <div class="container mt-3  ">
                                        <form runat="server">

                                            <div class="mb-3">
                                                <label for="txtDescripcion" class="form-label text-light">Descripcion</label>
                                                <asp:TextBox ID="txtDescripcion" runat="server" class="form-control"></asp:TextBox>
                                            </div>

                                            <div class="mb-3">
                                                <label for="txtFechaInicio" class="form-label text-light">Fecha y hora de inicio</label>
                                                <asp:TextBox ID="txtFechaInicio" runat="server" class="form-control"></asp:TextBox>
                                            </div>

                                            <div class="mb-3">
                                                <label for="txtEmpleado" class="form-label text-light">ID del Empleado</label>
                                                <asp:TextBox ID="txtEmpleado" runat="server" class="form-control"></asp:TextBox>
                                            </div>

                                            <div class="mb-3">
                                                <label for="txtAdmin" class="form-label text-light">ID del Administrador</label>
                                                <asp:TextBox ID="txtAdmin" runat="server" class="form-control"></asp:TextBox>
                                            </div>

                                             <div class="mb-3">
                                                <label for="txtEstado" class="form-label text-light">Estado</label>
                                                <asp:TextBox ID="txtEstado" runat="server" class="form-control"></asp:TextBox>
                                            </div>

                                            <div>

                                                <asp:Button ID="btnRegistrar" class="btn btn-outline-success mb-5" runat="server" Text="Registar Tarea" OnClick="btnRegistrar_Click" />
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
