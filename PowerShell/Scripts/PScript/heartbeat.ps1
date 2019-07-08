# Getting status of the Services and look for anything that's "stopped"
$ServiceStatus = get-service DWMRCS | where-object {$_.Status -eq "stopped"}

# Convert Result to String
$ServiceStatusText = $ServiceStatus | fl | Out-String

# If $ServiceStatus <> $null then send notification
If ($ServiceStatus -ne $null)
 {
 ###Send mail
 
$mail = New-Object System.Net.Mail.MailMessage

# Set the addresses (FROM:)
$mail.From ="gsrsadmin@manulife.com"

# Set the Recipient Address (TO:)
$mail.To.Add(”nizam_mahmood@manulife.com”)

# Email Subject
$mail.Subject = “Service Stopped”

# Message Body - Call Function Here

$MessageBody = "One or more services has stopped running or crashed. Please check the server ASAP for possible issues`n"
 $MessageBody = $MessageBody + $ServiceStatusText

# Connect to your mail server
$smtp = New-object System.Net.Mail.SmtpClient("mail.manulife.com")


# Send Mail
$smtp.Send($mail)
}