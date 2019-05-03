<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EditarPerfil.aspx.cs" Inherits="AMARON_INTERFACE.EditarPerfil" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <style>
        .doc yui-t7{
            margin:auto;
        }
        .doc a{
            margin: 40px auto;
            display: block;
            width: 30%;
            height: auto;
            text-align: center;
        }
        .header{
            margin: 10px auto;
            display:block;
            text-align: center;
        }
        .parte-izquierda{
            width: 40%;
            padding: 10px;
            float: left;
            text-align: justify;
        }
        .parte-derecha{
            width: 55%;
            padding: 10px;
            float: right;
            text-align: justify;
        }
        .img-hover {
            width: 50%;
            height: auto;
            margin: 10px auto;
            display: block;
        }
        .form-group{
            margin: 60px auto;
            display: block;
            font-size: 20px;
            border: 1px solid #CCCCCC;
            padding: 40px 20px;
        }
        .formulario{
            margin-top: 30px;
            margin-left: 100px;
            width: 100%;
            text-align: center;
            align-content: center;
        }
        .form-control {
            width: 100%;
        }

    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
            <div class="doc yui-t7">
                <div class="header">
                    <h1>EDITAR PERFIL</h1>
                </div>
                <div class="row">
                    <div class="parte-izquierda">
                        <div class="col-md-13">
                            <img class="img-responsive img-portfolio img-hover" src="Imagenes/fotoPerfil.jpg">
                        </div>
                    </div>
                    <div class="parte-derecha">
                        <form>
                            <div class="form-group">
                                <label for="exampleFormControlFile1">Cambiar foto de perfil</label>
                                <input type="file" class="form-control-file" id="exampleFormControlFile1">
                            </div>
                        </form>
                    </div>
                </div>
                <div class="row">
                    <form>
                        <div class="row">
                            <h3>Nombre:</h3>
                            <input class="form-control" placeholder="Nombre actual">
                            <h3>Apellidos:</h3>
                            <input class="form-control" placeholder="Apellidos actuales">
                            <h3>Dirección:</h3>
                            <input class="form-control" placeholder="Dirección actual">
                            <h3>Email:</h3>
                            <input class="form-control" placeholder="Email actual">
                        </div>
                    </form>
                </div>
                <a href="#" class="btn btn-success" role="button"> Guardar</a>
            </div>
    </div>
</asp:Content>
