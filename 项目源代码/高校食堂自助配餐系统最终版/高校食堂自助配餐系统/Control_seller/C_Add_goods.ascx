<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="C_Add_goods.ascx.cs" Inherits="高校食堂自助配餐系统.Control_seller.Add_goods" %>
<header>
    <style>
       

     

        .text {
            height: 30px;
            width: 250px;
            margin-top: 10px;
            margin-bottom: 10px;
        }

        .left {
            height: auto;
            width: auto;
            text-align: center;
            margin: 0 auto;
        }


        label {
            font-size: 17px;
           
        }
    </style>
     <link href="../bootstrap/css/bootstrap.css" rel="stylesheet" type="text/css" />
</header>




<div class="panel panel-primary">
	<div class="panel-heading">
		<h3 class="panel-title">添加商品</h3>
	</div>
	<div class="panel-body">
		
<div >
    <div class="left">

        <table class="table table-hover">
            <tr>
                <td colspan="3">
                   <h2> 添加商品</h2>
                </td>
            </tr>

            <tr>
                <td>
                    <label>商品名称：</label></td>
                <td>
                    <asp:TextBox ID="txtProduct_name" runat="server" placeholder="请输入商品名称" CssClass="text"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtProduct_name" ErrorMessage="必须输入商品名称"></asp:RequiredFieldValidator></td>

            </tr>


            <tr>
                <td>
                    <label>商品分类：</label></td>
                <td>
                    <asp:TextBox ID="txtProduct_category" runat="server" placeholder="请输入输入商品分类" CssClass="text"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtProduct_category" ErrorMessage="必须输入产品分类"></asp:RequiredFieldValidator></td>

            </tr>


            <tr>
                <td>
                    <label>商品单价：</label></td>
                <td>
                    <asp:TextBox ID="txtProduct_price" runat="server" placeholder="请输入商品价格" CssClass="text"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtProduct_price" ErrorMessage=" 必须输入商品单价"></asp:RequiredFieldValidator></td>

            </tr>


            <tr>
                <td>
                    <label>商品数量：</label></td>
                <td>
                    <asp:TextBox ID="txtProduct_number" runat="server" placeholder="请输入商品数量" CssClass="text"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtProduct_number" ErrorMessage="必须输入商品数量"></asp:RequiredFieldValidator></td>

            </tr>


            <tr>
                <td>
                    <label>商品图片：</label></td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" /></td>
                <td></td>
            </tr>
        </table>


        <asp:Button ID="btn_Ensure" runat="server" Text="确定" OnClick="Button1_Click" CssClass="btn btn-primary" />
        <br />
    </div>
</div>

	</div>
</div>



