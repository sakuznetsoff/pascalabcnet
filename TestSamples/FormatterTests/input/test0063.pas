type TFileArray = array[1..3] of Text;
     TDynFileArray = array of Text;
     
var arr : TFileArray;
    parr : ^TFileArray;
    darr : TDynFileArray;
    
begin
  Assign(arr[1],'test.dat');
  New(parr);
  Assign(parr^[2],'test2.dat');
  SetLength(darr,3);
  Assign(darr[0],'test3.dat');
  darr := new Text[3];
  Assign(darr[1],'test.dat');
end.