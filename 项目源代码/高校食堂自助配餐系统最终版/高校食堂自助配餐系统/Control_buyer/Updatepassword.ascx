<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Updatepassword.ascx.cs" Inherits="Updatepassword" %>

<div style="width:550px;  height:500px;">
    密码修改<br />
    <br />
    <i style="color:orange; font-size:30px;">密码修改</i><i style="color:gray;font-size:10px;">Password Change</i>

    <br />
    <br />
    <br />
&nbsp;&nbsp;&nbsp; 密保问题:
    <asp:DropDownList ID="DropDownList1" runat="server" Width="169px">
    </asp:DropDownList>
    <br />
    <br />
&nbsp;&nbsp;&nbsp; 密保答案:
    <asp:TextBox ID="TextBox1" runat="server" Width="161px"></asp:TextBox>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
&nbsp;&nbsp;&nbsp;&nbsp; 旧密码:
    <asp:TextBox ID="TextBox2" runat="server" Width="159px"></asp:TextBox>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp; 新密码:
    <asp:TextBox ID="TextBox3" runat="server" Width="158px"></asp:TextBox>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
&nbsp;&nbsp;&nbsp; 重复输入：<asp:TextBox ID="TextBox4" runat="server" Width="159px"></asp:TextBox>
    <br />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="ImageButton1" runat="server" Height="39px" ImageUrl="~/imge/tijiaoxiugai.jpg" Width="100px" />
    <br />

</div>