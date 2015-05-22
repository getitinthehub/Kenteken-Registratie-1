<%@ Page Title="" Language="C#" MasterPageFile="~/RDWMain.Master" AutoEventWireup="true" CodeBehind="RDWLogin.aspx.cs" Inherits="KentekenRegistratie.wfLogin" %>
<%@ Register src="ucLogin.ascx" tagname="ucLogin" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ucLogin ID="ucLogin1" runat="server" />
</asp:Content>
