<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnNewForm = New System.Windows.Forms.Button()
        Me.btnSecondForm = New System.Windows.Forms.Button()
        Me.btnSchedule = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNewForm
        '
        Me.btnNewForm.Location = New System.Drawing.Point(70, 55)
        Me.btnNewForm.Name = "btnNewForm"
        Me.btnNewForm.Size = New System.Drawing.Size(128, 23)
        Me.btnNewForm.TabIndex = 0
        Me.btnNewForm.Text = "New Form"
        Me.btnNewForm.UseVisualStyleBackColor = True
        '
        'btnSecondForm
        '
        Me.btnSecondForm.Location = New System.Drawing.Point(70, 84)
        Me.btnSecondForm.Name = "btnSecondForm"
        Me.btnSecondForm.Size = New System.Drawing.Size(128, 23)
        Me.btnSecondForm.TabIndex = 1
        Me.btnSecondForm.Text = "Second Form"
        Me.btnSecondForm.UseVisualStyleBackColor = True
        '
        'btnSchedule
        '
        Me.btnSchedule.Location = New System.Drawing.Point(70, 113)
        Me.btnSchedule.Name = "btnSchedule"
        Me.btnSchedule.Size = New System.Drawing.Size(128, 23)
        Me.btnSchedule.TabIndex = 2
        Me.btnSchedule.Text = "Schedule Form"
        Me.btnSchedule.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnSchedule)
        Me.Controls.Add(Me.btnSecondForm)
        Me.Controls.Add(Me.btnNewForm)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNewForm As Button
    Friend WithEvents btnSecondForm As Button
    Friend WithEvents btnSchedule As Button
End Class
