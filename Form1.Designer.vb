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
        Label4 = New Label()
        Label5 = New Label()
        maleRadio = New RadioButton()
        femaleRadio = New RadioButton()
        ageInput = New TextBox()
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
        Button1.Location = New Point(32, 250)
        Button1.Name = "Button1"
        Button1.Size = New Size(130, 51)
        Button1.TabIndex = 6
        Button1.Text = "Calculate"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft JhengHei", 10.2F)
        Label4.ForeColor = Color.Blue
        Label4.Location = New Point(32, 163)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 22)
        Label4.TabIndex = 7
        Label4.Text = "Age"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft JhengHei", 10.2F)
        Label5.ForeColor = Color.Blue
        Label5.Location = New Point(32, 210)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 22)
        Label5.TabIndex = 8
        Label5.Text = "Gender"
        ' 
        ' maleRadio
        ' 
        maleRadio.AutoSize = True
        maleRadio.Location = New Point(257, 210)
        maleRadio.Name = "maleRadio"
        maleRadio.Size = New Size(63, 24)
        maleRadio.TabIndex = 9
        maleRadio.TabStop = True
        maleRadio.Text = "Male"
        maleRadio.UseVisualStyleBackColor = True
        ' 
        ' femaleRadio
        ' 
        femaleRadio.AutoSize = True
        femaleRadio.Location = New Point(340, 210)
        femaleRadio.Name = "femaleRadio"
        femaleRadio.Size = New Size(78, 24)
        femaleRadio.TabIndex = 10
        femaleRadio.TabStop = True
        femaleRadio.Text = "Female"
        femaleRadio.UseVisualStyleBackColor = True
        ' 
        ' ageInput
        ' 
        ageInput.Location = New Point(257, 163)
        ageInput.Name = "ageInput"
        ageInput.Size = New Size(125, 27)
        ageInput.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.HighlightText
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(791, 400)
        Controls.Add(ageInput)
        Controls.Add(femaleRadio)
        Controls.Add(maleRadio)
        Controls.Add(Label5)
        Controls.Add(Label4)
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents maleRadio As RadioButton
    Friend WithEvents femaleRadio As RadioButton
    Friend WithEvents ageInput As TextBox

End Class
