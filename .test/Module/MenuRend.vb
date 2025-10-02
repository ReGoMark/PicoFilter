Module MenuRend

    Public Class MenuRender
        Inherits ToolStripProfessionalRenderer

        Public Sub New()
            MyBase.New(New ModernColorTable())
        End Sub

        Protected Overrides Sub OnRenderArrow(e As ToolStripArrowRenderEventArgs)
            e.ArrowColor = Color.DarkSlateBlue
            MyBase.OnRenderArrow(e)
        End Sub

        Protected Overrides Sub OnRenderImageMargin(e As ToolStripRenderEventArgs)
            Dim marginRect As Rectangle = e.AffectedBounds
            Using brush As New Drawing2D.LinearGradientBrush(
                marginRect,
                Color.FromArgb(244, 238, 255),
                Color.FromArgb(244, 238, 255),
                Drawing2D.LinearGradientMode.Horizontal)
                e.Graphics.FillRectangle(brush, marginRect)
            End Using
        End Sub

        Protected Overrides Sub OnRenderSeparator(e As ToolStripSeparatorRenderEventArgs)
            Dim g = e.Graphics
            Dim bounds = e.Item.ContentRectangle
            Dim y = bounds.Top + bounds.Height \ 2
            Using pen As New Pen(Color.FromArgb(244, 238, 255), 1)
                g.DrawLine(pen, bounds.Left + 25, y, bounds.Right - 4, y)
            End Using
        End Sub

    End Class

    Public Class ModernColorTable
        Inherits ProfessionalColorTable

        Public Overrides ReadOnly Property MenuBorder As Color
            Get
                Return Color.FromArgb(244, 238, 255)
            End Get
        End Property

        Public Overrides ReadOnly Property MenuItemBorder As Color
            Get
                Return Color.FromArgb(244, 238, 255)
            End Get
        End Property

        Public Overrides ReadOnly Property MenuItemSelected As Color
            Get
                Return Color.FromArgb(244, 238, 255)
            End Get
        End Property

    End Class

End Module