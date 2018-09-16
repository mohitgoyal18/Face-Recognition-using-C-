<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PROJECT
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
        Me.mass = New System.Windows.Forms.TextBox()
        Me.mmwp = New System.Windows.Forms.TextBox()
        Me.mmw = New System.Windows.Forms.TextBox()
        Me.mw = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.eva = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.m = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mw1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mmw1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mp = New System.Windows.Forms.TextBox()
        Me.read = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mass
        '
        Me.mass.Location = New System.Drawing.Point(192, 41)
        Me.mass.Name = "mass"
        Me.mass.Size = New System.Drawing.Size(100, 20)
        Me.mass.TabIndex = 0
        '
        'mmwp
        '
        Me.mmwp.Location = New System.Drawing.Point(192, 244)
        Me.mmwp.Name = "mmwp"
        Me.mmwp.Size = New System.Drawing.Size(100, 20)
        Me.mmwp.TabIndex = 1
        '
        'mmw
        '
        Me.mmw.Location = New System.Drawing.Point(192, 166)
        Me.mmw.Name = "mmw"
        Me.mmw.Size = New System.Drawing.Size(100, 20)
        Me.mmw.TabIndex = 2
        '
        'mw
        '
        Me.mw.Location = New System.Drawing.Point(192, 93)
        Me.mw.Name = "mw"
        Me.mw.Size = New System.Drawing.Size(100, 20)
        Me.mw.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(229, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Mass"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(211, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "MW(g/mol)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(214, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Mass/MW"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(156, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 26)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Moles of limiting reagent * MW" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " of Product"
        '
        'eva
        '
        Me.eva.Location = New System.Drawing.Point(376, 102)
        Me.eva.Name = "eva"
        Me.eva.Size = New System.Drawing.Size(75, 23)
        Me.eva.TabIndex = 8
        Me.eva.Text = "Evaluate"
        Me.eva.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(352, 38)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(150, 20)
        Me.DateTimePicker1.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(312, 137)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(173, 150)
        Me.DataGridView1.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Mass"
        '
        'm
        '
        Me.m.Location = New System.Drawing.Point(23, 41)
        Me.m.Name = "m"
        Me.m.Size = New System.Drawing.Size(100, 20)
        Me.m.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "MW(G/MOL)"
        '
        'mw1
        '
        Me.mw1.Location = New System.Drawing.Point(23, 93)
        Me.mw1.Name = "mw1"
        Me.mw1.Size = New System.Drawing.Size(100, 20)
        Me.mw1.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Mass/MW"
        '
        'mmw1
        '
        Me.mmw1.Location = New System.Drawing.Point(23, 166)
        Me.mmw1.Name = "mmw1"
        Me.mmw1.Size = New System.Drawing.Size(100, 20)
        Me.mmw1.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 204)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 26)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Mole of limiting " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "agent*Mw of product"
        '
        'mp
        '
        Me.mp.Location = New System.Drawing.Point(23, 244)
        Me.mp.Name = "mp"
        Me.mp.Size = New System.Drawing.Size(100, 20)
        Me.mp.TabIndex = 19
        '
        'read
        '
        Me.read.Location = New System.Drawing.Point(37, 283)
        Me.read.Name = "read"
        Me.read.Size = New System.Drawing.Size(75, 23)
        Me.read.TabIndex = 20
        Me.read.Text = "Read file"
        Me.read.UseVisualStyleBackColor = True
        '
        'PROJECT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(514, 405)
        Me.Controls.Add(Me.read)
        Me.Controls.Add(Me.mp)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.mmw1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.mw1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.m)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.eva)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mw)
        Me.Controls.Add(Me.mmw)
        Me.Controls.Add(Me.mmwp)
        Me.Controls.Add(Me.mass)
        Me.Name = "PROJECT"
        Me.Text = "PROJECT"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mass As System.Windows.Forms.TextBox
    Friend WithEvents mmwp As System.Windows.Forms.TextBox
    Friend WithEvents mmw As System.Windows.Forms.TextBox
    Friend WithEvents mw As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents eva As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents m As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mw1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents mmw1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents mp As System.Windows.Forms.TextBox
    Friend WithEvents read As System.Windows.Forms.Button

End Class
