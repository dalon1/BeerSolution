<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BeerMainForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnFileExplorer = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.gdvBeers = New System.Windows.Forms.DataGridView()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtLogs = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.gdvBeers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSend)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.txtFilePath)
        Me.Panel1.Controls.Add(Me.btnFileExplorer)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(628, 57)
        Me.Panel1.TabIndex = 0
        '
        'btnFileExplorer
        '
        Me.btnFileExplorer.Location = New System.Drawing.Point(4, 4)
        Me.btnFileExplorer.Name = "btnFileExplorer"
        Me.btnFileExplorer.Size = New System.Drawing.Size(75, 23)
        Me.btnFileExplorer.TabIndex = 0
        Me.btnFileExplorer.Text = "File Explorer"
        Me.btnFileExplorer.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.gdvBeers)
        Me.Panel2.Location = New System.Drawing.Point(13, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(628, 152)
        Me.Panel2.TabIndex = 1
        '
        'gdvBeers
        '
        Me.gdvBeers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gdvBeers.Location = New System.Drawing.Point(4, 4)
        Me.gdvBeers.Name = "gdvBeers"
        Me.gdvBeers.Size = New System.Drawing.Size(621, 145)
        Me.gdvBeers.TabIndex = 0
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(85, 6)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.ReadOnly = True
        Me.txtFilePath.Size = New System.Drawing.Size(540, 20)
        Me.txtFilePath.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtLogs)
        Me.Panel3.Location = New System.Drawing.Point(13, 236)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(628, 91)
        Me.Panel3.TabIndex = 2
        '
        'txtLogs
        '
        Me.txtLogs.BackColor = System.Drawing.SystemColors.Window
        Me.txtLogs.Location = New System.Drawing.Point(4, 4)
        Me.txtLogs.Multiline = True
        Me.txtLogs.Name = "txtLogs"
        Me.txtLogs.ReadOnly = True
        Me.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLogs.Size = New System.Drawing.Size(621, 84)
        Me.txtLogs.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(4, 31)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(85, 31)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 3
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'BeerMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 339)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "BeerMainForm"
        Me.Text = "Beer Main Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.gdvBeers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnFileExplorer As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents gdvBeers As DataGridView
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtLogs As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents btnSave As Button
End Class
