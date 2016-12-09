ECHO OFF
prompt Lab11:
cls
ECHO Submitting 10 orders...
ECHO *
copy "C:\Labs\Work\Lab 11\FileDrop\More Samples\Order*.xml" "C:\Labs\Work\Lab 11\FileDrop\New Order"


ECHO Wait a few seconds before sending the orders for approval by pressing any key...

Pause

move "C:\Labs\Work\Lab 11\FileDrop\Waiting For Approval\*.xml" "C:\Labs\Work\Lab 11\FileDrop\Approved"

