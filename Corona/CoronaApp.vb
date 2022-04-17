Imports System.Net
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

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
        If cbMaakond.SelectedItem IsNot "Eesti" Then


            request = DirectCast(WebRequest.Create("https://raw.githubusercontent.com/owid/covid-19-data/master/public/data/latest/owid-covid-latest.json"), HttpWebRequest)
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())
            Dim jsonString As String
            jsonString = reader.ReadToEnd()

            Dim WorldCountry() As String = {"Latvia", "Lithuania", "Poland", "Norway", "Finland", "Sweden", "Austria", "Belgium", "Bulgaria", "Croatia", "
Cyprus", "Czechia", "Denmark", "France", "Germany", "Greece", "Hungary", "Ireland", "Italy", "Luxembourg", "Malta", "Netherlands", "Portugal", "Romania", "Slovakia", "Slovenia", "Spain"}
            Dim WorldCountryAbbrev() As String = {"LVA", "LVO", "POL", "NOR", "FIN", "SWE", "AUT", "BEL", "BGR", "HRV", "CYP", "CZE", "DNK", "FRA", "DEU", "GRC", "HUN", "IRL", "ITA", "LUX", "MLT", "NLD", "PRT", "ROU", "SVK", "SVN", "ESP"}

            For i As Integer = 0 To 26
                If WorldCountry(i) = cbMaakond.SelectedItem Then
                    Dim objectList = JObject.Parse(jsonString)
                    Dim foundItem = JsonConvert.DeserializeObject(Of JSON_result)(objectList(WorldCountryAbbrev(i)).ToString)
                    lblMaakond.Text = foundItem.location
                    txtOutputTotal.Text = foundItem.total_cases
                    txtOutputDaily.Text = foundItem.new_cases
                    txtOutputPerPop.Text = foundItem.total_cases_per_million
                    txtOutputTotal14.Text = "No Data For this County"
                    txtOutputLast.Text = foundItem.last_updated_date
                End If
            Next



        End If

    End Sub

    Private Sub CoronaApp_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbMaakond.SelectedItem = "Eesti"
    End Sub
End Class

