<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="presentacion.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Default" runat="server">
    <section class="mx-auto" style="max-width:480px">
      <div class="vstack gap-3">
<asp:TextBox ID="voucherBox" runat="server"
 CssClass="form-control form-control-lg text-center" placeholder="Ingrese su Voucher"></asp:TextBox>
 <asp:Button ID="btnEnviar" runat="server" Text="Enviar" CssClass="btn btn-primary btn-lg w-100" OnClick="btnEnviar_Click" />
     <aside id="toastError"
        class="toast text-bg-danger position-fixed top-50 start-50 translate-middle"
        role="status" aria-live="polite" aria-atomic="true"
        data-bs-delay="3000">
      <div class="d-flex align-items-center">
        <p class="toast-body mb-0 flex-grow-1">Ingrese un voucher válido.</p>
        <button type="button"
          class="btn-close btn-close-white ms-3"
           data-bs-dismiss="toast"
            aria-label="Cerrar"></button>
      </div>
    </aside>
     </div>
 </section>
</asp:Content>
