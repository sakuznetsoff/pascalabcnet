unit PT4Demo;

interface

implementation

uses PT4TaskMaker;

procedure Demo3;
var
  a, b: real;
begin
  StartTask('���� � ����� ������, �������� ������������');
  TaskText('���� ������� ��������������~{a} �~{b}.', 0, 2);
  TaskText('����� ��� ������� {S}~=~{a}\*{b} � �������� {P}~=~2\*({a}\;+\;{b}).', 0, 4);
  a := (1 + Random(100)) / 10;
  b := (1 + Random(100)) / 10;
  DataR('a = ', a, xLeft, 3, 4);
  DataR('b = ', b, xRight, 3, 4);
  ResultR('S = ', a * b, 0, 2, 4);
  ResultR('P = ', 2 * (a + b), 0, 4, 4);
  SetNumberOfTests(3);
end;

procedure Demo4;
var
  m, n, i, j, k: integer;
  a: array [1..5, 1..8] of real;
begin
  StartTask('��������� ������� (�������): ����� ���������');
  TaskText('���� ������� �������~{M}\;\x\;{N} �\ ����� �����~{K} (1~\l~{K}~\l~{M}).', 0, 2);
  TaskText('������� �������� {K}-� ������ ������ �������.', 0, 4);
  m := 2 + Random(4);
  n := 4 + Random(5);
  k := 1;
  if m = 5 then k := 0;
  DataN('M = ', m, 3, 1, 1);
  DataN('N = ', n, 10, 1, 1);
  for i := 1 to M do
    for j := 1 to N do
    begin
      a[i, j] := 9.98 * Random;
      DataR('', a[i,j], Center(j, n, 4, 2), i + k, 4);
    end;
  k := 1 + Random(m);
  dataN('K = ', k, 68, 5, 1);
  for j := 1 to n do
    ResultR('', a[k, j], Center(j, n, 4, 2), 3, 4);
  SetNumberOfTests(5);
end;

procedure Demo5;
var s: string;
begin
  StartTask('������� � ������: �������� ��������');
  TaskText('���� ������~{S}.', 0, 2);
  TaskText('������� �� ������ � ��������� ������.', 0, 4);
  s := SampleWord(Random(SampleWordCount));
  DataS('S = ', s, 0, 3);
  ResultC('������ ������: ', s[1], xLeft, 3);
  ResultC('��������� ������: ', s[length(s)], xRight, 3);
  SetNumberOfTests(4);
end;

function FileName(Len: integer): string;
const
  c = '0123456789abcdefghijklmnopqrstuvwxyz';
var
  i: integer;
begin
  result := '';
  for i := 1 to len do
    result := result + c[Random(Length(c))+1];
end;

procedure Demo6;
var
  k, i, j, jmax: integer;
  s1, s2, s3: string;
  fs1: file of shortstring;
  fs2: file of shortstring;
  fc3: file of char;
  s: shortstring;
  c: char;
