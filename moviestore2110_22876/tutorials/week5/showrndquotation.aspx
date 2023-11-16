<%@ Page Title="" Language="C#" MasterPageFile="~/guestmasterpage.Master" AutoEventWireup="true" CodeBehind="showrndquotation.aspx.cs" Inherits="moviestore2110_22876.tutorials.week5.showrndquotation" %>

<%@ Register Src="~/tutorials/week5/rndquotation.ascx" TagPrefix="user" TagName="randomquote" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .quote {
            width: 200px;
            padding: 20px;
            border: Dotted 2px orange;
            background-color: #eeeeee;
            font: 16px Georgia,Serif;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>

        <%= DateTime.Now %>
        <br />
        <asp:Timer runat="server" ID="timer" Interval="2000" ></asp:Timer>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <user:randomquote runat="server" ID="rndquotation" />
            </ContentTemplate>
            <Triggers>
    <asp:AsyncPostBackTrigger ControlID="timer" EventName="Tick" />
</Triggers>
        </asp:UpdatePanel>

    </div>
</asp:Content>
