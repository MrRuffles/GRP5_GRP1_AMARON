<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="AMARON_INTERFACE.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <style type="text/css">
        body {
            background-color: whitesmoke;
        }

        @keyframes backgound {
            100% {
                background-color: #ffffff;
            }
        }
    </style>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="align-content: center; align-items: center; text-align: center">
        <h2 style="padding: 50px 0px 0px 0px; font-size: 50px; text-align: center; align-items: center">Registro</h2>
        <hr width="60%" align="center" />
    </div>
    <div class="container col-md-8" id="register-form">
        <div class="row rounded" style="border-radius: 200px; background-color: coral">
            <div class="col-md-8 offset-xl-2 py-5">
                <div class="controls">
                    <div class="row ">
                        <div class="col-md-6">
                            <div class="form-group">
                                <div class="d-flex align-baseline">
                                    <asp:Label runat="server" Font-Size="Larger" Text="Nombre *"></asp:Label>
                                </div>
                                <asp:TextBox runat="server" ID="tb_name" TextMode="SingleLine" CssClass="form-control" placeholder="Introduce tu nombre" ></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredName" runat="server" ErrorMessage="&laquo; (Required)" ControlToValidate="tb_name" CssClass="ValidationError" ToolTip="Este campo es obligatorio"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group" style="width: 200px">
                                <div class="d-flex align-baseline">
                                    <asp:Label runat="server" Font-Size="Larger" Text="Fecha de nacimiento *"></asp:Label>
                                </div>
                                <asp:TextBox runat="server" ID="tb_birth" Width="150px" TextMode="Date" CssClass="form-control" required="required"></asp:TextBox>
                                <asp:Label runat="server" ID="Error_Birth" ForeColor="Red" Visible="false" Text=""></asp:Label>
                                <asp:RequiredFieldValidator ID="RequiredBirthdate" runat="server" ErrorMessage="&laquo; (Required)" ControlToValidate="tb_birth" CssClass="ValidationError" ToolTip="Este campo es obligatorio"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <div class="form-group">
                                <div class="d-flex align-baseline">
                                    <asp:Label runat="server" Font-Size="Larger" Text="Email *"></asp:Label>
                                </div>
                                <asp:TextBox runat="server" ID="tb_email" TextMode="Email" CssClass="form-control" placeholder="Introduzca su email" oninvalid="this.setCustomValidity('Introduzca un email válido: ex@abc.xyz')"
                                    oninput="this.setCustomValidity('')" onkeyup="EnforceMaximumLength(this,320)"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredEmail" runat="server" ErrorMessage="&laquo; (Required)" ControlToValidate="tb_email" CssClass="ValidationError" ToolTip="Este campo es obligatorio"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <div class="d-flex align-baseline">
                                    <asp:Label runat="server" Font-Size="Larger" Text="Contraseña *"></asp:Label>
                                </div>
                                <asp:TextBox runat="server" ID="tb_password" TextMode="password" CssClass="form-control" placeholder="********" oninvalid="this.setCustomValidity(')"></asp:TextBox>
                                <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="tb_password" ID="PasswordValidator" ValidationExpression="^[\s\S]{6,}$" runat="server" ErrorMessage="Tu contraseña debe tener al menos 6 caracteres."></asp:RegularExpressionValidator>
                                <asp:RequiredFieldValidator ID="RequiredPassword" runat="server" ErrorMessage="&laquo; (Required)" ControlToValidate="tb_Password" CssClass="ValidationError" ToolTip="Este campo es obligatorio"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <div class="form-group">
                                <div class="d-flex align-baseline">
                                    <asp:Label runat="server" Font-Size="Larger" Text="Comprobación de email *"></asp:Label>
                                </div>

                                <asp:TextBox runat="server" ID="tb_email_confirm" TextMode="Email" CssClass="form-control" placeholder="Introduzca su email de nuevo" oninvalid="this.setCustomValidity('Introduzca un email válido: ex@abc.xyz')"
                                    oninput="this.setCustomValidity('')" onkeyup="EnforceMaximumLength(this,320)"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredEmailCheck" runat="server" ErrorMessage="&laquo; (Required)" ControlToValidate="tb_email_confirm" CssClass="ValidationError" ToolTip="Este campo es obligatorio"></asp:RequiredFieldValidator>
                                <asp:Label runat="server" ID="Error_email" ForeColor="Red" Visible="false" Text="¡Los emails deben coincidir!"></asp:Label>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <div class="d-flex align-baseline">
                                    <asp:Label runat="server" Font-Size="Larger" Text="Comprobación de contraseña *"></asp:Label>
                                </div>
                                <asp:TextBox runat="server" ID="tb_password_confirm" TextMode="password" CssClass="form-control" placeholder="********"></asp:TextBox>
                                <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="tb_password_confirm" ID="PasswordCheckValidator" ValidationExpression="^[\s\S]{6,}$" runat="server" ErrorMessage="Tu contraseña debe tener al menos 6 caracteres."></asp:RegularExpressionValidator>
                                <asp:RequiredFieldValidator ID="RequiredPasswordCheck" runat="server" ErrorMessage="&laquo; (Required)" ControlToValidate="tb_Password_confirm" CssClass="ValidationError" ToolTip="Este campo es obligatorio"></asp:RequiredFieldValidator>

                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <div class="form-group">
                                <div class="d-flex align-baseline">
                                    <asp:Label runat="server" Font-Size="Larger" Text="Dirección de envio *"></asp:Label>
                                </div>
                                <asp:TextBox runat="server" ID="tb_delivery_address" TextMode="SingleLine" CssClass="form-control" placeholder="Introduzca la dirección de envio" required="required"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredAddress" runat="server" ErrorMessage="&laquo; (Required)" ControlToValidate="tb_delivery_address" CssClass="ValidationError" ToolTip="Este campo es obligatorio"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <div class="d-flex align-baseline">
                                    <asp:Label runat="server" Text="Foto de perfil"></asp:Label>
                                </div>
                                <div id="form2" runat="server" enctype="multipart/form-data">
                                    <asp:FileUpload ID="pictureUpload" class="btn btn-primary" runat="server" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row" typeof="file">
                        <div class="col-md-6">
                            <div class="form-group">
                                <div class="d-flex align-baseline">
                                    <asp:Label runat="server" Font-Size="Larger" Text="Empresa"></asp:Label>
                                </div>
                                <asp:TextBox runat="server" ID="tb_empresa" TextMode="SingleLine" CssClass="form-control" placeholder="Si eres un proveedor, añade tu empresa:"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <asp:Button CssClass="btn btn-success" ID="Button_register" OnClick="Button_register_click" runat="server" Text="Crea mi cuenta" />
                            <div class="align-baseline" style="text-align: left">
                                <asp:Label ID="Label_Sending_Error" runat="server" Text="Hubo un error al crear su cuenta, pruebe de nuevo o contacte un administrador." Visible="false" ForeColor="red" Font-Size="Large"></asp:Label>
                                <asp:Label ID="Label_Sending_Success" runat="server" Text="Tu cuenta ha sido creada" Visible="false" ForeColor="Green" CssClass="text-left btn" Font-Size="Large" Font-Italic="false"></asp:Label>
                                <asp:Label ID="Label_Main" runat="server" Text="" Visible="false" ForeColor="Red" Font-Bold="false"></asp:Label>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12" style="padding-top: 20px">
                            <p class="text-muted">
                                <strong>(*)</strong> Estos campos son obligatorios
                            </p>
                            <p class="text-muted">
                                Al crear su cuenta, acepta nuestros Terminos de Servicio.
                            </p>
                        </div>
                    </div>
                </div>
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

