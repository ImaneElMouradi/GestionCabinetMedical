Imports System.Data.OleDb


Public Class Form2


    Private strConnexion As String = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=..\..\Cabinet_Medical.mdb"
    Private oConnection As OleDbConnection = New OleDbConnection(strConnexion)

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oConnection.Open()

        Try

            Dim strRequete As String = "select CodePatient from Patient"
            Dim oCommand As New OleDbCommand(strRequete, oConnection)
            Dim oReader As OleDbDataReader = oCommand.ExecuteReader()

            While oReader.Read()

                cmb_patient.Items.Add(oReader.GetInt32(0))

            End While

        Catch ex As Exception
            MsgBox("le problème suivant a été rencontré" + ex.Message)

        End Try

        oConnection.Close()

    End Sub



    Private Sub btn_enregistrer_Click(sender As Object, e As EventArgs) Handles btn_enregistrer.Click
        Dim maxIDConsultation As Integer = 0

        oConnection.Open()



        Dim requete_max As String = "select max(CodeConsultation) from Consultation"
        Dim oCommand As New OleDbCommand(requete_max, oConnection)

        'MsgBox(requete_max)

        Try


            maxIDConsultation = oCommand.ExecuteScalar()
            'MsgBox(oCommand.ExecuteScalar())

        Catch ex As Exception

            Console.WriteLine(ex.Message)

        End Try

        oConnection.Close()


        If cmb_patient.Text = "" And txt_motif.Text = "" Then
            MsgBox("Vous avez oublié un champ", vbCritical, "Erreur")

        Else
            oConnection.Open()

            maxIDConsultation += 1
            Dim requete_ajout As String = "insert into Consultation values (" + maxIDConsultation.ToString() + ",#" + Format(dtp_consultation.Value(), "dd/MM/yyyy") + "#,'" + txt_motif.Text + "'," + cmb_patient.Text + ")"
            oCommand = New OleDbCommand(requete_ajout, oConnection)

            'MsgBox(requete_ajout)

            Try

                oCommand.ExecuteNonQuery()

            Catch ex As Exception

                Console.WriteLine(ex.Message)

            End Try

            oConnection.Close()

        End If

        MsgBox("Vous avez enregistré une nouvelle consultation.")

        cmb_patient.Text = ""
        txt_motif.Clear()
        Me.Hide()

    End Sub



End Class