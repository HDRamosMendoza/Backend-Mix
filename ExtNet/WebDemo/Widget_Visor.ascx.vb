Imports AspMap
Partial Class Widget_Visor
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        AspMap.License.SetLicenseKey("ccccfecmlnblgdabbcifoobjapolaloicelgpebbpdcgff")

        Dim CapaLayer As Layer = Main_Map.AddLayer(MapPath("map/world/world.shp"))
        CapaLayer.Symbol.FillColor = Drawing.Color.Aqua
    End Sub

    Function MandarDatos() As String
        Return ""
    End Function
End Class
