Imports atcData
Imports atcData.atcDataGroup
Imports atcUtility
Imports MapWindow.Interfaces
Imports MapWinUtility
Imports MapWinGeoProc
Imports atcMwGisUtility

Imports Microsoft.VisualBasic
Imports System

Public Module ScriptGridValues
    Private pTestPath As String = "D:\GisData\SERDP"
    Private pStepSize As Integer = 2000 'meters

    Public Sub ScriptMain(ByRef aMapWin As IMapWin)
        Logger.Dbg("Start")
        'change to the directory of the current project
        ChDriveDir(pTestPath)
        Logger.Dbg(" CurDir:" & CurDir())
        Dim lString As New Text.StringBuilder
        Dim lPointCollection As atcCollection
        Dim lX, lY As Double

        lString.AppendLine("PointsFromGridWithStep " & pStepSize)
        'sample and save points from grid
        For lX = 688000 To 724000 Step pStepSize
            For lY = 3568000 To 3604000 Step pStepSize
                lPointCollection = XY2Z(aMapWin, lX, lY)
                ReportPoints(lX, lY, lPointCollection, lString)
            Next lY
        Next lX

        'sample points going up Upatoi Creek
        lString.AppendLine("PointsFromStream")
        GisUtil.MappingObject = aMapWin
        Dim lLayerIndex As Integer = GisUtil.LayerIndex("UpatoiNHDFlowline")
        Logger.Dbg("Found Upatoi:ShapeCount:" & GisUtil.NumFeatures(lLayerIndex))

        Dim lComIdFieldIndex As Integer = GisUtil.FieldIndex(lLayerIndex, "COMID")
        Dim lToComIdFieldIndex As Integer = GisUtil.FieldIndex(lLayerIndex, "TOCOMID")
        Dim lLengthFieldIndex As Integer = GisUtil.FieldIndex(lLayerIndex, "LENGTHKM")
        Dim lLengthTotal As Double = 0
        Dim lLengthSegment As Double
        Dim lLength As Double
        Dim lCnt As Integer = 0
        Dim lComId As Integer = 3434322 'downstream COMID for Upitoi Creek from visual inspection
        Do While lComId > 0
            Dim lFeatureIndex As Integer = FindFeatureIndex(lLayerIndex, lComIdFieldIndex, lComId.ToString)
            Dim lXArray() As Double = Nothing
            Dim lYArray() As Double = Nothing
            lLengthSegment = 0
            GisUtil.PointsOfLine(lLayerIndex, lFeatureIndex, lXArray, lYArray)
            For lIndex As Integer = lXArray.GetUpperBound(0) To 0 Step -1
                If lIndex = lXArray.GetUpperBound(0) Then
                    lLength = 0
                Else
                    lLength = Math.Sqrt((lXArray(lIndex + 1) - lXArray(lIndex)) ^ 2 + _
                                        (lYArray(lIndex + 1) - lYArray(lIndex)) ^ 2) / 1000.0
                End If
                lLengthSegment += lLength
                Logger.Dbg("   CalcSegment " & lIndex & _
                             " Length " & DoubleToString(lLength, , "#,##0.###", , , 6) & _
                             " CumSegmentLength " & DoubleToString(lLengthSegment, , "#,##0.###", , , 6))
                lPointCollection = XY2Z(aMapWin, lXArray(lIndex), lYArray(lIndex))
                ReportPoints(lXArray(lIndex), lYArray(lIndex), lPointCollection, lString, lLengthTotal + lLengthSegment)
            Next lIndex
            lLengthTotal += lLengthSegment
            Logger.Dbg("  ComId:" & lComId & " FeatureIndex:" & lFeatureIndex & _
                                             " Length:" & DoubleToString(lLengthSegment, , "#,##0.###", , , 6) & _
                                             " from DBF " & GisUtil.FieldValue(lLayerIndex, lFeatureIndex, lLengthFieldIndex) & _
                                             " LengthTotal:" & DoubleToString(lLengthTotal, , "#,##0.###", , , 6))

            Dim lFeatureIndexUpstream As Integer = FindFeatureIndex(lLayerIndex, lToComIdFieldIndex, lComId.ToString)
            If lFeatureIndexUpstream >= 0 Then
                lComId = GisUtil.FieldValue(lLayerIndex, lFeatureIndexUpstream, lComIdFieldIndex)
                lCnt += 1
            Else
                lComId = 0
            End If
        Loop
        Logger.Dbg("ShapeProcessedCount:" & lCnt & " Length:" & lLengthTotal)
        SaveFileString("GridSample.txt", lString.ToString)
    End Sub

    Function FindFeatureIndex(ByVal aLayerIndex As Integer, ByVal aFieldIndex As Integer, ByVal aValue As String) As Integer
        For lFeatureIndex As Integer = 0 To GisUtil.NumFeatures(aLayerIndex) - 1
            If GisUtil.FieldValue(aLayerIndex, lFeatureIndex, aFieldIndex) = aValue Then
                Return lFeatureIndex
            End If
        Next
        Return -1
    End Function

    Sub ReportPoints(ByVal aX As Double, ByVal aY As Double, ByVal aPointCollection As atcCollection, ByRef aString As Text.StringBuilder, Optional ByVal aPos As Double = -1)
        If aPointCollection.Count > 1 Then
            Dim lRatio As Double = aPointCollection(0) / aPointCollection(1)
            If aPos > -1 Then
                aString.Append(DoubleToString(aPos, 5) & vbTab)
            End If
            aString.Append(DoubleToString(aX, 14, , , , 10) & vbTab & _
                           DoubleToString(aY, 14, , , , 10) & vbTab & _
                           aPointCollection(0) & vbTab & _
                           aPointCollection(1) & vbTab & _
                           DoubleToString(lRatio))
            For lIndex As Integer = 3 To aPointCollection.Count
                aString.Append(vbTab & aPointCollection(lIndex - 1) & vbTab & "???")
            Next lIndex
            aString.AppendLine()
        End If
    End Sub

    Function XY2Z(ByRef aMapWin As IMapWin, ByVal aX As Double, ByVal aY As Double) As atcCollection
        Dim lZ As Double
        Dim lR, lC As Integer
        Dim lOutCollection As New atcCollection

        For lLayerIndex As Integer = 0 To aMapWin.Layers.NumLayers - 1
            If aMapWin.Layers(lLayerIndex).LayerType = eLayerType.Grid Then
                Dim lGrid As MapWinGIS.Grid = aMapWin.Layers(lLayerIndex).GetGridObject
                lGrid.ProjToCell(aX, aY, lC, lR)
                lZ = lGrid.Value(lC, lR)
                If lZ > 0 Then
                    lOutCollection.Add(lLayerIndex, lZ)
                End If
            End If
        Next
        Return lOutCollection
    End Function
End Module
