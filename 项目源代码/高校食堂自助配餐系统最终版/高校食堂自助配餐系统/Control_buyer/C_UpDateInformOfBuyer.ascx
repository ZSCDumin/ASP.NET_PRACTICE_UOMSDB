<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="C_UpDateInformOfBuyer.ascx.cs" Inherits="高校食堂自助配餐系统.control_buyer.UpDateInformOfBuyer" %>


<link href="../bootstrap/css/bootstrap.css" rel="stylesheet" type="text/css" />



<div class="panel panel-primary">
    <div class="panel-heading">
        <h3 class="panel-title">个人信息修改</h3>
    </div>
    <div class="panel-body">
        <div style="width:700px;margin-left:20%;">
           <h2 style="margin-left:30%;"> 用户个人信息修改</h2>
            <table class="table">
               
                
                <tr>
                    <td >姓名：
             </td>
                    <td colspan="2" >
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td >电话：
            </td>
                    <td colspan="2" >
                        <asp:TextBox ID="txtTel" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td >密保问题：
            </td>
                    <td colspan="2" >
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>你父亲的姓名?</asp:ListItem>
                            <asp:ListItem>你母亲的姓名?</asp:ListItem>
                            <asp:ListItem>你爱人的姓名?</asp:ListItem>
                            <asp:ListItem>你的出生日期?</asp:ListItem>
                            <asp:ListItem>你的大学的学号?</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>答案：
            </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtAnswer" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>电子邮箱：
            </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"></td>
                    <td class="auto-style2">
                        <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" CssClass="btn btn-primary" />
                    </td>
                    <td class="auto-style1">
                        <asp:Button ID="Button2" runat="server" Text="取消" OnClick="Button2_Click" CssClass="btn btn-primary" />
                    </td>
                </tr>
            </table>
        </div>

    </div>
</div>


