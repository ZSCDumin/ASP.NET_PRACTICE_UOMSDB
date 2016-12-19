<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="C_pageOfEvaluation.ascx.cs" Inherits="高校食堂自助配餐系统.control_buyer.pageOfEvaluation" %>

<link href="../bootstrap/css/bootstrap.css" rel="stylesheet" type="text/css" />

<div class="panel panel-primary">
	<div class="panel-heading">
		<h3 class="panel-title">商品评价</h3>
	</div>
	<div class="panel-body">
		<div style="margin-left:10%;margin-top:20px;">

     <asp:Image ID="Image1" runat="server" Height="100px" Width="100px" /> 

    <div class="input-group">
      
       <asp:TextBox ID="TextBox1" runat="server" class="form-control" placeholder="请在此输入您的评价。。。" Height="184px" TextMode="MultiLine" Width="900px"></asp:TextBox>
    </div>
    <asp:Button ID="Button1" runat="server" Text="提交评价" OnClick="Button1_Click" CssClass="btn btn-primary" style="margin-left:50%;margin-top:20px;" />

    <asp:Button ID="Button2" runat="server" Text="取消评价" OnClick="Button2_Click" CssClass="btn btn-primary" style="margin-left:2%;margin-top:20px;" />
</div>

	</div>
</div>
