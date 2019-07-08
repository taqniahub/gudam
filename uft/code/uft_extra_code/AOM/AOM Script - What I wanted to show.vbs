Dim App 'As Application
Set App = CreateObject("QuickTest.Application")
App.Launch
App.Visible = True
App.Test.Settings.Launchers("Web").Active = False
App.Test.Settings.Launchers("Web").Browser = "IE"
App.Test.Settings.Launchers("Web").Address = "www.amazon.com"
App.Test.Settings.Launchers("Web").CloseOnExit = True
App.Test.Settings.Launchers("Windows Applications").Active = True
App.Test.Settings.Launchers("Windows Applications").Applications.RemoveAll
App.Test.Settings.Launchers("Windows Applications").RecordOnQTDescendants = True
App.Test.Settings.Launchers("Windows Applications").RecordOnExplorerDescendants = False
App.Test.Settings.Launchers("Windows Applications").RecordOnSpecifiedApplications = True
App.Test.Settings.Run.IterationMode = "rngAll"
App.Test.Settings.Run.StartIteration = 1
App.Test.Settings.Run.EndIteration = 1
App.Test.Settings.Run.ObjectSyncTimeOut = 40000
App.Test.Settings.Run.OnError = "Dialog"
App.Test.Settings.Run.DisableSmartIdentification = False
App.Test.Settings.Resources.DataTablePath = "<Default>"
App.Test.Settings.Resources.Libraries.RemoveAll
App.Test.Settings.Web.BrowserNavigationTimeout = 30000
App.Test.Settings.Web.ActiveScreenAccess.UserName = ""
App.Test.Settings.Web.ActiveScreenAccess.Password = ""
App.Test.Settings.Recovery.Enabled = True
App.Test.Settings.Recovery.SetActivationMode "OnEveryStep"
App.Test.Settings.Recovery.RemoveAll
App.Test.Settings.Recovery.Item(1).Enabled = False 
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' System Local Monitoring settings
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
App.Test.Settings.LocalSystemMonitor.Enable = false
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Log Tracking settings
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
With App.Test.Settings.LogTracking 
	.IncludeInResults = False 
	.Port = 18081 
	.IP = "127.0.0.1" 
	.MinTriggerLevel = "ERROR" 
	.EnableAutoConfig = False 
	.RecoverConfigAfterRun = False 
	.ConfigFile = "" 
	.MinConfigLevel = "WARN" 
End With
