<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="AMARON_INTERFACE.Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .js-tilt {
            margin-left: 80px;
            height: 32px;
            width: 144px;
        }

        .ph1 {
            background: url('Imagenes/contact_background.jpg');
            background-attachment:scroll;
            background-size:cover;
        }

        #TextArea1 {
            width: 318px;
            margin-top: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2"  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="ph1">
        <div>
            <div class="js-tilt" data-tilt="">
                <asp:Label ID="LabelContactUs" runat="server" Font-Names="LIQUOR" Text="Contact;: Us" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" Font-Overline="False" Font-Strikeout="False" Font-Underline="True" ForeColor="Black"></asp:Label>

                <br />
                <br />
            </div>
            <asp:Label ID="Label1" runat="server" Font-Names="Times" Text="Please fill this form in a decent manner" Font-Italic="True" Font-Bold="True" ForeColor="Black"></asp:Label>

            <br />

            <table>
                <tr>
                    <td>
                        <asp:Label ID="LabelName" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="LIQUOR" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" Text="NAME : "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="tbName" required="true" pattern="[A-Za-z]{1,30}" oninvalid="this.setCustomValidity('A valid name is required')" oninput="this.setCustomValidity('')" input="text" runat="server" minlenght="1" MaxLength="30" onkeyup="EnforceMaximumLength(this,30)" Height="16px" Width="319px"></asp:TextBox>

                    </td>
                    <td>
                        <asp:Label ID="LabelErrorName" runat="server" Text="" Font-Bold="True" Font-Italic="True" ForeColor="Red" Font-Overline="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LabelEmail" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="LIQUOR" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" Text="Email : "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="tbEmail" oninvalid="this.setCustomValidity('Valid email is required: ex@abc.xyz')" oninput="this.setCustomValidity('')" type="email" runat="server" minlenght="1" Height="16px" Width="318px" required="true" onkeyup="EnforceMaximumLength(this,300)"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="LabelErrorEmail" runat="server" Text="" Font-Bold="True" Font-Italic="True" ForeColor="Red" Font-Overline="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LabelSubject" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="LIQUOR" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" Text="Subject : "></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="tbSubject" type="text" runat="server" Height="16px" Width="318px" onkeyup="EnforceMaximumLength(this,500)"></asp:TextBox>

                    </td>
                    <td>
                        <asp:Label ID="LabelErrorSubject" runat="server" Text="" Font-Bold="True" Font-Italic="True" ForeColor="Red" Font-Overline="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LabelMessage" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="LIQUOR" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" Text="Message : "></asp:Label></td>

                    <td>

                        <textarea id="TextArea1" rows="8" name="S1" required runat="server" onkeyup="EnforceMaximumLength(this,100000)" oninvalid="this.setCustomValidity('Message field is required')" oninput="this.setCustomValidity('')"></textarea>
                    </td>
                    <td>
                        <asp:Label ID="LabelErrorMsg" runat="server" Text="" Font-Bold="True" Font-Italic="True" ForeColor="Red" Font-Overline="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                        <asp:Button runat="server" OnClick="Send_email" Style="font-family: LIQUOR; font-size: larger; font-weight: 500; font-style: oblique;" title="SEND EMAIL" Text="Send    Email"></asp:Button>
                    </td>
                    <td>
                        <asp:Label ID="MainLabel" runat="server" Text=""></asp:Label>                        
                    </td>
                </tr>
            </table>
        </div>
    </div>

    <script type="text/javascript"><!--
    function EnforceMaximumLength(fld, len) {
        if (fld.value.length > len) { fld.value = fld.value.substr(0, len); }
    }
//-->
    </script>

</asp:Content>
