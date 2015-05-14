uses FilesOperations,
     System.IO,
     System.Resources;

var Files:array of FileInfo;
    i:integer;
    res:string;
    ResWriter:ResourceWriter;
    
begin
  Files:=DirectoryInfo.Create('..\..\bin\lng\rus').GetFiles('*.*');
  Writeln('������� '+Files.Length.tostring+' ������, ���������...');
  res:='';
  for i:=0 to Files.Length-1 do
    res:=res+#13#10#13#10'//'+Files[i].Name+#13#10'%PREFIX%='#13#10+
    	ReadFileToEnd(Files[i].FullName);
  Writeln('���������� ��������� ����� � ������...');
  ResWriter:=ResourceWriter.Create('..\..\Localization\DefaultLang.resources');
  ResWriter.AddResource('DefaultLanguage', System.Text.Encoding.GetEncoding(1251).GetBytes(res));
  ResWriter.Generate;
  ResWriter.Close;
  Writeln('OK');
end.