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
            border-bottom: 3px solid #000000;
            border-top: 3px solid #000000;
            border-left: 3px solid #000000;
            border-right: 3px solid #000000;
            background-color: #df6025;
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
        <div class="d-flex justify-content-center">
            <asp:Label runat="server" Font-Size="XX-Large" Text="Pago"></asp:Label>
        </div>
        <div class ="row">
            <div class="col-md-2">
                <asp:Label ID="Label1" runat="server" Text="Dirección de envío: "></asp:Label>
            </div>
            <div class="col-md-2">
                <asp:Label ID="Direccion" Text="" runat="server"  BorderColor="Window" CssClass="form-control"></asp:Label>
            </div>
        </div>
        <div class="row">
            <div class ="col-md-2">
                <asp:Label ID="Titular" runat="server" Text="Titular de la tarjeta: "></asp:Label>
            </div>
            <div class="col-md-2">
                <asp:TextBox ID="nombre" runat="server" CssClass="form-control" oninvalid="this.setCustomValidity('Nombre y apellidos del titular')"
                            oninput="this.setCustomValidity('')" ></asp:TextBox>
                </div>
        </div>
        <div class="row">
            <div class="col-md-2">
                <asp:Label ID="numero" runat="server" Text="Número de tarjeta: "></asp:Label>&nbsp;
            </div>
            <div class="col-md-2">
                <div class="form-group form-inline">
                    <asp:TextBox ID="Tarjeta" runat="server" CssClass="form-control" oninvalid="this.setCustomValidity('Numero de tarjeta')"
                            oninput="this.setCustomValidity('')" MaxLength="16"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-2">
                <asp:Label ID="mes" runat="server" Text="Mes de caducidad: "></asp:Label>&nbsp;
            </div>
            <div class="col-md-2">
                <div class="form-group form-inline">
                    <asp:TextBox runat="server" ID="MesCad" MaxLength="2" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-2">
                <asp:Label ID="ano" runat="server" Text="Año de caducidad: "></asp:Label>
            </div>
            <div class="col-md-2">
                <div class="form-group form-inline">
                    <asp:TextBox runat="server" ID="AnoCad" MaxLength="4" CssClass="form-control"></asp:TextBox>
                    <asp:Label ID="Error_Caducidad" runat="server" Text="Tarjeta caducada" ForeColor="Red" Visible="False" ></asp:Label>
                    <asp:Label ID="Error_Fecha" runat="server" Text="Mes inválido" ForeColor="Red" Visible="False" ></asp:Label>
                </div>
            </div>
         </div>
        <div class="row">
            <div class="col-md-2">
                <asp:Label ID="CodCVC" runat="server" Text="Código CVC: "></asp:Label>
            </div>
            <div class="col-md-2">
                <div class="form-group form-inline">
                    <asp:TextBox ID="CVC" runat="server" CssClass="form-control" MaxLength="3"></asp:TextBox>
                </div>
            </div>
        </div>
         <div class="row">
        </div>
        
        <h5>TOTAL:
            <asp:Label ID="TotalPrice" Text="" runat="server" BorderColor="Window" CssClass="d-flex justify-content-center"></asp:Label><br />
        </h5>
        <h6>&nbsp<asp:Button ID="Button1" Text="Finalizar Compra" CssClass="btn btn-light" runat="server" OnClick="Button_FinCompra"></asp:Button></h6>
    </div>
</asp:Content>

