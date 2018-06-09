Imports Clienti.mFunzioni

Public Class fFatture


    Private _SceDati As EnumSceDati = Nothing
    Private _OggettiInForm As Object() = Nothing
    Private RecordsLetti As cRecordsLetti

    '***** INIZIO PROPRIETA' *****
    Public Property SceDati As EnumSceDati
        Get
            Return _SceDati
        End Get
        Set(value As EnumSceDati)
            _SceDati = value
            'Funzione cambio SceDati
        End Set
    End Property
    Private Property OggettiInForm As Object()
        Get
            If _OggettiInForm Is Nothing Then _OggettiInForm = OggettiInOggetto(Me)
            Return _OggettiInForm
        End Get
        Set(value As Object())
            _OggettiInForm = value
        End Set
    End Property
    '***** FINE PROPRIETA' *****

    Private Sub fFatture_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Abilito i menù
        AbilitaMenuModifica(True)
        AbilitaMainMenuSotto(EnumMainMenuSotto.OK)

        CaricaTestoControlli(Me, OggettiInForm)
    End Sub
End Class