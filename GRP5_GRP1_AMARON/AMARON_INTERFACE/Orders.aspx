<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="AMARON_INTERFACE.Orders" %>
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
      
        .auto-style2 {
            width: 458px;
        }
        .auto-style3 {
            width: 456px;
        }
      
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="orders">
        <h1>Your Orders</h1>
    </div>

    <table class="table table-sm">
  <thead>
    <tr class="table-warning">
      <th scope="col" class="auto-style3">Order Number</th>
      <th scope="col" class="auto-style2">Date</th>
      <th scope="col">P.V.P(€)</th>
      
    </tr>
  </thead>
  <tbody>
    <tr>
      <th scope="row" class="auto-style3">1</th>
      <td class="auto-style2">10/01/2019</td>
      <td>50</td>
      
    </tr>
    <tr>
      <th scope="row" class="auto-style3">2</th>
      <td class="auto-style2">28/01/2019</td>
      <td>21</td>
      
    </tr>
    <tr>
      <th scope="row" class="auto-style3">3</th>
      <td class="auto-style2">02/02/2019</td>
      <td>15</td>
      
    </tr>
      <tr>
      <th scope="row" class="auto-style3">4</th>
      <td class="auto-style2">04/03/2019</td>
      <td>35</td>
      
    </tr>
      <tr>
      <th scope="row" class="auto-style3">5</th>
      <td class="auto-style2">15/04/2019</td>
      <td>67</td>
      
    </tr>
  </tbody>
</table>


</asp:Content>
