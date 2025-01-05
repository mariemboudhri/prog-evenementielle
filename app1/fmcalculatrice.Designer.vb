<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fmcalculatrice
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
        TextA = New TextBox()
        TextB = New TextBox()
        btnplus = New Button()
        btnmoin = New Button()
        btnfois = New Button()
        btndiv = New Button()
        btnegal = New Button()
        Button6 = New Button()
        Label4 = New Label()
        lblRes = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(1361, 255)
        Label1.Margin = New Padding(6, 0, 6, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 29)
        Label1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(242, 60)
        Label2.Margin = New Padding(6, 0, 6, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 38)
        Label2.TabIndex = 1
        Label2.Text = "A"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(242, 153)
        Label3.Margin = New Padding(6, 0, 6, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 38)
        Label3.TabIndex = 2
        Label3.Text = "B"
        ' 
        ' TextA
        ' 
        TextA.Location = New Point(313, 64)
        TextA.Margin = New Padding(6, 4, 6, 4)
        TextA.Name = "TextA"
        TextA.Size = New Size(231, 34)
        TextA.TabIndex = 3
        ' 
        ' TextB
        ' 
        TextB.Location = New Point(313, 157)
        TextB.Margin = New Padding(6, 4, 6, 4)
        TextB.Name = "TextB"
        TextB.Size = New Size(231, 34)
        TextB.TabIndex = 4
        ' 
        ' btnplus
        ' 
        btnplus.BackColor = SystemColors.WindowFrame
        btnplus.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold)
        btnplus.ForeColor = SystemColors.ActiveCaptionText
        btnplus.Location = New Point(292, 242)
        btnplus.Margin = New Padding(6, 4, 6, 4)
        btnplus.Name = "btnplus"
        btnplus.Size = New Size(124, 74)
        btnplus.TabIndex = 5
        btnplus.Text = "+"
        btnplus.UseVisualStyleBackColor = False
        ' 
        ' btnmoin
        ' 
        btnmoin.BackColor = SystemColors.WindowFrame
        btnmoin.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold)
        btnmoin.ForeColor = SystemColors.ActiveCaptionText
        btnmoin.Location = New Point(420, 244)
        btnmoin.Margin = New Padding(6, 4, 6, 4)
        btnmoin.Name = "btnmoin"
        btnmoin.Size = New Size(124, 74)
        btnmoin.TabIndex = 6
        btnmoin.Text = "-"
        btnmoin.UseVisualStyleBackColor = False
        ' 
        ' btnfois
        ' 
        btnfois.BackColor = SystemColors.WindowFrame
        btnfois.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold)
        btnfois.ForeColor = SystemColors.ActiveCaptionText
        btnfois.Location = New Point(557, 242)
        btnfois.Margin = New Padding(6, 4, 6, 4)
        btnfois.Name = "btnfois"
        btnfois.Size = New Size(124, 74)
        btnfois.TabIndex = 7
        btnfois.Text = "*"
        btnfois.UseVisualStyleBackColor = False
        ' 
        ' btndiv
        ' 
        btndiv.BackColor = SystemColors.WindowFrame
        btndiv.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold)
        btndiv.ForeColor = SystemColors.ActiveCaptionText
        btndiv.Location = New Point(698, 242)
        btndiv.Margin = New Padding(6, 4, 6, 4)
        btndiv.Name = "btndiv"
        btndiv.Size = New Size(124, 74)
        btndiv.TabIndex = 8
        btndiv.Text = "/"
        btndiv.UseVisualStyleBackColor = False
        ' 
        ' btnegal
        ' 
        btnegal.BackColor = SystemColors.WindowFrame
        btnegal.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold)
        btnegal.ForeColor = SystemColors.ActiveCaptionText
        btnegal.Location = New Point(352, 326)
        btnegal.Margin = New Padding(6, 4, 6, 4)
        btnegal.Name = "btnegal"
        btnegal.Size = New Size(124, 74)
        btnegal.TabIndex = 9
        btnegal.Text = "="
        btnegal.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = SystemColors.Info
        Button6.Location = New Point(557, 344)
        Button6.Margin = New Padding(6, 4, 6, 4)
        Button6.Name = "Button6"
        Button6.Size = New Size(264, 57)
        Button6.TabIndex = 10
        Button6.Text = "Reset"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(292, 458)
        Label4.Margin = New Padding(6, 0, 6, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(123, 38)
        Label4.TabIndex = 11
        Label4.Text = "Resultat"
        ' 
        ' lblRes
        ' 
        lblRes.AutoSize = True
        lblRes.Location = New Point(557, 479)
        lblRes.Margin = New Padding(6, 0, 6, 0)
        lblRes.Name = "lblRes"
        lblRes.Size = New Size(0, 29)
        lblRes.TabIndex = 12
        ' 
        ' fmcalculatrice
        ' 
        AutoScaleDimensions = New SizeF(15F, 29F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1500, 652)
        Controls.Add(lblRes)
        Controls.Add(Label4)
        Controls.Add(Button6)
        Controls.Add(btnegal)
        Controls.Add(btndiv)
        Controls.Add(btnfois)
        Controls.Add(btnmoin)
        Controls.Add(btnplus)
        Controls.Add(TextB)
        Controls.Add(TextA)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold)
        Margin = New Padding(6, 4, 6, 4)
        Name = "fmcalculatrice"
        Text = "calculatrice"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextA As TextBox
    Friend WithEvents TextB As TextBox
    Friend WithEvents btnplus As Button
    Friend WithEvents btnmoin As Button
    Friend WithEvents btnfois As Button
    Friend WithEvents btndiv As Button
    Friend WithEvents btnegal As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblRes As Label

End Class
