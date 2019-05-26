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
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" HeaderStyle-BackColor="OrangeRed" Width="100%">
                <Columns>
                    <asp:BoundField DataField="cod" HeaderText="Cod. Pruducto" SortExpression="cod" />
                    <asp:BoundField DataField="name" HeaderText="Nombre Producto" SortExpression="name" />
                    <asp:BoundField DataField="amount" HeaderText="Cantidad" SortExpression="amount" />
                    <asp:BoundField DataField="sum" HeaderText="PVP." SortExpression="sum" />
                </Columns>

<HeaderStyle BackColor="OrangeRed"></HeaderStyle>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AmaronDataBase %>" SelectCommand="SELECT Cart.cod, Product.name, Cart.amount, Cart.sum FROM Cart INNER JOIN Product ON Cart.cod = Product.cod WHERE (Cart.userID = @UserID)">
                <SelectParameters>
                    <asp:QueryStringParameter Name="userID" QueryStringField="userID" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
        <h5>&nbsp<asp:Button ID="Button" Text="Finalizar Compra" runat="server" OnClick="Button_FinCompra"></asp:Button></h5>
    </div>
    <br />
    
</asp:Content>