begin
  StartTask('���������� � ��������� �����');
  TaskText('���� ����� �����~{K} (>\,0) � ��������� ����.', 0, 1);
  TaskText('������� ��� ����� �����: ���������, ���������� ������ {K}~��������', 0, 2);
  TaskText('������ ������ ��������� �����, � ����������, ���������� {K}-� ������', 0, 3);
  TaskText('������ ������ (���� ����� ������ ������~{K}, �� � ��������� ����', 0, 4);
  TaskText('������������ ��� ������, � � ���������� ���� ������������ ������).', 0, 5);
  s1 := '1' + FileName(5) + '.tst';
  s2 := '2' + FileName(5) + '.tst';
  s3 := '3' + FileName(5) + '.tst';
  Assign(fs1, s1);
  Rewrite(fs1);
  Assign(fs2, s2);
  Rewrite(fs2);
  Assign(fc3, s3);
  Rewrite(fc3);
  k := 2 + Random(10);
  jmax := 0;
  for i := 1 to 10 + Random(20) do
  begin
    j := 2 + Random(15);
    if jmax < j then
      jmax := j;
    s := FileName(j);
    write(fs1, s);
    if j >= k then
      c := s[k]
    else
      c := ' ';
    write(fc3, c);
    s := copy(s, 1, k);
    write(fs2,s);
  end;
  Close(fs1);
  Close(fs2);
  Close(fc3);
  DataN('K =', k, 0, 1, 2);
  DataS('��� ��������� �����: ', s1, 3, 2);
  DataS('��� ��������������� ���������� �����:  ', s2, 3, 4);
  DataS('��� ��������������� ����������� �����: ', s3, 3, 5);
  DataComment('���������� ��������� �����:', xRight, 2);
  DataFileS(s1, 3, jmax + 3);
  ResultComment('���������� ��������������� ���������� �����:', 0, 2);
  ResultComment('���������� ��������������� ����������� �����:', 0, 4);
  ResultFileS(s2, 3, k + 3);
  ResultFileC(s3, 5, 4);
end;

procedure Demo7;
var
  i, n: integer;
  s: TSampleLines;
  s1, s2: string;
  t1, t2: text;
begin
  StartTask('��������� �����: �������� ��������');
  TaskText('��� ��������� ����.', 0, 2);
  TaskText('������� �� ���� ��� ������ ������.', 0, 4);
  s1 := FileName(6) + '.tst';
  s2 := '#' + FileName(6) + '.tst';
  SampleText(Random(SampleTextCount), n, S);
  Assign(t2, s2);
  Rewrite(t2);
  Assign(t1, s1);
  Rewrite(t1);
  for i := 0 to n - 1 do
  begin
    writeln(t2, s[i]);
    if s[i] <> '' then
      writeln(t1, s[i]);
  end;
  Close(t1);
  Close(t2);
  ResultFileT(s1, 1, 5);
  Rename(t2, s1);
  DataFileT(s1, 2, 5);
  DataS('��� �����: ', s1, 0, 1);
  SetNumberOfTests(3);
end;

var WrongNode: TNode;

procedure Demo8;
var
  i, n: integer;
  p, p1, p2: PNode;
begin
  StartTask('������������ ��������� ������: ���������� ������');
  TaskText('��� ���������~{P}_1 �� ������ �������� ������� ���������-������� ���� TNode,', 0, 1);
  TaskText('��������� ����� ����� � ������� ���� Next. ��������� ���� Prev ������ TNode,', 0, 2);
  TaskText('������������� �������� (\I�����������\i) ������� �  \I����������\i, � ������� ������', 0, 3);
  TaskText('������� ������ �� ������ � ����������� ��������� (� ������� ���� Next),', 0, 4);
  TaskText('�� � � ���������� (� ������� ���� Prev). ���� Prev ������� �������� ��������', 0, 5);
  TaskText('������~\N. ������� ��������� �� ��������� ������� ��������������� �������.', 0, 0);
  if Random(4) = 0 then
    n := 1
  else
    n := 2 + Random(8);
  new(p1);
  p1^.Data := Random(90) + 10;
  p1^.Prev := nil;
  p2 := p1;
  for i := 2 to n do
  begin
    new(p);
    p^.Data := Random(90) + 10;
    p^.Prev := p2;
    p2^.Next := p;
    p2 := p;
  end;
  p2^.Next := nil;
  SetPointer(1, p1);
  SetPointer(2, p2);
  ResultP('����� ���������� ��������: ', 2, 0, 2);
  ResultList(1, 0, 3);
  ShowPointer(2);
  DataP('', 1, 0, 2);
  p := p1;
  for i := 1 to n do
  begin
    p^.prev := @WrongNode;
    p := p^.Next;
  end;
  DataList(1, 0, 3);
  ShowPointer(1);
end;

procedure Demo9;
var
  i, n: integer;
  p, p1, p2: PNode;
