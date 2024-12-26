<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Session1.aspx.cs" Inherits="Sessions.Session1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container my-4">
     <div class="row">
         <div class="col-md-6">
             <div class="form-group my-2">
                 <label>Name:</label>
                 <asp:TextBox runat="server" ID="txtName" placeholder="Enter Name" CssClass="form-control"></asp:TextBox>

             </div>
             <div class="form-group my-2">
                 <label>Contact:</label>
                 <asp:TextBox TextMode="Number" runat="server" ID="txtContact" placeholder="Enter Contact" CssClass="form-control"></asp:TextBox>

             </div>
            
             <asp:Button runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" CssClass="btn btn-primary" Text="Submit" />

         </div>
     </div>
 </div>
</asp:Content>
