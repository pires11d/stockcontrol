<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewProductForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewProductForm))
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cbbKind = New System.Windows.Forms.ComboBox()
        Me.cbbVendor = New System.Windows.Forms.ComboBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.tbCost = New System.Windows.Forms.TextBox()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(77, 332)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(138, 49)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Adicionar"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'cbbKind
        '
        Me.cbbKind.FormattingEnabled = True
        Me.cbbKind.Location = New System.Drawing.Point(130, 17)
        Me.cbbKind.Name = "cbbKind"
        Me.cbbKind.Size = New System.Drawing.Size(146, 30)
        Me.cbbKind.TabIndex = 1
        '
        'cbbVendor
        '
        Me.cbbVendor.FormattingEnabled = True
        Me.cbbVendor.Location = New System.Drawing.Point(130, 65)
        Me.cbbVendor.Name = "cbbVendor"
        Me.cbbVendor.Size = New System.Drawing.Size(146, 30)
        Me.cbbVendor.TabIndex = 1
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(130, 113)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(146, 31)
        Me.tbName.TabIndex = 2
        '
        'tbCost
        '
        Me.tbCost.Location = New System.Drawing.Point(192, 174)
        Me.tbCost.Name = "tbCost"
        Me.tbCost.Size = New System.Drawing.Size(84, 31)
        Me.tbCost.TabIndex = 2
        '
        'tbPrice
        '
        Me.tbPrice.Location = New System.Drawing.Point(192, 220)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(84, 31)
        Me.tbPrice.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Custo unitário:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Preço unitário:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tipo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Marca:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 22)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Produto:"
        '
        'lblCode
        '
        Me.lblCode.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(-1, 281)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(293, 22)
        Me.lblCode.TabIndex = 3
        Me.lblCode.Text = "-"
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NewProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 395)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbPrice)
        Me.Controls.Add(Me.tbCost)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.cbbVendor)
        Me.Controls.Add(Me.cbbKind)
        Me.Controls.Add(Me.btnAdd)
        Me.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "NewProductForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adicionar Novo Produto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents cbbKind As ComboBox
    Friend WithEvents cbbVendor As ComboBox
    Friend WithEvents tbName As TextBox
    Friend WithEvents tbCost As TextBox
    Friend WithEvents tbPrice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCode As Label
End Class
