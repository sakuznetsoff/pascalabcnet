Uses System;

var 
  d1, d2, d3: DateTime; // ������� ��� �������� ���� � �������
  ts: TimeSpan; // ������ ��� �������� ����������� �������

begin
  // ��������� ������� ���� - ����� ������������ ������
  d1 := DateTime.Now; 
  Writeln(d1);
  
  // ���� � ����� ����� ���� �����
  d2 := d1.AddMonths(1);
  Writeln(d2);

  // ���� � ����� �� 12 ����� ������
  d2 := d1.AddHours(-12);
  Writeln(d2);

  // ������������ ���� - ����� ������������ ������� (���, �����,�����)
  d3 := new DateTime(2001, 1, 1);
  Writeln(d3);
  
  // ����������� �������, ���������� � ������ ����������� (�������� ���)
  ts := d1.Subtract(d3);

  // ���������� ������� � ���� (��������� - ������������ �����)
  Writeln(ts.TotalDays);
  
  // ���������� ������� � ����, �����, ������� � ��������
  WritelnFormat('{0} {1}:{2}:{3}',ts.Days,ts.Hours,ts.Minutes,ts.Seconds);
end.