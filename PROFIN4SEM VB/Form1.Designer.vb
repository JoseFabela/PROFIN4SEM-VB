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
        Me.btnSaveToJson = New System.Windows.Forms.Button()
        Me.btnLoadFile = New System.Windows.Forms.Button()
        Me.btnLoadFromDatabase = New System.Windows.Forms.Button()
        Me.btnSaveToDatabase = New System.Windows.Forms.Button()
        Me.btnSaveToXML = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnSaveToCSV = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSaveToJson
        '
        Me.btnSaveToJson.Location = New System.Drawing.Point(600, 250)
        Me.btnSaveToJson.Name = "btnSaveToJson"
        Me.btnSaveToJson.Size = New System.Drawing.Size(121, 23)
        Me.btnSaveToJson.TabIndex = 15
        Me.btnSaveToJson.Text = "SaveToJSON"
        Me.btnSaveToJson.UseVisualStyleBackColor = True
        '
        'btnLoadFile
        '
        Me.btnLoadFile.Location = New System.Drawing.Point(79, 345)
        Me.btnLoadFile.Name = "btnLoadFile"
        Me.btnLoadFile.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadFile.TabIndex = 14
        Me.btnLoadFile.Text = "LoadFile"
        Me.btnLoadFile.UseVisualStyleBackColor = True
        '
        'btnLoadFromDatabase
        '
        Me.btnLoadFromDatabase.Location = New System.Drawing.Point(362, 345)
        Me.btnLoadFromDatabase.Name = "btnLoadFromDatabase"
        Me.btnLoadFromDatabase.Size = New System.Drawing.Size(143, 23)
        Me.btnLoadFromDatabase.TabIndex = 13
        Me.btnLoadFromDatabase.Text = "LoadFromDatabase"
        Me.btnLoadFromDatabase.UseVisualStyleBackColor = True
        '
        'btnSaveToDatabase
        '
        Me.btnSaveToDatabase.Location = New System.Drawing.Point(194, 345)
        Me.btnSaveToDatabase.Name = "btnSaveToDatabase"
        Me.btnSaveToDatabase.Size = New System.Drawing.Size(151, 23)
        Me.btnSaveToDatabase.TabIndex = 12
        Me.btnSaveToDatabase.Text = "SaveToDatabase"
        Me.btnSaveToDatabase.UseVisualStyleBackColor = True
        '
        'btnSaveToXML
        '
        Me.btnSaveToXML.Location = New System.Drawing.Point(600, 206)
        Me.btnSaveToXML.Name = "btnSaveToXML"
        Me.btnSaveToXML.Size = New System.Drawing.Size(121, 23)
        Me.btnSaveToXML.TabIndex = 11
        Me.btnSaveToXML.Text = "SaveToXML"
        Me.btnSaveToXML.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(600, 293)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Add Row"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnSaveToCSV
        '
        Me.btnSaveToCSV.Location = New System.Drawing.Point(600, 155)
        Me.btnSaveToCSV.Name = "btnSaveToCSV"
        Me.btnSaveToCSV.Size = New System.Drawing.Size(121, 23)
        Me.btnSaveToCSV.TabIndex = 9
        Me.btnSaveToCSV.Text = "SaveToCSV"
        Me.btnSaveToCSV.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(155, 82)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(387, 234)
        Me.DataGridView2.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSaveToJson)
        Me.Controls.Add(Me.btnLoadFile)
        Me.Controls.Add(Me.btnLoadFromDatabase)
        Me.Controls.Add(Me.btnSaveToDatabase)
        Me.Controls.Add(Me.btnSaveToXML)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSaveToCSV)
        Me.Controls.Add(Me.DataGridView2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSaveToJson As Button
    Friend WithEvents btnLoadFile As Button
    Friend WithEvents btnLoadFromDatabase As Button
    Friend WithEvents btnSaveToDatabase As Button
    Friend WithEvents btnSaveToXML As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnSaveToCSV As Button
    Friend WithEvents DataGridView2 As DataGridView
End Class
