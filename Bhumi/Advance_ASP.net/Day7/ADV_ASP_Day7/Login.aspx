<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ADV_ASP_Day7.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="css/style.css" rel="stylesheet" type="text/css" />
<title>Login Page</title>  
<!-- Custom Theme files -->
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" /> 
<meta name="keywords" content="Login form web template, Sign up Web Templates, Flat Web Templates, Login signup Responsive web template, Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyErricsson, Motorola web design" />
<!--Google Fonts-->
<link href='http://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800' rel='stylesheet' type='text/css' />
<!--Google Fonts-->
</head>
<body>
<form id="form1" runat="server" defaultfocus="TxtUserName">
						<div class="login-top">
				<h1>User login</h1>
					<asp:TextBox CssClass="login-top1" runat="server" ID="TxtUserName"></asp:TextBox><asp:RequiredFieldValidator
                        ID="RfvUserName" runat="server" ErrorMessage="  *" ForeColor="Red" ControlToValidate="TxtUserName"></asp:RequiredFieldValidator>
					<asp:TextBox CssClass="login-top2" runat="server" ID="TxtPassword" TextMode="Password"></asp:TextBox><asp:RequiredFieldValidator
                        ID="RfvPassword" runat="server" ErrorMessage="  *" ForeColor="Red" ControlToValidate="TxtPassword"></asp:RequiredFieldValidator><br />
				<asp:Label CssClass="l1" runat="server" ID="LblAccessDenied" Text="Access Denied" ForeColor="Red" Font-Size="Larger" Visible="false"></asp:Label>			
					<asp:Button CssClass="log-bwn" runat="server" Text="Sign In" Id="BtnLogin" onclick="BtnLogin_Click"/>	
			</div>
		</form>	
</body>
</html>
