<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Mockup_1.aspx.vb" Inherits="Mockup_1" %>
<%@ Register Assembly="AspMapNET" Namespace="AspMap.Web" TagPrefix="aspmap" %>

<!DOCTYPE html>
<html lang="es" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GEORGE</title>

    <!-- META -->
    <meta name="encoding" charset="UTF-8" />
    <meta name="description" content="Web Site Map" />
    <meta name="keywords" content="GIS, ASPMAP, HTML, CSS, XML, JavaScript" />
    <meta name="author" content="Heber Daniel Ramos Mendoza" />
    <meta name="copyright" content="DerTec S.A.C." />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>
    <form id="frmMap" runat="server">
        <ext:ResourceManager ID="ResourceManager_1" runat="server" DisableViewState="false"/>
        <ext:Viewport runat="server" Layout="BorderLayout">
            <Items>
                <ext:Panel runat="server"
                    Border="false"
                    BodyCls="panel"
                    Layout="FitLayout"
                    Region="center" >
                    <Items>
                        <ext:FieldContainer runat="server"
                            Layout="FitLayout"
                            >
                            <Items>
                                <ext:Panel runat="server"
                                    id="Panel_Visor"
                                    Border="false"
                                    BodyCls="panel_1"
                                    ColumnWidth="1"
                                    Height="800"
                                    Width="1000" >
                                </ext:Panel>
                                <ext:Window runat="server"
                                    id="Widget_Consulta"
                                    Region="South"
                                    Height="400"
                                    Width="400"
                                    BodyCls="panel_ramos">
                                </ext:Window>
                            </Items>
                        </ext:FieldContainer>

                    </Items>
                </ext:Panel>
            </Items>
        </ext:Viewport>
    </form>

    <!-- JS -->
    <script type="text/javascript" src="https://code.jquery.com/jquery-1.12.4.js" integrity="sha256-Qw82+bXyGq6MydymqBxNPYTaUXXq7c8v3CwiYwLLNXU=" crossorigin="anonymous"></script>
</body>
</html>
