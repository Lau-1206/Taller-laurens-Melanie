<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="Taller.CapaPresentacion.Usuarios" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Usuarios</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="Usuarios.aspx">Usuarios</a> | <a href="Equipos.aspx">Equipos</a>
        </div>
        <h1>Gestión de Usuarios</h1>
        <p>Laurens Urbina y Melanie Chacon</p>
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
        <div>
            <asp:Label ID="lblid" runat="server" Text="UsuarioID"></asp:Label>
            <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblnombre" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblcorreo" runat="server" Text="Correo"></asp:Label>
            <asp:TextBox ID="txtcorreo" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbltel" runat="server" Text="Telefono"></asp:Label>
            <asp:TextBox ID="txttel" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
            <asp:Button ID="btnEditar" runat="server" Text="Modificar" OnClick="btnEditar_Click" />
            <asp:Button ID="btnBorrar" runat="server" Text="Borrar" OnClick="btnBorrar_Click" />
        </div>
        <asp:Label ID="lblmsg" runat="server"></asp:Label>
    </form>
</body>
</html>