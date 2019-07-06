<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jogoDaForca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(jogoDaForca))
        Me.PBX_cabeca = New System.Windows.Forms.PictureBox()
        Me.PBX_tronco = New System.Windows.Forms.PictureBox()
        Me.PBX_braco_esq = New System.Windows.Forms.PictureBox()
        Me.PBX_braco_dir = New System.Windows.Forms.PictureBox()
        Me.PBX_perna_esq = New System.Windows.Forms.PictureBox()
        Me.PBX_perna_dir = New System.Windows.Forms.PictureBox()
        Me.TXT_letra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_letras_error = New System.Windows.Forms.TextBox()
        Me.TXT_acertos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PBX_cabeca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBX_tronco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBX_braco_esq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBX_braco_dir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBX_perna_esq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBX_perna_dir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBX_cabeca
        '
        Me.PBX_cabeca.BackgroundImage = Global.jogoDaForca.My.Resources.Resources.cabeca
        Me.PBX_cabeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PBX_cabeca.Location = New System.Drawing.Point(480, 139)
        Me.PBX_cabeca.Name = "PBX_cabeca"
        Me.PBX_cabeca.Size = New System.Drawing.Size(122, 132)
        Me.PBX_cabeca.TabIndex = 0
        Me.PBX_cabeca.TabStop = False
        '
        'PBX_tronco
        '
        Me.PBX_tronco.BackgroundImage = Global.jogoDaForca.My.Resources.Resources.Tronco
        Me.PBX_tronco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PBX_tronco.Location = New System.Drawing.Point(532, 271)
        Me.PBX_tronco.Name = "PBX_tronco"
        Me.PBX_tronco.Size = New System.Drawing.Size(15, 134)
        Me.PBX_tronco.TabIndex = 1
        Me.PBX_tronco.TabStop = False
        '
        'PBX_braco_esq
        '
        Me.PBX_braco_esq.BackgroundImage = Global.jogoDaForca.My.Resources.Resources.bracoEsquerdo
        Me.PBX_braco_esq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PBX_braco_esq.Location = New System.Drawing.Point(457, 288)
        Me.PBX_braco_esq.Name = "PBX_braco_esq"
        Me.PBX_braco_esq.Size = New System.Drawing.Size(74, 86)
        Me.PBX_braco_esq.TabIndex = 2
        Me.PBX_braco_esq.TabStop = False
        '
        'PBX_braco_dir
        '
        Me.PBX_braco_dir.BackgroundImage = Global.jogoDaForca.My.Resources.Resources.bracoDireito
        Me.PBX_braco_dir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PBX_braco_dir.Location = New System.Drawing.Point(542, 277)
        Me.PBX_braco_dir.Name = "PBX_braco_dir"
        Me.PBX_braco_dir.Size = New System.Drawing.Size(64, 77)
        Me.PBX_braco_dir.TabIndex = 3
        Me.PBX_braco_dir.TabStop = False
        '
        'PBX_perna_esq
        '
        Me.PBX_perna_esq.BackgroundImage = Global.jogoDaForca.My.Resources.Resources.pernaEsquerda
        Me.PBX_perna_esq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PBX_perna_esq.Location = New System.Drawing.Point(458, 381)
        Me.PBX_perna_esq.Name = "PBX_perna_esq"
        Me.PBX_perna_esq.Size = New System.Drawing.Size(74, 94)
        Me.PBX_perna_esq.TabIndex = 4
        Me.PBX_perna_esq.TabStop = False
        '
        'PBX_perna_dir
        '
        Me.PBX_perna_dir.BackgroundImage = Global.jogoDaForca.My.Resources.Resources.pernaDireita
        Me.PBX_perna_dir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PBX_perna_dir.Location = New System.Drawing.Point(541, 381)
        Me.PBX_perna_dir.Name = "PBX_perna_dir"
        Me.PBX_perna_dir.Size = New System.Drawing.Size(65, 78)
        Me.PBX_perna_dir.TabIndex = 5
        Me.PBX_perna_dir.TabStop = False
        '
        'TXT_letra
        '
        Me.TXT_letra.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_letra.Location = New System.Drawing.Point(501, 592)
        Me.TXT_letra.Name = "TXT_letra"
        Me.TXT_letra.Size = New System.Drawing.Size(60, 38)
        Me.TXT_letra.TabIndex = 6
        Me.TXT_letra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 430)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 21)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Tentativas"
        '
        'TXT_letras_error
        '
        Me.TXT_letras_error.Location = New System.Drawing.Point(78, 454)
        Me.TXT_letras_error.Multiline = True
        Me.TXT_letras_error.Name = "TXT_letras_error"
        Me.TXT_letras_error.ReadOnly = True
        Me.TXT_letras_error.Size = New System.Drawing.Size(97, 176)
        Me.TXT_letras_error.TabIndex = 9
        '
        'TXT_acertos
        '
        Me.TXT_acertos.Location = New System.Drawing.Point(404, 521)
        Me.TXT_acertos.Multiline = True
        Me.TXT_acertos.Name = "TXT_acertos"
        Me.TXT_acertos.ReadOnly = True
        Me.TXT_acertos.Size = New System.Drawing.Size(246, 39)
        Me.TXT_acertos.TabIndex = 10
        Me.TXT_acertos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(361, 604)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 21)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Tente a Letra:"
        '
        'jogoDaForca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.jogoDaForca.My.Resources.Resources.fundo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(871, 701)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_acertos)
        Me.Controls.Add(Me.TXT_letras_error)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_letra)
        Me.Controls.Add(Me.PBX_tronco)
        Me.Controls.Add(Me.PBX_perna_dir)
        Me.Controls.Add(Me.PBX_perna_esq)
        Me.Controls.Add(Me.PBX_braco_dir)
        Me.Controls.Add(Me.PBX_braco_esq)
        Me.Controls.Add(Me.PBX_cabeca)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(887, 740)
        Me.MinimumSize = New System.Drawing.Size(887, 740)
        Me.Name = "jogoDaForca"
        Me.Text = "Forca"
        CType(Me.PBX_cabeca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBX_tronco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBX_braco_esq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBX_braco_dir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBX_perna_esq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBX_perna_dir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBX_cabeca As PictureBox
    Friend WithEvents PBX_tronco As PictureBox
    Friend WithEvents PBX_braco_esq As PictureBox
    Friend WithEvents PBX_braco_dir As PictureBox
    Friend WithEvents PBX_perna_esq As PictureBox
    Friend WithEvents PBX_perna_dir As PictureBox
    Friend WithEvents TXT_letra As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_letras_error As TextBox
    Friend WithEvents TXT_acertos As TextBox
    Friend WithEvents Label2 As Label
End Class
