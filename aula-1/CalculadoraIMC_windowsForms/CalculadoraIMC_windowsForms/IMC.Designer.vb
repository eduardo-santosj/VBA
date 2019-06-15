<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMC
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtPeso = New System.Windows.Forms.TextBox()
        Me.LblPeso = New System.Windows.Forms.Label()
        Me.LblAltura = New System.Windows.Forms.Label()
        Me.TxtAltura = New System.Windows.Forms.TextBox()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.LblImc = New System.Windows.Forms.Label()
        Me.LblNome = New System.Windows.Forms.Label()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.LblResultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtPeso
        '
        Me.TxtPeso.Location = New System.Drawing.Point(64, 108)
        Me.TxtPeso.Name = "TxtPeso"
        Me.TxtPeso.Size = New System.Drawing.Size(100, 20)
        Me.TxtPeso.TabIndex = 0
        '
        'LblPeso
        '
        Me.LblPeso.AutoSize = True
        Me.LblPeso.Location = New System.Drawing.Point(72, 92)
        Me.LblPeso.Name = "LblPeso"
        Me.LblPeso.Size = New System.Drawing.Size(34, 13)
        Me.LblPeso.TabIndex = 1
        Me.LblPeso.Text = "Peso:"
        '
        'LblAltura
        '
        Me.LblAltura.AutoSize = True
        Me.LblAltura.Location = New System.Drawing.Point(209, 92)
        Me.LblAltura.Name = "LblAltura"
        Me.LblAltura.Size = New System.Drawing.Size(37, 13)
        Me.LblAltura.TabIndex = 2
        Me.LblAltura.Text = "Altura:"
        '
        'TxtAltura
        '
        Me.TxtAltura.Location = New System.Drawing.Point(200, 111)
        Me.TxtAltura.Name = "TxtAltura"
        Me.TxtAltura.Size = New System.Drawing.Size(100, 20)
        Me.TxtAltura.TabIndex = 3
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Location = New System.Drawing.Point(64, 165)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(236, 39)
        Me.BtnCalcular.TabIndex = 4
        Me.BtnCalcular.Text = "Calcular IMC"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'LblImc
        '
        Me.LblImc.AutoSize = True
        Me.LblImc.Location = New System.Drawing.Point(12, 240)
        Me.LblImc.Name = "LblImc"
        Me.LblImc.Size = New System.Drawing.Size(24, 13)
        Me.LblImc.TabIndex = 5
        Me.LblImc.Text = "Imc"
        '
        'LblNome
        '
        Me.LblNome.AutoSize = True
        Me.LblNome.Location = New System.Drawing.Point(72, 31)
        Me.LblNome.Name = "LblNome"
        Me.LblNome.Size = New System.Drawing.Size(35, 13)
        Me.LblNome.TabIndex = 6
        Me.LblNome.Text = "Nome"
        '
        'TxtNome
        '
        Me.TxtNome.Location = New System.Drawing.Point(64, 47)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(236, 20)
        Me.TxtNome.TabIndex = 7
        '
        'LblResultado
        '
        Me.LblResultado.AutoSize = True
        Me.LblResultado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblResultado.Location = New System.Drawing.Point(124, 239)
        Me.LblResultado.Name = "LblResultado"
        Me.LblResultado.Size = New System.Drawing.Size(55, 13)
        Me.LblResultado.TabIndex = 8
        Me.LblResultado.Text = "Resultado"
        '
        'IMC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 319)
        Me.Controls.Add(Me.LblResultado)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.LblNome)
        Me.Controls.Add(Me.LblImc)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.TxtAltura)
        Me.Controls.Add(Me.LblAltura)
        Me.Controls.Add(Me.LblPeso)
        Me.Controls.Add(Me.TxtPeso)
        Me.Name = "IMC"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtPeso As TextBox
    Friend WithEvents LblPeso As Label
    Friend WithEvents LblAltura As Label
    Friend WithEvents TxtAltura As TextBox
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents LblImc As Label
    Friend WithEvents LblNome As Label
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents LblResultado As Label
End Class
