<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="administrator_uc.ascx.cs" Inherits="高校食堂自助配餐系统.WebUserControl1" %>

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        #zxc
        {
            background-image:url('images/111.jpg');
            width: 746px;
        }
        #box
        {
            width:294px;
            height:281px;
        }
        
        .auto-style1 {
            width: 38px;
        }
        
        .auto-style2 {
            width: 67px;
        }
        
    </style>
<body>
    <table id="zxc">
        <tr>
            <td rowspan="3" class="auto-style1"><img src="../images/管理员头像.png" id="box" /></td><td colspan="2" align="right" class="auto-style2">账号：</td>
            <td>
                <asp:TextBox ID="txtAccount" runat="server" Height="16px" Width="231px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="请输入用户名" ControlToValidate="txtAccount">必须输入</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="right">密      码：</td>
            <td colspan="2">
                <asp:TextBox ID="txtPassword" runat="server" Height="16px" Width="232px" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="请输入密码" ControlToValidate="txtPassword">必须输入</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="3" align="center">
                <asp:Button ID="btnSubmit" runat="server" Text="登  录" Width="74px" OnClick="Button1_Click" Font-Bold="True" ForeColor="#0000CC" Height="31px" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnReset" runat="server" Text="重置" Width="75px" Font-Bold="True" ForeColor="Blue" Height="30px" OnClick="btnReset_Click" />
            </td>
        </tr>
    </table>
</body>