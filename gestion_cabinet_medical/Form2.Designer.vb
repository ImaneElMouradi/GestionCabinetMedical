<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_patient = New System.Windows.Forms.ComboBox()
        Me.dtp_consultation = New System.Windows.Forms.DateTimePicker()
        Me.btn_enregistrer = New System.Windows.Forms.Button()
        Me.txt_motif = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date consultation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(256, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Patient"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(240, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Motif consultation"
        '
        'cmb_patient
        '
        Me.cmb_patient.FormattingEnabled = True
        Me.cmb_patient.Location = New System.Drawing.Point(354, 43)
        Me.cmb_patient.Name = "cmb_patient"
        Me.cmb_patient.Size = New System.Drawing.Size(121, 21)
        Me.cmb_patient.TabIndex = 3
        '
        'dtp_consultation
        '
        Me.dtp_consultation.Location = New System.Drawing.Point(12, 57)
        Me.dtp_consultation.Name = "dtp_consultation"
        Me.dtp_consultation.Size = New System.Drawing.Size(200, 20)
        Me.dtp_consultation.TabIndex = 5
        '
        'btn_enregistrer
        '
        Me.btn_enregistrer.Location = New System.Drawing.Point(399, 296)
        Me.btn_enregistrer.Name = "btn_enregistrer"
        Me.btn_enregistrer.Size = New System.Drawing.Size(153, 23)
        Me.btn_enregistrer.TabIndex = 6
        Me.btn_enregistrer.Text = "Enregistrer consultation"
        Me.btn_enregistrer.UseVisualStyleBackColor = True
        '
        'txt_motif
        '
        Me.txt_motif.Location = New System.Drawing.Point(354, 141)
        Me.txt_motif.Multiline = True
        Me.txt_motif.Name = "txt_motif"
        Me.txt_motif.Size = New System.Drawing.Size(220, 130)
        Me.txt_motif.TabIndex = 7
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 421)
        Me.Controls.Add(Me.txt_motif)
        Me.Controls.Add(Me.btn_enregistrer)
        Me.Controls.Add(Me.dtp_consultation)
        Me.Controls.Add(Me.cmb_patient)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Consultations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_patient As ComboBox
    Friend WithEvents dtp_consultation As DateTimePicker
    Friend WithEvents btn_enregistrer As Button
    Friend WithEvents txt_motif As TextBox
End Class
