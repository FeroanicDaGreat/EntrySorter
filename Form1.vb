Imports System.Net.Security

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usrI As String = TextBox1.Text
        Label1.Text = "Added " & usrI
        Entries.Items.Add(usrI)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Entries.SelectedItem IsNot Nothing Then
            MessageBox.Show("You chose: " & Entries.SelectedItem.ToString())
        Else
            MessageBox.Show("Please select something first!")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Entries.SelectedItem IsNot Nothing Then
            Entries.Items.Remove(Entries.SelectedItem)
        Else
            MessageBox.Show("Please select something first!")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If CheckBox1.Checked Then
            ' Sort the items alphabetically
            Dim sortedList As New List(Of String)
            For Each item As String In Entries.Items
                sortedList.Add(item)
            Next
            sortedList.Sort()

            ' Clear and re-add sorted items
            Entries.Items.Clear()
            For Each item As String In sortedList
                Entries.Items.Add(item)
            Next

            MessageBox.Show("Entries sorted alphabetically")
        Else
            MessageBox.Show("Entries left Default")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim searchText As String = TextBox1.Text.ToLower()

        ' Clear current items
        Results.Items.Clear()

        ' Re-add only items that match the search
        For Each item As String In Entries.Items
            If item.ToLower().StartsWith(searchText) Then
                Results.Items.Add(item)
            End If
        Next

    End Sub
End Class
