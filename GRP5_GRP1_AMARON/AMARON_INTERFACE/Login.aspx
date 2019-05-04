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
        #login-group{
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
        <hr>
        <asp:label ID="login_label" runat="server" CssClass="text-success text-center"></asp:label>
        <div class=" d-flex justify-content-center" style="">
            <div id="login-group" class="card">
                <article class="card-body">
                    
                    <div class="form-group">
                        <label>Your email</label>
                        <input name="" class="form-control" placeholder="Email" type="email">
                    </div>
                    <div class="form-group">
                        <a class="float-right" href="#">Forgot?</a>
                        <label>Your password</label>
                        <input class="form-control" placeholder="Password" type="password">
                    </div>
                    <div class="form-group">
                        <div class="checkbox">
                            <label>
                                <input type="checkbox">
                                Save password
                            </label>
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Button ID="login_button" Text="Login" runat="server" CssClass="btn btn-primary"/>
                        <asp:HyperLink runat="server" Text="Register" NavigateUrl="/Register.aspx" CssClass="btn btn-outline-dark float-right"></asp:HyperLink>
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
</asp:Content>
