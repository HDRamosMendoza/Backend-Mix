Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports AspMap
Imports AspMap.Web

Partial Class Principal
    Inherits System.Web.UI.Page
    Public TEST_HTML As String = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed egestas gravida nibh, quis porttitor felis venenatis id. Nam sodales mollis quam eget venenatis. Aliquam metus lorem, tincidunt ut egestas imperdiet, convallis lacinia tortor."

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'mainMap.MapUnit = MeasureUnit.Degree

        'Dim layer As AspMap.Layer = mainMap.AddLayer(MapPath("map/world/world.shp"))

        'Dim layerExtentt As AspMap.Rectangle
        'layerExtentt = New AspMap.Rectangle(-122.68, 45.53, -122.45, 45.6)
        'mainMap.Extent = layerExtentt
        '-122.68, 45.53, -122.45, 45.6
        ' labels

        'layer.ShowLabels = True
        'layer.LabelField = "NAME"
        'layer.LabelStyle = LabelStyle.PolygonCenter
        'layer.LabelFont.Name = "Verdana"
        'layer.LabelFont.Size = 14
        'layer.LabelFont.Outline = True

        ' line size and color
        'layer.Symbol.Size = 1
        'layer.Symbol.LineColor = Color.LightGray

        ' fill color
        'layer.Symbol.FillColor = Color.Ivory

    End Sub
End Class
