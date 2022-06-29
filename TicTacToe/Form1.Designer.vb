<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.top_left = New System.Windows.Forms.Button()
        Me.top_mid = New System.Windows.Forms.Button()
        Me.top_right = New System.Windows.Forms.Button()
        Me.mid_left = New System.Windows.Forms.Button()
        Me.mid = New System.Windows.Forms.Button()
        Me.mid_right = New System.Windows.Forms.Button()
        Me.bot_left = New System.Windows.Forms.Button()
        Me.bot_mid = New System.Windows.Forms.Button()
        Me.bot_right = New System.Windows.Forms.Button()
        Me.restart_btn = New System.Windows.Forms.Button()
        Me.turn_disp = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'top_left
        '
        Me.top_left.Location = New System.Drawing.Point(12, 12)
        Me.top_left.Name = "top_left"
        Me.top_left.Size = New System.Drawing.Size(176, 180)
        Me.top_left.TabIndex = 0
        Me.top_left.UseVisualStyleBackColor = True
        '
        'top_mid
        '
        Me.top_mid.Location = New System.Drawing.Point(194, 12)
        Me.top_mid.Name = "top_mid"
        Me.top_mid.Size = New System.Drawing.Size(176, 180)
        Me.top_mid.TabIndex = 1
        Me.top_mid.UseVisualStyleBackColor = True
        '
        'top_right
        '
        Me.top_right.Location = New System.Drawing.Point(376, 12)
        Me.top_right.Name = "top_right"
        Me.top_right.Size = New System.Drawing.Size(176, 180)
        Me.top_right.TabIndex = 2
        Me.top_right.UseVisualStyleBackColor = True
        '
        'mid_left
        '
        Me.mid_left.AccessibleDescription = ""
        Me.mid_left.Location = New System.Drawing.Point(12, 198)
        Me.mid_left.Name = "mid_left"
        Me.mid_left.Size = New System.Drawing.Size(176, 180)
        Me.mid_left.TabIndex = 3
        Me.mid_left.UseVisualStyleBackColor = True
        '
        'mid
        '
        Me.mid.Location = New System.Drawing.Point(194, 198)
        Me.mid.Name = "mid"
        Me.mid.Size = New System.Drawing.Size(176, 180)
        Me.mid.TabIndex = 4
        Me.mid.UseVisualStyleBackColor = True
        '
        'mid_right
        '
        Me.mid_right.Location = New System.Drawing.Point(376, 198)
        Me.mid_right.Name = "mid_right"
        Me.mid_right.Size = New System.Drawing.Size(176, 180)
        Me.mid_right.TabIndex = 5
        Me.mid_right.UseVisualStyleBackColor = True
        '
        'bot_left
        '
        Me.bot_left.Location = New System.Drawing.Point(12, 384)
        Me.bot_left.Name = "bot_left"
        Me.bot_left.Size = New System.Drawing.Size(176, 180)
        Me.bot_left.TabIndex = 6
        Me.bot_left.UseVisualStyleBackColor = True
        '
        'bot_mid
        '
        Me.bot_mid.Location = New System.Drawing.Point(194, 384)
        Me.bot_mid.Name = "bot_mid"
        Me.bot_mid.Size = New System.Drawing.Size(176, 180)
        Me.bot_mid.TabIndex = 7
        Me.bot_mid.UseVisualStyleBackColor = True
        '
        'bot_right
        '
        Me.bot_right.Location = New System.Drawing.Point(376, 384)
        Me.bot_right.Name = "bot_right"
        Me.bot_right.Size = New System.Drawing.Size(176, 180)
        Me.bot_right.TabIndex = 8
        Me.bot_right.UseVisualStyleBackColor = True
        '
        'restart_btn
        '
        Me.restart_btn.Location = New System.Drawing.Point(577, 464)
        Me.restart_btn.Name = "restart_btn"
        Me.restart_btn.Size = New System.Drawing.Size(165, 61)
        Me.restart_btn.TabIndex = 9
        Me.restart_btn.Text = "Restart"
        Me.restart_btn.UseVisualStyleBackColor = True
        '
        'turn_disp
        '
        Me.turn_disp.AutoSize = True
        Me.turn_disp.Location = New System.Drawing.Point(638, 69)
        Me.turn_disp.Name = "turn_disp"
        Me.turn_disp.Size = New System.Drawing.Size(0, 20)
        Me.turn_disp.TabIndex = 10
        Me.turn_disp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 581)
        Me.Controls.Add(Me.turn_disp)
        Me.Controls.Add(Me.restart_btn)
        Me.Controls.Add(Me.bot_right)
        Me.Controls.Add(Me.bot_mid)
        Me.Controls.Add(Me.bot_left)
        Me.Controls.Add(Me.mid_right)
        Me.Controls.Add(Me.mid)
        Me.Controls.Add(Me.mid_left)
        Me.Controls.Add(Me.top_right)
        Me.Controls.Add(Me.top_mid)
        Me.Controls.Add(Me.top_left)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents top_left As Button
    Friend WithEvents top_mid As Button
    Friend WithEvents top_right As Button
    Friend WithEvents mid_left As Button
    Friend WithEvents mid As Button
    Friend WithEvents mid_right As Button
    Friend WithEvents bot_left As Button
    Friend WithEvents bot_mid As Button
    Friend WithEvents bot_right As Button
    Friend WithEvents restart_btn As Button
    Friend WithEvents turn_disp As Label
End Class
