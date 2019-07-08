$objExcel = New-Object -comobject Excel.Application
$objExcel.visible = $True
$objWorkbook = $objExcel.Workbooks.Add()
$objSheet = $objWorkbook.Worksheets.Item(1)
$objSheet.Cells.Item(1,1) = "Server"
$objSheet.Cells.Item(1,2) = "LogName"
$objSheet.Cells.Item(1,3) = "Time"
$objSheet.Cells.Item(1,4) = "Source"
$objSheet.Cells.Item(1,5) = "Message"
$objSheetFormat = $objSheet.UsedRange
$objSheetFormat.Interior.ColorIndex = 19
$objSheetFormat.Font.ColorIndex = 11
$objSheetFormat.Font.Bold = $True



