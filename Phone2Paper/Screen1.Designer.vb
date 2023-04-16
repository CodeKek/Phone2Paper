<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Screen1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btCalibrate = New System.Windows.Forms.Button()
        Me.btExposure = New System.Windows.Forms.Button()
        Me.btImage = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btX = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Black
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1094, 603)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 9
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.76471!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btX, 8, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btCalibrate, 5, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btExposure, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btImage, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 7, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1088, 62)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'btCalibrate
        '
        Me.btCalibrate.BackColor = System.Drawing.Color.Black
        Me.btCalibrate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btCalibrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCalibrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCalibrate.ForeColor = System.Drawing.Color.Red
        Me.btCalibrate.Location = New System.Drawing.Point(641, 11)
        Me.btCalibrate.Name = "btCalibrate"
        Me.btCalibrate.Size = New System.Drawing.Size(283, 40)
        Me.btCalibrate.TabIndex = 4
        Me.btCalibrate.Text = "Calibrate"
        Me.btCalibrate.UseVisualStyleBackColor = False
        '
        'btExposure
        '
        Me.btExposure.BackColor = System.Drawing.Color.Black
        Me.btExposure.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btExposure.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btExposure.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btExposure.ForeColor = System.Drawing.Color.Red
        Me.btExposure.Location = New System.Drawing.Point(332, 11)
        Me.btExposure.Name = "btExposure"
        Me.btExposure.Size = New System.Drawing.Size(283, 40)
        Me.btExposure.TabIndex = 2
        Me.btExposure.Text = "Exposure"
        Me.btExposure.UseVisualStyleBackColor = False
        '
        'btImage
        '
        Me.btImage.BackColor = System.Drawing.Color.Black
        Me.btImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btImage.ForeColor = System.Drawing.Color.Red
        Me.btImage.Location = New System.Drawing.Point(23, 11)
        Me.btImage.Name = "btImage"
        Me.btImage.Size = New System.Drawing.Size(283, 40)
        Me.btImage.TabIndex = 1
        Me.btImage.Text = "Image"
        Me.btImage.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(950, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 46)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "--:--"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'btX
        '
        Me.btX.BackColor = System.Drawing.Color.Black
        Me.btX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btX.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btX.ForeColor = System.Drawing.Color.Red
        Me.btX.Location = New System.Drawing.Point(1065, 11)
        Me.btX.Name = "btX"
        Me.btX.Size = New System.Drawing.Size(20, 40)
        Me.btX.TabIndex = 6
        Me.btX.Text = "x"
        Me.btX.UseVisualStyleBackColor = False
        '
        'Screen1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 603)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Screen1"
        Me.Text = "Screen1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btImage As Button
    Friend WithEvents btExposure As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btCalibrate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btX As Button
End Class
