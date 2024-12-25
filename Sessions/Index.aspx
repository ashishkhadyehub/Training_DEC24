<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Sessions.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Form</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />
</head>
<body>
    
    <form id="form1" runat="server">
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
                    <div class="form-group my-2">
                        <label>City:</label>
                        <asp:DropDownList ID="ddlCity" CssClass="form-control" runat="server">
                            <asp:ListItem Value="Select" Text="Select City"></asp:ListItem>
                            <asp:ListItem Value="Mumbai" Text="Mumbai"></asp:ListItem>
                            <asp:ListItem Value="Pune" Text="Pune"></asp:ListItem>
                            <asp:ListItem Value="Delhi" Text="Delhi"></asp:ListItem>
                        </asp:DropDownList>
                        
                        
                    </div>
                    <asp:Button runat="server" ID="btnSubmit" CssClass="btn btn-primary" Text="Submit" />

                </div>
            </div>
        </div>
    </form>
</body>
</html>
