<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucLogin.ascx.cs" Inherits="KentekenRegistratie.ucLogin" %>
<asp:Label ID="lblGebruikersnaam" runat="server" Text="Gebruikersnaam"></asp:Label>
<br />
<asp:TextBox ID="txtGebruikersnaam" runat="server"></asp:TextBox>
<br />
<br />
<asp:Label ID="lblWachtwoord" runat="server" Text="Wachtwoord"></asp:Label>
<br />
<asp:TextBox ID="txtWachtwoord" TextMode="Password" runat="server"></asp:TextBox>
<br />
<br />
<asp:Button ID="btnLogin" runat="server" Text="Login" Width="126px" OnClick="btnLogin_Click" />

