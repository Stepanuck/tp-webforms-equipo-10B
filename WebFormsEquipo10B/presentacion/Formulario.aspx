<%@ Page Title="Formulario de contacto" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true"
    CodeBehind="Formulario.aspx.cs" Inherits="presentacion.Formulario" ClientIDMode="Static" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta name="description" content="Formulario de contacto para completar datos personales en el concurso web." />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Default" runat="server">
    <section class="container my-5" aria-labelledby="Titulo-form">
        <header class="mb-4">
            <h1 id="Titulo-form" class="h4 text-white">Ingresa tus datos</h1>
            <p class="text-muted">Completa el formulario para obtener tu premio.</p>
        </header>

        <fieldset class="border-0 p-0" itemtype="https://schema.or/Person" itemscope>
            <legend class="visually-hidden">Datos Personales</legend>

            <!--DNI--> 
            
                <div class="col-12 col-sm-6 col-md-4">

                <label for="txtDni" class="text-white form-label">DNI</label>
                    <asp:TextBox ID="txtDni" runat="server" CssClass="form-control"
                        MaxLength="8" placeholder="9988777"
                        autocomplete="off" inputmode="numeric">
                    </asp:TextBox>
                    <small id="hint-dni" class="text-danger d-none">Solo numeros, 7-8 digitos.</small>
                </div>

                <div class="row g-3">
                <!--Nombre-->
                <fieldset class="col-12 col-sm-6 col-md-4">
                    <label for="txtNombre" class="text-white form-label">Nombre</label>
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"
                        MaxLength="50" placeholder="Maxi"
                        autocomplete="given-name">
                    </asp:TextBox>
                    <small id="hint-nombre" class="text-danger d-none">Solo letras y espacios, 2-50 caracteres.</small>
                </fieldset>

                <!--Apellido-->
                <fieldset class="col-12 col-sm-6 col-md-4">
                    <label for="txtApellido" class="text-white form-label">Apellido</label>
                    <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"
                        MaxLength="50" placeholder="Programa"
                        autocomplete="family-name">
                    </asp:TextBox>
                    <small id="hint-apellido" class="text-danger d-none">Solo letras y espacios, 2-50 caracteres.</small>
                </fieldset>
                   
               <!--Email-->
                    <fieldset class="col-12 col-sm-6 col-md-4">
                       <label for="txtEmail" class="text-white form-label">Email</label>
                          <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"
                             placeholder="maxi@programa.com.ar"
                              autocomplete="email">
                              </asp:TextBox>
                     <small id="hint-email" class="text-danger d-none">Formato de email invalido.</small>
                    </fieldset>
                <!-- Direccion -->
                    <fieldset class="col-12 col-sm-6">
                        <label for="txtDireccion" class="text-white form-label">Dirección</label>
                        <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"
                            placeholder="Calle MaxiPrograma 010101"
                            autocomplete="street-address">
                        </asp:TextBox>
                        <small id="hint-direccion" class="text-danger d-none">Minimo 4 caracteres</small>
                    </fieldset>

                    <!-- Ciudad -->
                    <fieldset class="col-6 col-md-4"> 
                        <label for="txtCiudad" class="text-white form-label">Ciudad</label>
                        <asp:TextBox ID="txtCiudad" runat="server" CssClass="form-control"
                            placeholder="MaxiCiudad"
                            autocomplete="address-level12">
                        </asp:TextBox>
                        <small id="hint-ciudad" class="text-danger d-none">Ingrese la ciudad</small>
                   </fieldset>
                     
                    <!-- Codigo Postal -->
                    <fieldset class="col-6 col-md-2">
                        <label for="txtCp" class="form-label text-white">CP</label>
                        <asp:TextBox ID="txtCp" runat="server" CssClass="form-control"
                            placeholder="6666" MaxLength="8" inputmode="numeric" autocomple="postal-code"></asp:TextBox>
                        <small id="hint-cp" class="text-danger d-none">Se admiten solamente 4 numeros y 4 letras, no mas de 8 digitos.</small>
                        </fieldset>
                    
                    <!-- Terminos -->
                    <div class="col-12">
                        <div class="form-check">
                            <input id="chkTerminos" type="checkbox" class="form-check-input" />
                            <label for="chkTerminos" class="form-check-label text-white">
                              Acepto los terminos y condiciones.
                                </label>
                            </div>
                        <small id="hint-terminos" class="text-danger d-none">Debe aceptar los terminos y condiciones.</small>
                   </div>
                    <!-- Boton Enviar -->
                    
                    <div class="col-12">
                        <asp:Button ID="btnEnviar" runat="server" Text="Enviar" CssClass="btn btn-primary"
                            UseSubmitBehavior="true"
                            OnClientClick="return validarFormulario(event);"
                            OnClick="btnEnviar_Click" />
                    </div>
              </div>
        </fieldset>
    </section>

     <script src="/Script/Script.js"></script>
</asp:Content>