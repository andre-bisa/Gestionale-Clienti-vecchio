#Region "EnumComboAccesso"
' Salvataggio del combobox per salvare nome utente e/o password
Public Enum EnumComboAccesso
    Nulla
    Utente
    UserEPassword
End Enum
#End Region

Public Class cOpzioniBisa
    ' Colori
    Public ColoreInserimento As Color = Color.FromArgb(-4587591)
    Public ColoreModifica As Color = Color.FromArgb(-71)
    Public ColoreRicerca As Color = Color.FromArgb(-12594)

    'Accesso
    Public ComboAccesso As EnumComboAccesso = EnumComboAccesso.Nulla
    Public AutoLogin As Boolean = False

End Class