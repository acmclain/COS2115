<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class data
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.EagleEnterprisesDataSet1 = New Grading_System.EagleEnterprisesDataSet()
        Me.EagleEnterprisesDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.EagleEnterprisesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EagleEnterprisesDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EagleEnterprisesDataSet1
        '
        Me.EagleEnterprisesDataSet1.DataSetName = "EagleEnterprisesDataSet"
        Me.EagleEnterprisesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EagleEnterprisesDataSet1BindingSource
        '
        Me.EagleEnterprisesDataSet1BindingSource.DataSource = Me.EagleEnterprisesDataSet1
        Me.EagleEnterprisesDataSet1BindingSource.Position = 0
        '
        'data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Name = "data"
        Me.Text = "data"
        CType(Me.EagleEnterprisesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EagleEnterprisesDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EagleEnterprisesDataSet1 As EagleEnterprisesDataSet
    Friend WithEvents EagleEnterprisesDataSet1BindingSource As BindingSource
End Class
