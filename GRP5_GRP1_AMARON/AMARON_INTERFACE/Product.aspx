<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="AMARON_INTERFACE.Product" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.8.2/css/all.css">
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <style>
        .container{
            margin-top: 50px;
            margin-bottom: 50px;
           
        }
        .prod-img{
            width: 250px;
            height: 400px;
        }
        .prod-name-label{
           /*text-shadow: 1px 0.5px 0.5px #333;*/
           border-bottom:0.5px ridge coral;
           text-align:left;
        }
        .prod-info-label{
            color: black;
            padding-top: 0.05em;
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
            color: black;
            padding-right: 0.25em;
       }
       
       .RatingStar{
           height:30px;
           width:30px;
           cursor: pointer;
           background-repeat: no-repeat;
           display: block;
       }
       .Filled{
           background-image: url("InterfaceImgs/FilledStar.jpg"); 
           /*border-image:url("InterfaceImgs/FilledStar.jpg");*/
           background-color: gold;
           border: 2px solid beige;
                      
       }
       .Saved{
           background-image:url("InterfaceImgs/WaitingStar1.png");
           background-color: red;
       }
       .Empty{
           background-image: url("Imagenes/EmptyStar1.png");
           background-color: blue;
           border: 2px solid grey;
           border-image-outset: 50px;
       }

    </style>
    <title> PRODUCT PAGE </title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <!-- Contiene las filas y columnas en las que se divide la página -->
    <div class="container" >
        <!---------------------------------------- PRODUCT INFO SECTION ------------------------------------------------------->
        <div class="row">

            <!-- Wrong Amount raning Label -->
            <div class="row">
                <div class="col-md-12">
                    <div class="form-group form-inline">
                        <asp:Label ID="AmountErrorLabel" class="alert alert-danger" runat="server" Visible="false" Text="¡Este dato no puede ser 0!">
                        </asp:Label>
                    </div>
                </div>
            </div>
            <!-- Product Image --><!-- TODO: RESPONSIVE IMAGE-->
            <div class="col-md-3 align-self-center">
                <asp:Image runat="server" ID="ProductImage" CssClass="img-responsive" ImageUrl="~/Imagenes/GIN_Puerto.jpg" />
            </div>

            <!-- The media body is next to the media -->
            <div class="col-md-6">
                    <!-- NAME -->
                    <div class="row">
                        <div class="col-xs-12 align-self-center"> 
                            <h4>
                                <asp:Label ID="ProductNameLabel" runat="server" CssClass="prod-name-label"></asp:Label>
                            </h4>
                        </div>                        
                    </div>
                    <!-- PRICE -->
                    <div class="row">
                        <div class="col-xs-1 align-self-center">
                            <h5>
                                <asp:Label ID="PVPLabel" runat="server" CssClass="prod-info-letter" Text="PVP: "></asp:Label>
                            </h5>
                        </div>
                        <div class="col-xs-2 align-self-center">
                            <h5>
                                <asp:Label ID="ProductPriceLabel" CssClass="prod-info-label" runat="server"></asp:Label>
                            </h5>
                        </div>
                    </div>
                    <!-- VOLUME -->
                    <div class="row">
                        <div class="col-xs-2 align-self-center">
                            <h5>
                                <asp:Label ID="VolumenLabel" CssClass="prod-info-letter" runat="server" Text="Volumen:" Visible="false"></asp:Label>
                            </h5>
                        </div>
                        <div class="col-xs-2 align-self-center">
                            <h5>
                                <asp:Label ID="ProductVolumeLabel" CssClass="prod-info-label" runat="server" Visible="false"></asp:Label>
                            </h5>
                        </div>                         
                    </div>
                    <!-- GRADE -->
                    <div class="row">
                       <div class="col-xs-1 align-self-center">
                           <h5>
                               <asp:Label ID="GradoLabel" CssClass="prod-info-letter" runat="server" Text="Grado:" Visible="false"></asp:Label>
                           </h5>
                       </div>
                       <div class="col-xs-2 align-self-center">
                            <h5>
                                <asp:label ID="ProductGradeLabel" cssClass="prod-info-label" runat="server" Visible="false"></asp:label>
                            </h5>
                       </div>
                   </div>
                   <!-- ALCOHOLIC TYPE -->
                   <div class="row">
                       <div class="col-xs-1 align-self-center">
                            <h5>
                                <asp:Label ID="TipoDeAlcoholLabel" CssClass="prod-info-letter" runat="server" Text="Tipo de Alcohol: " Visible="false"></asp:Label>
                            </h5>
                       </div>
                       <div class="col-xs-3 align-self-center">
                           <h5><asp:label ID="ProdAlcoholTypeLabel" cssClass="prod-info-label" runat="server" Visible="false"></asp:label></h5>
                       </div>
                   </div>
                   <!-- BRAND -->
                   <div class="row">
                        <div class="col-xs-1 align-self-center">
                            <h5>
                                <asp:Label ID="MarcaLabel" CssClass="prod-info-letter" runat="server" Text="Marca: "></asp:Label>
                            </h5>
                        </div>
                        <div class="col-xs-4 align-self-center">
                            <h5><asp:label ID="ProductBrandLabel" cssClass="prod-info-label" runat="server" Text="Puerto de Indias"></asp:label></h5>
                        </div>
                   </div>
                   <!-- CHOOSE QUANTITY -->
                   <div class="row">
                        <div class="col-xs-1 form-group form-inline align-self-center">
                            <h5>
                                <asp:Label ID="CantidadLabel" CssClass="prod-info-letter" runat="server" Text="Cantidad: "></asp:Label>
                            </h5>
                            <asp:TextBox ID="ProdAmount" TextMode="Number" width="75px" CssClass="form-control" runat="server"></asp:TextBox>
                       </div>
                   </div>
                    <!--ADD TO CART-->
                   <div class="row">
                       <div class="col-xs-1 align-self-center">
                           <asp:Button ID="AddCartButton" runat="server" CssClass="btn btn-add-cart" Text="AÑADIR AL CARRITO" OnClick="AddCartButton_Click"/>
                       </div>
                   </div>

            </div>
         </div><!-- End MediaProduct Row -->
        
        <!------------------------------------- DESCRIPTION SECTION ------------------------------------------------------------>        
        <div class="row" style="padding-top: 1em;">
            <div class="col-xs-1 align-self-center">
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
        <!----------------------------------------- RATING SECTION ------------------------------------------------------------------->
        <!-- video que me ha ayudado: https://www.youtube.com/watch?v=D0ppJ7iF4y0 -->
        <div class="row">
            
            <div class="col-md-2">
              <label for="InputComment" style="padding-top: 0.5em" >¡Valora este producto!</label>
            </div>
            <div class="col-md-10">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <ajaxToolkit:Rating ID="ratingStars" runat="server"
                            MaxRating="5" Direction="LeftToRight"
                            CurrentRating="0"
                            StarCssClass="RatingStar"
                            WaitingStarCSSClass="Saved"
                            FilledStarCSSClass="Filled"
                            EmptyStarCSSClass="Empty"                            
                        >
                        </ajaxToolkit:Rating>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>            
        </div>
        <div class="row">
            <div class="col-lg-12">
                <div class="star-rating">
                    <span class="fa fa-star-o" data-rating="1"></span>
                    <span class="fa fa-star-o" data-rating="2"></span>
                    <span class="fa fa-star-o" data-rating="3"></span>
                    <span class="fa fa-star-o" data-rating="4"></span>
                    <span class="fa fa-star-o" data-rating="5"></span>
                    <input type="hidden" name="whatever1" class="rating-value" value="2.56">
                </div>
            </div>
        </div>
        <!----------------------------------------- COMMENTS SECTION ----------------------------------------------------------------->
        <div class="row">
            <div class="col-md-12">

                <div class="row"><!-- Comment text box-->
                    <div class="col-md-6">
                         <label for="InputComment">¡Añade un comentario!</label>
                    </div>
                </div>
                <div class="row">
                    <div class="form-group">
                        <div class="col-md-12">
                            <asp:TextBox ID="CommentTextBox" type="text" TextMode="MultiLine" runat="server" style="padding-bottom: 0.5em" Rows="4"
                                CssClass="form-control" width="650px"></asp:TextBox>
                        </div>
                    </div>
                </div> <!-- Comment Text Box -->
                
                <div class="row"><!-- Send comment button -->
                    <div>
                        <button type="submit" class="btn btn-success" style="margin-top:0.5em">Enviar Comentario</button>
                    </div>
                </div>

            </div>
        </div><!-- END COMMENT SECTION -->

    </div><!--END CONTAINER-->
        
</asp:Content>
