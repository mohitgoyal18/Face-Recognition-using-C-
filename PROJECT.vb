Imports System.IO

Public Class PROJECT

    Dim var1 As Double
    Dim var2 As Double
    Dim division As Double
    Dim vir3 As Double
    Dim ca As Object

    Private Property dat2 As String

    Private Property dat3 As String

    Private Property dat4 As String

    Private Property dat1 As String



    Private Sub PROJECT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub mass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mass.TextChanged

    End Sub

    Private Sub eva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eva.Click
       





        var1 = Val(mass.Text)
        var2 = Val(mw.Text)
        division = var1 / var2
        mmw.Text = division
        vir3 = Val(division * mw.Text)




        mmwp.Text = vir3






       



    End Sub
    Public Sub calculate()
      

    End Sub

    Private Sub result_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m.TextChanged

    End Sub

    Private Sub read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles read.Click
        Dim objReader As New StreamReader("C:\Users\user\data.txt")
        Dim sLine As String = ""
        Dim arrText As New ArrayList()

        Do
            sLine = objReader.ReadLine()
            If Not sLine Is Nothing Then
                sLine.Split(" ")


                arrText.Add(sLine)

            End If
        Loop Until sLine Is Nothing
        objReader.Close()

        For Each sLine In arrText
            Console.WriteLine(sLine)
        Next
        Console.ReadLine()

        dat2 = arrText(0).ToString
        dat3 = arrText(1).ToString
        dat4 = arrText(2).ToString
        dat1 = arrText(3).ToString
        m.Text = dat2
        mw1.Text = dat3
        mmw1.Text = dat4
        mp.Text = dat1










    End Sub

    Private Sub mw1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mw1.TextChanged

    End Sub

    Private Sub mmw1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmw1.TextChanged

    End Sub

    Private Sub mp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mp.TextChanged

    End Sub
End Class
