<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="AMARON_INTERFACE.Payment" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="Stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <style>
        .Payment h2{
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
        .Payment h3{
            text-align: center;
        }
        .Payment h4{
            text-align:center;
            font-size: 40px;
        }
        .Payment h5{
            text-align: center;
            display: block;
            font-size: 30px;
        }
        .Payment h6{
            text-align:center;
            display: block;
            font-size: 30px;
        }

    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Payment">
        <h4>PAGO</h4>
        <h2>
            <br />Direccion de envio:
            <asp:Label ID="Direccion" Text="" runat="server" BorderColor="Window" style="text-align: left"></asp:Label><br />
            <br />
        </h2>
        <h3>&nbsp<asp:Button ID="Button" Text="Cambiar Direccion" runat="server" OnClick="Button_ChangeDir"></asp:Button></h3>
        <h5>TOTAL:
            <asp:Label ID="TotalPrice" Text="" runat="server" BorderColor="Window" style="text-align: left"></asp:Label><br />
        </h5>
        <h6>&nbsp<asp:Button ID="Button1" Text="Finalizar Compra" runat="server" OnClick="Button_FinCompra"></asp:Button></h6>
    </div>
</asp:Content>

