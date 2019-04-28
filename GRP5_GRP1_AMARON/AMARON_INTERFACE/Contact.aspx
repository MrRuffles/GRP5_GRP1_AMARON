<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="AMARON_INTERFACE.Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <style>
        body {
            background-color: darkorange;
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
        <asp:HyperLink runat="server" ImageUrl="Imagenes/support_center.png" ImageHeight="200px" NavigateUrl="~/Support.aspx">SUPPORT</asp:HyperLink>
    </div>
    <div>
        <h2 style="font-family: 'Bahnschrift Condensed'; text-align: center">* * *</h2>
        <p style="font-family: 'Bahnschrift Condensed'; text-align: center">Universidad de Alicante</p>
        <p style="font-family: 'Bahnschrift Condensed'; text-align: center">Carretera de San Vicente del Raspeig s/n 03690 </p>
        <p style="font-family: 'Bahnschrift Condensed'; text-align: center">San Vicente del Raspeig</p>
        <p style="font-family: 'Bahnschrift Condensed'; text-align: center">Alicante (Spain)</p>
        
        <div style="text-align:center"><a href="https://eps.ua.es/" >http://eps.ua.es</a></div>
        <h2 style="font-family: 'Bahnschrift Condensed'; text-align: center">* * *</h2>
    </div>
    <h1 style="font-family: LIQUOR; font-size: 35px; text-align: center; align-items: center">Contact Us</h1>

    <div class="container col-md-8" id="contact-form">
        <div class="row">
            <div class="col-md-8 offset-xl-2 py-5">
                <p class="lead" style="font-style: italic">Please fill this form in a decent manner</p>

                <div class="messages"></div>
                <div class="controls">
                    <div class="row ">
                        <div class="col-md-6">
                            <div class="form-group">
                                <label for="form_name">Name *</label>
                                <input id="form_name" type="text" runat="server" name="name" class="form-control" placeholder="Please enter your name *" required="required" data-error="Firstname is required.">
                                <div class="help-block with-errors"></div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <div class="form-group">
                                <label for="form_email">Email *</label>
                                <input id="form_email" type="email" runat="server" name="email" class="form-control" placeholder="Please enter your email *"
                                    required="required" oninvalid="this.setCustomValidity('Valid email is required: ex@abc.xyz')"
                                    oninput="this.setCustomValidity('')" onkeyup="EnforceMaximumLength(this,320)">
                                <div class="help-block with-errors"></div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <div class="form-group">
                                <label for="form_subject">Subject *</label>
                                <input id="form_subject" type="text" runat="server" name="subject" class="form-control" placeholder="Subject *" required="required" data-error="Subject is required.">
                                <div class="help-block with-errors"></div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <div class="form-group">
                                <label for="form_message">Message *</label>
                                <textarea id="form_message" name="message" runat="server" class="form-control" placeholder="Message *" rows="8" required="required" data-error="Please, leave us a message."></textarea>
                                <div class="help-block with-errors"></div>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <asp:Button CssClass="btn btn-success" ID="send_button" OnClick="Button_send_click" runat="server" Text="Send Message" />
                        </div>
                        <div class="col-md-6">
                            <asp:Label ID="Label_Sending_Success" runat="server" Text="Email sent" Visible="false" ForeColor="LimeGreen" Font-Bold="true"></asp:Label>
                            <asp:Label ID="Label_Sending_Error" runat="server" Text="There was an error trying to send your message, please try again." Visible="false" ForeColor="OrangeRed" Font-Bold="true"></asp:Label>
                            <asp:Label ID="Label_Main" runat="server" Text="" Visible="false" ForeColor="Red" Font-Bold="false"></asp:Label>

                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <p class="text-muted">
                                <strong>*</strong> These fields are required.
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
</asp:Content>
