<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Mockup_2.aspx.vb" Inherits="Mockup_2" %>
<%@ Register Assembly="AspMapNET" Namespace="AspMap.Web" TagPrefix="aspmap" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Demo Scroll</title>

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
        <ext:ResourceManager ID="ResourceManager_1" runat="server" DisableViewState="false" />
        <ext:Viewport runat="server" Layout="BorderLayout">
            <Items>
                <ext:Panel
                    runat="server"
                    Title="North"
                    Region="North"
                    Split="true"
                    Height="200"
                    BodyPadding="6"
                    Html="North"
                    Collapsible="true">
                </ext:Panel>

                <ext:Panel
                    runat="server"
                    Title="West"
                    Region="West"
                    Layout="AccordionLayout"
                    Width="250"
                    MinWidth="250"
                    MaxWidth="400"
                    Split="true"
                    Collapsible="true">
                </ext:Panel>

                <ext:Panel runat="server"
                    Border="false"
                    BodyCls="panel"
                    Layout="FitLayout"
                    Region="center">
                    <Items>
                        <ext:FieldContainer runat="server"
                            Layout="FitLayout">
                            <Items>
                                <ext:Panel runat="server"
                                    ID="Panel_Visor"
                                    Border="false"
                                    BodyCls="panel_1"
                                    ColumnWidth="1"
                                    Height="800"
                                    Width="1000">
                                </ext:Panel>
                                <ext:Window
                                    id="Widget_Consulta" Constrain="true"
                                    runat="server"
                                    Title="Accordion"
                                    Width="250"
                                    Height="400"
                                    Maximizable="true"
                                    BodyBorder="0"
                                    Icon="ApplicationTileVertical"
                                    Layout="Accordion">
                                    <Items>
                                        <ext:TreePanel runat="server" Title="Online Users" RootVisible="false">
                                            <Tools>
                                                <ext:Tool Type="Refresh" Handler="Ext.Msg.alert('Message','Refresh Tool Clicked!');" />
                                            </Tools>
                                            <Root>
                                                <ext:Node Text="Root">
                                                    <Children>
                                                        <ext:Node Text="Friends" Expanded="true">
                                                            <Children>
                                                                <ext:Node Text="George" Icon="User" Leaf="True" />
                                                                <ext:Node Text="Brian" Icon="User" Leaf="True" />
                                                                <ext:Node Text="Jon" Icon="User" Leaf="True" />
                                                                <ext:Node Text="Tim" Icon="User" Leaf="True" />
                                                                <ext:Node Text="Brent" Icon="User" Leaf="True" />
                                                                <ext:Node Text="Fred" Icon="User" Leaf="True" />
                                                                <ext:Node Text="Bob" Icon="User" Leaf="True" />
                                                            </Children>
                                                        </ext:Node>
                                                        <ext:Node Text="Family" Expanded="true">
                                                            <Children>
                                                                <ext:Node Text="Kelly" Icon="UserFemale" Leaf="True" />
                                                                <ext:Node Text="Sara" Icon="UserFemale" Leaf="True" />
                                                                <ext:Node Text="Zack" Icon="UserGreen" Leaf="True" />
                                                                <ext:Node Text="John" Icon="UserGreen" Leaf="True" />
                                                            </Children>
                                                        </ext:Node>
                                                    </Children>
                                                </ext:Node>
                                            </Root>
                                        </ext:TreePanel>
                                        <ext:Panel runat="server" Title="Settings" />
                                        <ext:Panel runat="server" Title="Even More Stuff" />
                                        <ext:Panel runat="server" Title="My Stuff" />
                                    </Items>
                                </ext:Window>
                            </Items>
                        </ext:FieldContainer>
                    </Items>
                </ext:Panel>

                <ext:Panel
                    runat="server"
                    Title="South"
                    Region="South"
                    Split="true"
                    Collapsible="true">
                </ext:Panel>
            </Items>
        </ext:Viewport>
    </form>
</body>
</html>
