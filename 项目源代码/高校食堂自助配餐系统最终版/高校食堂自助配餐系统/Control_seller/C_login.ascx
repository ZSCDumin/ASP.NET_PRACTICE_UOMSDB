<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="C_login.ascx.cs" Inherits="高校食堂自助配餐系统.Control_seller.login" %>

<header>
    <style>
        .contain {
            height: 560px;
        }

        .text {
            height: 30px;
            width: 250px;
            margin-top: 10px;
        }

        .left {
            height: 560px;
            margin-left: 8%;
            float: left;
        }

        .right {
            height: 560px;
            margin-left: 50px;
            float: left;
        }

        .Radiobtn {
            font-size: 17px;
        }
    </style>
    <link href="../bootstrap/css/bootstrap.css" rel="stylesheet" type="text/css" media="all" />
</header>

<div>

    <div class="left">
        <img src="../images/login_img.png" style="margin-left: 200px; margin-top: 110px; height: 287px; width: 277px;" />
    </div>
    <div class="right">
        <div style="margin-top: 124px;">
            <h2>登录</h2>
            <br />
            <asp:TextBox ID="txtAccount" runat="server" placeholder="用户名" CssClass="text"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAccount" ErrorMessage="必须输入账号"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="txtPassword" runat="server" placeholder="密码" CssClass="text" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="必须输入密码"></asp:RequiredFieldValidator>
            <a href="../seller/Retrieve_pwd.aspx" style="font-size: 14px;">忘记密码？</a>
            <br />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div style="margin-top: 10px;">
                        <asp:TextBox ID="txtCode" runat="server" placeholder="在此输入验证码"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;<asp:Label ID="lblCode" runat="server" BackColor="#66FF99" ForeColor="Red" Height="20px" Width="60px">974612</asp:Label>
                        &nbsp;&nbsp;&nbsp;        
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="请输入验证码" ControlToValidate="txtCode"></asp:RequiredFieldValidator>
                    </div>
                    <br />
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" CssClass="Radiobtn">
                        <asp:ListItem>买家</asp:ListItem>
                        <asp:ListItem>卖家</asp:ListItem>
                    </asp:RadioButtonList>
                    <br />
                </ContentTemplate>
            </asp:UpdatePanel>
            <asp:Button ID="btnLanding" runat="server" OnClick="Button1_Click" Text="登录" CssClass="btn btn-primary" Width="206px" />
            <br />
        </div>
    </div>

</div>
