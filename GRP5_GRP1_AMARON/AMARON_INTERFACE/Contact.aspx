<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="AMARON_INTERFACE.Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <script async defer src="https://connect.facebook.net/es_LA/sdk.js#xfbml=1&version=v3.3"></script>
    <style type="text/css">
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
        <h1 style="padding: 50px 0px 0px 0px; font-size: 50px; text-align: center; align-items: center">Contact Us</h1>
    </div>
    <hr width="60%" align="center"/>
    <div class="container col-md-8" id="contact-form">
        <div class="row">
            <div class="col-md-8 offset-xl-2 py-5">
                <p class="lead" style="font-style: italic">Please fill this form in a decent manner</p>
                <div class="messages"></div>
                <div class="controls">
                    <div class="row ">
                        <div class="col-md-6">
                            <div class="form-group">
                                <div class="d-flex align-baseline">
                                    <asp:Label runat="server" Font-Size="Larger" Text="Name *"></asp:Label>
                                </div>
                                <asp:TextBox runat="server" ID="tb_name" TextMode="SingleLine" CssClass="form-control" placeholder="Please enter your name *" required="required"></asp:TextBox>
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
                                <asp:TextBox runat="server" ID="tb_email" TextMode="Email" CssClass="form-control" placeholder="Please enter your email *" required="required" oninvalid="this.setCustomValidity('Valid email is required: ex@abc.xyz')"
                                    oninput="this.setCustomValidity('')" onkeyup="EnforceMaximumLength(this,320)"></asp:TextBox>
                                <div class="help-block with-errors"></div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <div class="form-group">
                                <div class="d-flex align-baseline">
                                    <asp:Label runat="server" Font-Size="Larger" Text="Subject *"></asp:Label>
                                </div>
                                <asp:TextBox runat="server" ID="tb_subject" TextMode="SingleLine" CssClass="form-control" placeholder="Subject *" required="required"></asp:TextBox>
                                <div class="help-block with-errors"></div>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group"> 
                                <div class="d-flex align-baseline">
                                    <asp:Label runat="server" Font-Size="Larger" Text="Suggestion / Support?"></asp:Label>
                                </div>
                                <asp:DropDownList ID="form_option" CssClass="form-control" runat="server">
                                    <asp:ListItem Value="Suggestion" Text="I'd like to make a suggestion"></asp:ListItem>
                                    <asp:ListItem Value="Support" Text="I need support"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <div class="form-group">
                                <div class="d-flex align-baseline">
                                    <asp:Label runat="server" Font-Size="Larger" Text="Message *"></asp:Label>
                                </div>
                                <asp:TextBox runat="server" ID="tb_message" type="text" TextMode="MultiLine" CssClass="form-control" placeholder="Message *" required="required" Rows="8"></asp:TextBox>
                                <div class="help-block with-errors"></div>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <asp:Button CssClass="btn btn-success" ID="send_button" OnClick="Button_send_click" runat="server" Text="Send Message" />
                        </div>
                        <div class="col-md-6">
                            <asp:Label ID="Label_Sending_Success" runat="server" Text="Email sent" Visible="false" ForeColor="Green" Font-Size="X-Large" Font-Bold="true" Font-Italic="true"></asp:Label>
                            <asp:Label ID="Label_Sending_Error" runat="server" Text="There was an error trying to send your message, please try again." Visible="false" ForeColor="OrangeRed" Font-Size="X-Large"></asp:Label>
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
                    <div class="row">
                        <div class="col-md-6">
                            <a href="https://twitter.com/UA_Universidad?ref_src=twsrc%5Etfw" class="twitter-follow-button" data-show-count="false">Follow @UA_Universidad</a><script async src="https://platform.twitter.com/widgets.js" charset="utf-8"></script>
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