begin
  StartTask('������������ ��������� ������: ���������� ������');
  TaskText('���� ������~{A}_1 �� ������ �������� ������� ���������-�������� ���� Node,', 0, 1);
  TaskText('��������� ����� ����� � ������� ����� ������� Next. ��������� �������� Prev', 0, 2);
  TaskText('������ ��������, ������������� �������� (\I�����������\i) ������� � \I����������\i,', 0, 3);
  TaskText('� ������� ������ ������� ������ �� ������ � ����������� ��������� (� �������', 0, 4);
  TaskText('�������� Next), �� � � ���������� (� ������� �������� Prev). �������� Prev', 0, 5);
  TaskText('������� �������� �������� ������~\O. ������� ������~{A}_2 �� ���������', 0, 0);
  TaskText('������� ��������������� �������.', 0, 0);
  SetObjectStyle;
  if Random(4) = 0 then
    n := 1
  else
    n := 2 + Random(8);
  new(p1);
  p1^.Data := Random(90) + 10;
  p1^.Prev := nil;
  p2 := p1;
  for i := 2 to n do
  begin
    new(p);
    p^.Data := Random(90) + 10;
    p^.Prev := p2;
    p2^.Next := p;
    p2 := p;
  end;
  p2^.Next := nil;
  SetPointer(1, p1);
  SetPointer(2, p2);
  ResultP('��������� �������: ', 2, 0, 2);
  ResultList(1, 0, 3);
  ShowPointer(2);
  DataP('', 1, 0, 2);
  p := p1;
  for i := 1 to n do
  begin
    p^.prev := @WrongNode;
    p := p^.Next;
  end;
  DataList(1, 0, 3);
  ShowPointer(1);
  SetNumberOfTests(6);
end;

var i: integer := 0;

procedure InitTask(num: integer);
begin
  i += 1;
  writeln(i);
  case num of
  1..2: UseTask('Begin', num);
  3: Demo3;
  4: Demo4;
  5: Demo5;
  6: Demo6;
  7: Demo7;
  8: Demo8;
  9: Demo9;
  end;
end;

begin
  AddGroup('Demo', '������� ��������� �����', '�. �. �������, 2008',
    'qwqfsdf13dfttd', 9, InitTask);
    
  AddCommentText('��������������� ��������� �����������');
  AddCommentText('������������ ������� ������� \MPT4TaskMaker\m.');

  SubgroupComment('���� � ����� ������, �������� ������������');
  AddCommentText('� ������ ��������� ��� ������ ������� \I�������������\i');
  AddCommentText('�� ������ \SBegin\s. ');
  AddCommentText('\P���������� ���� ����� ��������� ����� ������������ �� ������ \SBegin\s.\P');
  UseCommentText('Begin');

  SubgroupComment('��������� ������� (�������): ����� ���������');
  AddCommentText('������ ������� ��������� ������� Matrix7.');

  SubgroupComment('���������� � ��������� �����');
  AddCommentText('������ ������� ��������� ������� File63. ��� �������������');
  AddCommentText('�����������, ��������� � ��������� \I����������\i �������.');
  AddCommentText('��� ���������� ������� ������������ ��������������� ������� \MFileName\m.');

  SubgroupComment('��������� �����: �������� ��������');
  AddCommentText('������ ������� ��������� ������� Text16.');

  SubgroupComment('������������ ��������� ������: ���������� ������');
  AddCommentText('������ ������� ��������� ������� Dynamic30.');
  AddCommentText('\P������ ������� ��������� ������� ObjDyn30. ��� ���������� ���������, �� ��������, ');
  AddCommentText('� ����������� ����������� �������. ������� ����������� ���� � ����� ������������:');
  AddCommentText('�� ������ ������� ����������� \<���������\> �����, ����������� ��� ����� .NET.');

  RegisterGroup;

  CloseGroup;
end.

