<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BankofHomePage.aspx.cs" Inherits="Assesment1_mock_up.BankofHomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-image: url('Image/backgroundcolor.png')">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 191px;
            height: 89px;
            margin-right: 0px;
        }
        .auto-style2 {
            font-size: x-large;
            font-style: italic;
            color: #000099;
        }
        .auto-style4 {
            color: #FF0000;
        }
        .auto-style3 {
            width: 227px;
            height: 86px;
            margin-right: 0px;
            margin-top: 39px;
        }
        .auto-style5 {
            width: 217px;
            height: 71px;
        }
        .auto-style6 {
            width: 239px;
            height: 77px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="color: #3333FF">
            <h3 style="height: 106px; width: 1548px">
                <img alt="" class="auto-style1" src="Image/home.png" />&nbsp; <span class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dashboad&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Welcom User</span></h3>
            <p style="width: 1548px">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="auto-style4">&nbsp; <strong>Click on a Dashboad Option&nbsp;</strong></span></p>
            <p style="height: 300px; width: 1557px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<img alt="" class="auto-style3" src="Image/search.png" /><asp:Button ID="BtnSearch" runat="server" OnClick="BtnSearch_Click" style="color: #FF0000" Text="Question" Width="114px" />
&nbsp;&nbsp;&nbsp;
                <img alt="" class="auto-style5" src="Image/Staffsearch.jpg" /><asp:Button ID="BtnStaffSearch" runat="server" BorderColor="#3333CC" BorderStyle="Solid" OnClick="BtnStaffSearch_Click" style="color: #FF0000" Text="Staff" Width="89px" />
            &nbsp;
            </p>
            <p style="height: 300px; width: 1557px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<img alt="" class="auto-style6" src="Image/Respondents.png" />&nbsp; &nbsp;<asp:Button ID="BtnRegister" runat="server" OnClick="BtnRegister_Click" style="color: #3333FF" Text="Register" Width="82px" />
            </p>
            <p style="height: 106px; width: 1548px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
        </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
