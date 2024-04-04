<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Najava.aspx.cs" Inherits="isptina2012.Najava" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container" style="margin: 20px;">
        <div class="row">
            <div class="col-md-3">
                Name:
                <asp:TextBox ID="name" runat="server" Style="width: 100%"></asp:TextBox>
            </div>
            <div class="col-md-9 text-left">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter a name!"
                    Style="color: red"
                    ControlToValidate="name"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="row" style="margin-top: 10px;">
            <div class="col-md-3">
                Password:
                <asp:TextBox ID="password" TextMode="Password" runat="server" Style="width: 100%"></asp:TextBox>
            </div>
            <div class="col-md-9 text-left">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter a password!"
                    Style="color: red" ControlToValidate="password"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter a valid password!"
                    Style="color: red" ControlToValidate="password" ValidationExpression=".{5,}"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="row" style="margin-top: 10px;">
            <div class="col-md-3">
                Email:
                <asp:TextBox ID="email" runat="server" Style="width: 100%"></asp:TextBox>
            </div>
            <div class="col-md-9 text-left">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter a email!"
                    Style="color: red"
                    ControlToValidate="email"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"
                    ErrorMessage="Enter a valid email!"
                    Style="color: red"
                    ControlToValidate="email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="row" style="margin-left: 0px; margin-top: 10px;">
            <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click" Width="86px" />
        </div>
    </div>

</asp:Content>
