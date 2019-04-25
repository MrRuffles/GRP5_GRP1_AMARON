<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AMARON_INTERFACE.Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <style>
        body{
            background-color:aqua;
        }
        .button-slide{
            background-color: orange;
            border-radius:4px;
            border-style:none;
            
        }
        .button-slide:hover{
            animation-name:backgound;
            animation-duration:1s;
            animation-fill-mode:forwards;
        }

        @keyframes backgound{
            100%{
                background-color: #faa166;
            }
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server" ID="ScriptManager1"></asp:ScriptManager>
    <div class="d-flex justify-content-center" style="margin: 30px 0px 0px 0px">
        <div class=" d-flex justify-content-between">
            <asp:Button CssClass="button-slide" ID="Button1" runat="server" Text="<" />
            <asp:Image runat="server" ID="Image1" Height="200" Width="500" ImageUrl="Imagenes/ron.jpg" AlternateText="Roncico pa to el mundo" />
            <asp:Button CssClass="button-slide" ID="Button2" runat="server" Text=">" />
            <ajaxToolkit:SlideShowExtender ID="Image1_SlideShowExtender" runat="server" Enabled="True" SlideShowServicePath="SlideService.asmx" TargetControlID="Image1" SlideShowServiceMethod="GetSlides" NextButtonID="Button2" PreviousButtonID="Button1" AutoPlay="True" Loop="True" />
        </div>
    </div>
    <div class="row d-flex justify-content-around" style="margin-top:30px; margin-bottom:30px">
        <div class="card" style="width: 18rem;">
            <asp:Image runat="server" ID="Image2" Height="270" ImageUrl="Imagenes/ron.jpg" AlternateText="Roncico pa to el mundo" />
            <div class="card-body">
                <h5 class="card-title">Card title</h5>
                <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                <asp:Button runat="server" href="#" class="btn btn-primary" Text="Go somewhere" />
            </div>
        </div>
        <div class="card" style="width: 18rem;">
            <asp:Image runat="server" ID="Image3" ImageUrl="Imagenes/vodka.jpg" AlternateText="Agua para rusos" />
            <div class="card-body">
                <h5 class="card-title">Card title</h5>
                <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                <asp:Button runat="server" href="#" class="btn btn-primary" Text="Go somewhere" />
            </div>
        </div>
        <div class="card" style="width: 18rem;">
            <asp:Image runat="server" ID="Image4" Height="270" ImageUrl="Imagenes/ginebra.jpg" AlternateText="Mejor en chupitazos" />
            <div class="card-body">
                <h5 class="card-title">Card title</h5>
                <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                <asp:Button runat="server" href="#" class="btn btn-primary" Text="Go somewhere" />
            </div>
        </div>
        <div class="card" style="width: 18rem;">
            <asp:Image runat="server" ID="Image5" Height="270" ImageUrl="Imagenes/whisky.jpg" AlternateText="Siempre mejor con hielo" />
            <div class="card-body">
                <h5 class="card-title">Card title</h5>
                <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                <asp:Button runat="server" href="#" class="btn btn-primary" Text="Go somewhere" />
            </div>
        </div>
    </div>
</asp:Content>
