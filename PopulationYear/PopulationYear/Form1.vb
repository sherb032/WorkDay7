﻿Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As Object, e As EventArgs) Handles btnPopulation.Click
        Dim pop1 As Double = 7000000000
        Dim year As Integer = 2014

        Do While pop1 >= 6000000

            pop1 /= 2
            year -= 50

        Loop

        MessageBox.Show("The answer is " & year)

    End Sub
End Class
