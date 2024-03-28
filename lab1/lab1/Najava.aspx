<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Najava.aspx.cs" Inherits="lab1.Najava" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


<div class="container" style="margin: 20px;">
       <div class="row">
           <div class="col-md-3">
              Name <asp:TextBox ID="name" runat="server" style="width: 100%"></asp:TextBox>
           </div>
           <div class="col-md-9 text-left">
               <asp:RequiredFieldValidator 
                   ID="nameVal"
                   runat="server" 
                   ErrorMessage="Please enter a name"
                   ControlToValidate="name"
                   Style="color: red"></asp:RequiredFieldValidator>
           </div>
       </div>

       <div class="row" style="margin-top: 10px;">
           <div class="col-md-3">
              Password <asp:TextBox ID="password" runat="server" style="width: 100%"></asp:TextBox>
           </div>
           <div class="col-md-9 text-left">
               <asp:RequiredFieldValidator 
                   ID="passReqVal" 
                   runat="server" 
                   ErrorMessage="Please enter a password"
                   ControlToValidate="password"
                   Style="color: red"></asp:RequiredFieldValidator>
           </div>
       </div>

       <div class="row" style="margin-top: 10px;">
           <div class="col-md-3">
              E-mail <asp:TextBox ID="email" runat="server" style="width: 100%"></asp:TextBox>
           </div>
           <div class="col-md-9 text-left">

               <asp:RequiredFieldValidator 
                   ID="mailReqVal" 
                   runat="server" 
                   ErrorMessage="Please enter a e-mail address" ControlToValidate="email"
                   Style="color: red"></asp:RequiredFieldValidator>


               <asp:RegularExpressionValidator 
                   ID="mailVal" 
                   runat="server" 
                   ErrorMessage="Please enter a valid e-mail address"
                   ControlToValidate="email"
                   ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                   Style="color: red"></asp:RegularExpressionValidator>
           </div>
       </div>

       <div class="row" style="margin-left: 0px; margin-top: 10px; width: 80px">
           <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click" />
       </div>
   </div>


</asp:Content>
