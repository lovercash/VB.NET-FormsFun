<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScheduleForm
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
        Me.brnBackToMain = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'brnBackToMain
        '
        Me.brnBackToMain.Location = New System.Drawing.Point(80, 98)
        Me.brnBackToMain.Name = "brnBackToMain"
        Me.brnBackToMain.Size = New System.Drawing.Size(99, 23)
        Me.brnBackToMain.TabIndex = 0
        Me.brnBackToMain.Text = "Back to Main Form"
        Me.brnBackToMain.UseVisualStyleBackColor = True
        '
        'frmScheduleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.brnBackToMain)
        Me.Name = "frmScheduleForm"
        Me.Text = "Schedule Form"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents brnBackToMain As Button
End Class
