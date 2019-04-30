<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_prenom = New System.Windows.Forms.TextBox()
        Me.btn_chercher = New System.Windows.Forms.Button()
        Me.btn_consultation = New System.Windows.Forms.Button()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.txt_codepatient = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_grpsanguin = New System.Windows.Forms.TextBox()
        Me.txt_taille = New System.Windows.Forms.TextBox()
        Me.txt_poids = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_supprimer = New System.Windows.Forms.Button()
        Me.list_historique = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_motif = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_prenom)
        Me.GroupBox1.Controls.Add(Me.btn_chercher)
        Me.GroupBox1.Controls.Add(Me.btn_consultation)
        Me.GroupBox1.Controls.Add(Me.txt_nom)
        Me.GroupBox1.Controls.Add(Me.txt_codepatient)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(556, 119)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informations personelles"
        '
        'txt_prenom
        '
        Me.txt_prenom.Location = New System.Drawing.Point(95, 78)
        Me.txt_prenom.Name = "txt_prenom"
        Me.txt_prenom.Size = New System.Drawing.Size(100, 20)
        Me.txt_prenom.TabIndex = 5
        '
        'btn_chercher
        '
        Me.btn_chercher.Location = New System.Drawing.Point(268, 21)
        Me.btn_chercher.Name = "btn_chercher"
        Me.btn_chercher.Size = New System.Drawing.Size(75, 23)
        Me.btn_chercher.TabIndex = 1
        Me.btn_chercher.Text = "Chercher"
        Me.btn_chercher.UseVisualStyleBackColor = True
        '
        'btn_consultation
        '
        Me.btn_consultation.Location = New System.Drawing.Point(268, 50)
        Me.btn_consultation.Name = "btn_consultation"
        Me.btn_consultation.Size = New System.Drawing.Size(75, 23)
        Me.btn_consultation.TabIndex = 2
        Me.btn_consultation.Text = "Consultation"
        Me.btn_consultation.UseVisualStyleBackColor = True
        '
        'txt_nom
        '
        Me.txt_nom.Location = New System.Drawing.Point(95, 49)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(100, 20)
        Me.txt_nom.TabIndex = 4
        '
        'txt_codepatient
        '
        Me.txt_codepatient.Location = New System.Drawing.Point(95, 23)
        Me.txt_codepatient.Name = "txt_codepatient"
        Me.txt_codepatient.Size = New System.Drawing.Size(100, 20)
        Me.txt_codepatient.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Prénom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code patient"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_grpsanguin)
        Me.GroupBox2.Controls.Add(Me.txt_taille)
        Me.GroupBox2.Controls.Add(Me.txt_poids)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(30, 156)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(556, 79)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informations médicales"
        '
        'txt_grpsanguin
        '
        Me.txt_grpsanguin.Location = New System.Drawing.Point(404, 30)
        Me.txt_grpsanguin.Name = "txt_grpsanguin"
        Me.txt_grpsanguin.Size = New System.Drawing.Size(100, 20)
        Me.txt_grpsanguin.TabIndex = 5
        '
        'txt_taille
        '
        Me.txt_taille.Location = New System.Drawing.Point(212, 30)
        Me.txt_taille.Name = "txt_taille"
        Me.txt_taille.Size = New System.Drawing.Size(100, 20)
        Me.txt_taille.TabIndex = 4
        '
        'txt_poids
        '
        Me.txt_poids.Location = New System.Drawing.Point(70, 30)
        Me.txt_poids.Name = "txt_poids"
        Me.txt_poids.Size = New System.Drawing.Size(100, 20)
        Me.txt_poids.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(318, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Groupe sanguin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(174, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Taille"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Poids"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_motif)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.btn_supprimer)
        Me.GroupBox3.Controls.Add(Me.list_historique)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(30, 258)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(556, 151)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Historiques"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(273, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Motif de consultation"
        '
        'btn_supprimer
        '
        Me.btn_supprimer.Location = New System.Drawing.Point(177, 68)
        Me.btn_supprimer.Name = "btn_supprimer"
        Me.btn_supprimer.Size = New System.Drawing.Size(75, 23)
        Me.btn_supprimer.TabIndex = 2
        Me.btn_supprimer.Text = "Supprimer"
        Me.btn_supprimer.UseVisualStyleBackColor = True
        '
        'list_historique
        '
        Me.list_historique.FormattingEnabled = True
        Me.list_historique.Location = New System.Drawing.Point(28, 36)
        Me.list_historique.Name = "list_historique"
        Me.list_historique.Size = New System.Drawing.Size(142, 95)
        Me.list_historique.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Historique consultations"
        '
        'txt_motif
        '
        Me.txt_motif.Location = New System.Drawing.Point(276, 36)
        Me.txt_motif.Multiline = True
        Me.txt_motif.Name = "txt_motif"
        Me.txt_motif.Size = New System.Drawing.Size(258, 95)
        Me.txt_motif.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 421)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Gestion de cabinet medical"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_prenom As TextBox
    Friend WithEvents btn_chercher As Button
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents txt_codepatient As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_consultation As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_grpsanguin As TextBox
    Friend WithEvents txt_taille As TextBox
    Friend WithEvents txt_poids As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_supprimer As Button
    Friend WithEvents list_historique As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_motif As TextBox
End Class
