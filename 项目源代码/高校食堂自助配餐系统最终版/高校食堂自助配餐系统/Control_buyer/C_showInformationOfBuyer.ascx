<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="C_showInformationOfBuyer.ascx.cs" Inherits="高校食堂自助配餐系统.control_buyer.showInformationOfBuyer" %>
<style type="text/css">
    .auto-style1 {
        width: 227px;
    }

    .auto-style2 {
        width: 83px;
    }

    .auto-style3 {
        width: 83px;
        height: 26px;
    }

    .auto-style4 {
        width: 227px;
        height: 26px;
    }
</style>
<link href="../bootstrap/css/bootstrap.css" rel="stylesheet" type="text/css" />
<div class="panel panel-primary">
    <div class="panel-heading">
        <h3 class="panel-title">个人信息</h3>
    </div>
    <div class="panel-body">
        <table class="table table-hover">
            <tr>
                <td></td>
                <td class="auto-style2">
                    <asp:Image ID="Image1" runat="server" Height="122px" ImageUrl="~/images/123.gif" Width="113px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <h4>
                        <asp:Label ID="lblAccount" runat="server" Text="账号信息："></asp:Label>
                    </h4>
                </td>
                <td class="auto-style1">
                    <h4>
                        <asp:Label ID="laccount" runat="server" Text="Label"></asp:Label></h4>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <h4>
                        <asp:Label ID="lblName" runat="server" Text="姓名："></asp:Label></h4>
                </td>
                <td class="auto-style1">
                    <h4>
                        <asp:Label ID="lname" runat="server" Text="Label"></asp:Label></h4>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <h4>
                        <asp:Label ID="lblTel" runat="server" Text="联系电话："></asp:Label></h4>
                </td>
                <td class="auto-style1">
                    <h4>
                        <asp:Label ID="ltel" runat="server" Text="Label"></asp:Label></h4>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <h4>
                        <asp:Label ID="lblBalance" runat="server" Text="账户余额："></asp:Label></h4>
                </td>
                <td class="auto-style4">
                    <h4>
                        <asp:Label ID="lbalance" runat="server" Text="Label"></asp:Label></h4>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <h4>
                        <asp:Label ID="lblEmail" runat="server" Text="电子邮箱："></asp:Label></h4>
                </td>
                <td class="auto-style1">
                    <h4>
                        <asp:Label ID="lemail" runat="server" Text="Label"></asp:Label></h4>
                </td>
            </tr>
        </table>

    </div>
</div>


