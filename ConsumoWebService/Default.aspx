<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ConsumoWebService._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table ID="Table1" runat="server">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label1" runat="server" Text="Ingrese numero 1"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label2" runat="server" Text="Ingrese numero 2"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Button ID="btnSumar" runat="server" Text="Sumar" OnClick="Sumar"/>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Label ID="lblRespuesta" runat="server" Text=""></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>

            <h1>Manejo de Sesiones</h1>


             <asp:Table ID="Table2" runat="server">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label3" runat="server" Text="Ingrese numero 1"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtNum1Resta" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label4" runat="server" Text="Ingrese numero 2"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtNum2Resta" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Button ID="btnRestar" runat="server" Text="Restar" OnClick="Restar"/>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Label ID="lblRespuestaResta" runat="server" Text=""></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <asp:GridView ID="gridCalculos" runat="server">

            </asp:GridView>
        </div>
    </form>
</body>
</html>
