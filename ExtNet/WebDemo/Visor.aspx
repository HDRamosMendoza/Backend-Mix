<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Visor.aspx.vb" Inherits="Visor" %>
<%@ Register Src="~/Widget_Visor.ascx" TagPrefix="mp001" TagName="ctrMapa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Visor Map</title>
    
        <!-- META -->
        <meta name="encoding" charset="UTF-8"/>
        <meta name="description" content="Web Site Map"/>
        <meta name="keywords" content="GIS, ASPMAP, HTML, CSS, XML, JavaScript"/>
        <meta name="author" content="Heber Daniel Ramos Mendoza"/>
        <meta name="copyright" content="DerTec S.A.C."/>
        <meta name="viewport" content="width=device-width, initial-scale=1.0"/>

        <!-- CSS -->
        <link rel="stylesheet" type="text/css" href="css/main.css" />
    </head>
    <body>
        <form id="frmMapa" runat="server">
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel_Mapa" runat="server">
                <ContentTemplate>
                    <mp001:ctrMapa ClientIDMode="Static" runat="server" ID="ctMapa" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </form>
        <script type="text/javascript" src="js/main.js"></script>
    </body>
</html>
