Imports Clienti.mFunzioni

Module mFileINI
    Public Declare Auto Function GetPrivateProfileString Lib "kernel32.dll" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Public Declare Auto Function WritePrivateProfileString Lib "kernel32.dll" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

    Public Const kPathDirectoryGenerale = "C:\\Clienti\\"
    Public Const kPathDirectoryAllegati = kPathDirectoryGenerale & "Allegati\\"
    Public Const kPathFileSettings = kPathDirectoryGenerale & "Settings.ini"


    Public Sub CheckDirectories()
        CheckDirectory(kPathDirectoryGenerale)
        CheckDirectory(kPathDirectoryAllegati)
        If kTipoDatabase = EnumDatabases.Access Then CheckDirectory(kDirectoryDatabaseAccess)
    End Sub

    Public Sub CheckSettings()
        CheckDirectory(kPathDirectoryGenerale)
        If Not (IO.File.Exists(kPathFileSettings)) Then
            IO.File.CreateText(kPathFileSettings)
        End If
    End Sub

    Private Sub CheckDirectory(ByVal path As String)
        If Not (IO.Directory.Exists(path)) Then
            IO.Directory.CreateDirectory(path)
        End If
    End Sub

    Public Function IniLeggi(ByVal Filename As String, ByVal Section As String, ByVal Key As String, Optional ByVal lpDefault As String = "", Optional ByVal bRaiseError As Boolean = False) As String
        Dim RetVal As String = New String(" ", 255)
        Dim LenResult As Integer
        Dim ErrString As String

        LenResult = GetPrivateProfileString(Section, Key, lpDefault, RetVal, RetVal.Length, Filename)
        If LenResult = 0 AndAlso bRaiseError Then
            If Not (System.IO.File.Exists(Filename)) Then
                ErrString = "Impossibile aprire il file INI" & Filename
            Else
                ErrString = "La sezione o la chiave sono errate oppure l’accesso al file non è consentito"
            End If
            Throw New Exception(ErrString)
        End If
        Return RetVal.Substring(0, LenResult)
    End Function

    Public Function IniScrivi(ByVal Filename As String, ByVal Section As String, ByVal Key As String, ByVal Value As String, Optional ByVal bRaiseError As Boolean = False) As Boolean
        Dim LenResult As Integer
        Dim ErrString As String

        LenResult = WritePrivateProfileString(Section, Key, Value, Filename)
        If LenResult = 0 And bRaiseError Then
            If Not (System.IO.File.Exists(Filename)) Then
                ErrString = "Impossibile aprire il file INI " & Filename
            Else
                ErrString = "Accesso al file non consentito"
            End If
            Throw New Exception(ErrString)
        End If
        Return IIf(LenResult = 0, False, True)
        End
    End Function

    Public Sub LeggiFileIni()
        On Error Resume Next
        CheckSettings()

        ' Colori
        OpzioniBisa.ColoreInserimento = Color.FromArgb(IniLeggi(kPathFileSettings, "Opzioni", "ColoreIns"))
        OpzioniBisa.ColoreModifica = Color.FromArgb(IniLeggi(kPathFileSettings, "Opzioni", "ColoreMod"))
        OpzioniBisa.ColoreRicerca = Color.FromArgb(IniLeggi(kPathFileSettings, "Opzioni", "ColoreRic"))

        ' Accesso
        OpzioniBisa.ComboAccesso = Convert.ToInt32(IniLeggi(kPathFileSettings, "Opzioni", "ComboAccesso"))
        OpzioniBisa.AutoLogin = Convert.ToBoolean(IniLeggi(kPathFileSettings, "Opzioni", "AutoLogin"))
        ' User & Password
        mUtente.USERNAME = IniLeggi(kPathFileSettings, "Opzioni", "AccessoUser")
        mUtente.PASSWORD = IniLeggi(kPathFileSettings, "Opzioni", "AccessoPsw")
    End Sub

    Public Sub SalvaFileIni()
        ' Salvo Colori
        IniScrivi(kPathFileSettings, "Opzioni", "ColoreIns", OpzioniBisa.ColoreInserimento.ToArgb)
        IniScrivi(kPathFileSettings, "Opzioni", "ColoreMod", OpzioniBisa.ColoreModifica.ToArgb)
        IniScrivi(kPathFileSettings, "Opzioni", "ColoreRic", OpzioniBisa.ColoreRicerca.ToArgb)

        ' Salvo Accesso
        IniScrivi(kPathFileSettings, "Opzioni", "ComboAccesso", OpzioniBisa.ComboAccesso)
        IniScrivi(kPathFileSettings, "Opzioni", "AutoLogin", OpzioniBisa.AutoLogin)
        ' Salvo User & Password
        Select Case OpzioniBisa.ComboAccesso
            Case EnumComboAccesso.Nulla
                IniScrivi(kPathFileSettings, "Opzioni", "AccessoUser", vbNullString)
                IniScrivi(kPathFileSettings, "Opzioni", "AccessoPsw", vbNullString)
            Case EnumComboAccesso.Utente
                IniScrivi(kPathFileSettings, "Opzioni", "AccessoUser", mUtente.USERNAME)
                IniScrivi(kPathFileSettings, "Opzioni", "AccessoPsw", vbNullString)
            Case EnumComboAccesso.UserEPassword
                IniScrivi(kPathFileSettings, "Opzioni", "AccessoUser", mUtente.USERNAME)
                IniScrivi(kPathFileSettings, "Opzioni", "AccessoPsw", mUtente.PASSWORD)
        End Select
    End Sub

End Module
