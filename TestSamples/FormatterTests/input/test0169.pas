type TArr<T> = array of T;

TClass<T> = class
arr : TArr<T>;
end;

var c : TClass<integer>;

begin
c := new TClass<integer>;
SetLength(c.arr,10);
c.arr[2] := 7;
assert(c.arr[2]=7);
end.