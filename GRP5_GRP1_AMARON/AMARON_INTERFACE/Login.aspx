<%@ Page Title="Iniciar Sesión" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AMARON_INTERFACE.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <style type="text/css">
        body {
            background-color: whitesmoke;
        }

        #login-group {
            background-color: coral;
        }

        @keyframes backgound {
            100% {
                background-color: #faa166;
            }
        }
    </style>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="align-content: center; align-items: center; text-align: center">
        <h1 style="padding: 50px 0px 0px 0px; font-size: 50px; text-align: center; align-items: center">Inicio de sesión</h1>
        <hr style=" width:60%; align-self:center" />
        <asp:Label ID="login_label" runat="server" CssClass="text-success text-center"></asp:Label>
        <div class=" d-flex justify-content-center" style="">
            <div id="login-group" class="card">
                <article class="card-body">
                    <div class="form-group">
                        <div class="d-flex align-baseline">
                            <asp:Label runat="server" Font-Size="Larger" Text="Email"></asp:Label>
                        </div>
                        <asp:TextBox runat="server" ID="login_email" TextMode="Email" CssClass="form-control" placeholder="Email" oninvalid="this.setCustomValidity('Se requiere un email válido: ex@abc.xyz')"
                            oninput="this.setCustomValidity('')"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredEmailLogin" runat="server" ErrorMessage="Introduce tu email" ControlToValidate="login_email" CssClass="ValidationError" ToolTip="Introduce tu email"></asp:RequiredFieldValidator>
                        
                    </div>
                    <div class="form-group">

                        <asp:Label runat="server" CssClass="float-left" Font-Size="Larger" Text="Contraseña"></asp:Label>
                        <asp:TextBox runat="server" ID="login_password" TextMode="password" CssClass="form-control" placeholder="Contraseña" oninvalid="this.setCustomValidity('Introduzca su contraseña')"
                            oninput="this.setCustomValidity('')"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredPasswordLogin" runat="server" ErrorMessage="Introduce tu contraseña" ControlToValidate="login_password" CssClass="ValidationError" ToolTip="Introduce tu contraseña"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="login_password" ID="PasswordValidator" ValidationExpression="^[\s\S]{6,15}$" runat="server" ErrorMessage="Tu contraseña tiene entre 6 y 15 caracteres."></asp:RegularExpressionValidator>
                        <div style="padding-top: 10px" class="float-right">
                            <asp:HyperLink runat="server" Text="¿Contraseña olvidada?" NavigateUrl="/Forgot.aspx"></asp:HyperLink>
                        </div>
                    </div>
                    <div class="form-group" style="padding-top: 50px;">
                        <div class="d-flex justify-content-center">
                            <asp:Button ID="login_button" Text="Iniciar sesión" runat="server" CssClass="btn btn-primary" OnClick="login_button_Click" />
                            <asp:HyperLink runat="server" Text="Registrarme" NavigateUrl="/Register.aspx" CssClass="btn btn-outline-dark float-right"></asp:HyperLink>
                        </div>
                    </div>
                    <div class="align-baseline" style="text-align: left">
                        <asp:Label ID="Label_Login_Error" runat="server" Text="Email y/o contraseña incorrecto/s." Visible="false" ForeColor="red" Font-Size="Large"></asp:Label>
                        <asp:Label ID="Label_Main" runat="server" Text="" Visible="false" ForeColor="Red" Font-Bold="false"></asp:Label>
                    </div>
                </article>
            </div>
        </div>
    </div>

    <script type="text/javascript">
        function EnforceMaximumLength(fld, len) {
            if (fld.value.length > len) { fld.value = fld.value.substr(0, len); }
        }
    </script>
    <script>
        //Prevent resumbitting when reloading page
        if (window.history.replaceState) {
            window.history.replaceState(null, null, window.location.href);
        }
    </script>
</asp:Content>
