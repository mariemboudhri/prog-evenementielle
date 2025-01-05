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
        Label2 = New Label()
        Label3 = New Label()
        rd_1 = New RadioButton()
        rd_2 = New RadioButton()
        rd_3 = New RadioButton()
        chk_1 = New CheckBox()
        chk_2 = New CheckBox()
        chk_3 = New CheckBox()
        chk_4 = New CheckBox()
        btn = New Button()
        lst = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.PeachPuff
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(43, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 28)
        Label1.TabIndex = 0
        Label1.Text = "Taille de pizza" & vbCrLf
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.PeachPuff
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(43, 171)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 28)
        Label2.TabIndex = 2
        Label2.Text = "Type de croute" & vbCrLf
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.PeachPuff
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(43, 262)
        Label3.Name = "Label3"
        Label3.Size = New Size(148, 28)
        Label3.TabIndex = 3
        Label3.Text = "Taille de pizza" & vbCrLf
        ' 
        ' rd_1
        ' 
        rd_1.AutoSize = True
        rd_1.BackColor = Color.PeachPuff
        rd_1.Location = New Point(235, 171)
        rd_1.Name = "rd_1"
        rd_1.Size = New Size(103, 24)
        rd_1.TabIndex = 4
        rd_1.TabStop = True
        rd_1.Text = "Croute fine"
        rd_1.UseVisualStyleBackColor = False
        ' 
        ' rd_2
        ' 
        rd_2.AutoSize = True
        rd_2.BackColor = Color.PeachPuff
        rd_2.Location = New Point(393, 171)
        rd_2.Name = "rd_2"
        rd_2.Size = New Size(138, 24)
        rd_2.TabIndex = 5
        rd_2.TabStop = True
        rd_2.Text = "Croute classique"
        rd_2.UseVisualStyleBackColor = False
        ' 
        ' rd_3
        ' 
        rd_3.AutoSize = True
        rd_3.BackColor = Color.PeachPuff
        rd_3.Location = New Point(589, 171)
        rd_3.Name = "rd_3"
        rd_3.Size = New Size(127, 24)
        rd_3.TabIndex = 6
        rd_3.TabStop = True
        rd_3.Text = "Croute épaisse"
        rd_3.UseVisualStyleBackColor = False
        ' 
        ' chk_1
        ' 
        chk_1.AutoSize = True
        chk_1.BackColor = Color.PeachPuff
        chk_1.Location = New Point(235, 266)
        chk_1.Name = "chk_1"
        chk_1.Size = New Size(116, 24)
        chk_1.TabIndex = 7
        chk_1.Text = "champigions"
        chk_1.UseVisualStyleBackColor = False
        ' 
        ' chk_2
        ' 
        chk_2.AutoSize = True
        chk_2.BackColor = Color.PeachPuff
        chk_2.Location = New Point(379, 266)
        chk_2.Name = "chk_2"
        chk_2.Size = New Size(71, 24)
        chk_2.TabIndex = 8
        chk_2.Text = "Olives"
        chk_2.UseVisualStyleBackColor = False
        ' 
        ' chk_3
        ' 
        chk_3.AutoSize = True
        chk_3.BackColor = Color.PeachPuff
        chk_3.Location = New Point(480, 266)
        chk_3.Name = "chk_3"
        chk_3.Size = New Size(86, 24)
        chk_3.TabIndex = 9
        chk_3.Text = "Poivrons"
        chk_3.UseVisualStyleBackColor = False
        ' 
        ' chk_4
        ' 
        chk_4.AutoSize = True
        chk_4.BackColor = Color.PeachPuff
        chk_4.Location = New Point(591, 262)
        chk_4.Name = "chk_4"
        chk_4.Size = New Size(197, 24)
        chk_4.TabIndex = 10
        chk_4.Text = "Formage supplémentaire"
        chk_4.UseVisualStyleBackColor = False
        ' 
        ' btn
        ' 
        btn.BackColor = Color.IndianRed
        btn.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn.Location = New Point(235, 347)
        btn.Name = "btn"
        btn.Size = New Size(269, 51)
        btn.TabIndex = 11
        btn.Text = "Afficher la récapitulatif"
        btn.UseVisualStyleBackColor = False
        ' 
        ' lst
        ' 
        lst.FormattingEnabled = True
        lst.Items.AddRange(New Object() {"Max", "Moyenne", "Mini"})
        lst.Location = New Point(263, 80)
        lst.Name = "lst"
        lst.Size = New Size(399, 28)
        lst.TabIndex = 12
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lst)
        Controls.Add(btn)
        Controls.Add(chk_4)
        Controls.Add(chk_3)
        Controls.Add(chk_2)
        Controls.Add(chk_1)
        Controls.Add(rd_3)
        Controls.Add(rd_2)
        Controls.Add(rd_1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "pizza"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents rd_1 As RadioButton
    Friend WithEvents rd_2 As RadioButton
    Friend WithEvents rd_3 As RadioButton
    Friend WithEvents chk_1 As CheckBox
    Friend WithEvents chk_2 As CheckBox
    Friend WithEvents chk_3 As CheckBox
    Friend WithEvents chk_4 As CheckBox
    Friend WithEvents btn As Button
    Friend WithEvents lst As ComboBox

End Class
