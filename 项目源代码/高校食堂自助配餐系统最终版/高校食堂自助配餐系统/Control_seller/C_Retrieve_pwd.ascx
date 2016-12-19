<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="C_Retrieve_pwd.ascx.cs" Inherits="高校食堂自助配餐系统.Control_seller.Retrieve_pwd" %>
<header>
    <style>
        .contain {
            width: 100%;
            height: 560px;
        }

        .btn {
            padding: 0px 40px 0px 40px;
            background-color: #f7e8af;
            font-size: 17px;
            font-family: SimHei;
            height: 27px;
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
            margin-left: 300px;
            margin-top: 80px;
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
     
</header>
<link href="../bootstrap/css/bootstrap.css" rel="stylesheet" type="text/css" />








<div>
    
    
    

    <div class="left">
                <div class="panel panel-primary">
	    <div class="panel-heading">
		    <h3 class="panel-title">找回密码</h3>
	    </div>
	    <div class="panel-body">
             <h2 style="margin-left:10%;"> 密码找回</h2>
        <table  class="table table-hover">


            <tr>
                <td>
                    <label>请输入你的账号：</label></td>
                <td>
                    <asp:TextBox ID="txtSell_Account" runat="server" CssClass="text" placeholder="在此处输入用户名"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="必须输入账号" ControlToValidate="txtSell_Account"></asp:RequiredFieldValidator></td>
            </tr>



            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btn_Sumbit" runat="server" OnClick="btn_Sumbit_Click" Text="提交" CssClass="btn btn-primary" /></td>
            </tr>



            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>



            <tr>
                <td>
                    <label>请回答问题：</label></td>
                <td>
                    <asp:TextBox ID="txtSell_Answer" runat="server" CssClass="text" placeholder="请回答密保问题"></asp:TextBox></td>

            </tr>



            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btn_Ensure" runat="server" OnClick="btn_Ensure_Click" Text="确定" CssClass="btn btn-primary" />
                </td>
                <td>&nbsp;</td>
            </tr>

        </table>
	    </div>
    </div>
    </div>
</div>
