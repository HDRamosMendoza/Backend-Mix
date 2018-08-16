Imports Microsoft.VisualBasic
Imports Ext.Net
Partial Class Mockup_1
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim cLoader As New ComponentLoader
        cLoader.Url = "~/Visor.aspx"
        cLoader.Mode = LoadMode.Frame
        cLoader.LoadMask.ShowMask = True
        cLoader.LoadMask.Msg = "Cargando ... "
        Panel_Visor.Loader = cLoader

        Widget_Consulta.Show()
    End Sub
End Class