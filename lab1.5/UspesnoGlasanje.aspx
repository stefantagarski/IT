<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UspesnoGlasanje.aspx.cs" Inherits="isptina2012.UspesnoGlasanje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <asp:Label ID="Message" runat="server" Text=""></asp:Label>
    </div>

    <div>
        <asp:LinkButton ID="resuts" runat="server" OnClick="resuts_Click">Results</asp:LinkButton>
    </div>

</asp:Content>
