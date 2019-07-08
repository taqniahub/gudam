SystemUtil.CloseProcessByName "iexplore.exe"

SystemUtil.Run "iexplore.exe","www.google.com"



'How to use xpath
'Find out the Browser tile and page title from object property using object spy and for the webEdit use xpath

Browser("title:=Google").Page("title:=Google").WebEdit("xpath:=//input[@type='text']").Set "python"
