<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Glasaj.aspx.cs" Inherits="isptina2012.Glasaj" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">




    <div class="container" style="margin: 20px;">

        <div>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/logo_10.png" />
        </div>

        <br />

        <div class="row">
            <div>
                <asp:ListBox ID="lbProfesori" runat="server" AutoPostBack="true" OnSelectedIndexChanged="lbProfesori_SelectedIndexChanged">
                    <asp:ListItem Value="GA">Prof. d-r Goce Armenski</asp:ListItem>
                    <asp:ListItem Value="IM">Prof. d-r Igor Miskovski</asp:ListItem>
                    <asp:ListItem Value="IC">Prof. d-r Ivan Chorbev</asp:ListItem>
                </asp:ListBox>

                <asp:ListBox ID="lbPredmeti" runat="server" AutoPostBack="true"></asp:ListBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Select a subject" ControlToValidate="lbPredmeti"
                    Style="color: red"></asp:RequiredFieldValidator>

            </div>
        </div>

        

        <div>
            Grade:
            <asp:TextBox ID="grade" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter a grade!" Style="color: red" ControlToValidate="grade"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Enter a valid grade!" Style="color: red" ControlToValidate="grade" MaximumValue="10" MinimumValue="5" Type="Integer"></asp:RangeValidator>
        </div>

        <hr />

        <div class="row" style="margin-left: 0px; margin-top: 10px;">
            <asp:Button ID="glasajte" runat="server" Text="Vote" Width="64px" OnClick="glasajte_Click" />
        </div>
    </div>

</asp:Content>
