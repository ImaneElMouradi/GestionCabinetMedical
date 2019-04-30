Imports System.Data.OleDb


Public Class Form1

    Private strConnexion As String = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=..\..\Cabinet_Medical.mdb"
    Private oConnection As OleDbConnection = New OleDbConnection(strConnexion)

    Private Sub btn_chercher_Click(sender As Object, e As EventArgs) Handles btn_chercher.Click
        list_historique.Items.Clear()
        txt_motif.Clear()
        txt_nom.Clear()
        txt_poids.Clear()
        txt_prenom.Clear()
        txt_taille.Clear()
        txt_grpsanguin.Clear()


        Dim exist As Integer = 0

        oConnection.Open()

        Try

            Dim strRequete As String = "select * from Patient where Patient.CodePatient =" + txt_codepatient.Text
            Dim oCommand As New OleDbCommand(strRequete, oConnection)
            Dim oReader As OleDbDataReader = oCommand.ExecuteReader()

            While oReader.Read()
                exist = 1

                txt_codepatient.Text = oReader.GetInt32(0)
                txt_nom.Text = oReader.GetString(1)
                txt_prenom.Text = oReader.GetString(2)
                txt_poids.Text = oReader.GetString(3)
                txt_taille.Text = oReader.GetString(4)
                txt_grpsanguin.Text = oReader.GetString(5)





            End While

        Catch ex As Exception
            MsgBox("le problème suivant a été rencontré" + ex.Message)

        End Try

        Try

            Dim strRequete As String = "select * from Patient,Consultation where Patient.CodePatient = Consultation.CodePatient and Patient.CodePatient =" + txt_codepatient.Text
            Dim oCommand As New OleDbCommand(strRequete, oConnection)
            Dim oReader As OleDbDataReader = oCommand.ExecuteReader()

            While oReader.Read()


                txt_codepatient.Text = oReader.GetInt32(0)
                txt_nom.Text = oReader.GetString(1)
                txt_prenom.Text = oReader.GetString(2)
                txt_poids.Text = oReader.GetString(3)
                txt_taille.Text = oReader.GetString(4)
                txt_grpsanguin.Text = oReader.GetString(5)


                list_historique.Items.Add(Format(oReader.GetDateTime(7), "MM/dd/yyyy"))


            End While

        Catch ex As Exception
            MsgBox("le problème suivant a été rencontré" + ex.Message)

        End Try

        oConnection.Close()

        If exist = 0 Then
            MsgBox("Ce patient n'existe pas.")
        End If



    End Sub

    Private Sub list_historique_SelectedIndexChanged(sender As Object, e As EventArgs) Handles list_historique.SelectedIndexChanged

        oConnection.Open()


        If list_historique.SelectedItem() <> "" Then
            Try
                Dim strRequete As String = "select Motif from Consultation where CodePatient= " + txt_codepatient.Text + " and DateConsultation=#" + list_historique.SelectedItem() + "#"

                'MsgBox(list_historique.SelectedItem())
                'MsgBox(strRequete)
                Dim oCommand As New OleDbCommand(strRequete, oConnection)
                Dim oReader As OleDbDataReader = oCommand.ExecuteReader()


                txt_motif.Clear()
                While oReader.Read()

                    txt_motif.Text = (oReader.GetString(0))


                End While

            Catch ex As Exception
                MsgBox("le problème suivant a été rencontré" + ex.Message)
            End Try
        End If







        oConnection.Close()



    End Sub

    Private Sub btn_consultation_Click(sender As Object, e As EventArgs) Handles btn_consultation.Click

        Form2.Show()




    End Sub

    Private Sub btn_supprimer_Click(sender As Object, e As EventArgs) Handles btn_supprimer.Click
        Dim supprimer As Integer
        supprimer = MsgBox("Voulez-vous vraiment supprimer?", vbYesNo + vbCritical, "Supprimer")
        oConnection.Open()

        If supprimer = vbYes Then



            Dim requete_supprimer As String = " delete from Consultation where CodeConsultation = (select CodeConsultation from Consultation where CodePatient=" + txt_codepatient.Text + " and DateConsultation=#" + list_historique.SelectedItem() + "#)"
            Dim oCommand As New OleDbCommand(requete_supprimer, oConnection)

            'MsgBox(requete_supprimer)

            Try

                oCommand.ExecuteNonQuery()

            Catch ex As Exception

                Console.WriteLine(ex.Message)

            End Try

            oConnection.Close()

            list_historique.Items.Remove(list_historique.SelectedItem())
            txt_motif.Clear()

        End If




    End Sub


End Class
