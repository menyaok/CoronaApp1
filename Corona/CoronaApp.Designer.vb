<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoronaApp
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
        Me.btnData = New System.Windows.Forms.Button()
        Me.txtOutputTotal = New System.Windows.Forms.Label()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOutputDaily = New System.Windows.Forms.Label()
        Me.txtOutputTotal14 = New System.Windows.Forms.Label()
        Me.txtOutputPerPop = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtOutputLast = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbMaakond = New System.Windows.Forms.ComboBox()
        Me.lblMaakond = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtOutputNext = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnData
        '
        Me.btnData.Location = New System.Drawing.Point(164, 173)
        Me.btnData.Name = "btnData"
        Me.btnData.Size = New System.Drawing.Size(75, 23)
        Me.btnData.TabIndex = 0
        Me.btnData.Text = "Find"
        Me.btnData.UseVisualStyleBackColor = True
        '
        'txtOutputTotal
        '
        Me.txtOutputTotal.AutoSize = True
        Me.txtOutputTotal.Location = New System.Drawing.Point(395, 161)
        Me.txtOutputTotal.Name = "txtOutputTotal"
        Me.txtOutputTotal.Size = New System.Drawing.Size(13, 13)
        Me.txtOutputTotal.TabIndex = 1
        Me.txtOutputTotal.Text = "0"
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(164, 132)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(87, 20)
        Me.txtData.TabIndex = 2
        Me.txtData.Text = "2020-03-20"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(142, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Insert Data(yyyy-mm-dd)"
        '
        'txtOutputDaily
        '
        Me.txtOutputDaily.AutoSize = True
        Me.txtOutputDaily.Location = New System.Drawing.Point(395, 139)
        Me.txtOutputDaily.Name = "txtOutputDaily"
        Me.txtOutputDaily.Size = New System.Drawing.Size(13, 13)
        Me.txtOutputDaily.TabIndex = 5
        Me.txtOutputDaily.Text = "0"
        '
        'txtOutputTotal14
        '
        Me.txtOutputTotal14.AutoSize = True
        Me.txtOutputTotal14.Location = New System.Drawing.Point(395, 183)
        Me.txtOutputTotal14.Name = "txtOutputTotal14"
        Me.txtOutputTotal14.Size = New System.Drawing.Size(13, 13)
        Me.txtOutputTotal14.TabIndex = 6
        Me.txtOutputTotal14.Text = "0"
        '
        'txtOutputPerPop
        '
        Me.txtOutputPerPop.AutoSize = True
        Me.txtOutputPerPop.Location = New System.Drawing.Point(395, 230)
        Me.txtOutputPerPop.Name = "txtOutputPerPop"
        Me.txtOutputPerPop.Size = New System.Drawing.Size(13, 13)
        Me.txtOutputPerPop.TabIndex = 7
        Me.txtOutputPerPop.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(324, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Daily Cases:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(278, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Cases Per Population:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(323, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total Cases:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(290, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Total Cases In 14d:"
        '
        'txtOutputLast
        '
        Me.txtOutputLast.AutoSize = True
        Me.txtOutputLast.Location = New System.Drawing.Point(395, 207)
        Me.txtOutputLast.Name = "txtOutputLast"
        Me.txtOutputLast.Size = New System.Drawing.Size(13, 13)
        Me.txtOutputLast.TabIndex = 12
        Me.txtOutputLast.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(288, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Last Statistics Date:"
        '
        'cbMaakond
        '
        Me.cbMaakond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMaakond.FormattingEnabled = True
        Me.cbMaakond.Items.AddRange(New Object() {"Eesti", "Harju maakond", "Hiiu maakond", "Ida-Viru maakond", "Järva maakond", "Jõgeva maakond", "Lääne maakond", "Lääne-Viru maakond", "Pärnu maakond", "Põlva maakond", "Rapla maakond", "Saare maakond", "Tartu maakond", "Valga maakond", "Viljandi maakond", "Võru maakond"})
        Me.cbMaakond.Location = New System.Drawing.Point(145, 269)
        Me.cbMaakond.Name = "cbMaakond"
        Me.cbMaakond.Size = New System.Drawing.Size(121, 21)
        Me.cbMaakond.TabIndex = 14
        '
        'lblMaakond
        '
        Me.lblMaakond.AutoSize = True
        Me.lblMaakond.Location = New System.Drawing.Point(337, 77)
        Me.lblMaakond.Name = "lblMaakond"
        Me.lblMaakond.Size = New System.Drawing.Size(52, 13)
        Me.lblMaakond.TabIndex = 15
        Me.lblMaakond.Text = "Maakond"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(442, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Next Day Cases:"
        '
        'txtOutputNext
        '
        Me.txtOutputNext.AutoSize = True
        Me.txtOutputNext.Location = New System.Drawing.Point(534, 161)
        Me.txtOutputNext.Name = "txtOutputNext"
        Me.txtOutputNext.Size = New System.Drawing.Size(13, 13)
        Me.txtOutputNext.TabIndex = 17
        Me.txtOutputNext.Text = "0"
        '
        'CoronaApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtOutputNext)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblMaakond)
        Me.Controls.Add(Me.cbMaakond)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtOutputLast)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtOutputPerPop)
        Me.Controls.Add(Me.txtOutputTotal14)
        Me.Controls.Add(Me.txtOutputDaily)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.txtOutputTotal)
        Me.Controls.Add(Me.btnData)
        Me.Name = "CoronaApp"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnData As Button
    Friend WithEvents txtOutputTotal As Label
    Friend WithEvents txtData As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtOutputDaily As Label
    Friend WithEvents txtOutputTotal14 As Label
    Friend WithEvents txtOutputPerPop As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtOutputLast As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbMaakond As ComboBox
    Friend WithEvents lblMaakond As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtOutputNext As Label
End Class
