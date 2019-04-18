<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AMARON_INTERFACE.Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <style>
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
    <div style="background-color:aqua" class="d-flex justify-content-center">
        <div>
            <asp:Image runat="server" ID="Image1" Height="200" Width="500" ImageUrl="Imagenes/ron.jpg" AlternateText="Roncico pa to el mundo" />
            <asp:Button CssClass="button-slide" ID="Button1" runat="server" Text="<" />
            <asp:Button CssClass="button-slide" ID="Button2" runat="server" Text=">" />
            <ajaxToolkit:SlideShowExtender ID="Image1_SlideShowExtender" runat="server" Enabled="True" SlideShowServicePath="SlideService.asmx" TargetControlID="Image1" SlideShowServiceMethod="GetSlides" NextButtonID="Button2" PreviousButtonID="Button1" />
        </div>
    </div>
    
    
</asp:Content>
