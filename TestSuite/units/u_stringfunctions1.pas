unit u_stringfunctions1;
begin
  assert(MaxShortInt = shortint.MaxValue);
  assert(MaxByte = byte.MaxValue);
  assert(MaxSmallInt = smallint.MaxValue);
  assert(MaxWord = word.MaxValue);
  assert(MaxInt = integer.MaxValue);
  assert(MaxLongWord = longword.MaxValue);
  assert(MaxInt64 = int64.MaxValue);
  assert(MaxUInt64 = uint64.MaxValue);
  assert(MaxDouble = real.MaxValue);
  assert(MinDouble = real.Epsilon);
  assert(MaxReal = real.MaxValue);
  assert(MinReal = real.Epsilon);
  assert(MaxSingle = single.MaxValue);
  assert(MinSingle = single.Epsilon);
  assert(Pi = 3.141592653589793);
  assert(E = 2.718281828459045);
  
  assert(LowerCase('S')='s');
  assert(UpperCase('p')='P');
  assert(LowCase('S')='s');
  assert(UpCase('p')='P');
  assert(Pos('as','dras')=3);
  assert(Pos('as','fgga')=0);
  assert(PosEx('as','drasfasa',4)=6);
  assert(PosEx('as','fggasfga',5)=0);
  assert(Length('abcd')=4);
  assert(Length('')=0);
  var s := 'abc';
  SetLength(s,5); assert(s='abc  ');
  SetLength(s,2); assert(s='ab');
  Insert('11',s,2); assert(s='a11b');
  Delete(s,2,3); assert(s='a');
  s := 'abcdefg'; assert(Copy(s,2,3)='bcd');
  assert(Concat('ab','cd')='abcd');
  assert(Concat('ab','cd','ef')='abcdef');
  assert(LowerCase('ABcDe')='abcde');
  assert(UpperCase('abCdE')='ABCDE');
  assert(StringOfChar('d',4)='dddd');
  assert(ReverseString('abcde')='edcba');
  assert(CompareStr('abc','abc')=0);
  assert(CompareStr('ab','abc')<0);
  assert(CompareStr('abc','ab')>0);
  assert(LeftStr('abcd',2)='ab');
  assert(RightStr('abcd',3)='bcd');
  assert(Trim('   abc     ')='abc');
  assert(Trim('abc')='abc');
  assert(TrimLeft('   abc ')='abc ');
  assert(TrimRight(' abc   ')=' abc');
  assert(Format('ab {0} cd {1} {2}',2,3,5)='ab 2 cd 3 5');
  assert(StrToInt('234')=234);
  assert(StrToFloat('2.67')=2.67);
  assert(IntToStr(45)='45');
end.