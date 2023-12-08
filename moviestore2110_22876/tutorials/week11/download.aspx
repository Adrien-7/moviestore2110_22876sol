<%@ Page Title="" Language="C#" MasterPageFile="~/guestmasterpage.Master" AutoEventWireup="true" CodeBehind="download.aspx.cs" Inherits="moviestore2110_22876.tutorials.week11.download" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style type="text/css">
 html {
 background-color: silver;
 }
 .content {
 width: 600px;
 border: solid 1px black;
 background-color: #eeeeee;
 }
 .doc {
 margin: 20px 10px;
 padding: 10px;
 border: dashed 2px black;
 background-color: white;
 }
 </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1>Download document: </h1>
 <div class="content">
 <asp:Repeater
 ID="rptdoc"
 runat="server">
 <ItemTemplate>
 <div class="doc">

 <%-- add a hyperlink control with databinding
expression to display the file name in the Text Property and
the path in the Navigateurl property
Add a label control to display the name of the user who has
uploaded the file --%>

     <asp:HyperLink ID="HyperLink1"  runat="server" target="_blank"  Text='<%# Eval("file_name") %>' 
         NavigateUrl='<%# Eval("file_path") %>' >HyperLink</asp:HyperLink>
     by 
     <asp:Label ID="Label1" runat="server" Text='<%# Eval("username") %>'></asp:Label>


 </div>
 </ItemTemplate>
 </asp:Repeater>
 </div>
</asp:Content>
