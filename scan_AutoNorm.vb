Imports Microsoft.VisualBasic
Public Class frmAutoNorm
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AutoNormStop = -1
    End Sub


    Public Const SWP_NOMOVE = 2
    Public Const SWP_NOSIZE = 1
    Public Const ontopFLAGS = SWP_NOMOVE Or SWP_NOSIZE
    Public Const HWND_TOPMOST = -1
    Public Const HWND_NOTOPMOST = -2
    Declare Function SetWindowPos Lib "user32" (ByVal hWnd As Long, ByVal hWndInsertAfter As Long,
                 ByVal x As Long, ByVal y As Long, ByVal cx As Long, ByVal cy As Long,
                 ByVal wFlags As Long) As Long



    Public AutoNormResolutionCoarse As Double 'the resolution may typically be 0.1 degree
    Public AutoNormResolutionFine As Double
    Public AutoNormRangeCoarse As Double '+/- this value to limit search area, in order to keep it safe
    Public AutoNormRangeFine As Double
    Public AutoNormWPCalib As Integer
    Public AutoNormWPCalibA2D As Long 'the a/d value at calibration
    Public AutoNormChannelNo As Integer 'which a/d channel number will be used
    Public AutoNormWPChannelNo As Integer
    Public AutoNormSearchType As Integer 'which of the searchtypes to use
    Public AutoNormWPResolution As Double
    Public AutoNormWPRange As Double
    Public Const AutoNormRevWP As Integer = 1
    Public Const AutoNormRangeMaxCoarse As Double = 20
    Public Const AutoNormRangeMinCoarse As Double = 5
    Public Const AutoNormRangeMaxFine As Double = 5
    Public Const AutoNormRangeMinFine As Double = 1
    Public Const AutoNormWPRangeMax As Double = 2 'only search +/- 2 inch or 50 mm
    Public Const AutoNormWPRangeMin As Double = 0.2 'only search +/- 0.2 inch or 5 mm
    Public Const AutoNormWPResolutionMax As Double = 0.2 ' or 5mm
    Public Const AutoNormWPResolutionMin As Double = 0.02 'or .5mm
    Public Const AutoNormWPFineResFactor As Long = 10
    Public Const AutoNormResolutionMaxCoarse As Double = 5
    Public Const AutoNormResolutionMinCoarse As Double = 1
    Public Const AutoNormResolutionMaxFine As Double = 1
    Public Const AutoNormResolutionMinFine As Double = 0.05
    Public Const AutoNormNavg As Long = 8 '+2 readings are made with the max and min discarded
    Public Const AutoNormNoiseLimit As Long = 102 'the total range of the noise allowed on signal
    Public Const AutoNormMinChange As Long = 102 'change required to log a down slope
    Public Const AutoNormWPMinChange As Long = 102
    Public Const AutoNormRetry As Long = 16 'number of times to retry getting the noise within limits
    Public AutoNormWithWP As Integer  'includes adjusting Waterpath, -1 =True
    Public AutoNormStop As Integer
    Public Const AutoNormMaxNoInsPts As Long = 9
    Public AutoTeachLineInc As Double
    Public Const GimbalOffsetY As Double = 0 'make sure it is always zero
    Public dAPLength As Double 'double version of APLength!
    Public GimbalType As Integer
End Class
