<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="presentacion.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Default" runat="server">
     <section class="mx-auto" style="max-width:480px">
          <div class="vstack gap-3">
         <asp:TextBox ID="voucherBox" runat="server"
             CssClass="form-control form-control-lg text-center" placeholder="Ingrese su Voucher"></asp:TextBox>
         <asp:Button ID="btnEnviar" runat="server" Text="Enviar" CssClass="btn btn-primary btn-lg w-100" />
     </div>
 </section>
</asp:Content>
