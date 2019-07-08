$objExcel = New-Object -comobject Excel.Application
$objExcel.visible = $True
$objWorkbook = $objExcel.Workbooks.Add()
$objSheet = $objWorkbook.Worksheets.Item(1)
$objSheet.Cells.Item(1,1) = "Server"
$objSheet.Cells.Item(1,2) = "LogName"
$objSheetFormat = $objSheet.UsedRange
$objSheetFormat.Interior.ColorIndex = 19
$objSheetFormat.Font.ColorIndex = 11
$objSheetFormat.Font.Bold = $True

$row = 1

$servers = gc servers.txt

foreach ($server in $servers)
{
$row = $row + 1
$objSheet.Cells.Item($row,1).Font.Bold = $True
$objSheet.Cells.Item($row,1) = $server
$systemLog = Get-EventLog -LogName System -EntryType Error -computer $server -Newest 5
$row = $row + 1
$objSheet.Cells.Item($row,1).Font.Bold = $True
$objSheet.Cells.Item($row,2) = 'System'
foreach ($SystemEvent in $SystemLog)
{
$row = $row + 1
$objSheet.Cells.Item($row,3) = $SystemEvent.TimeGenerated
$objSheet.Cells.Item($row,4) = $SystemEvent.Source
$objSheet.Cells.Item($row,5) = $SystemEvent.Message
}
}

$objSheetFormat = $objSheet.UsedRange
$objSheetFormat.EntireColumn.AutoFit()
$objSheetFormat.RowHeight = 15
