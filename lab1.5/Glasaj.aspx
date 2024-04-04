<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Glasaj.aspx.cs" Inherits="isptina2012.Glasaj" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">




    <div class="container" style="margin: 20px;">

        <div>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/logo_10.png" />
        </div>

        <br />

        <div>
            <asp:Label ID="lbProffesor" runat="server" Text=""></asp:Label>
        </div>

        <br />

       <div class="row">
           <div class="col-md-3">
               <asp:ListBox ID="lbPredmeti" runat="server" OnSelectedIndexChanged="lbPredmeti_SelectedIndexChanged" AutoPostBack="true"></asp:ListBox>
               <asp:ListBox ID="lbKrediti" runat="server"></asp:ListBox>
           </div>          
       </div>

       
       <div class="row">
           <div class="col-md-3">
           </div>          
       </div>

        <hr />

       <div class="row" style="margin-left: 0px; margin-top: 10px;">
           <asp:Button ID="glasajte" runat="server" Text="Vote" Width="64px" OnClick="glasajte_Click" />
       </div>
   </div>

</asp:Content>
