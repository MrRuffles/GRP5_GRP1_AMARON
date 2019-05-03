<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddNewProduct.aspx.cs" Inherits="AMARON_INTERFACE.AddNewProduct" %>
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
            <div class="col-xl-1">
                <div class="form-group form-inline">
                    <label for="NewProdNameTB">Nombre del producto:</label>&nbsp;
                    <asp:TextBox ID="NewProNameTB" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>

    <!-- BRAND -->
    <div class="row">
        <div class="col-xl-1">
            <div class="form-group form-inline">
                <label for="NewProdBrandTB">Nombre de la marca:</label>&nbsp;
                <asp:TextBox ID="NewProdBrandTB" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
    </div>
    <!-- TYPE -->
    <div class="row">
        <div class="col-xl-1">
            <div class="form-group form-inline">
                <label for="NewProductTypeTB">Tipo de alcohol:</label>&nbsp;
                <asp:TextBox ID="NewProdTypeTB" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
    </div>    
    <!-- Volume -->
    <div class="row">
        <div class="col-xl-1">
            <div class="form-group form-inline">
                <label for="NewProdVolume">Volumen de la botella (ml):</label>&nbsp;
                <asp:TextBox ID="NewPordVolume" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
    </div>
    <!-- PRICE -->
    <div class="row">
        <div class="col-xl-1">
            <div class="form-group form-inline">
                <label for="NewProdPriceTB">Precio (€):</label>&nbsp;
                <asp:TextBox ID="NewProdPriceTB" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
    </div>
    
        
    <!-- STOCK -->
    <div class="row">
        <div class="col-xl-1">
            <div class="form-group form-inline">
                <label for="NewProductStock">Stock del producto:</label>&nbsp;
                <asp:TextBox ID="NewProdStockTB" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
    </div>
       <!-- Imagen del producto -->
        <div class="row">
            <div class="col-xl-1">
                 <div class="form-group">
                    <label for="ProductImg">Imagen del producto:</label>
                    <input type="file" id="ProductImg">
                 </div>
            </div>
        </div>
</div>


</asp:Content>
