Imports System.Xml
Public Class GeoLocation
    Private Sub GeoLocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub Geo()
        Dim xmldoc As New XmlDocument
        Dim xmlnode As XmlNodeList
        Dim i As Integer
        xmldoc.Load("http://freegeoip.net/xml/" & TextBox1.Text)
        xmlnode = xmldoc.GetElementsByTagName("Response")
        For i = 0 To xmlnode.Count - 1
            xmlnode(i).ChildNodes.Item(0).InnerText.Trim()
            Label1.Text = "IP Address:  [ " & xmlnode(i).ChildNodes.Item(0).InnerText.Trim() & (" ]")
            Label1.ForeColor = Color.Red
            Label2.Text = "Country Code: [ " & xmlnode(i).ChildNodes.Item(1).InnerText.Trim() & (" ]")
            Label2.ForeColor = Color.Red
            Label3.Text = "Country Name: [ " & xmlnode(i).ChildNodes.Item(2).InnerText.Trim() & (" ]")
            Label3.ForeColor = Color.Red
            Label4.Text = "Region Code: [ " & xmlnode(i).ChildNodes.Item(3).InnerText.Trim() & (" ]")
            Label4.ForeColor = Color.Red
            Label5.Text = "Region Name: [ " & xmlnode(i).ChildNodes.Item(4).InnerText.Trim() & (" ]")
            Label5.ForeColor = Color.Red
            Label6.Text = "City: [ " & xmlnode(i).ChildNodes.Item(5).InnerText.Trim() & (" ]")
            Label6.ForeColor = Color.Red
            Label7.Text = "Zip Code: [ " & xmlnode(i).ChildNodes.Item(6).InnerText.Trim() & (" ]")
            Label7.ForeColor = Color.Red
            Label8.Text = "Latitude: [ " & xmlnode(i).ChildNodes.Item(9).InnerText.Trim() & (" ]")
            Label8.ForeColor = Color.Red
            Label9.Text = "Longitude: [ " & xmlnode(i).ChildNodes.Item(8).InnerText.Trim() & (" ]")
            Label9.ForeColor = Color.Red
            Label10.Text = "Metro Code: [ " & xmlnode(i).ChildNodes.Item(7).InnerText.Trim() & (" ]")
            Label10.ForeColor = Color.Red
            Label13.Text = "" & xmlnode(i).ChildNodes.Item(9).InnerText.Trim()
            Label14.Text = "" & xmlnode(i).ChildNodes.Item(8).InnerText.Trim()
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Geo()
        IP.Text = TextBox1.Text
        If TextBox1.Text = ("") Then
            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label6.Visible = False
            Label7.Visible = False
            Label8.Visible = False
            Label9.Visible = False
            Label10.Visible = False
            MsgBox("Invaild IP Address", MsgBoxStyle.Critical, Title:="WARNING")
        Else TextBox1.Text = Text
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            Label9.Visible = True
            Label10.Visible = True
            TextBox1.Text = IP.Text
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()

        If IP.ForeColor = Color.Lime Then
            IP.ForeColor = Color.Red
        ElseIf IP.ForeColor = Color.Red Then
            IP.ForeColor = Color.Aqua
        ElseIf IP.ForeColor = Color.Aqua Then
            IP.ForeColor = Color.Orange
        ElseIf IP.ForeColor = Color.Orange Then
            IP.ForeColor = Color.BlueViolet
        ElseIf IP.ForeColor = Color.BlueViolet Then
            IP.ForeColor = Color.Gold
        ElseIf IP.ForeColor = Color.Gold Then
            IP.ForeColor = Color.Maroon
        ElseIf IP.ForeColor = Color.Maroon Then
            IP.ForeColor = Color.Lime
        End If
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Clear()
    End Sub

    Private Sub Label11_MouseHover(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.Navigate("https://www.google.com/maps/place/" & LAT.Text & "+" & LON.Text & "+")
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles LAT.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LAT.Text = Label13.Text
        LON.Text = Label14.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        MORE_INFO.Show()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        WebBrowser1.Navigate("https://www.facebook.com/search/top/?q= " & First.Text & "%" & Last.Text & "+")
        If First.Text.Contains("brett") And
                Last.Text.Contains("hudson") Then
            WebBrowser1.Navigate("google.COM")
            MsgBox("This User Has Been Blacklisted", MsgBoxStyle.Critical, Title:="BLACKLISTED")
        End If
        If First.Text.Contains("carlos") And
                Last.Text.Contains("crespo") Then
            WebBrowser1.Navigate("google.com")
            MsgBox("This User Has Been Blacklisted", MsgBoxStyle.Critical, Title:="BLACKLISTED")
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label19.ForeColor = Color.Lime Then
            Label19.ForeColor = Color.Red
        ElseIf Label19.ForeColor = Color.Red Then
            Label19.ForeColor = Color.Aqua
        ElseIf Label19.ForeColor = Color.Aqua Then
            Label19.ForeColor = Color.Orange
        ElseIf Label19.ForeColor = Color.Orange Then
            Label19.ForeColor = Color.BlueViolet
        ElseIf Label19.ForeColor = Color.BlueViolet Then
            Label19.ForeColor = Color.Gold
        ElseIf Label19.ForeColor = Color.Gold Then
            Label19.ForeColor = Color.Maroon
        ElseIf Label19.ForeColor = Color.Maroon Then
            Label19.ForeColor = Color.Lime
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        ppp.Show()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        WebBrowser1.Navigate("https://www.facebook.com/search/top/?q= " & phone.Text)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        WebBrowser1.Navigate("https://pipl.com/search/?q=" & firstback.Text & "+" & lastback.Text & "&l=" & city.Text & "%" & "+")
        If firstback.Text.Contains("brett") And
                lastback.Text.Contains("Hudson") Then
            WebBrowser1.Navigate("repcitymafia.com")
            MsgBox("THIS USER HAS BEEN BLACKLISTED", MsgBoxStyle.Critical, Title:="BLACKLISTED")
        End If
        If firstback.Text.Contains("carlos") And
             lastback.Text.Contains("crespo") Then
            WebBrowser1.Navigate("repcitymafia.com")
            MsgBox("THIS USER HAS BEEN BLACKLISTED", MsgBoxStyle.Critical, Title:="BLACKLISTED")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        WebBrowser1.Navigate("http://www.repcitymafia.com")
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        WebBrowser1.GoBack()

    End Sub

    Private Sub CreditsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreditsToolStripMenuItem.Click
        MsgBox("Victim Tracking Dept.
------------------------
This Tool Was Made By RMOB_MOBBOSS @ RepCityMafia.Com", MsgBoxStyle.Information, Title:="CREDITS")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class
