<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AMARON_INTERFACE.Login" %>

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
    <div style="align-content: center; align-items: center; text-align: center">
        <h1 style="padding: 50px 0px 0px 0px; font-size: 50px; text-align: center; align-items: center">Login</h1>
        <hr width="60%" align="center"/>
        <asp:Label ID="login_label" runat="server" CssClass="text-success text-center"></asp:Label>
        <div class=" d-flex justify-content-center" style="">
            <div id="login-group" class="card">
                <article class="card-body">
                    <div class="form-group">
                        <div class="d-flex align-baseline">
                            <asp:Label runat="server" Font-Size="Larger" Text="Email"></asp:Label>
                        </div>
                        <asp:TextBox runat="server" ID="login_email" TextMode="Email" CssClass="form-control" placeholder="Email" required="required" oninvalid="this.setCustomValidity('Valid email is required: ex@abc.xyz')"
                            oninput="this.setCustomValidity('')"></asp:TextBox>

                    </div>
                    <div class="form-group">
                        
                        <asp:Label runat="server" CssClass="float-left" Font-Size="Larger" Text="Password"></asp:Label>
                        <asp:TextBox runat="server" ID="login_password" TextMode="password" CssClass="form-control" placeholder="Password" required="required" oninvalid="this.setCustomValidity('Please, enter your password')"
                            oninput="this.setCustomValidity('')"></asp:TextBox>
                        <div style="padding-top: 10px" class="float-right">
                            <asp:HyperLink runat="server" Text="Forgot password?" NavigateUrl="/Forgot.aspx"></asp:HyperLink>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class=" row d-flex justify-content-bottom" style="padding-top:50px">
                            <asp:Button ID="login_button" Text="Login" runat="server" CssClass="btn btn-primary" OnClick="login_button_Click" />
                            <asp:HyperLink runat="server" Text="Register" NavigateUrl="/Register.aspx" CssClass="btn btn-outline-dark float-right"></asp:HyperLink>
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
