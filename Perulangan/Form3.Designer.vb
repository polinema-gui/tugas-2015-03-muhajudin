<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.hasilText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.matriks1Text = New System.Windows.Forms.TextBox()
        Me.hitungButton = New System.Windows.Forms.Button()
        Me.matriks2Text = New System.Windows.Forms.TextBox()
        Me.operasiCombo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Hasil"
        '
        'hasilText
        '
        Me.hasilText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hasilText.Location = New System.Drawing.Point(88, 222)
        Me.hasilText.Multiline = True
        Me.hasilText.Name = "hasilText"
        Me.hasilText.ReadOnly = True
        Me.hasilText.Size = New System.Drawing.Size(340, 75)
        Me.hasilText.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Matriks 2"
        '
        'matriks1Text
        '
        Me.matriks1Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matriks1Text.Location = New System.Drawing.Point(88, 12)
        Me.matriks1Text.Multiline = True
        Me.matriks1Text.Name = "matriks1Text"
        Me.matriks1Text.Size = New System.Drawing.Size(340, 75)
        Me.matriks1Text.TabIndex = 20
        '
        'hitungButton
        '
        Me.hitungButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hitungButton.Location = New System.Drawing.Point(353, 367)
        Me.hitungButton.Name = "hitungButton"
        Me.hitungButton.Size = New System.Drawing.Size(75, 23)
        Me.hitungButton.TabIndex = 19
        Me.hitungButton.Text = "Hitung"
        Me.hitungButton.UseVisualStyleBackColor = True
        '
        'matriks2Text
        '
        Me.matriks2Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matriks2Text.Location = New System.Drawing.Point(88, 131)
        Me.matriks2Text.Multiline = True
        Me.matriks2Text.Name = "matriks2Text"
        Me.matriks2Text.Size = New System.Drawing.Size(340, 75)
        Me.matriks2Text.TabIndex = 18
        '
        'operasiCombo
        '
        Me.operasiCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.operasiCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.operasiCombo.FormattingEnabled = True
        Me.operasiCombo.Items.AddRange(New Object() {"Tambah", "Kurang"})
        Me.operasiCombo.Location = New System.Drawing.Point(88, 97)
        Me.operasiCombo.Name = "operasiCombo"
        Me.operasiCombo.Size = New System.Drawing.Size(340, 21)
        Me.operasiCombo.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Operasi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Matriks 1"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 402)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.hasilText)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.matriks1Text)
        Me.Controls.Add(Me.hitungButton)
        Me.Controls.Add(Me.matriks2Text)
        Me.Controls.Add(Me.operasiCombo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriks Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents hasilText As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents matriks1Text As System.Windows.Forms.TextBox
    Friend WithEvents hitungButton As System.Windows.Forms.Button
    Friend WithEvents matriks2Text As System.Windows.Forms.TextBox
    Friend WithEvents operasiCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
