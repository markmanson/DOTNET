<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="Day_1_2.Details" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
     <title>Details WebPage</title>
    <style type="text/css">
        .topleft {
	
	float: left;
	width: 167px;
	height: 681px;
	border:2px none Maroon;
	}

.topright {
	background: url('images/topbg.jpg') repeat-x;
	float: right;
	width: 76%;
	height: 434px;
	}
       
        #Frame1
        {
            width: 542px;
            height: 679px;
            margin-top: 0px;
        }
        .style1
        {
            width: 765px;
        }
        #frm1
        {
            width: 730px;
        }
    </style>
</head>
<body>
   <form id="frm1" runat="server" 
    style="background-color:Gray; margin-right:256px; height: 733px;">
   <div style="text-align:center">
   <table><tr style="width:755px"><td align="center" class="style1" 
           style="border: medium solid #008080; background-color:#FF9966";>
       <asp:Label ID="Label1" runat="server" Text="Web UserControl" 
           BackColor="#FF9966" BorderColor="Maroon" Font-Bold="True" ForeColor="#006666" Font-Size="X-Large"></asp:Label>
       </td></tr></table></div>
  
             <div class="topleft" 
       style="border-style: solid; border-width: medium; border-color: #800000"  ><br /><br />
 <asp:Button ID="btnGetEmp" Text="GetEmployeeDetail" runat="server" OnClick="Getbtn_Click" Width="150" /><br /><br />
 <asp:Button ID="btnGetDetails" Text="GetDepartmentDetails" runat="server"  Width="150" 
                     onclick="btnGetDetails_Click" />
 </div> <div  class="topright">
 <iframe runat="server" id="Frame1" style="border-style: solid; border-color: #000080" 
       ></iframe>
       </div>
</form>
</body>
</html>
