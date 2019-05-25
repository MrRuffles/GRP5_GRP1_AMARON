
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
        .prod-labels{
            color: black;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <!-- Feedback labels -->
        <div class="row">
            <div class="col-md-12">
                <div class="form-group form-inline">
                    <asp:Label ID="ProductCreatedLabel" class="alert alert-success" runat="server" Visible="false" Text="¡El producto ha sido añadido con éxito!">
                    </asp:Label>
                </div>
            </div>
        </div>
        <!-- Create Product Failed Feed back Label -->
       <div class="row">
            <div class="col-md-12">
                <div class="form-group form-inline">
                    <asp:Label ID="ErrorCreatingProductLabel" class="alert alert-danger" runat="server" Visible="false" Text="Ha habido un error y el producto no ha podido ser añadido, contáctanos a través de nuestro formulario si sigues teniendo problemas :(">
                    </asp:Label>
                </div>
            </div>
        </div>
        <!-- Error To convert -->
        <div class="row">
            <div class="col-md-12">
                <div class="form-group form-inline">
                    <asp:Label ID="ConvertErrorLabel" class="alert alert-danger" runat="server" Visible="false" Text="¡Este dato debe ser un número!">
                    </asp:Label>
                </div>
            </div>
        </div>
        <!-- Info label -->
        <div class="row">
            <div class="col-md-12">
                <div class="form-group form-inline">
                    <asp:Label ID="InfoLabel" runat="server" Visible="false" Text="Los campos con * son obligatorios.">
                    </asp:Label>
                </div>
            </div>
        </div>
        <!-- NAME -->
        <div class="row">
            <div class="col-md-2" style="padding-top:0.5em; align-content:flex-start" >
                <asp:label ID="NewProdNameLabel" runat="server" CssClass="prod-labels" Text="Nombre del producto:"></asp:label>&nbsp;
            </div>
            <div class="col-md-10">
                <div class="form-group form-inline">
                    <asp:TextBox ID="NewProdNameTB" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                </div>
            </div>
        </div>
        <!-- BRAND -->
        <div class="row">
            <div class="col-md-2" style="padding-top:0.5em">
                <asp:label ID ="NewProdBrandLabel" runat="server" CssClass="prod-labels" Text="Nombre de la marca:"></asp:label>&nbsp;
            </div>
            <div class="col-md-10">
                <div class="form-group form-inline">
                    <asp:TextBox ID="NewProdBrandTB" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                </div>
            </div>
        </div>

        <!-- PRODUCT TYPE -->
        <div class="row">
            <div class="col-md-2">
                <asp:label ID="NewProductTypeTB" runat="server" Text="Selecciona el tipo de producto:" CssClass="prod-labels"></asp:label>&nbsp;
            </div>
             <div class="col-md-10">             
                    <asp:DropDownList ID="ProdTypeDropDown" runat="server" OnSelectedIndexChanged="ProdTypeDropDown_SelectedIndexChanged">
                        <asp:listitem text="Botella de Alcohol" value="1"></asp:listitem>
                        <asp:listitem text="Miscelanea" value="2"></asp:listitem>
                    </asp:DropDownList>
            </div>
        </div> 
        <!-- ALCOHOL TYPE -->
        <div class="row">
            <div class="col-md-2">
                <asp:label ID="AlcoholicTypeLabel" visible="true" runat="server"  CssClass="prod-labels" Text="Tipo de alcohol:"></asp:label>&nbsp;
            </div>
            <div class="col-md-5">             
                <asp:DropDownList ID="AlcoholicTypeDropDown" runat="server" visible="true">
                    <asp:listitem text="Sin Alcohol" value="1"></asp:listitem>
                    <asp:listitem text="Ginebra" value="2"></asp:listitem>
                    <asp:listitem text="Ron" value="3"></asp:listitem>
                    <asp:listitem text="Whiski" value="4"></asp:listitem>
                    <asp:listitem text="Tequila" value="5"></asp:listitem>
                    <asp:listitem text="Cerveza" value="6"></asp:listitem>
                    <asp:listitem text="Vino tinto" value="7"></asp:listitem>
                    <asp:listitem text="Vino blanco" value="8"></asp:listitem>
                    <asp:listitem text="Champagne" value="9"></asp:listitem>
                    <asp:listitem text="Sidra" value="10"></asp:listitem>
                    <asp:listitem text="Licor" value="11"></asp:listitem>
                    <asp:listitem text="Vodka" value="12"></asp:listitem>
                    <asp:listitem text="Otro" value="13"></asp:listitem>
                </asp:DropDownList>
            </div>
        </div>    
        <!-- Volume -->
        <div class="row">
            <div class="col-md-2">
                <asp:label ID="NewProdVolumeLabel" visible="true" runat="server" Text="Volumen de la botella (ml)*:" CssClass="prod-labels"></asp:label>&nbsp;
            </div>
            <div class="col-md-10">
                <div class="form-group form-inline">
                    <asp:TextBox ID="NewProdVolumeTB" runat="server" CssClass="form-control" Placeholder="0,0" Visible="true"></asp:TextBox>
                    <asp:Label ID="Label2" runat="server" Text="-1"></asp:Label>
                </div>
            </div>
        </div>
        <!-- Grade -->
        <div class="row">
            <div class="col-md-2">
                <asp:label ID="NewProdGradeLabel" runat="server" visible="true"  CssClass="prod-labels" Text="Grado de la botella (%)*:"></asp:label>&nbsp;
            </div>
            <div class="col-md-10">
                <div class="form-group form-inline">
                    <asp:TextBox ID="NewProdGradeTB" runat="server" placeholder="0,0" CssClass="form-control" visible="true"></asp:TextBox>
                    <asp:Label ID="Label1" runat="server" Text="-1"></asp:Label>
                </div>
            </div>
        </div>
        <!-- PRICE -->
        <div class="row">
            <div class="col-md-2" style="padding-top:0.5em">
                <label for="NewProdPriceLabel">Precio (€)*:</label>&nbsp;
            </div>
            <div class="col-md-10">
                <div class="form-group form-inline">
                    <asp:TextBox ID="NewProdPriceTB" runat="server" CssClass="form-control" Placeholder="0,0" required="required"></asp:TextBox>
                    <asp:Label ID="pruebaPrice" runat="server" Text="-1" Visible="true"></asp:Label>
                </div>
            </div>
        </div>
        <!-- STOCK -->
        <div class="row">
            <div class="col-md-2" style="padding-top:0.5em">
                <label for="NewProductStockLabel">Stock del producto:*</label>&nbsp;
            </div>
            <div class="col-md-10">
                <div class="form-group form-inline">
                    <asp:TextBox ID="NewProdStockTB" TextMode="Number" runat="server"  CssClass="form-control" required="required"></asp:TextBox>
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
        <!-- Descripción del producto -->
        <div class="row">
            <div class="col-md-12">
                <div class="row">
                    <div class="col-md-6">
                         <label for="InputComment">Añade una descripción del producto</label>
                    </div>
                </div>
                <div class="row">
                    <div class="form-group">
                        <div class="col-md-12">
                            <asp:TextBox ID="NewProdDescriptionTB" type="text" TextMode="MultiLine" runat="server" style="padding-bottom: 0.5em" Rows="4"
                                CssClass="form-control" width="650px"></asp:TextBox>
                        </div>
                    </div>
                </div> 
            </div>
         </div>
        <!-- Botón Añadir Producto -->
        <div class="row">
            <div class="col-md-12">
                 <div class="form-group form-inline">
                     <asp:Button runat="server" ID="addProductBT" Text="¡Añade Este Producto!" class="btn btn-success" OnClick="addProductBT_Click"/>

                 </div>
            </div>
        </div>

    
    </div><!-- END CONTAINER-->

    
</asp:Content>
