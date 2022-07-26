Public Class News
    Private Sub News_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://luna4256.fra1.digitaloceanspaces.com/wuit/news.txt")
        Dim response As System.Net.HttpWebResponse = request.GetResponse

        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream)

        newsRich.Text = sr.ReadToEnd
    End Sub
End Class