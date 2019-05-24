﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="AMARON_INTERFACE.Orders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <style>
        .orders{
            display: block;
            width: 100%;
            line-height: 1em;
            }

        .orders h1{
            padding-bottom: 40px;
            border-bottom: 5px solid #ff6d00;
            padding-top: 40px;
            font-size: 35px;
            text-align: center;
            text-transform: uppercase;
            display: block;
        }

        table{
            text-align: center;
            margin-bottom: 35px;
            border-bottom: 1px solid #ff6d00;
            border-top: 1px solid #ff6d00;
        }
      
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="orders">
        <h1>TUS PEDIDOS</h1>
    </div>
    
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="orderNum" DataSourceID="SqlDataSource1" Width="100%" HeaderStyle-BackColor="#ff6600">
            <Columns>
                <asp:BoundField DataField="orderNum" HeaderText="Nº Pedido" ItemStyle-Width="25%" ItemStyle-Wrap="false" >
<ItemStyle Wrap="False" Width="25%"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="state" HeaderText="Estado" SortExpression="state" ItemStyle-Width="25%" ItemStyle-Wrap="false" >
<ItemStyle Wrap="False" Width="25%"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="cost" HeaderText="Coste(€)" SortExpression="cost" ItemStyle-Width="25%" ItemStyle-Wrap="false" >
<ItemStyle Wrap="False" Width="25%"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="date" HeaderText="Fecha" SortExpression="date" DataFormatString="{0:d}" ItemStyle-Width="25%" ItemStyle-Wrap="false" >
<ItemStyle Wrap="False" Width="25%"></ItemStyle>
                </asp:BoundField>
            </Columns>
            

<HeaderStyle BackColor="#FF6600"></HeaderStyle>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AmaronDataBase.mdf;Integrated Security=True;Connect Timeout=30" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [orderNum], [state], [cost], [date] FROM [Order]"></asp:SqlDataSource>
    </div>




</asp:Content>
