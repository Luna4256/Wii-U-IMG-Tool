Public Class Form1
    Private Sub iconTexOpen_Click(sender As Object, e As EventArgs) Handles iconTexOpen.Click
        iconTex.Filter = "PNG Image File|*.png"

        If iconTex.ShowDialog = DialogResult.OK Then
            iconTexPreview.Image = Image.FromFile(iconTex.FileName)
        End If
    End Sub

    Private Sub bootDrcTexOpen_Click(sender As Object, e As EventArgs) Handles bootDrcTexOpen.Click
        bootDrcTex.Filter = "PNG Image File|*.png"

        If bootDrcTex.ShowDialog = DialogResult.OK Then
            bootDrcTexPreview.Image = Image.FromFile(bootDrcTex.FileName)
        End If
    End Sub

    Private Sub bootTvTexOpen_Click(sender As Object, e As EventArgs) Handles bootTvTexOpen.Click
        bootTvTex.Filter = "PNG Image File|*.png"

        If bootTvTex.ShowDialog = DialogResult.OK Then
            bootTvTexPreview.Image = Image.FromFile(bootTvTex.FileName)
        End If
    End Sub

    Private Sub helpBtn_Click(sender As Object, e As EventArgs) Handles helpBtn.Click
        Help.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not System.IO.Directory.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\TempTools") Then
            System.IO.Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\TempTools")
        End If

        System.IO.File.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\TempTools\FreeImage.dll", My.Resources.FreeImage)
        System.IO.File.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\TempTools\png2tgacmd.exe", My.Resources.png2tgacmd)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If System.IO.Directory.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\TempTools") = True Then
            System.IO.Directory.Delete(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\TempTools", True)
        End If
    End Sub

    Private Sub convertBtn_Click(sender As Object, e As EventArgs) Handles convertBtn.Click
        Dim iconTexPath As String = iconTex.FileName
        Dim bootDrcTexPath As String = bootDrcTex.FileName
        Dim bootTvTexPath As String = bootTvTex.FileName

        Dim TexDest As String = Application.StartupPath + "\"

        ProgressBar1.Value = 0

        statusTxt.Text = "Converting..."
        statusTxt.ForeColor = Color.Orange

        If Not System.IO.Directory.Exists(TexDest + "tga_output") Then
            System.IO.Directory.CreateDirectory(TexDest + "tga_output")
            ProgressBar1.Value = 10
        End If

        If System.IO.File.Exists(iconTexPath) = True Then
            If System.IO.File.Exists(TexDest + "tga_output\iconTex.png") = True Then
                System.IO.File.Delete(TexDest + "tga_output\iconTex.png")
                System.IO.File.Copy(iconTexPath, TexDest + "tga_output\iconTex.png")
                ProgressBar1.Value = 20
            Else
                System.IO.File.Copy(iconTexPath, TexDest + "tga_output\iconTex.png")
                ProgressBar1.Value = 20
            End If
        Else
            If System.IO.Directory.Exists(TexDest + "tga_output") = True Then
                System.IO.Directory.Delete(TexDest + "tga_output", True)
            End If
            statusTxt.Text = "There was an error! Make sure all the files are correct."
            statusTxt.ForeColor = Color.LightCoral
            Exit Sub
        End If

        If System.IO.File.Exists(bootDrcTexPath) = True Then
            If System.IO.File.Exists(TexDest + "tga_output\bootDrcTex.png") = True Then
                System.IO.File.Delete(TexDest + "tga_output\bootDrcTex.png")
                System.IO.File.Copy(bootDrcTexPath, TexDest + "tga_output\bootDrcTex.png")
                ProgressBar1.Value = 30
            Else
                System.IO.File.Copy(bootDrcTexPath, TexDest + "tga_output\bootDrcTex.png")
                ProgressBar1.Value = 30
            End If
        Else
            If System.IO.Directory.Exists(TexDest + "tga_output") = True Then
                System.IO.Directory.Delete(TexDest + "tga_output", True)
            End If
            statusTxt.Text = "There was an error! Make sure all the files are correct."
            statusTxt.ForeColor = Color.LightCoral
            Exit Sub
        End If

        If System.IO.File.Exists(bootTvTexPath) = True Then
            If System.IO.File.Exists(TexDest + "tga_output\bootTvTex.png") = True Then
                System.IO.File.Delete(TexDest + "tga_output\bootTvTex.png")
                System.IO.File.Copy(bootTvTexPath, TexDest + "tga_output\bootTvTex.png")
                ProgressBar1.Value = 40
            Else
                System.IO.File.Copy(bootTvTexPath, TexDest + "tga_output\bootTvTex.png")
                ProgressBar1.Value = 40
            End If
        Else
            If System.IO.Directory.Exists(TexDest + "tga_output") = True Then
                System.IO.Directory.Delete(TexDest + "tga_output", True)
            End If
            statusTxt.Text = "There was an error! Make sure all the files are correct."
            statusTxt.ForeColor = Color.LightCoral
            Exit Sub
        End If


        Dim iconTexConvertion As New ProcessStartInfo
        iconTexConvertion.FileName = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\TempTools\png2tgacmd.exe"
        iconTexConvertion.Arguments = "-i " + Chr(34) + TexDest + "tga_output\iconTex.png" + Chr(34) + " --width=128 --height=128 --tga-bpp=32 --tga-compression=none"
        iconTexConvertion.WindowStyle = ProcessWindowStyle.Hidden
        Dim iconProcess As Process = Process.Start(iconTexConvertion)
        iconProcess.WaitForExit()

        ProgressBar1.Value = 50

        Dim bootDrcTexConvertion As New ProcessStartInfo
        bootDrcTexConvertion.FileName = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\TempTools\png2tgacmd.exe"
        bootDrcTexConvertion.Arguments = "-i " + Chr(34) + TexDest + "tga_output\bootDrcTex.png" + Chr(34) + " --width=854 --height=480 --tga-bpp=24 --tga-compression=none"
        bootDrcTexConvertion.WindowStyle = ProcessWindowStyle.Hidden
        Dim bootDrcProcess As Process = Process.Start(bootDrcTexConvertion)
        bootDrcProcess.WaitForExit()

        ProgressBar1.Value = 60

        Dim bootTvTexConvertion As New ProcessStartInfo
        bootTvTexConvertion.FileName = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\TempTools\png2tgacmd.exe"
        bootTvTexConvertion.Arguments = "-i " + Chr(34) + TexDest + "tga_output\bootTvTex.png" + Chr(34) + " --width=1280 --height=720 --tga-bpp=24 --tga-compression=none"
        bootTvTexConvertion.WindowStyle = ProcessWindowStyle.Hidden
        Dim bootTvProcess As Process = Process.Start(bootTvTexConvertion)
        bootTvProcess.WaitForExit()

        ProgressBar1.Value = 70

        System.IO.File.Delete(TexDest + "tga_output\iconTex.png")

        ProgressBar1.Value = 80

        System.IO.File.Delete(TexDest + "tga_output\bootDrcTex.png")

        ProgressBar1.Value = 90

        System.IO.File.Delete(TexDest + "tga_output\bootTvTex.png")

        ProgressBar1.Value = 100

        statusTxt.Text = "Files converted successfully! The files have been saved here: " + TexDest + "tga_output"
        statusTxt.ForeColor = Color.LightGreen
    End Sub

    Private Sub checkUpdatesBTN_Click(sender As Object, e As EventArgs) Handles checkUpdatesBTN.Click
        MessageBox.Show("This feature isn't implemented yet, please check in future updates by looking at: https://github.com/Luna4256/Wii-U-IMG-Tool/releases")
    End Sub
End Class
