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
        Label1 = New Label()
        lblResultado = New Label()
        btnRojo = New Button()
        btnAzul = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(274, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(218, 83)
        Label1.TabIndex = 7
        Label1.Text = "Selecciona un color"' 
        ' lblResultado
        ' 
        lblResultado.Location = New Point(168, 288)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(501, 104)
        lblResultado.TabIndex = 6
        ' 
        ' btnRojo
        ' 
        btnRojo.Location = New Point(539, 194)
        btnRojo.Name = "btnRojo"
        btnRojo.Size = New Size(94, 29)
        btnRojo.TabIndex = 5
        btnRojo.Text = "Rojo"
        btnRojo.UseVisualStyleBackColor = True
        ' 
        ' btnAzul
        ' 
        btnAzul.Location = New Point(132, 194)
        btnAzul.Name = "btnAzul"
        btnAzul.Size = New Size(94, 29)
        btnAzul.TabIndex = 4
        btnAzul.Text = "Azul"
        btnAzul.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(lblResultado)
        Controls.Add(btnRojo)
        Controls.Add(btnAzul)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents btnRojo As Button
    Friend WithEvents btnAzul As Button
End Class
