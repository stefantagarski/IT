<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Glasaj.aspx.cs" Inherits="lab1.Glasaj" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="container" style="margin: 20px;">

        <asp:Image ID="finki" runat="server" ImageUrl="~/logo_10.png" />

        <div>
            <asp:Label ID="lbProffesor" runat="server" Text=""></asp:Label>
        </div>

        <div class="row">
            <div class="col-md-3">
                <asp:ListBox ID="lbPredmeti" runat="server" AutoPostBack="true" OnSelectedIndexChanged="lbPredmeti_SelectedIndexChanged"></asp:ListBox>
                <asp:ListBox ID="lbKrediti" runat="server"></asp:ListBox>
            </div>

        </div>

        <div class="row" style="margin-top: 10px;">
            <div class="col-md-3">
            </div>

        </div>

        <div class="row" style="margin-left: 0px; margin-top: 10px; width: 80px">
            <asp:Button ID="glasajte" runat="server" Text="Glasajte" OnClick="glasajte_Click" />
        </div>


        <hr />


        <div class="row" style="margin-top: 10px;">
            <div class="col-md-3">
                Subjects:
                <asp:TextBox ID="subject" runat="server" Style="width: 100%"></asp:TextBox>
            </div>
        </div>

        <div class="row" style="margin-top: 10px;">
            <div class="col-md-3">
                Credits:
                <asp:TextBox ID="credits" runat="server" Style="width: 100%"></asp:TextBox>
            </div>
        </div>

        <div class="row" style="margin-left: 0px; margin-top: 10px;">
            <asp:Button ID="add" runat="server" Text="Add" Height="35px" Width="92px" OnClick="add_Click" />
        </div>

        <div class="row" style="margin-left: 0px; margin-top: 10px; width: 100px">
            <asp:Button ID="remove" runat="server" Text="Remove" OnClick="remove_Click"/>
        </div>
    </div>


</asp:Content>
