
'Module Module2
'    Public Declare Function CloseHandle Lib "kernel32" (ByVal hObject As Long) As Long
'    Public Declare Function WriteFile Lib "kernel32" (ByVal hFile As Long, lpBuffer As Byte(), ByVal nNumberOfBytesToWrite As Long, lpNumberOfBytesWritten As Long, ByVal lpOverlapped As Long) As Long

'    Public Structure SECURITY_ATTRIBUTES
'        Dim nLength As Long
'        Dim lpSecurityDescriptor As Long
'        Dim bInheritHandle As Long
'    End Structure
'    Public Declare Function CreateFile Lib "kernel32" Alias "CreateFileA" (ByVal lpFileName As String, ByVal dwDesiredAccess As Integer, ByVal dwShareMode As Integer, ByVal lpSecurityAttributes As SECURITY_ATTRIBUTES, ByVal dwCreationDisposition As Integer, ByVal dwFlagsAndAttributes As Integer, ByVal hTemplateFile As Integer) As Integer
'    Public Const GENERIC_READ = &H80000000
'    Public Const GENERIC_WRITE = &H40000000
'    Public Const OPEN_EXISTING = 3
'    Public Const INVALID_HANDLE_VALUE = -1
'End Module
