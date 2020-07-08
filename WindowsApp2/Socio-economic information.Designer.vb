<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Socio_economic_information
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Marital_Status = New System.Windows.Forms.ComboBox()
        Me.Industry_Employed = New System.Windows.Forms.ComboBox()
        Me.Employment_Status = New System.Windows.Forms.ComboBox()
        Me.No_Dependents = New System.Windows.Forms.TextBox()
        Me.Id_guardian = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employment Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Industry Employed"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No Dependents"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Guardian"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Marital Status"
        '
        'Marital_Status
        '
        Me.Marital_Status.FormattingEnabled = True
        Me.Marital_Status.Items.AddRange(New Object() {"married", "single", "divorced"})
        Me.Marital_Status.Location = New System.Drawing.Point(186, 244)
        Me.Marital_Status.Name = "Marital_Status"
        Me.Marital_Status.Size = New System.Drawing.Size(121, 21)
        Me.Marital_Status.TabIndex = 5
        '
        'Industry_Employed
        '
        Me.Industry_Employed.FormattingEnabled = True
        Me.Industry_Employed.Items.AddRange(New Object() {"formal-sector", "informal-sector"})
        Me.Industry_Employed.Location = New System.Drawing.Point(186, 74)
        Me.Industry_Employed.Name = "Industry_Employed"
        Me.Industry_Employed.Size = New System.Drawing.Size(121, 21)
        Me.Industry_Employed.TabIndex = 6
        '
        'Employment_Status
        '
        Me.Employment_Status.FormattingEnabled = True
        Me.Employment_Status.Items.AddRange(New Object() {"employed", "in-post-school-education", "in-basic-education", "unemployed"})
        Me.Employment_Status.Location = New System.Drawing.Point(186, 23)
        Me.Employment_Status.Name = "Employment_Status"
        Me.Employment_Status.Size = New System.Drawing.Size(121, 21)
        Me.Employment_Status.TabIndex = 7
        '
        'No_Dependents
        '
        Me.No_Dependents.Location = New System.Drawing.Point(186, 137)
        Me.No_Dependents.Name = "No_Dependents"
        Me.No_Dependents.Size = New System.Drawing.Size(121, 20)
        Me.No_Dependents.TabIndex = 8
        '
        'Id_guardian
        '
        Me.Id_guardian.Location = New System.Drawing.Point(186, 189)
        Me.Id_guardian.Name = "Id_guardian"
        Me.Id_guardian.Size = New System.Drawing.Size(121, 20)
        Me.Id_guardian.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(186, 312)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(49, 312)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(315, 312)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Socio_economic_information
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 347)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Id_guardian)
        Me.Controls.Add(Me.No_Dependents)
        Me.Controls.Add(Me.Employment_Status)
        Me.Controls.Add(Me.Industry_Employed)
        Me.Controls.Add(Me.Marital_Status)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Socio_economic_information"
        Me.Text = "Socio_economic_information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Marital_Status As ComboBox
    Friend WithEvents Industry_Employed As ComboBox
    Friend WithEvents Employment_Status As ComboBox
    Friend WithEvents No_Dependents As TextBox
    Friend WithEvents Id_guardian As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
