<%@ Page Title="Controls" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="basicControls.aspx.cs" Inherits="WebApp.SamplePages.basicControls" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Basic Controls</h1>
        <div class="row">
            <div class="col-sm-offset-1 col-sm-10">
                <div class="alert alert-info">
                    <blockquote style="font-style:italic">
                        This page will demonstrate some basic controls of a web page. We will investigate the CheckBox, TextBox, RadioButtonList,
                        DropDownList, Label, Literal and submit buttons (Button and LinkButton).
                        The formatting of the controls will be done in a &lt; table&gt; tag.
                        We will investigate event driven logic and how it differs from the top down logic on Razor/Form pages.<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </blockquote>
                </div>
            </div>
        </div>
        <table align="center" style="width:80%">
            <tr>
                <td align="right">TextBox:<table class="nav-justified">
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged">
                            </asp:TextBox>
                        </td>                        
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label" runat="server" Font-Bold="false" Text="RadioButtonList"></asp:Label>                           
                        </td>                       
                    </tr>
                    </table>
                </td>
                <td>
                    
                    
                </td>                
            </tr>
                
       </table>
        <br />
</asp:Content>
