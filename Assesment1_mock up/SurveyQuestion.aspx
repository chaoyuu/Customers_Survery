<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SurveyQuestion.aspx.cs" Inherits="Assesment1_mock_up.SurveyQuestion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-image: url('Image/Online Survey.jpg')">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Select1 {
            width: 256px;
        }
        .auto-style2 {
            color: #0000CC;
        }
        #form1 {
            color: #CC0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2 class="auto-style2"><strong>Online Survey</strong></h2>
        <asp:Label ID="QuestionText" runat="server" Text="Label" style="color: #FF0000"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        <br />
        <br />
        <br />
        <asp:Button ID="btnNext" runat="server" OnClick="btnNext_Click" Text="Next" />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="btnHomePage" runat="server" OnClick="btnHomePage_Click" style="height: 26px" Text="Home" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
