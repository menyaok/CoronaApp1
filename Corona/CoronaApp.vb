Imports System.Net
Imports System.IO
Imports Newtonsoft.Json
Public Class CoronaApp
    Dim request As HttpWebRequest
    Dim response As HttpWebResponse = Nothing
    Dim reader As StreamReader

    Private Sub btnData_Click1(sender As Object, e As EventArgs) Handles btnData.Click
        '------------------------------------------------------[ Eesti ]------------------------------------------------------
        If cbMaakond.SelectedItem = "Eesti" Then

            request = DirectCast(WebRequest.Create("https://opendata.digilugu.ee/opendata_covid19_tests_total.json"), HttpWebRequest)
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())
            Dim jsonString As String
            jsonString = reader.ReadToEnd()
            Dim objectList = JsonConvert.DeserializeObject(Of List(Of Data))(jsonString)
            Dim foundItem = objectList.Where(Function(__) __.StatisticsDate = txtData.Text).FirstOrDefault()

            If foundItem IsNot Nothing Then
                lblMaakond.Text = "Eesti"
                txtOutputTotal.Text = foundItem.TotalCases
                txtOutputTotal14.Text = foundItem.TotalCasesLast14D
                txtOutputDaily.Text = foundItem.DailyCases
                txtOutputPerPop.Text = foundItem.PerPopulation
                txtOutputLast.Text = foundItem.LastStatisticsDate
                If foundItem.LastStatisticsDate = foundItem.StatisticsDate Then
                    foundItem = objectList.Where(Function(__) __.StatisticsDate = txtData.Text).FirstOrDefault()
                    Dim nextDay As Double
                    nextDay = foundItem.TotalCases + foundItem.TotalCasesLast14D / 14
                    txtOutputNext.Text = nextDay.ToString("0")
                End If
            End If
            End If
        '------------------------------------------------------[ Maakond ]------------------------------------------------------
        If cbMaakond.SelectedItem IsNot "Eesti" Then
            request = DirectCast(WebRequest.Create("https://opendata.digilugu.ee/opendata_covid19_test_county_all.json"), HttpWebRequest)
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())
            Dim jsonString As String
            jsonString = reader.ReadToEnd()

            Dim objectList = JsonConvert.DeserializeObject(Of List(Of Data))(jsonString)
            Dim foundItem = objectList.Where(Function(__) __.StatisticsDate = txtData.Text And __.County = cbMaakond.SelectedItem And __.ResultValue = "P").FirstOrDefault

            If foundItem IsNot Nothing Then
                lblMaakond.Text = foundItem.County
                txtOutputTotal.Text = foundItem.TotalCases
                txtOutputDaily.Text = foundItem.DailyCases
                txtOutputPerPop.Text = "No Data For this County"
                txtOutputTotal14.Text = "No Data For this County"
                txtOutputLast.Text = foundItem.LastStatisticsDate

            End If
        End If

    End Sub

    Private Sub CoronaApp_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbMaakond.SelectedItem = "Eesti"
    End Sub
End Class

