<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="ListadoDeArticulos.aspx.cs" Inherits="presentacion.ListadoDeArticulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Default" runat="server">
<section class="container my-4" aria-labelledby="titulo-catalogo">
  <h1 id="titulo-catalogo" class="h3 text-center text-white mb-4">Elegí tu premio</h1>

<asp:Repeater ID="rptArticulos" runat="server" OnItemCommand="rptArticulos_ItemCommand">
  <HeaderTemplate>
    <ul class="row row-cols-1 row-cols-md-2 row-cols-lg-3 g-4 list-unstyled">
  </HeaderTemplate>

  <ItemTemplate>
    <li class="col">
      <article class="card h-100 shadow-sm" itemscope>
        
       <div id='<%# "car" + Eval("Id") %>' class="carousel slide"
     data-bs-ride="false" data-bs-interval="false" data-bs-pause="hover">


        
          <div class="carousel-indicators">
            <asp:Repeater ID="rptIndicators" runat="server"
                          DataSource='<%# ((dominio.Models.Articulo)Container.DataItem).Imagenes %>'>
              <ItemTemplate>
                <button type="button"
                        data-bs-target='<%# "#car" + Eval("IdArticulo") %>'
                        data-bs-slide-to='<%# Container.ItemIndex %>'
                        class='<%# Container.ItemIndex == 0 ? "active" : "" %>'
                        aria-current='<%# Container.ItemIndex == 0 ? "true" : "false" %>'
                        aria-label='<%# "Imagen " + (Container.ItemIndex + 1) %>'>
                </button>
              </ItemTemplate>
            </asp:Repeater>
          </div>

        
                     <div class="carousel-inner ratio ratio-4x3 bg-body-tertiary rounded-top overflow-hidden">
              <asp:Repeater ID="rptImgs" runat="server"
                            DataSource='<%# ((dominio.Models.Articulo)Container.DataItem).Imagenes %>'>
                <ItemTemplate>
                  <div class='carousel-item <%# Container.ItemIndex == 0 ? "active" : "" %>'>
                    <img class="d-block w-100 h-100 object-fit-contain p-3"
                         src='<%# Eval("NombreArchivo") %>'
                         alt='<%# "Imagen de " + Eval("IdArticulo") %>'
                         loading="lazy" />
                  </div>
                </ItemTemplate>
              </asp:Repeater>
            </div>

          <button class="carousel-control-prev" type="button"
                  data-bs-target='<%# "#car" + Eval("Id") %>' data-bs-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Anterior</span>
          </button>
          <button class="carousel-control-next" type="button"
                  data-bs-target='<%# "#car" + Eval("Id") %>' data-bs-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Siguiente</span>
          </button>
        </div>

        
        <div class="card-body d-flex flex-column">
          <h2 class="h6 card-title mb-2 text-truncate" itemprop="name"><%# Eval("Nombre") %></h2>
          <p class="card-text text-muted small mb-3"><%# Eval("Descripcion") %></p>

          <asp:Button ID="btnElegir" runat="server"
                      Text="Elijo este" CssClass="btn btn-primary mt-auto"
                      CommandName="Elegir"
                      CommandArgument='<%# Eval("Id") %>' />
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
