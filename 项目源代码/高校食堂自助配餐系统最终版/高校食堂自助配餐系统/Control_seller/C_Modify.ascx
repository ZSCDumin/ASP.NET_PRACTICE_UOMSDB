<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="C_Modify.ascx.cs" Inherits="高校食堂自助配餐系统.Control_seller.Modify" %>
<header>
    <style>
        .contain {
            width: 1003px;
            height: 560px;
        }

        .btn {
            padding: 0px 40px 0px 40px;
            background-color: #f7e8af;
            font-size: 17px;
            font-family: SimHei;
        }

        .text {
            height: 30px;
            width: 250px;
            margin-top: 10px;
        }

        .left {
            height: auto;
            width: auto;
            float: left;
            margin-left: 330px;
            margin-top: 20px;
            text-align: center;
        }

        .right {
            height: 560px;
            width: 503px;
            float: left;
        }

        label {
            font-size: 24px;
           
        }
    </style>
     <link href="../bootstrap/css/bootstrap.css" rel="stylesheet" type="text/css" />
</header>



<div class="panel panel-primary">
	<div class="panel-heading">
		<h3 class="panel-title">修改密码</h3>
	</div>
	<div class="panel-body">
		<div class="contain">
    <div class="left">
        <h2> 修改密码</h2>
        <table class="table table-hover">
            <tr>
                <td>
                    <label>新密码：</label></td>
                <td>
                    <asp:TextBox ID="txtSell_password" runat="server" CssClass="text" placeholder="请输入密码" TextMode="Password"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSell_password" ErrorMessage=" 必须输入密码"></asp:RequiredFieldValidator></td>

            </tr>



            <tr>
                <td>
                    <label>再次输入：</label></td>
                <td>
                    <asp:TextBox ID="txtAgain_password" runat="server" CssClass="text" placeholder="请再次输入密码" TextMode="Password"></asp:TextBox></td>
                <td>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtAgain_password" ControlToValidate="txtSell_password" ErrorMessage="2次密码输入不一致"></asp:CompareValidator><br />
                </td>
            </tr>


        </table>
        <asp:Button ID="btn_Submit" runat="server" OnClick="Button1_Click" Text="提交" CssClass="btn btn-primary" />

    </div>

</div>

	</div>
</div>





