rem �M���ª�ReplyService
rd /s/q ReplyService

rem �إߦ@�����
MKDIR ReplyService
XCOPY /E App_Data ReplyService\App_Data\
XCOPY bin\*.dll ReplyService\bin\
XCOPY *.asmx ReplyService\
XCOPY Web.config ReplyService\
PAUSE