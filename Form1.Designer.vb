<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lblConversion = New System.Windows.Forms.Label()
        Me.txtConversion = New System.Windows.Forms.TextBox()
        Me.lblrespuesta = New System.Windows.Forms.Label()
        Me.lblConversiondemonedas = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.cboMonedas = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(12, 86)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lblCantidad.TabIndex = 0
        Me.lblCantidad.Text = "Cantidad"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(85, 86)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 1
        '
        'lblConversion
        '
        Me.lblConversion.AutoSize = True
        Me.lblConversion.Location = New System.Drawing.Point(427, 94)
        Me.lblConversion.Name = "lblConversion"
        Me.lblConversion.Size = New System.Drawing.Size(60, 13)
        Me.lblConversion.TabIndex = 2
        Me.lblConversion.Text = "Conversion"
        '
        'txtConversion
        '
        Me.txtConversion.Location = New System.Drawing.Point(506, 89)
        Me.txtConversion.Name = "txtConversion"
        Me.txtConversion.Size = New System.Drawing.Size(100, 20)
        Me.txtConversion.TabIndex = 3
        '
        'lblrespuesta
        '
        Me.lblrespuesta.AutoSize = True
        Me.lblrespuesta.Location = New System.Drawing.Point(612, 92)
        Me.lblrespuesta.Name = "lblrespuesta"
        Me.lblrespuesta.Size = New System.Drawing.Size(58, 13)
        Me.lblrespuesta.TabIndex = 4
        Me.lblrespuesta.Text = "Respuesta"
        '
        'lblConversiondemonedas
        '
        Me.lblConversiondemonedas.AutoSize = True
        Me.lblConversiondemonedas.Location = New System.Drawing.Point(248, 22)
        Me.lblConversiondemonedas.Name = "lblConversiondemonedas"
        Me.lblConversiondemonedas.Size = New System.Drawing.Size(121, 13)
        Me.lblConversiondemonedas.TabIndex = 5
        Me.lblConversiondemonedas.Text = "Conversion de monedas"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(276, 148)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 6
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'cboMonedas
        '
        Me.cboMonedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonedas.FormattingEnabled = True
        Me.cboMonedas.Items.AddRange(New Object() {"Peso", "Quetzal", "Lempira", "Euro", "Yen", "Balboa", "Libra esterlina", "Colon costarricense", "Cordoba", "Bolivar"})
        Me.cboMonedas.Location = New System.Drawing.Point(251, 86)
        Me.cboMonedas.Name = "cboMonedas"
        Me.cboMonedas.Size = New System.Drawing.Size(121, 21)
        Me.cboMonedas.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cboMonedas)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.lblConversiondemonedas)
        Me.Controls.Add(Me.lblrespuesta)
        Me.Controls.Add(Me.txtConversion)
        Me.Controls.Add(Me.lblConversion)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.lblCantidad)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCantidad As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents lblConversion As Label
    Friend WithEvents txtConversion As TextBox
    Friend WithEvents lblrespuesta As Label
    Friend WithEvents lblConversiondemonedas As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents cboMonedas As ComboBox
End Class
