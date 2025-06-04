Imports System.IO

Public Class Joueur
    Public nom As String
    Public meilleurScore As Integer
    Public tempsMin As Integer
    Public nbParties As Integer
    Public tempsTotal As Integer
End Class

Public Module Module1
    ' Liste partagée par toute l'application
    Public ListeJoueurs As New List(Of Joueur)

    Public Sub ChargerJoueurs()
        Dim chemin As String = "donnees\joueurs.txt"
        If File.Exists(chemin) Then
            ListeJoueurs.Clear()
            Using sr As New StreamReader(chemin)
                While Not sr.EndOfStream
                    Dim ligne = sr.ReadLine()
                    Dim champs = ligne.Split(";"c)
                    If champs.Length = 5 Then
                        Dim j As New Joueur
                        j.nom = champs(0)
                        j.meilleurScore = Integer.Parse(champs(1))
                        j.tempsMin = Integer.Parse(champs(2))
                        j.nbParties = Integer.Parse(champs(3))
                        j.tempsTotal = Integer.Parse(champs(4))
                        ListeJoueurs.Add(j)
                    End If
                End While
            End Using
        End If
    End Sub

    Public Sub SauvegarderJoueurs()
        Dim chemin As String = "donnees\joueurs.txt"
        Using sw As New StreamWriter(chemin, False)
            For Each j In ListeJoueurs
                sw.WriteLine(j.nom & ";" & j.meilleurScore & ";" & j.tempsMin & ";" & j.nbParties & ";" & j.tempsTotal)
            Next
        End Using
    End Sub
End Module
