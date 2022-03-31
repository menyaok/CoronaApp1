﻿Imports System.IO
Imports Newtonsoft.Json
Public Class CoronaApp


    Private Sub btnData_Click1(sender As Object, e As EventArgs) Handles btnData.Click
        'Читаем всё из файла в jsonString
        Dim jsonString As String = File.ReadAllText("D:\University\database.json")
        'Используем Newtonsoft.Json чтобы как я понял конвертировать файл в нашу базу данных, если грубо говоря. Он перемещает все данные в class Data где находятся все переменные нужные для файла
        Dim objectList = JsonConvert.DeserializeObject(Of List(Of Data))(jsonString)
        'Тут мы начинаем искать по дате которую ввели и находим как я понял нужный нам ряд
        Dim foundItem = objectList.Where(Function(__) __.StatisticsDate = txtData.Text).FirstOrDefault()
        'foundItem выступает в роли нужного ряда, и затем мы просто выбираем нужные нам переменные из этого ряда 
        If foundItem IsNot Nothing Then
            txtOutputTotal.Text = foundItem.TotalCases
            txtOutputTotal14.Text = foundItem.TotalCasesLast14D
            txtOutputDaily.Text = foundItem.DailyCases
            txtOutputPerPop.Text = foundItem.PerPopulation
            txtOutputLast.Text = foundItem.LastStatisticsDate
        End If
    End Sub

End Class
