;#DropDB TransportEasyTest

#Application TransportWin
#Application TransportWeb

*FillForm
 User Name = Admin
*Action Log In

#IfDef TransportWin

*Action About...
 
*Action OK

#EndIf

#IfDef TransportWeb
*Action Navigation(My Details)
#EndIf
