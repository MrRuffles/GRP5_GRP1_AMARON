
<%@ Page Title="Añadir Producto" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddNewProduct.aspx.cs" Inherits="AMARON_INTERFACE.AddNewProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/popper.min.js"></script>

    <style>
        .container{
            margin-top: 50px;
        } 
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <!-- NAME -->
        <div class="row">
            <div class="col-md-12">
                <div class="form-group form-inline">
                    <asp:Label runat="server" Text="Nombre del producto: " Font-Size="Large"></asp:Label>&nbsp;
                    <asp:TextBox ID="NewProNameTB" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <!-- TYPEPROD -->
        <div class="row">
            <div class="col-md-12">
                <div class="form-group form-inline">
                    <asp:Label runat="server" Text="Tipo de producto: " Font-Size="Large"></asp:Label>&nbsp;
                    <asp:TextBox ID="NewProdTYPRTB" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <!-- TYPE -->
        <div class="row">
            <div class="col-md-12">
                <div class="form-group form-inline">
                    <asp:Label runat="server" Text="Tipo de alcohol: (solo si es una botella)" Font-Size="Large"></asp:Label>&nbsp;
                    <asp:TextBox ID="NewProdTypeTB" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>    
        <!-- Volume -->
        <div class="row">
            <div class="col-md-12">
                <div class="form-group form-inline">
                    <asp:Label runat="server" Text="Volumen de la botella (ml): " Font-Size="Large"></asp:Label>&nbsp;
                    <asp:TextBox ID="NewPordVolume" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <!-- PRICE -->
        <div class="row">
            <div class="col-md-12">
                <div class="form-group form-inline">
                    <asp:Label runat="server" Text="Precio (€): " Font-Size="Large"></asp:Label>&nbsp;
                    <asp:TextBox ID="NewProdPriceTB" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <!-- STOCK -->
        <div class="row">
            <div class="col-md-12">
                <div class="form-group form-inline">
                    <asp:Label runat="server" Text="Stock del producto: " Font-Size="Large"></asp:Label>&nbsp;
                    <asp:TextBox ID="NewProdStockTB" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
       <!-- Imagen del producto -->
        <div class="row">
            <div class="col-md-12">
                 <div class="form-group form-inline">
                     <asp:Label runat="server" Text="Imagen del producto: " Font-Size="Large"></asp:Label>&nbsp;
                     <asp:FileUpload ID="pictureUpload" class="btn btn-primary" runat="server" />
                 </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-12">
                 <div class="form-group form-inline">
                     <asp:Button runat="server" Text="Añadir producto." ID="addP" OnClick="AddP_Click"/>
                 </div>
            </div>
        </div>
    
    </div><!-- END CONTAINER-->


</asp:Content>
