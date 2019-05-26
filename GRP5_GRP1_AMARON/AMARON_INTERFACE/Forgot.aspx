<%@ Page Title="Recuperar Contraseña" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Forgot.aspx.cs" Inherits="AMARON_INTERFACE.Forgot" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <style type="text/css">
        body {
            background-color: whitesmoke;
        }

        #forgot-group {
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
    <div style="align-content: center; align-items: center; text-align: center;">
        <h1 style="padding: 50px 0px 0px 0px; font-size: 50px; text-align: center; align-items: center">Recuperación de credenciales</h1>
        <hr width="60%" align="center" />
        <div class=" d-flex justify-content-center" style="">
            <div id="forgot-group" class="card">
                <article class="card-body">
                    <div class="d-flex align-baseline">
                        <asp:Label runat="server" Font-Size="Larger" Text="Introduzca el email vinculado a su cuenta y le enviaremos sus nuevas credenciales."></asp:Label>
                    </div>
                    <div class="form-group">
                        <div class="d-flex align-baseline">
                            <asp:Label runat="server" Font-Size="Larger" Text="Email"></asp:Label>
                        </div>
                        <asp:TextBox runat="server" ID="recover_email" TextMode="Email" CssClass="form-control" placeholder="Email"  oninvalid="this.setCustomValidity('Introduzca un email válido: ex@abc.xyz')"
                            oninput="this.setCustomValidity('')"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredEmailForgot" runat="server" ErrorMessage="Introduce tu email" ControlToValidate="recover_email" CssClass="ValidationError" ToolTip="Introduce tu email"></asp:RequiredFieldValidator>
                        
                    </div>
                    <div class="form-group">
                        <div class=" row d-flex justify-content-around">
                            <asp:Button ID="Send_email" Text="Enviar" runat="server" CssClass="btn btn-primary" OnClick="Send_email_Click" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="align-baseline" style="text-align: left">
                            <asp:Label ID="Label_Update_Error" runat="server" Text="Ocurrió un error con su solicitud, contacte con un administrador si el problema persiste." Visible="false" ForeColor="red" Font-Size="Large"></asp:Label>
                            <asp:Label ID="Label_Finding_Error" runat="server" Text="No existe ningún usuario registrado vinculado a este email." Visible="false" ForeColor="red" Font-Size="Large"></asp:Label>
                            <asp:Label ID="Label_Sending_Success" runat="server" Text="Le hemos enviado sus credenciales al email indicado" Visible="false" ForeColor="Green" CssClass="text-left btn" Font-Size="Large" Font-Italic="false"></asp:Label>
                            <asp:Label ID="Label_Main" runat="server" Text="" Visible="false" ForeColor="Red" Font-Bold="false"></asp:Label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <div  style="text-align: left">
                                <asp:HyperLink runat="server" Text="¿Necesitas ayuda? Contáctanos" NavigateUrl="~/Contact.aspx"></asp:HyperLink> 

                            </div>
                        </div>
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
