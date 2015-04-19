Imports DeckRandomizer

Public Class MainForm
    Private _maxVal As Integer = 100000
    Private _cardDeck() As String = {"m2", "m3", "m4", "m5", "m6", "m7", "m8", "m9", "m10", "m11", "m12", "m13", "m14", "c2", "c3", "c4", "c5", "c6", "c7", "c8", "c9", "c10", "c11", "c12", "c13", "c14", "s2", "s3", "s4", "s5", "s6", "s7", "s8", "s9", "s10", "s11", "s12", "s13", "s14", "k2", "k3", "k4", "k5", "k6", "k7", "k8", "k9", "k10", "k11", "k12", "k13", "k14"}
    Private _cardDeck1() As String

    Private Sub PrintDeck(ByVal tb As TextBox)
        tb.Clear()
        For Each s In _cardDeck
            tb.Text += s + ",  "
        Next
        tb.Text = tb.Text.Remove(tb.Text.Length - 3, 3)
    End Sub

    Private Sub btnRandom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRandom.Click
        Randomizer.RandomizeDeck(_cardDeck)
        PrintDeck(tbRandom)
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PrintDeck(tbRandom)
        PrintDeck(tbMTRandom)
    End Sub

    Private Sub btnMTRandom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMTRandom.Click
        Dim r = New Random(200)
        Dim x As Integer
        For i As Integer = 0 To 10
            x = r.Next(0, 20)
            Debug.Print(x)
        Next

        'Dim c, m, k, s As Integer
        'c = m = k = s = 0
        'Dim objWriter As New System.IO.StreamWriter("c:\randommt.txt")
        'For i As Integer = 0 To 4000
        '    _cardDeck1 = _cardDeck.Clone()

        '    Randomizer.RandomizeDeckMT(_cardDeck1)
        '    If Mid(_cardDeck1(0), 1, 1) = "c" Then
        '        c = c + 1
        '    End If
        '    If Mid(_cardDeck1(0), 1, 1) = "k" Then
        '        k = k + 1
        '    End If
        '    If Mid(_cardDeck1(0), 1, 1) = "m" Then
        '        m = m + 1
        '    End If
        '    If Mid(_cardDeck1(0), 1, 1) = "s" Then
        '        s = s + 1
        '    End If
        '    For Each ss In _cardDeck1
        '        objWriter.Write(ss + " ")
        '    Next
        '    objWriter.WriteLine("")
        'Next i
        'objWriter.Close()


        'PrintDeck(tbMTRandom)

    End Sub

    Private Sub Measure(ByVal type As Integer, ByRef lbl As Label)
        Cursor = Cursors.WaitCursor
        Dim tm As Double
        lbl.Text = ""
        tm = DateAndTime.Timer
        If (type = 0) Then
            For i As Integer = 1 To _maxVal
                Randomizer.RandomizeDeck(_cardDeck)
            Next
        ElseIf (type = 1) Then
            For i As Integer = 1 To _maxVal
                Randomizer.RandomizeDeck(_cardDeck)
            Next
        End If
        tm = DateAndTime.Timer - tm
        lbl.Text = tm.ToString() + " secs"
        Cursor = Cursors.Default
    End Sub



    Private Sub btnGoRandom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoRandom.Click
        Measure(0, lblRandomRes)
    End Sub

    Private Sub btnGoMTRandom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoMTRandom.Click
        Measure(0, lblMTRandomRes)
    End Sub
End Class
