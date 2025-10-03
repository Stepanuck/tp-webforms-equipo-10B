<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="ListadoDeArticulos.aspx.cs" Inherits="presentacion.ListadoDeArticulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Default" runat="server">
    <section class="container my-4" aria-labelledby="titulo-catalogo">
        <h1 id="titulo-catalogo" class="h3 text-center text-white mb-4">Elegi tu premio</h1>
  
    <asp:Repeater ID="rptArticulos" runat="server">
        <HeaderTemplate>
            <ul class="row list-unstyled g-4">
        </HeaderTemplate>

        <ItemTemplate>
            <li class="col-12 col-sm-6 col-lg-4">
                <article class="card h-100 shadow-sm" itemscope>
                    <figure class="m-0">
                        <img class="card-img-top" src='<%# Eval("ImagenUrl") %>'
                            alt='<%#Eval("Nombre")%>' itemprop="image" />
                    </figure>
                    <div class="card-body d-flex flex-colum">
                        <h2 class="h5 card-title" itemprop="name"><%#Eval("Nombre")%></h2>
                        <p class="card-text text-muted mb-3" itemprop="description"><%#Eval("Descripcion")%></p>
                        <asp:Button ID="btnElegir" runat="server" Text="Eligo este"
                         CssClass="btn btn-primary w-100 mt-auto"
                            CommandName="Elegir"
                            CommandArgument='<%# Eval("IdArticulo") %>' />
                        </div>
                    </article>
               </li>
            </ItemTemplate>

        <FooterTemplate>
            </ul>
            </FooterTemplate>
        </asp:Repeater>
      </section>
</asp:Content>