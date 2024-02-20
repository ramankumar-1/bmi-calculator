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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        weightInput = New TextBox()
        heightInput = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        outputDisplay = New RichTextBox()
        SuspendLayout()
        ' 
        ' weightInput
        ' 
        weightInput.Location = New Point(257, 57)
        weightInput.Name = "weightInput"
        weightInput.Size = New Size(125, 27)
        weightInput.TabIndex = 0
        ' 
        ' heightInput
        ' 
        heightInput.Location = New Point(257, 108)
        heightInput.Name = "heightInput"
        heightInput.Size = New Size(125, 27)
        heightInput.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft JhengHei", 10.2F)
        Label2.ForeColor = Color.Blue
        Label2.Location = New Point(32, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(203, 22)
        Label2.TabIndex = 3
        Label2.Text = "Enter your weight (in Kg)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft JhengHei", 10.2F)
        Label3.ForeColor = Color.Blue
        Label3.Location = New Point(32, 115)
        Label3.Name = "Label3"
        Label3.Size = New Size(194, 22)
        Label3.TabIndex = 4
        Label3.Text = "Enter your height (in m)"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Button1.Font = New Font("Bahnschrift", 14F)
        Button1.Location = New Point(32, 186)
        Button1.Name = "Button1"
        Button1.Size = New Size(130, 51)
        Button1.TabIndex = 6
        Button1.Text = "Calculate"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' outputDisplay
        ' 
        outputDisplay.Location = New Point(32, 276)
        outputDisplay.Name = "outputDisplay"
        outputDisplay.Size = New Size(386, 52)
        outputDisplay.TabIndex = 12
        outputDisplay.Text = ""
        outputDisplay.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.HighlightText
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(791, 400)
        Controls.Add(outputDisplay)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(heightInput)
        Controls.Add(weightInput)
        DoubleBuffered = True
        Name = "Form1"
        Text = "BMI Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents weightInput As TextBox
    Friend WithEvents heightInput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents outputDisplay As RichTextBox

End Class
