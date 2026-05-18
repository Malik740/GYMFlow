Public Class SplashScreen

    ' حدث تشغيل الشاشة: نتأكد هنا من تشغيل التايمر بشكل إجباري
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    ' حدث الحركة للتايمر: يتم تنفيذه كل 50 ميللي ثانية بناءً على الـ Interval
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' زيادة قيمة شريط التحميل
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 2
        Else
            ' إذا وصل التحميل لـ 100% يتم إيقاف التايمر فوراً والانتقال
            Timer1.Stop()

            ' فتح شاشة الـ Login وإخفاء الـ Splash الحالي
            Login.Show()
            Me.Hide()
        End If
    End Sub

End Class