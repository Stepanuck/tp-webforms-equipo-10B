<%@ Page Title="Formulario de contacto" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true"
    CodeBehind="Formulario.aspx.cs" Inherits="presentacion.Formulario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta name="description" content="Formulario de contacto para completar datos personales en el concurso web." />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Default" runat="server">
    <section class="container my-5" aria-labelledby="titulo-formulario">
        <header class="text-center mb-4">
            <h1 id="titulo-formulario" class="h3 text-white">Completá tus datos</h1>
            <p>Ingrese sus datos por favor para terminar con la obtencion del premio.</p>
        </header>

        <div class="mx-auto" style="max-width:600px;">
            <fieldset class="mb-3">
                <asp:Label ID="lblNombre" runat="server" AssociatedControlID="txtNombre"
                           CssClass="form-label text-white" Text="Nombre" />
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="Ingrese su nombre" />
            </fieldset>

            <fieldset class="mb-3">
                <asp:Label ID="lblEmail" runat="server" AssociatedControlID="txtEmail"
                           CssClass="form-label text-white" Text="Email" />
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Ingrese su email" />
            </fieldset>

            <fieldset class="mb-3">
                <asp:Label ID="lblTelefono" runat="server" AssociatedControlID="txtTelefono"
                           CssClass="form-label text-white" Text="Teléfono" />
                <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" placeholder="Ingrese su teléfono" />
            </fieldset>

            <fieldset class="mb-4">
                <asp:Label ID="lblDireccion" runat="server" AssociatedControlID="txtDireccion"
                           CssClass="form-label text-white" Text="Dirección" />
                <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" placeholder="Ingrese su dirección" />
            </fieldset>

            <asp:Button ID="btnEnviar" runat="server" Text="Enviar"
                        CssClass="btn btn-primary w-100"
                        OnClick="btnEnviar_Click"
                        OnClientClick="this.disabled=true; this.value='Enviando...'; return true;" />
        </div>
    </section>
</asp:Content>