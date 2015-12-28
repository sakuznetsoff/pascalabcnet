// Программа генерации случайных лабиринтов
unit u_MazeGen;

uses GraphABC;

const
  szw=70;      // размер лабиринта
  szh=50;
  cellsz=10;   // размер ячейки

type
  point=record
    x,y: integer;
  end;

var
  maze: array [0..szw-1] of array [0..szh-1] of integer;
  todo: array [0..szw*szh-1] of point;
  todonum: integer;

//const
  dx: array [0..3] of integer;//=(0, 0, -1, 1);
  dy: array [0..3] of integer;//=(-1, 1, 0, 0);

procedure init;
var
  x,y,n,d: integer;
begin
  for x:=0 to szw-1 do
  for y:=0 to szh-1 do
    if (x=0) or (x=szw-1) or (y=0) or (y=szh-1) then
      maze[x][y]:=32
    else maze[x][y]:=63;

  x := Random(szw-2)+1;
  y := Random(szh-2)+1;

// Пометить клетку как принадлежащую лабиринту
  maze[x][y]:= maze[x][y] and not 48;

// Занести в список todo все ближайшие необработанные клетки
  for d:=0 to 3 do
    if (maze[x + dx[d]][y + dy[d]] and 16) <> 0 then
    begin
      todo[todonum].x:=x + dx[d];
      todo[todonum].y:=y + dy[d];
      Inc(todonum);
      maze[x + dx[d]][y + dy[d]] := maze[x + dx[d]][y + dy[d]] and not 16;
    end;

   // Пока не обработаны все клетки
   while todonum > 0 do
   begin
       // Выбрать из списка todo произвольную клетку
       n:= Random(todonum);
       x:= todo[n].x;
       y:= todo[n].y;

       // Удалить из списка обработанную клетку
       Dec(todonum);
       todo[n]:= todo[todonum];

       // Выбрать направление, которое ведет к лабиринту
       repeat
           d:=Random (4);
       until not ((maze[x + dx[d]][y + dy[d]] and 32) <> 0);

       // Присоединить выбранную клетку к лабиринту
       maze[x][y] := maze[x][y] and not ((1 shl d) or 32);
       maze[x + dx[d]][y + dy[d]] := maze[x + dx[d]][y + dy[d]] and not (1 shl (d xor 1));

       // Занести в список todo все ближайшие необработанные клетки
       for d:=0 to 3 do
           if (maze[x + dx[d]][y + dy[d]] and 16) <> 0 then
           begin
             todo[todonum].x := x + dx[d];
             todo[todonum].y := y + dy[d];
             Inc(todonum);
             maze[x + dx[d]][y + dy[d]] := maze[x + dx[d]][y + dy[d]] and not 16;
           end;
   end;

   maze[1][1] := maze[1][1] and not 1;                 // начало лабиринта - в левом верхнем углу
   maze[szw-2][szh-2] := maze[szw-2][szh-2] and not 2; // конец лабиринта - в правом нижнем углу
end;

procedure Draw;
var x,y: integer;
begin
  for x:=1 to szw-2 do
  for y:=1 to szh-2 do
  begin
   if ((maze[x][y] and 1) <> 0) then // верхняя стена
       Line(x * cellsz, y * cellsz, x * cellsz + cellsz , y * cellsz);
   if ((maze[x][y] and 2) <> 0) then // нижняя стена
       Line(x * cellsz, y * cellsz + cellsz, x * cellsz + cellsz , y * cellsz + cellsz);
   if ((maze[x][y] and 4) <> 0) then // левая стена
       Line(x * cellsz, y * cellsz, x * cellsz, y * cellsz + cellsz );
   if ((maze[x][y] and 8) <> 0) then // правая стена
       Line(x * cellsz + cellsz, y * cellsz, x * cellsz + cellsz, y * cellsz + cellsz );
  end;
end;

begin
  SetWindowCaption('Генерация лабиринта');
  SetWindowSize(800,600);
  dx[2]:=-1;dx[3]:=1;
  dy[0]:=-1;dy[1]:=1;
  init;
  draw;
end.

