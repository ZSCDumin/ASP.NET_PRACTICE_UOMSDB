<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="C_searchBalance.ascx.cs" Inherits="高校食堂自助配餐系统.control_buyer.searchBalance" %>


<style>
    .section {
        width: 800px;
        
    }

    .auto-style1 {
        width: 100%;
        height: 439px;
    }

    .auto-style3 {
        text-align: center;
    }

    .auto-style5 {
        width: 38px;
        height: 38px;
    }

    .auto-style6 {
        width: 38px;
        height: 38px;
    }

    .auto-style11 {
        height: 42px;
    }

    .auto-style13 {
        text-align: center;
        height: 165px;
        width: 223px;
    }

    .auto-style14 {
        text-align: center;
        font-family: 微软雅黑;
        font-weight: bold;
        width: 223px;
        height: 29px;
    }

    .auto-style17 {
        text-align: center;
        font-family: 微软雅黑;
        font-weight: bold;
        width: 228px;
        height: 29px;
    }

    .auto-style18 {
        text-align: center;
        height: 165px;
        width: 228px;
    }

    .auto-style19 {
        text-align: center;
        height: 102px;
    }

    .auto-style20 {
        font-family: 微软雅黑;
        font-weight: bold;
        border-left-color: #A0A0A0;
        border-right-color: #C0C0C0;
        border-top-color: #A0A0A0;
        border-bottom-color: #C0C0C0;
        padding: 1px;
    }

    .auto-style22 {
        width: 459px;
        height: 20px;
    }

    .auto-style23 {
        text-align: center;
        height: 15px;
    }

    .auto-style24 {
        font-family: 微软雅黑;
        font-weight: bold;
        color: #808080;
    }

    .auto-style25 {
        font-family: 微软雅黑;
        font-weight: bold;
        font-size: large;
        color: #FF0000;
        border-left-color: #A0A0A0;
        border-right-color: #C0C0C0;
        border-top-color: #A0A0A0;
        border-bottom-color: #C0C0C0;
        padding: 1px;
    }

    .auto-style26 {
        font-family: 微软雅黑;
        font-weight: bold;
        color: #808080;
        border-left-color: #A0A0A0;
        border-right-color: #C0C0C0;
        border-top-color: #A0A0A0;
        border-bottom-color: #C0C0C0;
        padding: 1px;
    }

    </style>
 <link href="../bootstrap/css/bootstrap.css" rel="stylesheet" type="text/css" />

<div class="panel panel-primary">
	<div class="panel-heading">
		<h3 class="panel-title">余额查询</h3>
	</div>
	<div class="panel-body">
		<div style="margin: 100px 0px 0px 300px;">
    <div class="section">
    <div class="box" style="width: 491px; height: 580px;">
        <table class="auto-style1">
            <tr>
                <td colspan="2" class="auto-style11"><i style="color: skyblue; font-size: 30px;">查询余额</i><i style="color: gray; font-size: 10px;"> check balance</i></td>
            </tr>
            <tr>
                <td class="auto-style11" colspan="2"><span class="auto-style24">尊敬的<asp:Label ID="Label1" runat="server" Text="lblname0"></asp:Label>
                    ,您的账户信息如下：</span></td>
            </tr>
            <tr>
                <td class="auto-style17">
                    <img alt="" class="auto-style6" src="../images/账号0.png" />
                    查询的用户账号</td>
                <td class="auto-style14">
                    <img alt="" class="auto-style5" src="../images/钱包0.png" />
                    我的余额</td>
            </tr>
            <tr>
                <td class="auto-style18">
                    <asp:Label ID="lblAccount" runat="server" Style="text-align: right" Text="Label1"></asp:Label>
                </td>
                <td class="auto-style13">
                    <asp:Label ID="lblbalance" runat="server" Text="Label2"></asp:Label>
                    <span class="auto-style25">元</span></td>
            </tr>
            <tr>
                <td class="auto-style23" colspan="2">
                    <img alt="" class="auto-style22" src="../images/浅蓝色横杠0.png" />
                </td>
            </tr>
            <tr>
                <td class="auto-style19" colspan="2">
                    <br />
                    <span class="auto-style26">输入要充值的金额：</span><br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox1" runat="server" Height="18px" Style="margin-left: 5px" Width="128px"></asp:TextBox>
                    <span class="auto-style20">元<br />
                    </span>
                    <br />
                    <br />
                    <asp:ImageButton ID="btnRecharge" runat="server" ImageUrl="~/images/充值0.png" OnClick="btnRecharge_Click" />
                </td>
            </tr>
        </table>
    </div>
    </div>
</div>

	</div>
</div>




