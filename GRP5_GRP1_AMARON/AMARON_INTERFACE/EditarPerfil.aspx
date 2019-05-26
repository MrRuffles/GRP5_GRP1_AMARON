<%@ Page Title="Editar Perfil" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EditarPerfil.aspx.cs" Inherits="AMARON_INTERFACE.EditarPerfil" %>


<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <style>
        .doc yui-t7 {
            margin: auto;
        }

        .doc a {
            margin: 40px auto;
            display: block;
            width: 30%;
            height: auto;
            text-align: center;
        }

        .header {
            margin: 10px auto;
            display: block;
            text-align: center;
        }

        .parte-izquierda {
            width: 40%;
            padding: 10px;
            float: left;
            text-align: justify;
        }

        .parte-derecha {
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

        .form-group {
            margin: 60px auto;
            display: block;
            font-size: 20px;
            padding: 40px 20px;
        }

        .formulario {
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
    <div class="container" id="edit_profile">
        <div class="doc yui-t7" >
            <div class="header">
                <h1>EDITAR PERFIL</h1>
            </div>
            <div class="row">
                <div class="parte-izquierda">
                    <div class="col-md-13">
                        <asp:Image ID="img" runat="server" class="img-responsive img-portfolio img-hover" ImageUrl="Imagenes/fotoPerfil.jpg" />
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

                <div class="col-md-6">
                    <asp:Label runat="server" CssClass="justify-content-start" Text="Nombre:" Font-Size="Larger"></asp:Label>
                    <asp:TextBox runat="server" ID="name" class="form-control" placeholder="Nuevo nombre"></asp:TextBox>
                    <asp:Label runat="server" CssClass="justify-content-start" Text="Dirección:" Font-Size="Larger"></asp:Label>
                    <asp:TextBox runat="server" ID="address" class="form-control" placeholder="Nueva dirección"></asp:TextBox>
                    <asp:Label runat="server" CssClass="justify-content-start" Text="Cambiar contraseña:" Font-Size="Larger"></asp:Label>
                    <asp:TextBox runat="server" ID="pass" class="form-control" TextMode="password" placeholder="Nueva contraseña"></asp:TextBox>
                    <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="pass" ID="PasswordValidator" ValidationExpression="^[\s\S]{6,15}$" runat="server" ErrorMessage="Tu contraseña debe tener entre 6 y 15 caracteres."></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredPass" runat="server" ErrorMessage="Este campo es obligatorio" ControlToValidate="pass" CssClass="ValidationError" ToolTip="Este campo es obligatorio"></asp:RequiredFieldValidator>
            <div class="row" style="margin-top: 5px; margin-left:1px">
                <asp:Button runat="server" OnClick="Unnamed_Click" class="btn btn-success" Text="Guardar Información" />
            </div>
                </div>
                <div class="col-md-6">
                    <asp:Label runat="server" ID="delete_account_label" Visible="false" CssClass="justify-content-start"  Text="¿Desea desactivar su cuenta?" Font-Size="Small"></asp:Label>
                    <asp:Label runat="server" ID="delete_check_label" Visible="false" CssClass="justify-content-start" Text="Esta accón no se puede revertir. ¿Estás segur@?" ForeColor="Red"> </asp:Label>
                    <asp:Button runat="server" ID="delete_request_button" Visible="false" OnClick="Delete_Request" class="btn btn-outline-dark " Text="Eliminar Cuenta" CausesValidation="False" UseSubmitBehavior="False"/>
                    <asp:Button runat="server" ID="delete_account_button" Visible="false" OnClick="Delete_Click" class="btn btn-outline-danger" Text="Eliminar Cuenta" CausesValidation="False" UseSubmitBehavior="False" />
                </div>
            </div>
        </div>

    </div>
</asp:Content>
