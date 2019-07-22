<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exercise1.aspx.cs" Inherits="Day5._Default" %>
<%@ OutputCache Duration="30" VaryByParam="None" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Exercise 1</title>  
</head>
<body>
    <form id="form1" runat="server">
    <div>
 Date of client side  
<script type="text/javascript">
<!--
var currentTime = new Date()
var hours = currentTime.getHours()
var minutes = currentTime.getMinutes()
var seconds=currentTime.getSeconds()
if (minutes < 10){
minutes = "0" + minutes
}
if(seconds<10)
{
seconds="0"+seconds
}
document.write(currentTime+" "+hours+":"+minutes+":"+seconds)
if(hours > 11){
document.write("PM")
} else {
document.write("AM")
}
//-->
</script>
    </div>
    </form>
</body>
</html>
