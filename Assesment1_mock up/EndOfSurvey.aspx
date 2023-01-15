<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EndOfSurvey.aspx.cs" Inherits="Assesment1_mock_up.EndOfSurvey" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-image: url('Image/EndofSurvey.jpg')">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            font-weight: normal;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 class="auto-style1"><strong>End of the Survey</strong></h2>
        </div>
        <p>
            &nbsp;</p>
        <asp:Table ID="questionAnswerDisplayTable" runat="server" style="color: #CC0000">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">Id </asp:TableCell>
                <asp:TableCell runat="server">Respondent_id </asp:TableCell>
                <asp:TableCell runat="server">QuestionId</asp:TableCell>
                <asp:TableCell runat="server">Answer text</asp:TableCell>
                <asp:TableCell runat="server">OptionId </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="BtnHomePage" runat="server" OnClick="BtnHomePage_Click" Text="Submit" />
        &nbsp;&nbsp;
            <asp:Button ID="btnhome" runat="server" OnClick="btnhome_Click" Text="Home" />
        </p>
    </form>
</body>
</html>
