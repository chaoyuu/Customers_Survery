<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffSearchPage.aspx.cs" Inherits="Assesment1_mock_up.StaffSearchPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-image: url('Image/Staff.jpg')">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            color: #3333FF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>&nbsp;&nbsp;<asp:Button ID="btnHome" runat="server" BorderColor="Red" BorderStyle="Groove" OnClick="btnHome_Click" Text="Back to Dashboad" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="auto-style2"> Staff search Page</span></h3>
            <h3>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; First Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Lass Name：<asp:TextBox ID="textLastName" runat="server"></asp:TextBox>
            </h3>
            <h3>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Age Range：&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="dropDownAg" runat="server">
                    <asp:ListItem>0~18</asp:ListItem>
                    <asp:ListItem>18~20</asp:ListItem>
                    <asp:ListItem>20~30</asp:ListItem>
                    <asp:ListItem>30~50</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; State/Territory:<asp:TextBox ID="textboxState" runat="server"></asp:TextBox>
&nbsp;&nbsp; Gender:<asp:DropDownList ID="DpDGender" runat="server">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </h3>
            <h3>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Home Suburb:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="textboxHS" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Home Post code:&nbsp;&nbsp;
                <asp:TextBox ID="textboxHPC" runat="server"></asp:TextBox>
&nbsp; Email Address:<asp:TextBox ID="textboxEA" runat="server"></asp:TextBox>
            </h3>
            <h3>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Bank Used:<asp:DropDownList ID="dpdBK" runat="server" DataSourceID="connectionString" DataTextField="Options_text" DataValueField="Options_text">
                </asp:DropDownList>
                <asp:SqlDataSource ID="connectionString" runat="server" ConnectionString="<%$ ConnectionStrings:connectionString %>" SelectCommand="SELECT [Options_text] FROM [Question_Options]"></asp:SqlDataSource>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp; Banks Service:<asp:DropDownList ID="dpdBS" runat="server">
                </asp:DropDownList>
                &nbsp;&nbsp;
&nbsp; Newspaper:&nbsp;&nbsp;
                <asp:DropDownList ID="dpdNS" runat="server">
                </asp:DropDownList>
            </h3>
            <h3>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Date:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBoxDate" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Calendar" />
                &nbsp;&nbsp;&nbsp; Ip&nbsp; address:&nbsp;&nbsp;
                <asp:TextBox ID="textboxIPA" runat="server" Width="181px"></asp:TextBox>
            </h3>
            <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Calendar ID="Calendar2" runat="server" Height="115px" OnSelectionChanged="Calendar2_SelectionChanged" Width="220px"></asp:Calendar>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
            <p>&nbsp;</p>
            <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnRest" runat="server" OnClick="btnRest_Click" style="height: 26px" Text="Reset" />
            </p>
            <p>&nbsp;</p>
        </div>
       
        <p>
            &nbsp;</p>
        <h3 class="auto-style1">Search Result</h3>
        <p>
            <asp:GridView ID="GridView1" runat="server" Width="547px">
                <Columns>
                    <asp:BoundField DataField="abc" HeaderText="Column2" SortExpression="abc" />
                </Columns>
            </asp:GridView>
        </p>
       
    </form>
</body>
</html>
