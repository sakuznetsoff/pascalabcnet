// ������� ���������� �. �����
uses ArrayLib;

/// ���������� a[l]..a[r] �� ����� a[l]..a[q] <= a[q+1]..a[r] 
function Partition(a: array of integer; l,r: integer): integer;
begin
  var i := l - 1;
  var j := r + 1;
  var x := a[l];
  while True do
  begin
    repeat
      Inc(i);
    until a[i]>=x;
    repeat
      Dec(j);
    until a[j]<=x;
    if i<j then 
      Swap(a[i],a[j])
    else 
    begin
      Result := j;
      exit;
    end;
  end;
end;
  
/// ���������� ������
procedure QuickSort(a: array of integer; l,r: integer);
begin
  if l>=r then exit;
  var j := Partition(a,l,r);
  QuickSort(a,l,j);
  QuickSort(a,j+1,r);
end;

const n = 20;

var a: array of integer;

begin
  CreateRandom(a,n);
  writeln('�� ����������: ');
  Writeln(a);
  QuickSort(a,0,a.Length-1);
  writeln('����� ����������: ');
  Writeln(a);
end.
