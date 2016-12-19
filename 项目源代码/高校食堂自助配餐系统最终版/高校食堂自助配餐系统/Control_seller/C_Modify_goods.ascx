<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="C_Modify_goods.ascx.cs" Inherits="高校食堂自助配餐系统.Control_seller.Modify_goods" %>
<header>
    <style>
        .contain {
            width: 1003px;
            height: 560px;
        }

        .btn {
            padding: 0px 70px 0px 70px;
            background-color: #f7e8af;
            font-size: 17px;
            margin-top: 50px;
            height: 27px;
        }

        .text {
            height: 30px;
            width: 250px;
            margin-top: 10px;
            margin-bottom: 10px;
        }

        .left {
            height: auto;
            width: auto;
            float: left;
            text-align: center;
            margin-left: 330px;
            margin-top: 20px;
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
        .auto-style1 {
            width: 363px;
        }
    </style>
    <link href="../bootstrap/css/bootstrap.css" rel="stylesheet" type="text/css" />
</header>




<div class="panel panel-primary">
	<div class="panel-heading">
		<h3 class="panel-title">修改商品</h3>
	</div>
	<div class="panel-body">
		<div class="contain">
    <div class="left">


        <h2>修改商品</h2>
     
        <table  class="table table-hover">
            <tr>
                <td>
                    <label>商品名称：</label></td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtProduct_name" runat="server" CssClass="text" placeholder="请输入商品名称"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtProduct_name" ErrorMessage="必须输入商品名称"></asp:RequiredFieldValidator></td>

            </tr>
            <tr>
                <td>
                    <label>商品分类：</label></td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtProduct_category" runat="server" CssClass="text" placeholder="请输入输入商品分类"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtProduct_category" ErrorMessage="必须输入商品分类"></asp:RequiredFieldValidator></td>

            </tr>
            <tr>
                <td>
                    <label>商品单价：</label></td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtProduct_price" runat="server" CssClass="text" placeholder="请输入商品价格"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtProduct_price" ErrorMessage="必须输入商品单价"></asp:RequiredFieldValidator></td>

            </tr>
            <tr>
                <td>
                    <label>商品数量：</label>
                <td class="auto-style1">
                    <asp:TextBox ID="txtProduct_number" runat="server" CssClass="text" placeholder="请输入商品数量"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtProduct_number" ErrorMessage="必须输入商品数量"></asp:RequiredFieldValidator></td>
            </tr>

            <tr>
                <td>
                    <label>商品图片：</label></td>
                <td class="auto-style1">
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                   </td>
                    <td>
                         <asp:Image ID="Image1" runat="server" style="width:100px;height:100px;" />
                    </td>
            </tr>

        </table>

        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="确定" CssClass="btn btn-primary" />
    </div>
</div>
	</div>
</div>






