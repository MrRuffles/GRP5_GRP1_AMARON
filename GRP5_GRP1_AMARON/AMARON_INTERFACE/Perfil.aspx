<%@ Page Title="Perfil" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="AMARON_INTERFACE.Perfil" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <style>
        .columna-izquierda{
            width: 20%;
            padding: 10px;
            float: left;
            text-align: center;
            justify-content: center;

        }
        .parte-central {
            width: 77%;
            padding: 10px;
            float: right;
            text-align: justify;
        }
        .img-hover {
            width: 80%;
            height: auto;
            margin: 10px auto;
            display: block;
        }
        .col-md-12 h4{
            margin: 15px 60px;
        }
        .list-primary{
            margin: 10px auto;
            display: block;
        }
        .list-primary a {
            text-align: center;
        }
        .clearfix {
            clear: both;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="clearfix">
        <div class="columna-izquierda">
            <div class="col-md-13">
                <asp:Image runat="server" style="border-width: 1px 1px 1px 1px; border-style: solid; border-color: coral;" ID="fotoPerfil" class="img-responsive img-portfolio img-hover" ImageUrl="Imagenes/fotoPerfil.jpg" />
            </div>
            <div class="col-md-13">
                <br/>
                <ul class="list-group list-primary">
                    <asp:Button runat="server" ID="pedidios" class="btn btn-outline-secondary" Style="margin: 2px auto" Width ="165px" onclick="verPedidos" text="Ver pedidos hechos" Visible="false"/>
                    <asp:Button runat="server" ID="edit_button" class="btn btn-outline-secondary" Style="margin: 2px auto" Width ="165px" Visible="false" onclick="editarPerfil" text="Editar perfil"/>
                    <asp:Button runat="server" ID="productos" class="btn btn-outline-secondary" Style="margin: 2px auto" Width ="165px" onclick="crearProducto" text="Subir Producto" Visible="false"/>
                </ul>
            </div>
        </div>
        <div class="parte-central">
            <div class="col-md-12" style="border-width: 1px 1px 1px 1px; border-style: solid; border-color: lightgrey; margin: 10px auto">
                <h3 style="text-align: center">Mi perfil </h3>
                <div class="d-flex justify-content-start">
                    <asp:Label runat="server" Width="10%" Text="Nombre:" Font-Size="Large">  </asp:Label>
                    <asp:Label ID="name"  runat="server" Font-Size="Large" Text=""></asp:Label>
                    </div>
                <div class="d-flex justify-content-start">
                    <asp:Label runat="server" Width="10%" Text="Nacimiento:" Font-Size="Large">  </asp:Label>
                    <asp:Label ID="birth"  runat="server" Font-Size="Large" Text=""></asp:Label>
                </div>
                <div class="d-flex justify-content-start">
                    <asp:Label runat="server" Width="10%" Text="Email:" Font-Size="Large">  </asp:Label>
                    <asp:Label ID="mail"  runat="server" Font-Size="Large" Text=""></asp:Label>
                </div>
                <div class="d-flex justify-content-start">
                    <asp:Label runat="server" Width="10%" Text="Dirección:" Font-Size="Large">  </asp:Label>
                    <asp:Label ID="address"  runat="server" Font-Size="Large" Text=""></asp:Label>
                </div>
                <div class="d-flex justify-content-start">
                    <asp:Label runat="server" Width="10%" Text="Empresa:" ID="company" Visible="false" Font-Size="Large">  </asp:Label>
                    <asp:Label ID="company1"  runat="server" Font-Size="Large" Text=""></asp:Label>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
