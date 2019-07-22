<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RateArticle.aspx.cs" Inherits="Day_4._Default" %>


<%@ Register Assembly="ServerControlRateArticle" Namespace="ServerControlRateArticle" TagPrefix="Rate" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>RateArticle WebPage</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style4
        {
            height: 32px;
        }
        .style6
        {
            height: 31px;
        }
        .style7
        {
            height: 32px;
            width: 32px;
        }
        .style8
        {
            height: 31px;
            width: 32px;
        }
    </style>
</head>
<body>
    <form id="form1"  runat="server" 
   >
    <div style="background-image: url('image/bamboo_mat_texture-600x400.jpg')">
        
   
        <table class="style1" align="center">
            <tr>
                <td class="style7" 
                    style="background-image: url('image/Grass_Texture_by_DeathlyRai.jpg')">
                </td>
                <td class="style4" 
                    
                    
                    style="font-size: x-large; font-weight: bold; font-style: italic; text-decoration: blink;  background-image: url('image/Grass_Texture_by_DeathlyRai.jpg'); background-repeat: repeat; color: #800080;" 
                    >
                    Always bear in mind that your own resolution to succeed is <br />
                    more important than any other....<br />
                    Have a good day..........<br />
                </td>
            </tr>
            <tr>
                <td class="style8">
                </td>
                <td class="style6">
                    <asp:Label ID="lblClick" runat="server" Font-Bold="True" Font-Italic="True" 
                        ForeColor="#000099"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style8">
                </td>
                <td class="style6">
                    <asp:Label ID="lblChanged" runat="server" Font-Bold="True" Font-Italic="True" 
                        ForeColor="Blue"></asp:Label>
                </td>
            </tr>
        </table>
          <Rate:ServerControlRateArticle ID="RtArt" runat="server"  OnClick ="btnVote_Click" OnSelectedIndexChanged="RblRate_SelectedIndexChanged" />   
   
    </div>
    </form>
</body>
</html>
