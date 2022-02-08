CREATE VIEW `Issue_Table_vt`(No,Name,Date,Title,Priority,Severity) 
AS select Issue_Tabel.Issue_ID,Issue_Assign.Name,Issue_Table.Date,Issue_Table.Title,Issue_Priority.Priority,Issue_Severity.Severity 
from Issue_Table,Issue_Priority,Issue_Assign, Issue_Severity 
where Issue_Table.Issue_ID = Issue_Assign.Issue_ID and Issue_Table.Issue_ID = Issue_Priority and Issue_Table.Issue_ID = Issue_Severity.IssueID;