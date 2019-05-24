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
            vertical-align:central;
        }
        .prod-img{
            width: 250px;
            height: 400px;
        }
        .prod-name-label{
           /*text-shadow: 2px 1px 1px #333;*/
            border-bottom:0.5px ridge coral;
        }
        .prod-info-label{
            color: black;
        }
        .btn-add-cart{
            background-color: coral;
            color: black;
            border-style: solid;
            border-color: black;
        }
        .jumbotron{
            padding: 10px 10px 7px 10px;
            max-width: 700px;
        }
       .btn-send-comment{
            background-color: lawngreen;   
        }
       .prod-info-letter{
            padding-top: 0.15em;
       }
    </style>
    <title> PRODUCT PAGE </title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <!-- Contiene las filas y columnas en las que se divide la página -->
    <div class="container">
        <!---------------------------------------- PRODUCT INFO SECTION ------------------------------------------------------->
        <div class="row">

            <!-- Product Image --><!-- TODO: RESPONSIVE IMAGE-->
            <div class="col-xs-6">
                <asp:Image runat="server" ID="ProductImage" CssClass="img-responsive" ImageUrl="~/Imagenes/GIN_PUERTOINDIAS_AZUL.jpg" />
            </div>

            <!-- The media body is next to the media -->
            <div class="col-xs-6">
                    <!-- NAME -->
                    <div class="row">
                        <div class="col-xs-1"> 
                            <h4>
                                <asp:Label ID="ProductName" runat="server" CssClass="prod-name-label" Text="GINEBRA CLÁSICA PUERTO DE INDIAS"></asp:Label>
                            </h4>
                        </div>                        
                    </div>
                    <!-- PRICE -->
                    <div class="row">
                        <div class="col-xs-1">
                            <h5 style="padding-top:0.15em">PVP:&nbsp;</h5>
                        </div>
                        <div class="col-xs-1">
                            <h5><asp:Label ID="ProductPriceLabel" CssClass="prod-info-label" runat="server" Text="13.50€"></asp:Label></h5>
                        </div>
                    </div>
                    <!-- VOLUME -->
                    <div class="row">
                        <div class="col-xs-1">
                            <h5 class="prod-info-letter">Volumen:&nbsp;</h5>
                        </div>
                        <div class="col-xs-1">
                            <h5><asp:Label ID="ProductGradeLabel" CssClass="prod-info-label" runat="server" Text="700ml"></asp:Label></h5>
                        </div>                         
                    </div>
                    <!-- GRADE -->
                    <div class="row">
                       <div class="col-xs-1">
                           <h5 class="prod-info-letter">Grado:&nbsp;</h5>
                       </div>
                       <div class="col-xs-11">
                            <h5><asp:label ID="ProductVolumeLabel" cssClass="prod-info-label" runat="server" Text="40.0%"></asp:label></h5>
                       </div>
                   </div>
                   <!-- TYPE -->
                   <div class="row">
                       <div class="col-xs-1">
                           <h5 class="prod-info-letter">Tipo:&nbsp;</h5>
                       </div>
                       <div class="col-xs-1">
                           <h5><asp:label ID="AlcoholTypeLabel" cssClass="prod-info-label" runat="server" Text="Ginebra"></asp:label></h5>
                       </div>
                   </div>
                   <!-- BRAND -->
                   <div class="row">
                        <div class="col-xs-1">
                            <h5 class="prod-info-letter">Marca:&nbsp;</h5>
                        </div>
                        <div class="col-xs-1">
                            <h5><asp:label ID="ProductBrandLabel" cssClass="prod-info-label" runat="server" Text="Puerto de Indias"></asp:label></h5>
                        </div>
                   </div>
                   <!-- CHOOSE QUANTITY -->
                   <!--div class="row">
                        <div class="col-xs-1">
                            <h5 class="prod-info-letter">Cantidad:&nbsp;</h5>
                        </div>
                        <div class="col-xs-1">
                           <asp:TextBox ID="ProdAmount" style="width: 40px" runat="server"></asp:TextBox>
                        </div>
                   <!--/div-->
                   <div class="row">
                        <div class="col-xs-1 form-group form-inline">
                            <h5 class="prod-info-letter"><label for="exampleInputName2">Cantidad:&nbsp;</label></h5>
                            <asp:TextBox ID="ProdQuantity" style="width: 60px" CssClass="form-control" runat="server"></asp:TextBox>
                       </div>
                   </div>
                    <!--ADD TO CART-->
                   <div class="row">
                       <div class="col-xs-1">
                           <asp:Button ID="AddCartButton" runat="server" CssClass="btn btn-add-cart" Text="AÑADIR AL CARRITO" OnClick="AddCartButton_Click"/>
                       </div>
                   </div>

            </div>
         </div><!-- End MediaProduct Row -->
        
        <!------------------------------------- DESCRIPTION SECTION ------------------------------------------------------------>        
        <div class="row" style="padding-top: 1em;">
            <div class="col-xs-1">
                <div class="jumbotron">
                    <h6>DESCRIPCIÓN DEL PRODUCTO</h6>
                    <asp:label ID="Label1" runat="server" CssClass="well"
                        Text="Puerto de Indias es una ginebra Premium elaborada en Carmona (Sevilla), en una de las destilerías 
                        más antiguas y con mayor tradición de Andalucía. 
                        Gin Puerto de Indias Classic destaca por su carácter corpulento para una ginebra más intensa, más cítrica. 
                        La lima, el pomelo, la cáscara de naranja y limón y el cilantro aportan al paladar un toque muy fresco.">
                    </asp:label>
                </div>
            </div>
        </div>
        <!----------------------------------------- COMMENTS SECTION ----------------------------------------------------------------->
        <div class="row">
            <div class="col-xs-12">
                <div class="row">
                    <div class="col-xs-1">
                         <label for="InputComment">¡Añade un comentario!</label>
                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-1">
                        <asp:TextBox ID="CommentTextBox" runat="server" style="padding-bottom: 0.5em"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-1">
                        <button type="submit" class="btn btn-success" style="margin-top:0.5em">Enviar Comentario</button>
                    </div>
                </div>
            </div>
        </div>
    </div><!--END CONTAINER-->
</asp:Content>
