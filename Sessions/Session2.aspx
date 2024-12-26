<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Session2.aspx.cs" Inherits="Sessions.Session2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container my-4">
            <h3>Confirm Details</h3>
    <div class="row">
        <div class="col-md-6">
            <div class="form-group my-2">
                <label>Name:</label>
                <asp:TextBox Enabled="false" runat="server" ID="txtName" placeholder="Enter Name" CssClass="form-control"></asp:TextBox>

            </div>
            <div class="form-group my-2">
                <label>Contact:</label>
                <asp:TextBox Enabled="false" TextMode="Number" runat="server" ID="txtContact" placeholder="Enter Contact" CssClass="form-control"></asp:TextBox>

            </div>
           
           

        </div>
    </div>
</div>
</asp:Content>
