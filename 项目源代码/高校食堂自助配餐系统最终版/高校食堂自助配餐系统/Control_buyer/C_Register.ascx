<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="C_Register.ascx.cs" Inherits="高校食堂自助配餐系统.control_buyer.C_Register" %>

<header>
    <style>
        .contain {
            width: 1003px;
            height: 560px;
        }

        .btn {
            padding: 0px 70px 0px 70px;
            background-color: #f7e8af;
            font-size: 24px;
            margin-top: 50px;
            margin-left:75%;
        }

        .text {
            height: 30px;
            width: 250px;
            margin-top: 10px;
        }

        .left {
            height: auto;
            width: 600px;
            float: left;
            text-align: center;
            margin-left: 300px;
        }

        .right {
            height: 560px;
            width: 503px;
            float: left;
            text-align: right;
        }

        label {
            font-size: 17px;
            
        }
    </style>
     <link href="../bootstrap/css/bootstrap.css" rel="stylesheet" type="text/css" />
</header>

<div class="left">
    <h2 style="margin-left:15%;">欢迎注册</h2>
        <table class="table">
            <tr>
                <td>
                    <label>您的帐号：</label></td>
                <td>
                    <asp:TextBox ID="txtSell_Account" runat="server" CssClass="text" placeholder="在此处输入您的账号"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtSell_Account" ErrorMessage="必须输入账号"></asp:RequiredFieldValidator></td>

            </tr>

            <tr>
                <td>
                    <label>输入密码：</label></td>
                <td>
                    <asp:TextBox ID="txtSell_password" runat="server" CssClass="text" placeholder="请输入密码" TextMode="Password"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSell_password" ErrorMessage="必须输入密码"></asp:RequiredFieldValidator></td>
            </tr>

            <tr>
                <td>
                    <label>再次输入：</label></td>
                <td>
                    <asp:TextBox ID="txtSell_again_passwod" runat="server" CssClass="text" placeholder="请再次输入密码" TextMode="Password"></asp:TextBox></td>
                <td>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtSell_again_passwod" ControlToValidate="txtSell_password" ErrorMessage="2次密码输入不一致"></asp:CompareValidator></td>
            </tr>


            <tr>
                <td>
                    <label>姓名：</label>&nbsp;&nbsp;</td>
                <td>
                    <asp:TextBox ID="txtSell_Name" runat="server" CssClass="text" placeholder="请输入您的姓名"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtSell_Name" ErrorMessage="必须输入密码"></asp:RequiredFieldValidator></td>
            </tr>

            <tr>
                <td>
                    <label>电话号码：</label></td>
                <td>
                    <asp:TextBox ID="txtSell_tel" runat="server" CssClass="text" placeholder="请输入您的手机号"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtSell_tel" ErrorMessage="必须输入电话号码"></asp:RequiredFieldValidator></td>
            </tr>

            
            <tr>
                <td>
                    <label>密保问题：</label></td>
                <td>
                    <asp:DropDownList ID="ddlQuestion" runat="server" Width="250px">
                        <asp:ListItem>你父亲的姓名？</asp:ListItem>
                        <asp:ListItem>你母亲的姓名？</asp:ListItem>
                        <asp:ListItem>你爱人的姓名？</asp:ListItem>
                        <asp:ListItem>你的出生日期？</asp:ListItem>
                        <asp:ListItem>你的大学的学号？</asp:ListItem>
                    </asp:DropDownList></td>
            </tr>

            <tr>
                <td>
                    <label>密保答案：</label></td>
                <td>
                    <asp:TextBox ID="txtSell_answer" runat="server" CssClass="text" placeholder="请在此处输入您的密保答案"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtSell_answer" ErrorMessage="密保答案不能为空"></asp:RequiredFieldValidator></td>

            </tr>


            <tr>
                <td>
                    <label>邮箱：&nbsp; </label>
                </td>
                <td>
                    <asp:TextBox ID="txtSell_mail" runat="server" CssClass="text" placeholder="请输入您的邮箱"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtSell_mail" ErrorMessage="邮箱不能为空"></asp:RequiredFieldValidator></td>

            </tr>
        </table>
        <asp:Button ID="btnRegister" runat="server" Text="注册" CssClass="btn btn-primary" OnClick="Button1_Click" />
</div>
