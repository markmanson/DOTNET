<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeNameHyperLink.aspx.cs" Inherits="ExerciseProject.DAY2.EmployeeNameHyperLink" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>DAY2-4(Employee Name-Hyperlink)</title>
  <%--  <script language="javascript" type="text/javascript">
    function openWin(url) 

 {
  var height = 400;                       //Set height
  var width = 400;                        //Set width
  var name = "window_name";             //Set window name
  var top = 20;                            //Set distance from top
  var left = 20;                            //Set distance from bottom
  newwin=window.open(url, name, "fullscreen=no,toolbar=no,status=no,menubar=no,scrollbars=no,resizable=no,directories=no,location=no,width=" + width + ",height=" + height + ",left=" + left + ",top=" + top);


}
--%>
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <asp:GridView ID="GrdEmployee" Font-Bold="True" 
     BorderStyle="Solid"
     AlternatingRowStyle-Font-Bold="true"
     HeaderStyle-BackColor="ActiveCaptionText" 
     AlternatingRowStyle-BorderStyle="Solid" 
     AlternatingRowStyle-ForeColor="CadetBlue" 
     HeaderStyle-Font-Bold="true" 
     HeaderStyle-Font-Size="Larger" 
     HeaderStyle-ForeColor="CadetBlue" 
     AlternatingRowStyle-Font-Names="Times New Roman, Times, serif"
     AlternatingRowStyle-BackColor="ActiveCaptionText" 
     BackColor="Azure"     
     runat="server" 
     Width="100%" AutoGenerateColumns="False" DataKeyNames="EmployeeID" onrowediting="GrdEmployee_RowEditing">
     
        <Columns>
            <asp:TemplateField HeaderText="Employee ID" Visible="false">
                <ItemTemplate>
                    <asp:Label ID="LblEmpId" runat="server" Text='<%# bind("EmployeeID")%>' Visible="false"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <%--<asp:TemplateField HeaderText="Last Name">
                <ItemTemplate>
                    <asp:Label ID="LblLastName" runat="server" Text='<%# bind("LastName")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>--%>
            <asp:TemplateField HeaderText="Name">
            <ItemTemplate>
            <asp:LinkButton ID="LnkFName" runat="server" Text='<%# bind("Name")%>' onclick="LnkFName_Click"></asp:LinkButton>  
            </ItemTemplate>
                
            </asp:TemplateField>
        
            <asp:TemplateField HeaderText="Title">
                <ItemTemplate>
                    <asp:Label ID="lblTitle" runat="server" Text='<%# bind("Title")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <%--<asp:TemplateField HeaderText="Title Of Courtesy">
                <ItemTemplate>
                    <asp:Label ID="lblTitleOfCourtesy" runat="server" Text='<%# bind("TitleOfCourtesy")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>--%>
            <asp:TemplateField HeaderText="Birth Date">
                <ItemTemplate>
                    <asp:Label ID="lblBirthDate" runat="server" Text='<%# bind("BirthDate")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Hire Date">
                <ItemTemplate>
                    <asp:Label ID="lblHireDate" runat="server" Text='<%# bind("HireDate")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Address">
                <ItemTemplate>
                    <asp:Label ID="lblAddress" runat="server" Text='<%# bind("Address")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="City">
                <ItemTemplate>
                    <asp:Label ID="lblCity" runat="server" Text='<%# bind("City")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Region">
                <ItemTemplate>
                    <asp:Label ID="lblRegion" runat="server" Text='<%# bind("Region")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PostalCode">
                <ItemTemplate>
                    <asp:Label ID="lblPostalCode" runat="server" Text='<%# bind("PostalCode")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Country">
                <ItemTemplate>
                    <asp:Label ID="lblCountry" runat="server" Text='<%# bind("Country")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Home Phone">
                <ItemTemplate>
                    <asp:Label ID="lblHomePhone" runat="server" Text='<%# bind("HomePhone")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Extension">
                <ItemTemplate>
                    <asp:Label ID="lblExtension" runat="server" Text='<%# bind("Extension")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <%--<asp:TemplateField HeaderText="Photo">
                <ItemTemplate>
                    <asp:Label ID="lblPhoto" runat="server" Text='<%# bind("Photo")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>--%>
            <asp:TemplateField HeaderText="Notes">
                <ItemTemplate>
                    <asp:Label ID="lblNotes" runat="server" Text='<%# bind("Notes")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Reports To">
                <ItemTemplate>
                    <asp:Label ID="lblReportsTo" runat="server" Text='<%# bind("ReportsTo")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Photo Path">
                <ItemTemplate>
                    <asp:Label ID="lblPhotoPath" runat="server" Text='<%# bind("PhotoPath")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
<HeaderStyle BackColor="ActiveCaptionText" Font-Bold="True" Font-Size="Larger" ForeColor="CadetBlue"></HeaderStyle>

<AlternatingRowStyle BackColor="ActiveCaptionText" BorderStyle="Solid" Font-Bold="True" Font-Names="Times New Roman,Times,serif" ForeColor="CadetBlue"></AlternatingRowStyle>
     
    </asp:GridView>
    
    </div>
    </form>
</body>
</html>
