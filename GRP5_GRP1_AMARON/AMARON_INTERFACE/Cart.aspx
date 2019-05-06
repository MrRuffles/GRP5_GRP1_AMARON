<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="AMARON_INTERFACE.Cart" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="Stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <style>
        .cart{
            display: block;
            width: 100%;
            line-height: 1.6em;
        }
        .cart h2 {
            margin-bottom: 50px;
            padding-bottom: 40px;
            border-bottom: 1px solid #CCCCCC;
            margin-top: 50px;
            padding-top: 40px;
            border-top: 1px solid #CCCCCC;
            font-size: 40px;
            text-align: center;
            display: block;
            margin-left:50px;
            margin-right:50px;
        }
        .cart h3{
            text-align: center;
            margin-bottom: 50px;
            margin-top:50px;
            margin-left:50px;
            margin-right:50px;
            border-bottom: 3px solid #4e89aa;
            border-top: 3px solid #4e89aa;
            border-left: 3px solid #4e89aa;
            border-right: 3px solid #4e89aa;
            background-color: coral;
        }
        .cart h4{
            text-align: center;
            display: block;
            font-size: 30px;
        }
        .cart h5{
            text-align: center;
            display: block;
            font-size: 30px;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="cart">
        <h2>Artículos en mi cesta</h2>
    
        <h3>
            <br />
            &nbsp;<asp:Label ID="Articulo_1" Text="" runat="server" BorderColor="Window" style="text-align: left"></asp:Label><br />
            &nbsp;<asp:Label ID="Articulo_2" Text="" runat="server" BorderColor="Window" style="text-align: left"></asp:Label><br />
            &nbsp;<asp:Label ID="Articulo_3" Text="" runat="server" BorderColor="Window" style="text-align: left"></asp:Label><br />
            &nbsp;<asp:Label ID="Articulo_4" Text="" runat="server" BorderColor="Window" style="text-align: left"></asp:Label><br />
            <br />
        </h3>
        <h4>TOTAL:
            <asp:Label ID="TotalPrice" Text="" runat="server" BorderColor="Window" style="text-align: left"></asp:Label><br />
        </h4>
        <h5>&nbsp<asp:Button ID="Button" Text="Finalizar Compra" runat="server" OnClick="Button_FinCompra"></asp:Button></h5>
    </div>
    <br />
    
</asp:Content>