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
            text-align: justify;
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
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="columna-izquierda">
            <div class="col-md-13">
                <img class="img-responsive img-portfolio img-hover" src="Imagenes/fotoPerfil.jpg">
            </div>
            <div class="col-md-13">
                <br/>
                <ul class="list-group list-primary">
                    <a href="#" class="list-group-item">Ver pedidos hechos</a>
                    <a href="#" class="list-group-item">Editar perfil</a>
                </ul>
            </div>
        </div>
        <div class="parte-central">
            <div class="col-md-12" style="border-width: 1px 1px 1px 1px; border-style: solid; border-color: lightgrey; margin: 10px auto">
                <h3 style="text-align: center">Mi perfil </h3>
                <h4>Nombre:<strong>  Nombre random</strong></h4>
                <h4>Apellidos:<strong>  Apellidos random</strong></h4>
                <h4>Edad:<strong>  Edad random</strong></h4>
                <h4>Email:<strong>  Email random</strong></h4>
                <h4>Dirección:<strong>  Dirección random</strong></h4>
            </div>
        </div>
    </div>
</asp:Content>
