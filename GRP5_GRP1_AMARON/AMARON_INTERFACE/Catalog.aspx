<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Catalog.aspx.cs" Inherits="AMARON_INTERFACE.Catalog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <style>
        body{
            background-color:white;
            min-width:290px;
            line-height: 1.5;
        }
        #navbar{
          position:fixed;
          min-width:290px;
          top:130px;
          left:-1px;
          width:300px;
          height:100%;
          border-right-style: solid;
          border-right-color: #ddd;
          border-right-width: medium;
        }

        #navbar ul{
          height:88%;
          overflow-y:auto;
          overflow-x:hidden;
        } 

        #navbar li{
          color: #4e89aa;
          border-bottom-width:1px;
          padding-left:45px;
          list-style: none;
          position:relative;
          left:-60px;
          width:148%;
          top: 0px;
          border-left-style: solid;
          border-left-color: inherit;
          border-left-width: 0px;
          border-right-style: solid;
          border-right-color: inherit;
          border-right-width: 0px;
          border-top-style: solid;
          border-top-color: inherit;
          border-top-width: 1px;
          border-bottom-style: solid;
          border-bottom-color: inherit;
          padding-right: 8px;
          padding-top: 8px;
          padding-bottom: 8px;
        }
        #navbar a{
          text-decoration: none;
          cursor: pointer;
        }

        header{
          font-size: 30px;
          color: #0189d8;
          text-align: center;
          font-size: 1.9em;
          font-weight:normal;
        }

        #main-doc{
          margin-left:310px;
          padding:20px;
          margin-bottom:110px;
        }

        #main-doc header{
          text-align:left;
          margin:0px;
        }
        a{
            list-style: none;
            text-decoration:none;
        }

        .imgcat{
            height: 270px;
        }

        
       

        @media only screen and (max-width: 815px) {
            /* For mobile phones: */
          #navbar ul{
            border:1px solid;
            height:207px;
          }
          #navbar{
            background-color:white;
            position:absolute;
            top:0;
            padding:0;
            margin: 0;
            width:100%;
            max-height:275px;
            border:none;
            z-index:1;
            border-bottom:2px solid;
          }
          #main-doc{
            position: relative;
            margin-left:0px;
            margin-top:270px;
          }
        }

        @media only screen and (max-width: 400px) {
          #main-doc{
            margin-left:-10px;
          }
          code{
            margin-left:-20px;
            width:100%;
            padding:15px;
            padding-left:10px;
            padding-right:45px;
            min-width:233px;
          }
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <nav id="navbar">
            <header>Filter</header>
            <ul>
                <a class="nav-link" href="Catalog.aspx?cat=bottle">
                    <li>Bottle</li>
                </a>
                <a class="nav-link" href="Catalog.aspx?cat=packs">
                    <li>Packs</li>
                </a>
                <a class="nav-link" href="Catalog.aspx?cat=misc">
                    <li>Miscellaneous</li>
                </a>
                <!--<a class="nav-link" href="Catalog.aspx?cat=bottle"><li>Function Declaration</li></a>-->
            </ul>
        </nav>
        <main id="main-doc">
            <asp:Table runat="server" ID="cat"></asp:Table>
        </main>
    </div>
</asp:Content>
