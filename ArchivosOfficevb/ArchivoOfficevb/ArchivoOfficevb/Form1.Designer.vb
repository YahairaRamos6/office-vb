<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Ptbword = New System.Windows.Forms.PictureBox()
        Me.PtbExcel = New System.Windows.Forms.PictureBox()
        CType(Me.Ptbword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtbExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Location = New System.Drawing.Point(-2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(442, 33)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Archivos Office"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Texto a guardar:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 31)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Guardar como:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(46, 158)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(312, 26)
        Me.TextBox1.TabIndex = 4
        '
        'Ptbword
        '
        Me.Ptbword.Image = CType(resources.GetObject("Ptbword.Image"), System.Drawing.Image)
        Me.Ptbword.Location = New System.Drawing.Point(46, 257)
        Me.Ptbword.Name = "Ptbword"
        Me.Ptbword.Size = New System.Drawing.Size(58, 50)
        Me.Ptbword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ptbword.TabIndex = 10
        Me.Ptbword.TabStop = False
        '
        'PtbExcel
        '
        Me.PtbExcel.Image = CType(resources.GetObject("PtbExcel.Image"), System.Drawing.Image)
        Me.PtbExcel.Location = New System.Drawing.Point(151, 257)
        Me.PtbExcel.Name = "PtbExcel"
        Me.PtbExcel.Size = New System.Drawing.Size(58, 50)
        Me.PtbExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PtbExcel.TabIndex = 11
        Me.PtbExcel.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 354)
        Me.Controls.Add(Me.PtbExcel)
        Me.Controls.Add(Me.Ptbword)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Ptbword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtbExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Private WithEvents Ptbword As PictureBox
    Private WithEvents PtbExcel As PictureBox
End Class
