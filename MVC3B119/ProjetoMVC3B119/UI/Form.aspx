<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="ProjetoMVC3D240.UI.Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous" />
    <link href="./CSS/estilos.css" rel="stylesheet" />
    <title>ProjetoMVC3B119</title>
</head>
<body>
    <form id="frmlogin" runat="server">
        <asp:Label ID="msgerro" runat="server" Text=""></asp:Label>
        <div class="form-group">
            <asp:Label ID="lblcpf" runat="server" Text="Cpf: "></asp:Label>
            <asp:TextBox ID="txtCpf3B119" CssClass="form-control" type="number" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="ValidarCpf" runat="server" ErrorMessage="Email inválido" ControlToValidate="txtCpf3B119"></asp:RequiredFieldValidator>
        </div>
            
        <div class="form-group">
            <asp:Label ID="lblnome" runat="server" Text="Nome Completo: "></asp:Label>
            <asp:TextBox ID="txtNome3B119" CssClass="form-control" type="text" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="ValidarNome" runat="server" ErrorMessage="Escreva sua senha" ControlToValidate="txtNome3B119"></asp:RequiredFieldValidator>
        </div>
        
        <div class="form-group">
            <asp:Label ID="lblnomemae" runat="server" Text="Nome da mâe: "></asp:Label>
            <asp:TextBox ID="txtNomeMae3B119" CssClass="form-control" type="text" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="ValidarNomeMae" runat="server" ErrorMessage="Escreva sua senha" ControlToValidate="txtNomeMae3B119"></asp:RequiredFieldValidator>
        </div>
            
        <asp:Button ID="btnlogin" CssClass="btn btn-info" runat="server" Text="Login" OnClick="btnlogin_Click" />
    </form>
</body>
</html>
