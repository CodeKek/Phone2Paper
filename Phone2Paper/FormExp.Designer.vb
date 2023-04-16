<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormExp
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btTest = New System.Windows.Forms.Button()
        Me.btExposure = New System.Windows.Forms.Button()
        Me.btZout = New System.Windows.Forms.Button()
        Me.btLeft = New System.Windows.Forms.Button()
        Me.btRight = New System.Windows.Forms.Button()
        Me.btZin = New System.Windows.Forms.Button()
        Me.btExpMin = New System.Windows.Forms.Button()
        Me.btExpPlu = New System.Windows.Forms.Button()
        Me.btGamMin = New System.Windows.Forms.Button()
        Me.btGamPlu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btDown = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bt100 = New System.Windows.Forms.Button()
        Me.btUp = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1037, 548)
        Me.Panel1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 13
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btTest, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btExposure, 7, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btZout, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btUp, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btLeft, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.btRight, 5, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.btZin, 5, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btExpMin, 7, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btExpPlu, 11, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btGamMin, 7, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.btGamPlu, 11, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 9, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 9, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.btDown, 3, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.bt100, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 5, 7)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1037, 548)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'btTest
        '
        Me.btTest.BackColor = System.Drawing.Color.Black
        Me.TableLayoutPanel1.SetColumnSpan(Me.btTest, 5)
        Me.btTest.Dock = System.Windows.Forms.DockStyle.Top
        Me.btTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTest.ForeColor = System.Drawing.Color.Red
        Me.btTest.Location = New System.Drawing.Point(23, 23)
        Me.btTest.Name = "btTest"
        Me.btTest.Size = New System.Drawing.Size(472, 106)
        Me.btTest.TabIndex = 1
        Me.btTest.Text = "Test"
        Me.btTest.UseVisualStyleBackColor = False
        '
        'btExposure
        '
        Me.btExposure.BackColor = System.Drawing.Color.Black
        Me.TableLayoutPanel1.SetColumnSpan(Me.btExposure, 5)
        Me.btExposure.Dock = System.Windows.Forms.DockStyle.Top
        Me.btExposure.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btExposure.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btExposure.ForeColor = System.Drawing.Color.Red
        Me.btExposure.Location = New System.Drawing.Point(541, 23)
        Me.btExposure.Name = "btExposure"
        Me.btExposure.Size = New System.Drawing.Size(472, 106)
        Me.btExposure.TabIndex = 7
        Me.btExposure.Text = "Exposure"
        Me.btExposure.UseVisualStyleBackColor = False
        '
        'btZout
        '
        Me.btZout.BackColor = System.Drawing.Color.Black
        Me.btZout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btZout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btZout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btZout.ForeColor = System.Drawing.Color.Red
        Me.btZout.Location = New System.Drawing.Point(23, 155)
        Me.btZout.Name = "btZout"
        Me.btZout.Size = New System.Drawing.Size(140, 106)
        Me.btZout.TabIndex = 8
        Me.btZout.Text = "Zoom" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "out"
        Me.btZout.UseVisualStyleBackColor = False
        '
        'btLeft
        '
        Me.btLeft.BackColor = System.Drawing.Color.Black
        Me.btLeft.Dock = System.Windows.Forms.DockStyle.Top
        Me.btLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btLeft.Font = New System.Drawing.Font("Symbol", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btLeft.ForeColor = System.Drawing.Color.Red
        Me.btLeft.Location = New System.Drawing.Point(23, 287)
        Me.btLeft.Name = "btLeft"
        Me.btLeft.Size = New System.Drawing.Size(140, 106)
        Me.btLeft.TabIndex = 10
        Me.btLeft.Text = ""
        Me.btLeft.UseVisualStyleBackColor = False
        '
        'btRight
        '
        Me.btRight.BackColor = System.Drawing.Color.Black
        Me.btRight.Dock = System.Windows.Forms.DockStyle.Top
        Me.btRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btRight.Font = New System.Drawing.Font("Symbol", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btRight.ForeColor = System.Drawing.Color.Red
        Me.btRight.Location = New System.Drawing.Point(355, 287)
        Me.btRight.Name = "btRight"
        Me.btRight.Size = New System.Drawing.Size(140, 106)
        Me.btRight.TabIndex = 12
        Me.btRight.Text = ""
        Me.btRight.UseVisualStyleBackColor = False
        '
        'btZin
        '
        Me.btZin.BackColor = System.Drawing.Color.Black
        Me.btZin.Dock = System.Windows.Forms.DockStyle.Top
        Me.btZin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btZin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btZin.ForeColor = System.Drawing.Color.Red
        Me.btZin.Location = New System.Drawing.Point(355, 155)
        Me.btZin.Name = "btZin"
        Me.btZin.Size = New System.Drawing.Size(140, 106)
        Me.btZin.TabIndex = 13
        Me.btZin.Text = "Zoom" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in"
        Me.btZin.UseVisualStyleBackColor = False
        '
        'btExpMin
        '
        Me.btExpMin.BackColor = System.Drawing.Color.Black
        Me.btExpMin.Dock = System.Windows.Forms.DockStyle.Top
        Me.btExpMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btExpMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btExpMin.ForeColor = System.Drawing.Color.Red
        Me.btExpMin.Location = New System.Drawing.Point(541, 155)
        Me.btExpMin.Name = "btExpMin"
        Me.btExpMin.Size = New System.Drawing.Size(140, 106)
        Me.btExpMin.TabIndex = 14
        Me.btExpMin.Text = "Exp" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-"
        Me.btExpMin.UseVisualStyleBackColor = False
        '
        'btExpPlu
        '
        Me.btExpPlu.BackColor = System.Drawing.Color.Black
        Me.btExpPlu.Dock = System.Windows.Forms.DockStyle.Top
        Me.btExpPlu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btExpPlu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btExpPlu.ForeColor = System.Drawing.Color.Red
        Me.btExpPlu.Location = New System.Drawing.Point(873, 155)
        Me.btExpPlu.Name = "btExpPlu"
        Me.btExpPlu.Size = New System.Drawing.Size(140, 106)
        Me.btExpPlu.TabIndex = 15
        Me.btExpPlu.Text = "Exp" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "+"
        Me.btExpPlu.UseVisualStyleBackColor = False
        '
        'btGamMin
        '
        Me.btGamMin.BackColor = System.Drawing.Color.Black
        Me.btGamMin.Dock = System.Windows.Forms.DockStyle.Top
        Me.btGamMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGamMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGamMin.ForeColor = System.Drawing.Color.Red
        Me.btGamMin.Location = New System.Drawing.Point(541, 287)
        Me.btGamMin.Name = "btGamMin"
        Me.btGamMin.Size = New System.Drawing.Size(140, 106)
        Me.btGamMin.TabIndex = 16
        Me.btGamMin.Text = "Gamma" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-"
        Me.btGamMin.UseVisualStyleBackColor = False
        '
        'btGamPlu
        '
        Me.btGamPlu.BackColor = System.Drawing.Color.Black
        Me.btGamPlu.Dock = System.Windows.Forms.DockStyle.Top
        Me.btGamPlu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGamPlu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGamPlu.ForeColor = System.Drawing.Color.Red
        Me.btGamPlu.Location = New System.Drawing.Point(873, 287)
        Me.btGamPlu.Name = "btGamPlu"
        Me.btGamPlu.Size = New System.Drawing.Size(140, 106)
        Me.btGamPlu.TabIndex = 17
        Me.btGamPlu.Text = "Gamma" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "+"
        Me.btGamPlu.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(707, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 112)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "5 s"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(707, 284)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 112)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "1,0"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btDown
        '
        Me.btDown.BackColor = System.Drawing.Color.Black
        Me.btDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btDown.Font = New System.Drawing.Font("Symbol", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btDown.ForeColor = System.Drawing.Color.Red
        Me.btDown.Location = New System.Drawing.Point(189, 419)
        Me.btDown.Name = "btDown"
        Me.btDown.Size = New System.Drawing.Size(140, 105)
        Me.btDown.TabIndex = 11
        Me.btDown.Text = ""
        Me.btDown.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Wingdings", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(23, 419)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 105)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = ""
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Wingdings", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(355, 419)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(140, 105)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = ""
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'bt100
        '
        Me.bt100.BackColor = System.Drawing.Color.Black
        Me.bt100.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bt100.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt100.Font = New System.Drawing.Font("Symbol", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.bt100.ForeColor = System.Drawing.Color.Red
        Me.bt100.Location = New System.Drawing.Point(189, 287)
        Me.bt100.Name = "bt100"
        Me.bt100.Size = New System.Drawing.Size(140, 106)
        Me.bt100.TabIndex = 20
        Me.bt100.Text = "100 %"
        Me.bt100.UseVisualStyleBackColor = False
        '
        'btUp
        '
        Me.btUp.BackColor = System.Drawing.Color.Black
        Me.btUp.Dock = System.Windows.Forms.DockStyle.Top
        Me.btUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btUp.Font = New System.Drawing.Font("Symbol", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btUp.ForeColor = System.Drawing.Color.Red
        Me.btUp.Location = New System.Drawing.Point(189, 155)
        Me.btUp.Name = "btUp"
        Me.btUp.Size = New System.Drawing.Size(140, 106)
        Me.btUp.TabIndex = 9
        Me.btUp.Text = ""
        Me.btUp.UseVisualStyleBackColor = False
        '
        'FormExp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 548)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormExp"
        Me.Text = "FormExp"
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Public WithEvents btTest As Button
    Public WithEvents btExposure As Button
    Friend WithEvents btZout As Button
    Friend WithEvents btLeft As Button
    Friend WithEvents btDown As Button
    Friend WithEvents btRight As Button
    Friend WithEvents btZin As Button
    Friend WithEvents btExpMin As Button
    Friend WithEvents btExpPlu As Button
    Friend WithEvents btGamMin As Button
    Friend WithEvents btGamPlu As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btUp As Button
    Friend WithEvents bt100 As Button
End Class
