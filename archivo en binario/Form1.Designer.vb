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
        btnLeer = New Button()
        btnGuardar = New Button()
        txtEdad = New TextBox()
        txtNombre = New TextBox()
        chkActivo = New CheckBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' btnLeer
        ' 
        btnLeer.Location = New Point(337, 210)
        btnLeer.Name = "btnLeer"
        btnLeer.Size = New Size(75, 23)
        btnLeer.TabIndex = 0
        btnLeer.Text = "leer"
        btnLeer.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(440, 210)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 23)
        btnGuardar.TabIndex = 1
        btnGuardar.Text = "guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' txtEdad
        ' 
        txtEdad.Location = New Point(201, 128)
        txtEdad.Name = "txtEdad"
        txtEdad.Size = New Size(100, 23)
        txtEdad.TabIndex = 2
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(201, 97)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(363, 23)
        txtNombre.TabIndex = 3
        ' 
        ' chkActivo
        ' 
        chkActivo.AutoSize = True
        chkActivo.Location = New Point(337, 185)
        chkActivo.Name = "chkActivo"
        chkActivo.Size = New Size(85, 19)
        chkActivo.TabIndex = 4
        chkActivo.Text = "CheckBox1"
        chkActivo.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(131, 105)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 5
        Label1.Text = "Nombre"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(131, 136)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 6
        Label2.Text = "telefono"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(chkActivo)
        Controls.Add(txtNombre)
        Controls.Add(txtEdad)
        Controls.Add(btnGuardar)
        Controls.Add(btnLeer)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLeer As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
