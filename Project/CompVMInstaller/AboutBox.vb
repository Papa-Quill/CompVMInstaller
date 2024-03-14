Public NotInheritable Class AboutBox

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        LabelAppName.Text = My.Application.Info.ProductName
        If MainForm.DevMode Then
            LabelVersion.Text = "Version " & MainForm.Version & " - DEV MODE"
        Else
            LabelVersion.Text = "Version " & MainForm.Version
        End If
        LabelCopyright.Text = My.Application.Info.Copyright
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub LabelCopyright_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LabelAppName.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LabelLicense.LinkClicked
        LabelLicense.LinkVisited = True
        Process.Start("https://www.gnu.org/licenses/gpl-3.0.en.html")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LabelForumLink.LinkClicked
        LabelForumLink.LinkVisited = True
        Process.Start("http://www.teamfortress.tv/34834/yttriums-competitive-viewmodels")
    End Sub
End Class
