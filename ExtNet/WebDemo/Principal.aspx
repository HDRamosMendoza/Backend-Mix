<%@ Register TagPrefix="aspmap" Namespace="AspMap.Web" Assembly="AspMapNET" %>

<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Principal.aspx.vb" Inherits="Principal" %>

<!DOCTYPE html>
<html lang="es" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Demo DANIEL</title>



    <!-- META -->
    <meta name="encoding" charset="UTF-8" />
    <meta name="description" content="Web Site Map" />
    <meta name="keywords" content="GIS, ASPMAP, HTML, CSS, XML, JavaScript" />
    <meta name="author" content="Heber Daniel Ramos Mendoza" />
    <meta name="copyright" content="DerTec S.A.C." />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

    <!-- CSS -->
    <link rel="stylesheet" type="text/css" href="css/main.css" />

</head>
<body>
    <form runat="server">
        <ext:ResourceManager runat="server" />
        <ext:Viewport runat="server" Layout="BorderLayout">
            <Items>
                <ext:Panel runat="server"
                    Layout="FitLayout"
                    title="PRINCIPAL"
                    Region="center"
                    BodyCls="panel" >
                    <Items>
                        <ext:FieldContainer runat="server"
                            Layout="ColumnLayout"
                            >
                            <%--<Defaults>
                                <ext:Parameter Mode="Raw" Name="Height" Value="" />
                                <ext:Parameter Mode="Raw" Name="AutoScroll" Value="true" />
                                <ext:Parameter Mode="Value" Name="Html" Value="<%# TEST_HTML %>" AutoDataBind="true" />
                            </Defaults>--%>
                            <Items>
                                <ext:Panel runat="server" 
                                    title="PANEL 1"
                                    Border="true"
                                    ColumnWidth="0.6" 
                                    height="500" 
                                    BodyCls="panel_1">
                                    <Content>
                                        <html>
                                            <p>
                                                HOLA MUNDO 1
                                            </p>
                                        </html>
                                    </Content>
                                </ext:Panel>

                                <ext:Panel runat="server" 
                                    title="PANEL 1"
                                    Border="true"
                                    ColumnWidth="0.4" 
                                    height="700"
                                    BodyCls="panel_2">
                                    <Content>
                                        <html>
                                            <p>
                                                HOLA MUNDO 2
                                            </p>
                                        </html>
                                    </Content>
                                </ext:Panel>
                            </Items>
                        </ext:FieldContainer>

                    </Items>
                </ext:Panel>
            </Items>
        </ext:Viewport>
    </form>
    <!-- JS -->
    <script type="text/javascript" src="https://code.jquery.com/jquery-1.12.4.js" integrity="sha256-Qw82+bXyGq6MydymqBxNPYTaUXXq7c8v3CwiYwLLNXU=" crossorigin="anonymous"></script>
    <script type="text/javascript" src="js/main.js"></script>
</body>
</html>
