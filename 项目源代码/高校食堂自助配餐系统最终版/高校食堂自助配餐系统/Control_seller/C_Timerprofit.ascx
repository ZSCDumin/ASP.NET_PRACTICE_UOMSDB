<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="C_Timerprofit.ascx.cs" Inherits="高校食堂自助配餐系统.Control_seller.C_Timerprofit" %>


<link href="../bootstrap/css/bootstrap.css" rel="stylesheet" type="text/css" media="all" />

<div class="panel panel-primary">
    <div class="panel-heading">
        <h3 class="panel-title">收益查询</h3>
    </div>
    <div class="panel-body" style="margin-left:35%;">

       
           <h4>时间段收益：<asp:Label ID="Label1" runat="server"></asp:Label> 元</h4>
        
        <p>
            开始时间：<asp:TextBox ID="txt_s_start" runat="server"></asp:TextBox>
            <asp:Button ID="btn_s_selectstart" runat="server" Text="选择日期" OnClick="btn_s_selectstart_Click"  CssClass="btn btn-primary" />
        </p>
        <p>
            <asp:Calendar ID="cld_s_start" runat="server" Visible="False" OnSelectionChanged="cld_s_start_SelectionChanged"></asp:Calendar>
        </p>
        <p>
            结束时间：<asp:TextBox ID="txt_s_end" runat="server"></asp:TextBox>
            <asp:Button ID="btn_s_selectend" runat="server" Text="选择日期" OnClick="btn_s_selectend_Click" CssClass="btn btn-primary" />
        </p>
        <p>
            <asp:Calendar ID="cld_s_end" runat="server" OnSelectionChanged="cld_s_end_SelectionChanged" Visible="False"></asp:Calendar>
        </p>
        <p>
            <asp:Button ID="btn_submit" runat="server" Text="提交"  OnClick="btn_submit_Click"  CssClass="btn btn-primary" />
        </p>
    </div>
</div>



