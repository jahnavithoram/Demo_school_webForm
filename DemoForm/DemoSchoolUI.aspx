<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DemoSchoolUI.aspx.cs" Inherits="DemoForm.DemoSchoolUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="align-content:baseline">
            <table >
                    <tr>
                        <td>
                            <asp:Label ID="lblname" runat="server" Text="Student Name"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                        </td>

                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblRoll" runat="server" Text="Roll Number"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtRN" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                   
                    <tr>
                        <td>
                            <asp:Label ID="lblEMail" runat="server" Text="Email"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox TextMode="Email" ID="txtEmail" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblDoB" runat="server" Text="Date OF birth"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox TextMode="Date" ID="txtDOB" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                 <tr>
                        <td>
                            <asp:Label ID="lblGpa" runat="server" Text="GPA"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextGpa" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Label ID="lblCounter" runat="server" Text=""></asp:Label>
                            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit Form" />
                        </td>
                    </tr>
                </table>
            
<div> <%

          var l=Rl();
          Response.Write("<table border='1'>");
          foreach(var item in l)
          {
              if (item.Name.Length > 0)
              {
                  if (item.sno == "1")
                      Response.Write("<tr> <th>SNo</th><th>Name</th> <th>RollNo</th> <th>GPA</th></tr>");
                  Response.Write("<tr> <td>" + item.sno + "</td><td>" + item.Name + "</td>");
                  Response.Write("<td>" + item.RollNo + "</td>");
                  Response.Write("<td>" + item.GPA + "</td></tr>");
              }
              // Response.Write("<li>"+"Name:"+item.Name+"</li><br/>");
          }
          Response.Write("</table>");
    %>
  
    </div>
   </div>     
    </form>
</body>
</html>
