<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminManage.aspx.cs" Inherits="高校食堂自助配餐系统.Administrator.AdminManage" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style>
        #box {
            background-image: url("../images/20100902122817194.jpg");
        }

        #bkg {
            background-image: url("../images/444.jpg");
        }

        #bj {
            background-image: url("../images/bjl.jpg");
        }

        .auto-style2 {
            width: 114px;
        }

        .auto-style3 {
            width: 257px;
            height: 128%;
        }

        .auto-style4 {
            width: 95px;
        }

        .auto-style6 {
            width: 327px;
        }
    </style>
</head>
<body id="box">
    <form runat="server">
        <center><div style="font-family: 华文行楷; font-size: xx-large; color: #000000; text-decoration: blink;"">网站管理员界面</div></center>
        <table cellspacing="10px">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style6">
                    <div style="width: 421px;font-size:larger;font-family:Consolas;font">
                         搜索框：<asp:TextBox ID="txtSearch" runat="server" Height="16px" Width="276px"></asp:TextBox>
                    </div>
                </td>
            </tr>
            <tr>
                <td rowspan="3" class="auto-style2">
                    <table cellspacing="10px" width="100%" height="100%">
                        <tr>
                            <td class="auto-style4" style="font-family: 微软雅黑; font-size: x-large; text-align: center;">操作栏
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4" height="40px" style="text-align: center">
                                <asp:Button ID="btnShowBuyer" runat="server" Text="搜索买家" OnClick="btnShowBuyer_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4" height="40px" style="text-align: center">
                                <asp:Button ID="btnShowSeller" runat="server" Text="搜索卖家" OnClick="btnShowSeller_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4" height="40px" style="text-align: center">
                                <asp:Button ID="btnShowAllBuyer" runat="server" Text="所有买家" OnClick="btnShowAllBuyer_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4" height="40px" style="text-align: center">
                                <asp:Button ID="btnShowAllSeller" runat="server" Text="所有卖家" OnClick="btnShowAllSeller_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4" height="40px" style="text-align: center">
                                <asp:Button ID="searchBOrder" runat="server" Text="买家订单" OnClick="searchBOrder_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4" height="40px" style="text-align: center">
                                <asp:Button ID="searchSOrder" runat="server" Text="卖家订单" OnClick="searchSOrder_Click" />
                            </td>
                        </tr>
                    </table>
                </td>
                <td valign="top" class="auto-style6">
                    <table style="border-style: double; border-color: #000000; height: 457px;">
                        <tr>
                            <td style="font-family: 黑体; color: #000000; font-weight: bold;">成员列表/管理
                            </td>
                        </tr>
                        <tr>
                            <td valign="top" class="auto-style3" width="100%" align="center">
                                <asp:GridView ID="gv" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="986px" Height="423px">
                                    <AlternatingRowStyle BackColor="White" />
                                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                                    <SortedAscendingCellStyle BackColor="#FDF5AC" />
                                    <SortedAscendingHeaderStyle BackColor="#4D0000" />
                                    <SortedDescendingCellStyle BackColor="#FCF6C0" />
                                    <SortedDescendingHeaderStyle BackColor="#820000" />
                                </asp:GridView>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>