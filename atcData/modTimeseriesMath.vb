Imports atcUtility
Imports MapWinUtility

Public Module modTimeseriesMath

  Public Function SubsetByDate(ByVal aTimeseries As atcTimeseries, _
                               ByVal aStartDate As Double, _
                               ByVal aEndDate As Double, _
                               ByVal aDataSource As atcDataSource) As atcTimeseries
    'TODO: boundary conditions...
    Dim iStart As Integer = 0
    Dim iEnd As Integer = aTimeseries.numValues - 1

    'TODO: binary search for iStart and iEnd could be faster
    While iStart < iEnd AndAlso aTimeseries.Dates.Value(iStart) < aStartDate
      iStart += 1
    End While

    While iEnd > iStart AndAlso aTimeseries.Dates.Value(iEnd) >= aEndDate
      iEnd -= 1
    End While

    Dim numNewValues As Integer = iEnd - iStart + 1
    Dim newValues(numNewValues) As Double
    Dim newDates(numNewValues) As Double

    System.Array.Copy(aTimeseries.Dates.Values, iStart, newDates, 0, numNewValues + 1)
    System.Array.Copy(aTimeseries.Values, iStart + 1, newValues, 1, numNewValues)

    Dim lnewTS As New atcTimeseries(aDataSource)
    lnewTS.Dates = New atcTimeseries(aDataSource)
    lnewTS.Values = newValues
    lnewTS.Dates.Values = newDates
    CopyBaseAttributes(aTimeseries, lnewTS, numNewValues, iStart + 1, 1)

    lnewTS.Attributes.SetValue("Parent Timeseries", aTimeseries)

    Return lnewTS

  End Function

  Public Function SubsetByDateBoundary(ByVal aTimeseries As atcTimeseries, _
                                       ByVal aBoundaryMonth As Integer, _
                                       ByVal aBoundaryDay As Integer, _
                                       ByVal aDataSource As atcDataSource) As atcTimeseries
    Dim lStartDate As Double
    Dim lEndDate As Double
    Dim lStartTimeseriesDate As Date
    Dim lEndTimeseriesDate As Date
    Dim lStartYear As Integer
    Dim lEndYear As Integer

    aTimeseries.EnsureValuesRead()

    'TODO: boundary conditions...
    lStartTimeseriesDate = Date.FromOADate(aTimeseries.Dates.Value(0))
    With lStartTimeseriesDate
      lStartYear = .Year
      If .Month > aBoundaryMonth Then
        lStartYear += 1
      ElseIf .Month = aBoundaryMonth Then
        If .Day > aBoundaryDay Then
          lStartYear += 1
        End If
      End If
      lStartDate = Jday(lStartYear, aBoundaryMonth, aBoundaryDay, 0, 0, 0)
    End With

    lEndTimeseriesDate = Date.FromOADate(aTimeseries.Dates.Value(aTimeseries.Dates.numValues))
    With lEndTimeseriesDate
      lEndYear = .Year
      If .Month < aBoundaryMonth Then
        lEndYear -= 1
      ElseIf .Month = aBoundaryMonth Then
        If .Day < aBoundaryDay Then
          lEndYear -= 1
        End If
      End If
      lEndDate = Jday(lEndYear, aBoundaryMonth, aBoundaryDay, 0, 0, 0)
    End With

    SubsetByDateBoundary = SubsetByDate(aTimeseries, lStartDate, lEndDate, aDataSource)
    SubsetByDateBoundary.Attributes.Add("seasbg", aBoundaryMonth)
    SubsetByDateBoundary.Attributes.Add("seadbg", aBoundaryDay)

  End Function

  Public Sub CopyBaseAttributes(ByVal aFromDataset As atcTimeseries, ByVal aToDataSet As atcTimeseries, _
                                Optional ByVal aNumValues As Integer = 0, _
                                Optional ByVal aStartFrom As Integer = 0, _
                                Optional ByVal aStartTo As Integer = 0)

    For Each lAttribute As atcDefinedValue In aFromDataset.Attributes
      If Not (lAttribute.Definition.Calculated) Then
        aToDataSet.Attributes.SetValue(lAttribute.Definition, lAttribute.Value)
      End If
    Next

    For lIndex As Integer = 0 To aNumValues - 1
      If aFromDataset.ValueAttributesExist(lIndex + aStartFrom) Then
        For Each lAttribute As atcDefinedValue In aFromDataset.ValueAttributes(lIndex + aStartFrom)
          If Not (lAttribute.Definition.Calculated) Then
            aToDataSet.ValueAttributes(lIndex + aStartTo).SetValue(lAttribute.Definition, lAttribute.Value)
          End If
        Next
      End If
    Next
  End Sub
  'Merge a group of atcTimeseries
  'Each atcTimeseries is assumed to be in order by date within itself
  'Resulting atcTimeseries will contain all unique dates from the group, sorted by date
  'If duplicate dates exist, values from atcTimeseries later in aGroup will be left out of result
  Public Function MergeTimeseries(ByVal aGroup As atcDataGroup) As atcTimeseries
    Dim lNewTS As New atcTimeseries(Nothing)
    Dim lNewIndex As Integer
    Dim lTotalNumValues As Integer = 0
    Dim lOldTS As atcTimeseries
    Dim lMinDate As Double = Double.MaxValue
    Dim lMaxGroupIndex As Integer = aGroup.Count - 1
    Dim lMaxCheckForDuplicate As Integer
    Dim lIndex As Integer
    Dim lMinIndex As Integer
    Dim lNextIndex() As Integer
    Dim lNextDate() As Double
    Dim lOldValue As Double

    ReDim lNextIndex(aGroup.Count - 1)
    ReDim lNextDate(aGroup.Count - 1)

    MergeAttributes(aGroup, lNewTS)
    'lNewTS.Attributes.AddHistory("Merged " & aGroup.Count)

    lNewTS.Dates = New atcTimeseries(Nothing)

    'Count total number of values and set up 
    For lIndex = 0 To lMaxGroupIndex
      lOldTS = aGroup.Item(lIndex)
      Try
        lTotalNumValues += lOldTS.numValues
        lNextIndex(lIndex) = 1
        lNextDate(lIndex) = lOldTS.Dates.Value(1)
        'Find minimum starting date and take date 0 from that TS
        If lNextDate(lIndex) < lMinDate Then
          lMinDate = lOldTS.Dates.Value(0)
        End If
      Catch 'Can't get dates values from this TS
        lNextIndex(lIndex) = -1
      End Try
    Next

    If lTotalNumValues > 0 Then
      lNewTS.numValues = lTotalNumValues
      lNewTS.Dates.numValues = lTotalNumValues
      If lMinDate < Double.MaxValue Then
        lNewTS.Dates.Value(0) = lMinDate
      Else
        lNewTS.Dates.Value(0) = Double.NaN
      End If
      lNewTS.Value(0) = Double.NaN

      For lNewIndex = 1 To lTotalNumValues
        'Find earliest date not yet used
        lMinIndex = -1
        lMinDate = Double.MaxValue
        For lIndex = 0 To lMaxGroupIndex
          If lNextIndex(lIndex) > 0 Then
            If lNextDate(lIndex) < lMinDate Then
              lMinIndex = lIndex
              lMinDate = lNextDate(lIndex)
            End If
          End If
        Next
        'TODO: could make common cases faster with Array.Copy
        'Now that we have found lMinDate, could also find the lNextMinDate when the 
        'minimum date from a different TS happens, then find out how many more values 
        'from this TS are earlier than lNextMinDate, then copy all of them to the 
        'new TS at once

        'Add earliest date/value to new TS
        If lMinIndex >= 0 Then
          lOldTS = aGroup.Item(lMinIndex)
          lOldValue = lOldTS.Value(lNextIndex(lMinIndex))
          If lOldTS.ValueAttributesGetValue(lNextIndex(lMinIndex), "Inserted", False) Then
            'This value was inserted during splitting and will now be removed
            lNewIndex -= 1
            lTotalNumValues -= 1
            lMaxCheckForDuplicate = lMinIndex 'Don't remove duplicate since we aren't using this one
          Else
            lNewTS.Dates.Value(lNewIndex) = lMinDate
            lNewTS.Value(lNewIndex) = lOldValue
            lMaxCheckForDuplicate = lMaxGroupIndex
          End If

          For lIndex = lMinIndex To lMaxCheckForDuplicate
            If lNextIndex(lIndex) > 0 Then
              If Math.Abs(lNextDate(lIndex) - lMinDate) < Double.Epsilon Then
                If lIndex > lMinIndex Then
                  lOldTS = aGroup.Item(lIndex)
                  lTotalNumValues -= 1
                  'Logger.dbg("MergeTimeseries discarding date " & DumpDate(lNextDate(lIndex)) & " value " & lOldTS.Value(lNextIndex(lIndex)) & " using " & lOldValue)
                End If
                lNextIndex(lIndex) += 1
                If lNextIndex(lIndex) <= lOldTS.numValues Then
                  lNextDate(lIndex) = lOldTS.Dates.Value(lNextIndex(lIndex))
                Else
                  lNextIndex(lIndex) = -1
                End If
              End If
            End If
          Next
        Else 'ran out of values in all the datasets
          Exit For
        End If
      Next
      If lTotalNumValues < lNewTS.numValues Then
        lNewTS.numValues = lTotalNumValues
        lNewTS.Dates.numValues = lTotalNumValues
      End If
    End If
    Return lNewTS
  End Function

  Private Sub MergeAttributes(ByVal aGroup As atcDataGroup, ByVal aTarget As atcTimeseries)
    For Each lAttribute As atcDefinedValue In aGroup(0).Attributes
      If Not lAttribute.Definition.Calculated Then
        Dim lMatch As Boolean = True
        For Each lData As atcDataSet In aGroup
          Try
            If lData.Attributes.GetValue(lAttribute.Definition.Name) <> lAttribute.Value Then
              lMatch = False
              Exit For
            End If
          Catch 'Can't test for equality, don't assign this one a value in aTarget
            lMatch = False
            Exit For
          End Try
        Next
        If lMatch Then aTarget.Attributes.SetValue(lAttribute.Definition, lAttribute.Value, lAttribute.Arguments)
      End If
    Next
  End Sub

  Public Function DatasetOrGroupToGroup(ByVal aObj As Object) As atcDataGroup
    Try
      Return aObj
    Catch
    End Try
    Try
      Return New atcDataGroup(aObj)
    Catch
    End Try
    Return Nothing
  End Function

  'Fill values in constant interval timeseries with specified values.
  'Assumes dates are at the end of each value's interval and that the
  '0th position in the Dates array is the beginning of the first interval.
  Public Function FillValues(ByVal aOldTSer As atcTimeseries, _
                             ByVal aTU As atcTimeUnit, _
                             Optional ByVal aTS As Long = 1, _
                             Optional ByVal aFillVal As Double = 0, _
                             Optional ByVal aMissVal As Double = -999, _
                             Optional ByVal aAccumVal As Double = -999, _
                             Optional ByVal aDataSource As atcDataSource = Nothing) As atcTimeseries
    'aTU - Time units (1-sec, 2-min, 3-hour, 4-day, 5-month, 6-year, 7-century).
    'aTS - Timestep in units of aTU.
    'aFillVal - Value to Fill data gaps with.
    'aMissVal - Value indicating missing data.
    'aAccumVal - Value indicating accumulated data.
    Dim lDate(5) As Integer
    Dim lNewNumVals As Integer
    Dim lNewInd As Integer
    Dim lOldInd As Integer
    Dim lDateNew As Double
    Dim lDateOld As Double
    Dim lValOld As Double
    Dim lNewVals() As Double
    Dim lNewDates() As Double = NewDates(aOldTSer, aTU, aTS)

    If lNewDates.GetUpperBound(0) > 0 Then 'dates for new timeseries set
      'Select Case aTU
      '  Case atcTimeUnit.TUSecond : lIntvl = JulianSecond : lVarLength = 0
      '  Case atcTimeUnit.TUMinute : lIntvl = JulianMinute : lVarLength = 0
      '  Case atcTimeUnit.TUHour : lIntvl = JulianHour : lVarLength = 0
      '  Case atcTimeUnit.TUDay : lIntvl = aTS : lVarLength = 0
      '  Case atcTimeUnit.TUMonth : lIntvl = aTS * 30.44 : lVarLength = 1
      '  Case atcTimeUnit.TUYear : lIntvl = aTS * 365.25 : lVarLength = 2
      '  Case atcTimeUnit.TUCentury : lIntvl = aTS * 36525 : lVarLength = 3
      'End Select

      Dim lNewTSer As New atcTimeseries(aDataSource)
      CopyBaseAttributes(aOldTSer, lNewTSer)
      lNewTSer.Attributes.SetValue("point", False)
      If aOldTSer.ValueAttributesExist Then 'TODO:: Something with value attributes
      End If

      'If aOldTSer.Dates.Value(0) <= 0 Or Double.IsNaN(aOldTSer.Dates.Value(0)) Then
      '  If lVarLength > 0 Then
      '    J2Date(aOldTSer.Dates.Value(1), lDate)
      '    If lVarLength = 1 Then
      '      lSJDay = aOldTSer.Dates.Value(1) - daymon(lDate(0), lDate(1))
      '    ElseIf lVarLength = 2 Then
      '      lSJDay = aOldTSer.Dates.Value(1) - 365 - (daymon(lDate(0), 2) - 28)
      '    Else 'TODO::something for centuries
      '    End If
      '  Else
      '    lSJDay = aOldTSer.Dates.Value(1) - lIntvl
      '  End If
      'Else
      '  lSJDay = aOldTSer.Dates.Value(0)
      'End If
      'lEJDay = aOldTSer.Dates.Value(aOldTSer.numValues)
      'lNewNumVals = (lEJDay - lSJDay) / lIntvl
      'ReDim lNewVals(lNewNumVals)
      'ReDim lNewDates(lNewNumVals)
      'lNewDates(0) = lSJDay
      lNewNumVals = lNewDates.GetUpperBound(0)
      ReDim lNewVals(lNewNumVals)
      lOldInd = 1
      lDateOld = aOldTSer.Dates.Value(lOldInd)
      lNewInd = 1
      lDateNew = lNewDates(lNewInd)
      While lNewInd <= lNewNumVals
        While lDateNew < lDateOld - JulianSecond 'Fill values not present in original data
          Select Case lValOld
            Case aMissVal
              If aOldTSer.Value(lOldInd) = aMissVal Then
                lNewVals(lNewInd) = aMissVal
              Else
                lNewVals(lNewInd) = aFillVal
              End If
            Case aAccumVal : lNewVals(lNewInd) = aAccumVal
            Case Else : lNewVals(lNewInd) = aFillVal
          End Select
          'lNewDates(lNewInd) = lDateNew
          lNewInd += 1
          lDateNew = lNewDates(lNewInd)
          'If lVarLength = 1 Then
          '  Call J2Date(lDateNew, lDate)
          '  lDateNew = lDateNew + daymon(lDate(0), lDate(1))
          'ElseIf lVarLength = 2 Then
          '  Call J2Date(lDateNew, lDate)
          '  lDateNew = lDateNew + 365 + (daymon(lDate(0), 2) - 28)
          'Else
          '  lDateNew = lDateNew + lIntvl
          'End If
        End While
        lValOld = aOldTSer.Value(lOldInd)
        lNewVals(lNewInd) = lValOld
        'lNewDates(lNewInd) = lDateNew
        'If lVarLength = 1 Then 'monthly
        '  Call J2Date(lDateNew, lDate)
        '  lDateNew = lDateNew + daymon(lDate(0), lDate(1))
        'ElseIf lVarLength = 2 Then 'yearly
        '  Call J2Date(lDateNew, lDate)
        '  lDateNew = lDateNew + 365 + (daymon(lDate(0), 2) - 28)
        'Else
        '  lDateNew = lDateNew + lIntvl
        'End If
        lNewInd += 1
        If lNewInd <= lNewNumVals Then lDateNew = lNewDates(lNewInd)
        lOldInd += 1
        If lOldInd <= aOldTSer.numValues Then lDateOld = aOldTSer.Dates.Value(lOldInd)
      End While
      lNewTSer.Dates = New atcTimeseries(Nothing)
      lNewTSer.Dates.Values = lNewDates
      lNewTSer.Values = lNewVals
      Return lNewTSer
    Else
      Logger.Msg("Invalid value for time units ('" & aTU & "') in call to Timeseries FillValues module.", "Fill Values Problem")
      Return Nothing
    End If
  End Function

  Public Function Aggregate(ByVal aTimeseries As atcTimeseries, _
                            ByVal aTU As atcTimeUnit, _
                            ByVal aTS As Integer, _
                            ByVal aTran As atcTran, _
                            Optional ByVal aDataSource As atcDataSource = Nothing) As atcTimeseries

    Dim lNewDates() As Double = NewDates(aTimeseries, aTU, aTS)
    Dim lNumNewVals As Integer = lNewDates.GetUpperBound(0)
    If lNumNewVals > 0 Then
      Dim lNewTSer As New atcTimeseries(aDataSource)
      lNewTSer.Dates = New atcTimeseries(aDataSource)
      CopyBaseAttributes(aTimeseries, lNewTSer)
      lNewTSer.Attributes.SetValue("TU", aTU)
      lNewTSer.Attributes.SetValue("TS", aTS)
      lNewTSer.Attributes.SetValue("point", False)
      If aTimeseries.ValueAttributesExist Then 'TODO:: Something with value attributes
      End If
      lNewTSer.Dates.Values = lNewDates
      Dim lNewIndex As Integer = 1
      Dim lNewVals(lNumNewVals) As Double
      Dim lDateNew As Double = lNewDates(1)
      Dim lDateOld As Double
      Dim lValOld As Double
      Dim lOldIndex As Integer = 1
      Dim lPrevDateOld As Double = lNewDates(0) 'old and new TSers should have same start date
      Dim lPrevDateNew As Double = lNewDates(0)
      Dim lOverlapStart As Double
      Dim lOverlapEnd As Double
      Dim lNumOldVals As Integer = aTimeseries.numValues
      Dim lFraction As Double
      Dim lCumuFrac As Double

      If aTimeseries.numValues > 0 Then
        lValOld = aTimeseries.Value(1)
        lDateOld = aTimeseries.Dates.Value(1)
      End If

      Select Case aTran

        Case atcTran.TranAverSame, atcTran.TranSumDiv
          While lNewIndex <= lNumNewVals
            lDateNew = lNewDates(lNewIndex)
            lNewVals(lNewIndex) = 0
            While lPrevDateOld < lDateNew And lOldIndex <= lNumOldVals
              If lPrevDateOld > lPrevDateNew Then lOverlapStart = lPrevDateOld Else lOverlapStart = lPrevDateNew
              If lDateNew > lDateOld Then lOverlapEnd = lDateOld Else lOverlapEnd = lDateNew
              lFraction = (lOverlapEnd - lOverlapStart) / (lDateNew - lPrevDateNew)
              lCumuFrac = lCumuFrac + lFraction
              If aTran = atcTran.TranSumDiv Then
                lFraction = (lOverlapEnd - lOverlapStart) / (lDateOld - lPrevDateOld)
              End If
              lNewVals(lNewIndex) = lNewVals(lNewIndex) + lFraction * lValOld
              If lPrevDateOld < lDateNew Then
                If lDateOld > lDateNew Then 'use remaining part of this old interval on next new interval
                  lPrevDateOld = lDateNew
                  If aTran = atcTran.TranSumDiv Then lValOld = lValOld - lValOld * lFraction
                Else
                  lPrevDateOld = lDateOld
                  lOldIndex = lOldIndex + 1
                  If lOldIndex <= lNumOldVals Then
                    lDateOld = aTimeseries.Dates.Value(lOldIndex)
                    lValOld = aTimeseries.Value(lOldIndex)
                  End If
                  lCumuFrac = 0
                End If
              End If
            End While
            lPrevDateNew = lDateNew
            If aTran = atcTran.TranSumDiv AndAlso lCumuFrac > 0.01 AndAlso lCumuFrac < 0.999 Then
              lNewVals(lNewIndex) = lNewVals(lNewIndex) / lCumuFrac
            End If
            lNewIndex = lNewIndex + 1
          End While

        Case atcTran.TranMax
          While lNewIndex <= lNumNewVals
            lDateNew = lNewDates(lNewIndex)
            lNewVals(lNewIndex) = -1.0E+30
            While lDateOld <= lDateNew AndAlso lOldIndex <= lNumOldVals
              If lNewVals(lNewIndex) < lValOld Then lNewVals(lNewIndex) = lValOld
              lOldIndex = lOldIndex + 1
              If lOldIndex <= lNumOldVals Then
                lDateOld = aTimeseries.Dates.Value(lOldIndex)
                lValOld = aTimeseries.Value(lOldIndex)
              End If
            End While
            lNewIndex = lNewIndex + 1
          End While

        Case atcTran.TranMin
          While lNewIndex <= lNumNewVals
            lDateNew = lNewDates(lNewIndex)
            lNewVals(lNewIndex) = 1.0E+30
            While lDateOld <= lDateNew AndAlso lOldIndex <= lNumOldVals
              If lNewVals(lNewIndex) > lValOld Then lNewVals(lNewIndex) = lValOld
              lOldIndex = lOldIndex + 1
              If lOldIndex <= lNumOldVals Then
                lDateOld = aTimeseries.Dates.Value(lOldIndex)
                lValOld = aTimeseries.Value(lOldIndex)
              End If
            End While
            lNewIndex = lNewIndex + 1
          End While

      End Select
      lNewTSer.Values = lNewVals
      Return lNewTSer
    Else
      Return Nothing
    End If
  End Function

  'Build Date array for a timeseries with start/end of aTSer and time units/step of aTU/aTS
  Public Function NewDates(ByVal aTSer As atcTimeseries, ByVal aTU As atcTimeUnit, ByVal aTS As Integer) As Double()

    Dim lNewDates() As Double
    Dim lIntvl As Double
    Dim lSJDay As Double
    Dim lEJDay As Double
    Dim lNewNumDates As Integer
    Dim lDate(5) As Integer
    Dim lSDate(5) As Integer
    Dim lTUnit As Integer
    Dim lTStep As Integer

    If aTU >= atcTimeUnit.TUSecond AndAlso aTU <= atcTimeUnit.TUCentury Then
      'get start date/time for existing TSer
      If aTSer.Dates.Value(0) <= 0 Or Double.IsNaN(aTSer.Dates.Value(0)) Then
        lTUnit = aTSer.Attributes.GetValue("Time Unit")
        lTStep = aTSer.Attributes.GetValue("Time Step")
        Select Case lTUnit
          Case atcTimeUnit.TUSecond : lIntvl = lTStep * JulianSecond
          Case atcTimeUnit.TUMinute : lIntvl = lTStep * JulianMinute
          Case atcTimeUnit.TUHour : lIntvl = lTStep * JulianHour
          Case atcTimeUnit.TUDay : lIntvl = lTStep
          Case atcTimeUnit.TUMonth : lIntvl = lTStep * 30.44
          Case atcTimeUnit.TUYear : lIntvl = lTStep * 365.25
          Case atcTimeUnit.TUCentury : lIntvl = lTStep * 36525
        End Select
        If lIntvl > 28 Then
          J2Date(aTSer.Dates.Value(1), lDate)
          If lTUnit = atcTimeUnit.TUMonth Then 'monthly
            lSJDay = aTSer.Dates.Value(1) - daymon(lDate(0), lDate(1))
          ElseIf lTUnit = atcTimeUnit.TUYear Then 'yearly
            lSJDay = aTSer.Dates.Value(1) - 365 - (daymon(lDate(0), 2) - 28)
          Else 'TODO::something for centuries
          End If
        Else
          lSJDay = aTSer.Dates.Value(1) - lIntvl
        End If
      Else
        lSJDay = aTSer.Dates.Value(0)
      End If
      'get interval of new TSer
      Select Case aTU
        Case atcTimeUnit.TUSecond : lIntvl = aTS * JulianSecond
        Case atcTimeUnit.TUMinute : lIntvl = aTS * JulianMinute
        Case atcTimeUnit.TUHour : lIntvl = aTS * JulianHour
        Case atcTimeUnit.TUDay : lIntvl = aTS
        Case atcTimeUnit.TUMonth : lIntvl = aTS * 30.44
        Case atcTimeUnit.TUYear : lIntvl = aTS * 365.25
        Case atcTimeUnit.TUCentury : lIntvl = aTS * 36525
      End Select
      lEJDay = aTSer.Dates.Value(aTSer.numValues)
      lNewNumDates = CInt((lEJDay - lSJDay) / lIntvl)
      ReDim lNewDates(lNewNumDates)
      lNewDates(0) = lSJDay 'new TSer start is same as existing TSer start
      If aTU > modDate.atcTimeUnit.TUDay Then J2Date(lSJDay, lSDate) 'will need start date array
      For i As Integer = 1 To lNewNumDates
        If aTU < modDate.atcTimeUnit.TUMonth Then
          lNewDates(i) = lSJDay + lIntvl * i
        Else 'need to use special TIMADD function for long, varying length intervals
          TIMADD(lSDate, aTU, aTS, i, lDate)
          lNewDates(i) = Date2J(lDate)
        End If
      Next
    End If
    Return lNewDates
  End Function

  ''Make bins, sort data values into the bins, and assign collection of Bins as new attribute
  'Public Sub MakeBins(ByVal aTS As atcTimeseries, Optional ByVal aMaxBinSize As Integer = 100)
  '  Dim lNumValues As Integer = aTS.numValues
  '  Dim lCurValue As Double
  '  Dim lBinIndex As Integer
  '  Dim lCurBin As New ArrayList
  '  Dim lBins As New atcCollection
  '  lBins.Add(aTS.Attributes.GetValue("Max"), lCurBin)

  '  Logger.Dbg("Sorting " & lNumValues & " values into bins of at most " & aMaxBinSize)
  '  For lOldIndex As Integer = 1 To lNumValues
  '    lCurValue = aTS.Value(lOldIndex)

  '    'find first bin with maximum >= lCurValue
  '    lBinIndex = 0
  '    While lCurValue > lBins.Keys(lBinIndex)
  '      lBinIndex += 1
  '    End While
  '    lCurBin = lBins.Item(lBinIndex)

  '    'Insert in numeric order within bin
  '    Dim lInsertIndex As Integer = 0
  '    Dim lLastIndex As Integer = lCurBin.Count - 1
  '    If lLastIndex > -1 Then  'Find position to insert
  '      While lCurValue > lCurBin.Item(lInsertIndex)
  '        lInsertIndex += 1
  '        If lInsertIndex > lLastIndex Then Exit While
  '      End While
  '    End If
  '    lCurBin.Insert(lInsertIndex, lCurValue)

  '    If lCurBin.Count > aMaxBinSize Then
  '      SplitBin(lBins, lCurBin, lBinIndex)
  '    End If

  '  Next
  '  Logger.Dbg("Created " & lBins.Count & " bins")
  '  For lBinIndex = 0 To lBins.Count - 1
  '    lCurBin = lBins.Item(lBinIndex)
  '    Logger.Dbg("Bin " & lBinIndex & " (" & lBins.Keys(lBinIndex) & ") contains " & lCurBin.Count)
  '    For Each lCurValue In lCurBin
  '      Logger.Dbg(DoubleToString(lCurValue))
  '    Next
  '    lNumValues -= lCurBin.Count
  '  Next
  '  If lNumValues <> 0 Then
  '    Logger.Dbg("Wrong number of values in bins -- " & lNumValues & " were in dataset but not in bins")
  '  End If
  '  aTS.Attributes.SetValue("Bins", lBins)
  'End Sub

  'Make bins, sort data values into the bins
  'Default maximum bin size is 1% of total number of values
  Public Function MakeBins(ByVal aTS As atcTimeseries, Optional ByVal aMaxBinSize As Integer = 0) As atcCollection
    Dim lNumValues As Integer = aTS.numValues
    Dim lCurValue As Double
    Dim lCurBinMax As Double = aTS.Attributes.GetValue("Max")
    Dim lBinIndex As Integer = 0
    Dim lCurBin As New ArrayList
    Dim lBins As New atcCollection                     'Keys of lBins are the maximum value in each bin                                   
    lBins.Add(lCurBinMax, lCurBin) 'First bin created is assigned maximum value for dataset
    'Bins created later are inserted before this bin, which remains the "last" bin containing the highest values
    If aMaxBinSize < 1 Then
      aMaxBinSize = lNumValues / 100 'Default to max of 1% of values in each bin
      If aMaxBinSize < 10 Then aMaxBinSize = 10
    End If
    Logger.Progress("Sorting values into bins", 0, lNumValues)
    For lOldIndex As Integer = 1 To lNumValues
      lCurValue = aTS.Value(lOldIndex)

      'If the previously used bin does not fit, find first bin with maximum >= lCurValue
      'If lCurValue > lCurBinMax OrElse (lBinIndex > 0 AndAlso lCurValue < lBins.Keys.Item(lBinIndex - 1)) Then
      lBinIndex = BinarySearchFirstGreaterDoubleArrayList(lBins.Keys, lCurValue)
      lCurBin = lBins.Item(lBinIndex)
      'lCurBinMax = lBins.Keys.Item(lBinIndex)
      'End If

      'Insert in numeric order within bin
      Dim lInsertIndex As Integer = BinarySearchFirstGreaterDoubleArrayList(lCurBin, lCurValue)
      lCurBin.Insert(lInsertIndex, lCurValue)

      If lCurBin.Count > aMaxBinSize Then
        SplitBin(lBins, lCurBin, lBinIndex)
        '  lCurBin = lBins.Item(lBinIndex)
        '  lCurBinMax = lBins.Keys.Item(lBinIndex)
        Logger.Progress("Sorting values into " & lBins.Count & " bins", lOldIndex, lNumValues)
      End If

    Next
    Logger.Progress("Sorted values into " & lBins.Count & " bins", lNumValues, lNumValues)
    'For lBinIndex = 0 To lBins.Count - 1
    '  lCurBin = lBins.Item(lBinIndex)
    '  Logger.Dbg("Bin " & lBinIndex & " (" & lBins.Keys(lBinIndex) & ") contains " & lCurBin.Count)
    '  For Each lCurValue In lCurBin
    '    Logger.Dbg(DoubleToString(lCurValue))
    '  Next
    '  lNumValues -= lCurBin.Count
    'Next
    'If lNumValues <> 0 Then
    '  Logger.Dbg("Wrong number of values in bins -- " & lNumValues & " were in dataset but not in bins")
    'End If
    Return lBins
  End Function

  'aBins = collection of bins
  'aBin = bin to be split in half
  'aBinIndex = current index of aBin in aBins
  Private Sub SplitBin(ByVal aBins As atcCollection, ByVal aBin As ArrayList, ByVal aBinIndex As Integer)
    Dim lSplitStart As Integer = 0
    Dim lSplitCount As Integer = aBin.Count / 2
    Dim lNewBin As New ArrayList(aBin.GetRange(lSplitStart, lSplitCount))
    aBin.RemoveRange(lSplitStart, lSplitCount)
    aBins.Insert(aBinIndex, lNewBin.Item(lSplitCount - 1), lNewBin)
  End Sub

  'Binary search through an ArrayList containing Double values sorted in ascending order
  'Return the index of the first value >= aValue
  'Returns aArray.Count if aArray contains no values >= aValue
  Private Function BinarySearchFirstGreaterDoubleArrayList(ByVal aArray As ArrayList, ByVal aValue As Double) As Integer
    Dim lHigher As Integer = aArray.Count - 1
    If lHigher < 0 Then Return 0 'No values present to compare to
    Dim lLower As Integer = -1 'Note: this starts one *lower than* start of where to search in array
    Dim lProbe As Integer
    While (lHigher - lLower > 1)
      lProbe = (lHigher + lLower) / 2
      If aArray(lProbe) < aValue Then
        lLower = lProbe
      Else
        lHigher = lProbe
      End If
    End While
    If aValue > aArray(lHigher) Then
      Return lHigher + 1
    Else
      Return lHigher
    End If
  End Function

  Public Sub ComputePercentile(ByVal aTimeseries As atcTimeseries, ByVal aPercentile As Double)
    Dim lNumValues As Integer = aTimeseries.numValues
    Select Case lNumValues
      Case Is < 1
        'Can't compute with no values
      Case 1
        aTimeseries.Attributes.SetValue(Format(aPercentile, "00.####") & "%", aTimeseries.Value(0))
      Case Else
        Dim lBins As atcCollection = aTimeseries.Attributes.GetValue("Bins")
        If lBins Is Nothing Then
          lBins = MakeBins(aTimeseries)
          aTimeseries.Attributes.SetValue("Bins", lBins)
        End If

        'TODO: could interpolate between closest two values rather than choosing closest one, should we?
        Dim lAccumulatedCount As Integer = 0
        Dim lNextAccumulatedCount As Integer = 0
        Dim lBinIndex As Integer = -1
        Dim lPercentileIndex As Integer = aPercentile * lNumValues / 100.0 - 1
        If lPercentileIndex < 0 Then lPercentileIndex = 0
        If lPercentileIndex >= aTimeseries.numValues Then lPercentileIndex = lNumValues - 1
        While lNextAccumulatedCount <= lPercentileIndex
          lAccumulatedCount = lNextAccumulatedCount
          lBinIndex += 1
          lNextAccumulatedCount = lAccumulatedCount + lBins(lBinIndex).Count
        End While
        Dim lBin As ArrayList = lBins(lBinIndex)
        aTimeseries.Attributes.SetValue(Format(aPercentile, "00.####") & "%", lBin.Item(lPercentileIndex - lAccumulatedCount))
    End Select
  End Sub
End Module
