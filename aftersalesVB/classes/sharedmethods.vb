Imports ComponentFactory.Krypton.Toolkit

Public Class sharedmethods
    Public Shared joborderno As String
    Public Sub ServicingScheduleFRMinitialize()
        With ServicingScheduleFRM.gv
            .RowTemplate.Height = 50
            .StateCommon.DataCell.Border.Color1 = Color.Black
            .StateCommon.DataCell.Border.Width = 1
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With
        dgvproperties(ServicingScheduleFRM.gv)


    End Sub
    Public Sub assessmentsettingFRMinitialize()
        With assessmentsettingFRM.gv
            '.RowTemplate.Height = 50
            '.StateCommon.DataCell.Border.Color1 = Color.Black
            '.StateCommon.DataCell.Border.Width = 1
            '.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With
        dgvproperties(assessmentsettingFRM.gv)
        dgvproperties(assessmentsettingFRM.gv2)
        AddHandler assessmentsettingFRM.gv.SelectionChanged, AddressOf assessmentsettingFRM.gv_SelectionChanged
        AddHandler assessmentsettingFRM.gv2.SelectionChanged, AddressOf assessmentsettingFRM.gv2_SelectionChanged
    End Sub

    Public Sub dgvproperties(ByVal dgv As KryptonDataGridView)
        With dgv
            .Dock = DockStyle.Fill
            .Select()
            .DefaultCellStyle.BackColor = Color.White
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = True
            .AllowUserToResizeRows = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .CausesValidation = True
            .ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText
            .PaletteMode = PaletteMode.Office2010Silver
            .ColumnHeadersHeight = 30
            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            With .StateCommon
                .DataCell.Content.Font = New Font("Segoe UI", 8.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                .HeaderColumn.Back.ColorAngle = -1
                .HeaderColumn.Back.ColorStyle = PaletteColorStyle.Dashed
                .HeaderColumn.Border.Width = 0
                .HeaderColumn.Content.Color1 = Color.DimGray
                .HeaderColumn.Content.Color2 = Color.Transparent
                .HeaderColumn.Content.Font = New Font("Calibri", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                .HeaderColumn.Content.Hint = PaletteTextHint.AntiAlias
            End With
        End With
    End Sub
End Class
