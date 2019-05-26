<%@ Page Title="Contacto" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="AMARON_INTERFACE.Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <script async defer src="https://connect.facebook.net/es_LA/sdk.js#xfbml=1&version=v3.3"></script>
    <style type="text/css">
        body {
            background-color: whitesmoke;
        }
        
        #contact-form {
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
        <h1 style="padding: 50px 0px 0px 0px; font-size: 50px; text-align: center; align-items: center">Contáctanos</h1>
    </div>
    <hr width="60%" align="center"/>
    <div class="container col-md-8" id="contact-form">
        <div class="row">
            <div class="col-md-8 offset-xl-2 py-5">
                <div class="messages"></div>
                <div class="controls">
                    <div class="row ">
                        <div class="col-md-6">
                            <div class="form-group">
                                <div class="d-flex align-baseline">
                                    <asp:Label runat="server" Font-Size="Larger" Text="Nombre *"></asp:Label>
                                </div>
                                <asp:TextBox runat="server" ID="tb_name" TextMode="SingleLine" CssClass="form-control" placeholder="Introduzca su nombre *"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredName" runat="server" ErrorMessage="Este campo es obligatorio" ControlToValidate="tb_name" CssClass="ValidationError" ToolTip="Este campo es obligatorio"></asp:RequiredFieldValidator>
                                <div class="help-block with-errors"></div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <div class="form-group">
                                <div class="d-flex align-baseline">
                                    <asp:Label runat="server" Font-Size="Larger" Text="Email *"></asp:Label>
                                </div>
                                <asp:TextBox runat="server" ID="tb_email" TextMode="Email" CssClass="form-control" placeholder="Introduzca su email *" oninvalid="this.setCustomValidity('Introduzca un email válido: ex@abc.xyz')"
                                    oninput="this.setCustomValidity('')" onkeyup="EnforceMaximumLength(this,320)"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredEmail" runat="server" ErrorMessage="Este campo es obligatorio" ControlToValidate="tb_email" CssClass="ValidationError" ToolTip="Este campo es obligatorio"></asp:RequiredFieldValidator>
                                <div class="help-block with-errors"></div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <div class="form-group">
                                <div class="d-flex align-baseline">
                                    <asp:Label runat="server" Font-Size="Larger" Text="Asunto *"></asp:Label>
                                </div>
                                <asp:TextBox runat="server" ID="tb_subject" TextMode="SingleLine" CssClass="form-control" placeholder="Asunto *" ></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredSubject" runat="server" ErrorMessage="Este campo es obligatorio" ControlToValidate="tb_subject" CssClass="ValidationError" ToolTip="Este campo es obligatorio"></asp:RequiredFieldValidator>
                                <div class="help-block with-errors"></div>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group"> 
                                <div class="d-flex align-baseline">
                                    <asp:Label runat="server" Font-Size="Larger" Text="¿Hace una sugerencia o necesita soporte? *"></asp:Label>
                                </div>
                                <asp:DropDownList ID="form_option" CssClass="form-control" runat="server">
                                    <asp:ListItem Value="Suggestion" Text="Me gustaría hacer una sugerencia"></asp:ListItem>
                                    <asp:ListItem Value="Support" Text="Necesito soporte"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <div class="form-group">
                                <div class="d-flex align-baseline">
                                    <asp:Label runat="server" Font-Size="Larger" Text="Mensaje *"></asp:Label>
                                </div>
                                <asp:TextBox runat="server" ID="tb_message" type="text" TextMode="MultiLine" CssClass="form-control" placeholder="Mensaje *"  Rows="8"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredMessage" runat="server" ErrorMessage="Este campo es obligatorio" ControlToValidate="tb_message" CssClass="ValidationError" ToolTip="Este campo es obligatorio"></asp:RequiredFieldValidator>
                                <div class="help-block with-errors"></div>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <asp:Button CssClass="btn btn-success" ID="send_button" OnClick="Button_send_click" runat="server" Text="Enviar mensaje" />
                        </div>
                        <div class="col-md-6">
                            <asp:Label ID="Label_Sending_Success" runat="server" Text="Mensaje enviado" Visible="false" ForeColor="Green" Font-Size="X-Large" Font-Bold="true" Font-Italic="true"></asp:Label>
                            <asp:Label ID="Label_Sending_Error" runat="server" Text="Ocurrió un error al enviar su mensaje, inténtelo de nuevo en unos segundos." Visible="false" ForeColor="OrangeRed" Font-Size="X-Large"></asp:Label>
                            <asp:Label ID="Label_Main" runat="server" Text="" Visible="false" ForeColor="Red" Font-Bold="false"></asp:Label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <p class="text-muted">
                                <strong>(*)</strong> Estos campos son obligatorios
                            </p>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <a href="https://twitter.com/UA_Universidad?ref_src=twsrc%5Etfw" class="twitter-follow-button " data-show-count="false">Sigue a @UA_Universidad</a><script async src="https://platform.twitter.com/widgets.js" charset="utf-8"></script>
                            <div class="fb-like" data-href="https://www.facebook.com/campusUA/" data-width="" data-layout="standard" data-action="like" data-size="small" data-show-faces="false" data-share="true"></div>
                        </div>
                        <div class="col-md-6 d-flex justify-content-end">
                            <asp:HyperLink runat="server" ImageUrl="~/Imagenes/Logo_UA.jpg" NavigateUrl="https://www.ua.es/"></asp:HyperLink>
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
