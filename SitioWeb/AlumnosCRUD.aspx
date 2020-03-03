<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AlumnosCRUD.aspx.cs" Inherits="SitioWeb.AlumnosCRUD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>AlumnosCRUD</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <h1>Listado de Alumnos</h1>
        <asp:GridView ID="ListadoAlumnos" runat="server" CssClass="table table-hover" OnSelectedIndexChanged="ListadoAlumnos_SelectedIndexChanged" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
            <Columns>
                <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                <asp:BoundField DataField="apellido" HeaderText="apellido" SortExpression="apellido" />
                <asp:BoundField DataField="curso" HeaderText="curso" SortExpression="curso" />
                <asp:ButtonField ButtonType="Button" Text="Modificar" ControlStyle-CssClass="btn btn-success"/>
            </Columns>
        </asp:GridView>
        
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="ListAlumnos" TypeName="BLL.AlumnosNet"></asp:ObjectDataSource>
        
    </div>
    </form>
</body>
</html>
