

Add-Content -Path "%Env:USERPROFILE%\Documents\Output.txt" -Value "Log entry created on"



Get-Date -Format MM/dd/yyyy-hh:mm:ss | Add-Content -Path "%Env:USERPROFILE%\Documents\Output.txt" -NoNewLine