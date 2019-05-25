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
           background-image: url("Imagenes/EstrellaRellena.png"); 
                     
       }
       .Saved{
           background-image:url("Imagenes/EstrellaMedio.png");
       }
       .Empty{
           background-image: url("Imagenes/EstrellaVacia.png");
       }
       .Well{
           text-align: start;
       }

    </style>
    <title> PRODUCT PAGE </title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <!-- Contiene las filas y columnas en las que se divide la página -->
    <div class="container" >
           <!-- Wrong Amount raning Label -->
            <div class="row">
                <div class="col-md-12">
                    <div class="form-group form-inline">
                        <asp:Label ID="AmountErrorLabel" class="alert alert-danger" runat="server" Visible="false" Text="¡Este dato no puede ser 0!">
                        </asp:Label>
                    </div>
                </div>
            </div>
            <!-- Feedback labels -->
            <div class="row">
                <div class="col-md-12">
                    <div class="form-group form-inline">
                        <asp:Label ID="ProductAddedLabel" class="alert alert-success" runat="server" Visible="false" Text="¡El producto ha sido añadido  al carrito con éxito!">
                        </asp:Label>
                    </div>
                </div>
            </div>
        <!---------------------------------------- PRODUCT INFO SECTION ------------------------------------------------------->
        <div class="row">

            <!-- Product Image -->
            <div class="col-md-3 align-self-center">
                <asp:Image runat="server" ID="ProductImage" CssClass="prod-img"/>
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
                <div class="jumbotron" style="height: 250px;  width:750px">
                    <h6>DESCRIPCIÓN DEL PRODUCTO</h6>
                    <asp:label ID="CommentTextLabel" runat="server" CssClass="well" ></asp:label>
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
