Imports System.Net.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class bloodForm

    Public apiUrl As String = "http://127.0.0.1:8000/api/v1/"

    Private Sub bloodForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub

    Private Sub bloodForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadingGif.Location = New Point((loaderPanel.Width / 2) - (loadingGif.Width / 2), (loaderPanel.Height / 2) - (loadingGif.Height / 2))

        'Fetch Division List'
        getDivisions()
    End Sub

    Private Async Sub getDivisions()
        Using client As HttpClient = New HttpClient()
            Using resp As HttpResponseMessage = Await client.GetAsync(apiUrl & "get-division-lists")
                Using content As HttpContent = resp.Content
                    Dim result As String = Await content.ReadAsStringAsync()

                    result = "{ data:" & result & "}"

                    Dim jsonObj As JObject = JObject.Parse(result)

                    Dim jsonArray As JArray = JArray.Parse(jsonObj.SelectToken("data").ToString())

                    divisonBox.DisplayMember = "Text"

                    For Each item As JObject In jsonArray
                        divisonBox.Items.Add(New With {.Text = item.SelectToken("name"), .Value = item.SelectToken("id")})
                    Next

                End Using
            End Using
        End Using
    End Sub

    Private Sub divisonBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles divisonBox.SelectedValueChanged

        Dim divisionId As String = divisonBox.SelectedItem.Value

        If divisionId IsNot Nothing Then
            cityBox.Enabled = True
            getCities(divisionId)
            areaBox.Items.Clear()
            FilterResults()
        End If

    End Sub

    Private Async Sub getCities(divId As String)
        cityBox.Items.Clear()
        Using client As HttpClient = New HttpClient()
            Using resp As HttpResponseMessage = Await client.GetAsync(apiUrl & "get-city-lists?division=" & divId)
                Using content As HttpContent = resp.Content
                    Dim result As String = Await content.ReadAsStringAsync()

                    result = "{ data:" & result & "}"

                    Dim jsonObj As JObject = JObject.Parse(result)

                    Dim jsonArray As JArray = JArray.Parse(jsonObj.SelectToken("data").ToString())

                    cityBox.DisplayMember = "Text"

                    For Each item As JObject In jsonArray
                        cityBox.Items.Add(New With {.Text = item.SelectToken("name"), .Value = item.SelectToken("id")})
                    Next

                End Using
            End Using
        End Using
    End Sub

    Private Sub cityBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles cityBox.SelectedValueChanged

        Dim areaId As String = cityBox.SelectedItem.Value
        If areaId IsNot Nothing Then
            areaBox.Enabled = True
            getAreas(areaId)
            FilterResults()
        End If
    End Sub

    Private Async Sub getAreas(area As String)
        areaBox.Items.Clear()
        Using client As HttpClient = New HttpClient()
            Using resp As HttpResponseMessage = Await client.GetAsync(apiUrl & "get-area-lists?division=" & area)
                Using content As HttpContent = resp.Content
                    Dim result As String = Await content.ReadAsStringAsync()

                    result = "{ data:" & result & "}"

                    Dim jsonObj As JObject = JObject.Parse(result)

                    Dim jsonArray As JArray = JArray.Parse(jsonObj.SelectToken("data").ToString())

                    areaBox.DisplayMember = "Text"

                    For Each item As JObject In jsonArray
                        areaBox.Items.Add(New With {.Text = item.SelectToken("name"), .Value = item.SelectToken("id")})
                    Next

                End Using
            End Using
        End Using
    End Sub

    Private Async Sub FilterResults()

        loaderPanel.Visible = True

        Dim division As String = ""
        Dim city As String = ""
        Dim area As String = ""
        Dim bloodGroup As String = "any"

        If divisonBox.SelectedIndex >= 0 Then
            division = divisonBox.SelectedItem.Value
        End If

        If cityBox.SelectedIndex >= 0 Then
            city = cityBox.SelectedItem.Value
        End If

        If areaBox.SelectedIndex >= 0 Then
            area = areaBox.SelectedItem.Value
        End If

        If bloodGroupBox.SelectedIndex >= 0 Then
            bloodGroup = bloodGroupBox.SelectedItem.ToString()
        End If

        Using client As HttpClient = New HttpClient()
            Using resp As HttpResponseMessage = Await client.GetAsync(apiUrl & "get-donor-list-lists/" & bloodGroup & "/find?division=" & division & "&city=" & city &
                                                                      "&area=" & area)
                Using content As HttpContent = resp.Content
                    Dim result As String = Await content.ReadAsStringAsync()

                    result = "{ data:" & result & "}"

                    Dim jsonObj As JObject = JObject.Parse(result)

                    Dim jsonArray As JArray = JArray.Parse(jsonObj.SelectToken("data").ToString())

                    bloodDonorTable.Rows.Clear()

                    For Each item As JObject In jsonArray
                        Dim rowId As Integer = bloodDonorTable.Rows.Add()
                        Dim row As DataGridViewRow = bloodDonorTable.Rows(rowId)
                        row.Cells("nameCol").Value = item.SelectToken("name").ToString()
                        row.Cells("bloodCol").Value = item.SelectToken("blood_group").ToString()
                        row.Cells("phoneCol").Value = item.SelectToken("phone").ToString()
                        row.Cells("addressCol").Value = item.SelectToken("address").ToString()
                        row.Cells("divCol").Value = item.SelectToken("division").SelectToken("name").ToString()
                        row.Cells("cityCol").Value = item.SelectToken("city").SelectToken("name").ToString()
                        row.Cells("areaCol").Value = item.SelectToken("area").SelectToken("name").ToString()
                    Next
                    loaderPanel.Visible = False
                End Using
            End Using
        End Using
    End Sub

    Private Sub areaBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles areaBox.SelectedValueChanged
        FilterResults()
    End Sub

    Private Sub bloodGroupBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles bloodGroupBox.SelectedValueChanged
        FilterResults()
    End Sub
End Class