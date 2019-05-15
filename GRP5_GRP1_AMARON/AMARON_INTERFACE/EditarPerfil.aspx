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
                            <asp:Image ID="img" runat="server" class="img-responsive img-portfolio img-hover" Imageurl="Imagenes/fotoPerfil.jpg" />
                        </div>
                    </div>
                    <div class="parte-derecha">
                        
                            <div class="form-group">
                                <div class="d-flex justify-content-start">
                                    <asp:Label runat="server" Text="Cambiar foto de perfil"></asp:Label>
                                </div>
                                <div id="form2" runat="server" enctype="multipart/form-data">
                                    <asp:FileUpload ID="pictureUpload" class="btn btn-primary" runat="server" />
                                </div>
                            </div>
                        
                    </div>
                </div>
                <div class="row">
                    
                        <div class="row">
                            <asp:Label runat="server" Text="Nombre:" Font-Size="Larger"></asp:Label>
                            <asp:Textbox runat="server" ID="name" class="form-control" placeholder="Nuevo nombre"></asp:Textbox>
                            <asp:Label runat="server" Text="Direccion:" Font-Size="Larger"></asp:Label>
                            <asp:Textbox runat="server" ID="address" class="form-control" placeholder="Nueva direccion"></asp:Textbox>
                            <asp:Label runat="server" Text="Cambiar contraseña:" Font-Size="Larger"></asp:Label>
                            <asp:Textbox runat="server" ID="pass" class="form-control" TextMode="password" placeholder="Nueva contraseña"></asp:Textbox>
                        </div>
                    
                </div>
                <asp:Button runat="server" OnClick="Unnamed_Click" class="btn btn-success" Text="Guardar" />
            </div>
    </div>
</asp:Content>
