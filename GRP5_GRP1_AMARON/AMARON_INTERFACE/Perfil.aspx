<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="AMARON_INTERFACE.Perfil" %>

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
                <asp:Image runat="server" id="fotoPerfil" class="img-responsive img-portfolio img-hover" ImageUrl="Imagenes/fotoPerfil.jpg" />
            </div>
            <div class="col-md-13">
                <br/>
                <ul class="list-group list-primary">
                    <asp:Button runat="server" ID="pedidios" class="btn btn-outline-secondary" Style="margin: 2px auto" Width ="165px" onclick="verPedidos" text="Ver pedidos hechos" Visible="true"/>
                    <asp:Button runat="server" class="btn btn-outline-secondary" Style="margin: 2px auto" Width ="165px" onclick="editarPerfil" text="Editar perfil"/>
                    <asp:Button runat="server" ID="productos" class="btn btn-outline-secondary" Style="margin: 2px auto" Width ="165px" onclick="crearProducto" text="Subir Producto" Visible="false"/>
                </ul>
            </div>
        </div>
        <div class="parte-central">
            <div class="col-md-12" style="border-width: 1px 1px 1px 1px; border-style: solid; border-color: lightgrey; margin: 10px auto">
                <h3 style="text-align: center">Mi perfil </h3>
                <asp:Label runat="server" Text="Nombre: "> <asp:Label ID="name" runat="server" Text=""></asp:Label> </asp:Label>
                <asp:Label runat="server" Text="Edad: "> <asp:Label ID="age" runat="server" Text=""></asp:Label> </asp:Label>
                <asp:Label runat="server" Text="Email: "> <asp:Label ID="mail" runat="server" Text=""></asp:Label> </asp:Label>
                <asp:Label runat="server" Text="Dirección: "> <asp:Label ID="address" runat="server" Text=""></asp:Label> </asp:Label>
                <asp:Label runat="server" Text="Empresa: " ID="company" Visible="false"> <asp:Label ID="company1" runat="server" Text=""></asp:Label> </asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
