Option Explicit

Dim UFTapp, FilePath, TestCount, ExcelWorkbook, ExcelSheet, i, TestFile

Set UFTapp = CreateObject ("QuickTest.Application")

Set ExcelWorkbook = Createobject ("Excel.Application")

FilePath = InputBox ("Enter the filepath for the excel workbook containing the test file paths")

ExcelWorkbook.Workbooks.Open FilePath

Set ExcelSheet = ExcelWorkbook.ActiveWorkbook.Worksheets("TestFiles")

TestCount = ExcelSheet.usedrange.rows.count

ExcelWorkbook.application.visible = true

UFTapp.Launch
UFTapp.Visible = True


For i = 2 To TestCount

	TestFile = ExcelSheet.cells(i,"B")

	UFTapp.open TestFile, false, false

	UFTapp.Test.Run

	ExcelSheet.cells(i,"C") = "Test Completed Successfully"
Next
