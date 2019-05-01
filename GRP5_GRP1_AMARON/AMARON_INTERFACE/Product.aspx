<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="AMARON_INTERFACE.Product" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <style>
        .container{
            margin-top: 50px;
            margin-bottom: 50px;
            align-content: flex-start;
        }
        .prod-info-label{
            color: black;
            padding-top: 0em;
        }
        .btn-add-cart{
            background-color: coral;
            color: black;
            border-style: solid;
            border-color: black;
        }
        .jumbotron{
            padding: 10px 5px 7px 5px;
        }
        .btn-send-comment{
            align
        }

    </style>
    <title> PRODUCT PAGE </title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <!-- Contiene las filas y columnas en las que se divide la página -->
    <div class="container">
        <!-- A row is a horizantal section of the page, 1 row = 12 columns -->
        <!-- MediaProduct Row -->
        <div class="row">
            <div class="media">
                <!-- Product Image -->
                <div class="media-left">
                    <asp:Image ID="ProductImage" runat="server" CssClass="img img-fluid" ImageUrl="~/Imagenes/GIN_PUERTOINDIAS_AZUL.jpg"/>
                </div>
                <!-- The media body is next to the media -->
                <div class="media-body">
                    <div class="row">
                        <h4>
                            <asp:Label ID="ProductName" runat="server" CssClass="prod-info-label border-bottom" Text="GINEBRA CLÁSICA PUERTO DE INDIAS"></asp:Label>
                        </h4>
                        
                    </div>
                    <div class="row">
                         <h5>PVP:&nbsp;</h5>
                         <h5><asp:Label ID="ProductPriceLabel" CssClass="prod-info-label" runat="server" Text="13.50€"></asp:Label></h5>
                    </div>
                    <div class="row">
                         <h5>Volumen:&nbsp;</h5>
                         <h5><asp:Label ID="ProductGradeLabel" CssClass="prod-info-label" runat="server" Text="700ml"></asp:Label></h5>
                    </div>
                   <div class="row">
                       <h5>Grado:&nbsp;</h5>
                       <h5><asp:label ID="ProductVolumeLabel" cssClass="prod-info-label" runat="server" Text="40.0%"></asp:label></h5>
                   </div>
                   <div class="row">
                       <h5>Tipo:&nbsp;</h5>
                       <h5><asp:label ID="AlcoholTypeLabel" cssClass="prod-info-label" runat="server" Text="Ginebra"></asp:label></h5>
                   </div>
                    <div class="row">
                       <h5>Marca:&nbsp;</h5>
                       <h5><asp:label ID="ProductBrandLabel" cssClass="prod-info-label" runat="server" Text="Puerto de Indias."></asp:label></h5>
                   </div>
                   <div class="row">
                       <asp:Button ID="AddCartButton" runat="server" CssClass="btn btn-add-cart" Text="AÑADIR AL CARRITO"/>
                   </div>
                   
                </div>
            </div>
        </div> <!-- End MediaProduct Row -->
        
        <div class="row"> 
            <div class="jumbotron">
                <h6>DESCRIPCIÓN DEL PRODUCTO</h6>
                    <asp:label ID="Label1" runat="server" CssClass="well"
                        Text="Puerto de Indias es una ginebra Premium elaborada en Carmona (Sevilla), en una de las destilerías más antiguas y con mayor tradición de Andalucía. 
                        Gin Puerto de Indias Classic destaca por su carácter corpulento para una ginebra más intensa, más cítrica. La lima, el pomelo, la cáscara de naranja y limón y el cilantro aportan al paladar
                        un toque muy fresco. 40% Volumen de alcohol.">
                    </asp:label>
            </div>
        </div>

        <div class="row">
            <label style="border-bottom: 0.5px solid">Comentarios</label>
        </div>
        <div class="row">
            <label for="comment">Comment:</label>
            <asp:TextBox ID="CommentTextBox" runat="server" CssClass="form-control textarea"></asp:TextBox>
        </div>
        <div class="row">
            <asp:button ID="SendCommentButton" runat="server" cssclass="btn btn-send-comment" Text="ENVIAR COMENTARIO"></asp:button>
        </div>
        
    </div> 
    
</asp:Content>
