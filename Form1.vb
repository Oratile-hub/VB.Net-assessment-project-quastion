Imports System.Windows

Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'The code below adds the word entered in the TextBox to the ListBox
        'and clears the TextBox if there is a value present.
        'If the word entered is already present in the ListBox,
        'it shows a message box indicating that the word already exists

        If TextBox1.Text <> "" Then
            If txtInput.Items.Contains(TextBox1.Text) Then
                txtInput.Items.Add(TextBox1.Text)
                TextBox1.Clear()
            Else
                MessageBox.Show("The word is already in the list.")
            End If
        Else
            MessageBox.Show("Please enter a word.")
        End If


    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        'This removes the selected word from the ListBox and clears the Label so that it is not showing anything.
        If txtInput.SelectedIndex <> -1 Then
            txtInput.Items.RemoveAt(txtInput.SelectedIndex)
            lstWords.Text = ""
        Else
            MessageBox.Show("Please select a word to remove.")
        End If


    End Sub

    Private Sub txtInput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtInput.SelectedIndexChanged

        'The code first checks to see if an item is selected in the ListBox.
        'If an item is selected, then it displays that text in the Label and calls the "UpdateLabel" method
        'which updates the Label based on which RadioButton is selected

        If txtInput.SelectedIndex >= 0 Then
            lstWords.Text = txtInput.SelectedItem.ToString()
            UpdateLabel()
        End If
    End Sub

    'This code checks which RadioButton is currently selected and applies the changes
    'to the text or color (if "Purple" or "Blue" is selected) of the Label based on the selection made

    Private Sub UpdateLabel()
        If radUpper.Checked Then
            lstWords.Text = lstWords.Text.ToUpper()
        ElseIf radLower.Checked Then
            lstWords.Text = lstWords.Text.ToLower()
        ElseIf radPurple.Checked Then
            lstWords.ForeColor = Color.Purple
        ElseIf radBlue.Checked Then
            lstWords.ForeColor = Color.Blue
        End If
    End Sub


    'This will ensure that the Label is updated every time one of the RadioButtons is selected
    Private Sub radLower_CheckedChanged(sender As Object, e As EventArgs) Handles radLower.CheckedChanged
        UpdateLabel()
    End Sub

    Private Sub radUpper_CheckedChanged(sender As Object, e As EventArgs) Handles radUpper.CheckedChanged
        UpdateLabel()
    End Sub

    Private Sub radBlue_CheckedChanged(sender As Object, e As EventArgs) Handles radBlue.CheckedChanged
        UpdateLabel()
    End Sub

    Private Sub radPurple_CheckedChanged(sender As Object, e As EventArgs) Handles radPurple.CheckedChanged
        UpdateLabel()
    End Sub

End Class
