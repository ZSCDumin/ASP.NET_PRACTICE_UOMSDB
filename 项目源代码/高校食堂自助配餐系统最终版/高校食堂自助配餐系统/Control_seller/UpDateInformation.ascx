<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UpDateInformation.ascx.cs" Inherits="高校食堂自助配餐系统.Control_seller.UpDateInformation" %>
<style type="text/css">

    #BJ
    {
        background-image:url('../images/bg2.jpg');
        height: 379px;
        width: 320px;
    }
    .auto-style2 {
        height: 24px;
    }
    .auto-style1 {
        width: 150px;
        height: 24px;
    }
    </style>



<div align="center">
    <table id="BJ">
        <tr>
            <td colspan="3" align="center" style="font-family: 方正姚体; font-size: x-large; font-weight: bold; color: #800080">商家信息修改
            </td>    
        </tr>
        <tr>
            <td align="right" style="font-family: 楷体; font-weight: bold;">姓名：
            </td>
            <td colspan="2" align="left">
                <asp:TextBox ID="txt_s_name" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" style="font-family: 楷体; font-weight: bold">电话：
            </td>
            <td colspan="2" align="left">
                <asp:TextBox ID="txt_s_tel" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" style="font-family: 楷体; font-weight: bold">密保问题：
            </td>
            <td colspan="2" align="left">
                <asp:DropDownList ID="ddl_s_question" runat="server">
                    <asp:ListItem>你父亲的姓名?</asp:ListItem>
                    <asp:ListItem>你母亲的姓名?</asp:ListItem>
                    <asp:ListItem>你爱人的姓名?</asp:ListItem>
                    <asp:ListItem>你的出生日期?</asp:ListItem>
                    <asp:ListItem>你的大学的学号?</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="right" style="font-family: 楷体; font-weight: bold">答案：
            </td>
            <td colspan="2" align="left">
                <asp:TextBox ID="txt_s_answer" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" style="font-family: 楷体; font-weight: bold">店名：
            </td>
            <td colspan="2" align="left">
                <asp:TextBox ID="txt_s_storename" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">

            </td>
            <td class="auto-style2">
                <asp:Button ID="btn_submit" runat="server" Text="提交" OnClick="btn_submit_Click" style="height: 21px"  />
            </td>
            <td class="auto-style1">
                <asp:Button ID="btn_s_cancel" runat="server" Text="取消" OnClick="btn_s_cancel_Click" />
            </td>
        </tr>
    </table>
</div>

