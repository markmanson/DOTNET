<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="BASICASPNETProject.Error" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
     <style type="text/css">
        .span
        {
            azimuth:center;
           color:#FF0000;
           font-size:larger;
            margin-top:auto;
           margin-left:auto;
           margin-right:auto;
           
          
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="LblErrorMessageId" CssClass="span" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
