rem 清除舊的ReplyService
rd /s/q ReplyService

rem 建立共有資料
MKDIR ReplyService
XCOPY /E App_Data ReplyService\App_Data\
XCOPY bin\*.dll ReplyService\bin\
XCOPY *.asmx ReplyService\
XCOPY Web.config ReplyService\
PAUSE