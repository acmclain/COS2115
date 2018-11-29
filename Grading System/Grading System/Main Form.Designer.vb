<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.blbFirst = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(618, 311)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 35)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblStudentID
        '
        Me.lblStudentID.BackColor = System.Drawing.Color.Lavender
        Me.lblStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStudentID.Location = New System.Drawing.Point(60, 57)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(100, 24)
        Me.lblStudentID.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Student ID:"
        '
        'blbFirst
        '
        Me.blbFirst.BackColor = System.Drawing.Color.Lavender
        Me.blbFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.blbFirst.Location = New System.Drawing.Point(237, 57)
        Me.blbFirst.Name = "blbFirst"
        Me.blbFirst.Size = New System.Drawing.Size(100, 24)
        Me.blbFirst.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(232, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "First Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(426, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Last Name:"
        '
        'lblLast
        '
        Me.lblLast.BackColor = System.Drawing.Color.Lavender
        Me.lblLast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLast.Location = New System.Drawing.Point(430, 57)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(100, 24)
        Me.lblLast.TabIndex = 7
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 365)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.blbFirst)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblStudentID)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.Text = "Life Prep Academy"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As Button
    Friend WithEvents lblStudentID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents blbFirst As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblLast As Label
End Class
