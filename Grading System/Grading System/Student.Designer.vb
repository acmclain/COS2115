<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudent
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
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.btnCourseList = New System.Windows.Forms.Button()
        Me.lblComments = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFullName
        '
        Me.lblFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFullName.Location = New System.Drawing.Point(22, 32)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(346, 30)
        Me.lblFullName.TabIndex = 0
        '
        'lblDOB
        '
        Me.lblDOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDOB.Location = New System.Drawing.Point(22, 81)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(116, 31)
        Me.lblDOB.TabIndex = 1
        '
        'btnCourseList
        '
        Me.btnCourseList.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnCourseList.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCourseList.Location = New System.Drawing.Point(312, 248)
        Me.btnCourseList.Name = "btnCourseList"
        Me.btnCourseList.Size = New System.Drawing.Size(116, 38)
        Me.btnCourseList.TabIndex = 2
        Me.btnCourseList.Text = "Course List"
        Me.btnCourseList.UseVisualStyleBackColor = False
        '
        'lblComments
        '
        Me.lblComments.BackColor = System.Drawing.SystemColors.Control
        Me.lblComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblComments.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblComments.Location = New System.Drawing.Point(22, 125)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(600, 107)
        Me.lblComments.TabIndex = 3
        '
        'btnExit
        '
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(494, 248)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 38)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStatus.Location = New System.Drawing.Point(432, 82)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(190, 30)
        Me.lblStatus.TabIndex = 5
        '
        'lblStudentID
        '
        Me.lblStudentID.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lblStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStudentID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStudentID.Location = New System.Drawing.Point(432, 32)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(190, 30)
        Me.lblStudentID.TabIndex = 6
        '
        'frmStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 322)
        Me.Controls.Add(Me.lblStudentID)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblComments)
        Me.Controls.Add(Me.btnCourseList)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.lblFullName)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Name = "frmStudent"
        Me.Text = "Student Information"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblFullName As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents btnCourseList As Button
    Friend WithEvents lblComments As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblStudentID As Label
End Class
