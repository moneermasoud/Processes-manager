Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getprosess()
    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        TextBox1.Text = ListBox1.SelectedItem.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName = TextBox1.Text Then

                    prog.Kill()
                    ListBox1.Items.Clear()
                    getprosess()

                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub


    Private Sub getprosess()
        For Each p As Process In Process.GetProcesses

            ListBox1.Items.Add(p.ProcessName.ToString)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        getprosess()
    End Sub
End Class
