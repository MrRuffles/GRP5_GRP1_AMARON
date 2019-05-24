<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Forgot.aspx.cs" Inherits="AMARON_INTERFACE.Forgot" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <style type="text/css">
        body {
            background-color: darkorange;
        }

        #login-group {
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
    <div style="align-content: center; align-items: center; text-align: center;">
        <h1 style="padding: 50px 0px 0px 0px; font-size: 50px; text-align: center; align-items: center">Password recovery</h1>
        <hr width="60%" align="center" />
        <div class=" d-flex justify-content-center" style="">
            <div id="login-group" class="card">
                <article class="card-body">
                    <div class="d-flex align-baseline">
                        <asp:Label runat="server" Font-Size="Larger" Text="Enter your email and we will provide your password via email."></asp:Label>
                    </div>
                    <div class="form-group">
                        <div class="d-flex align-baseline">
                            <asp:Label runat="server" Font-Size="Larger" Text="Email"></asp:Label>
                        </div>
                        <asp:TextBox runat="server" ID="recover_email" TextMode="Email" CssClass="form-control" placeholder="Email" required="required" oninvalid="this.setCustomValidity('Valid email is required: ex@abc.xyz')"
                            oninput="this.setCustomValidity('')"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <div class=" row d-flex justify-content-around">
                            <asp:Button ID="Send_email" Text="Send" runat="server" CssClass="btn btn-primary" OnClick="Send_email_Click" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="align-baseline" style="text-align: left">
                            <asp:Label ID="Label_Sending_Error" runat="server" Text="There is no registered user with the given email." Visible="false" ForeColor="red" Font-Size="Large"></asp:Label>
                            <asp:Label ID="Label_Sending_Success" runat="server" Text="We have sent an email with your information to the provided address." Visible="false" ForeColor="Green" CssClass="text-left btn" Font-Size="Large" Font-Italic="false"></asp:Label>
                            <asp:Label ID="Label_Main" runat="server" Text="" Visible="false" ForeColor="Red" Font-Bold="false"></asp:Label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <div  style="text-align: left">
                                <asp:HyperLink runat="server" Text="Do you need help? Contact us" NavigateUrl="~/Contact.aspx"></asp:HyperLink> 

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
