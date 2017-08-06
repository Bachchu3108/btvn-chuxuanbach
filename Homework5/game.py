#location
px = 2
py = 1
bx = 1
by = 2
gx = 1
gy = 3

for y in range(4):
     for x in range(4):
          if x == px and y == py:
               print("P", end = " ")
          elif x == gx and y == gy:
               print("G", end = " ")
          elif x == bx and y == by:
               print("B", end = " ")
          else:
               print("-", end = " ")
     print()
#command
while True:
     command = str(input("Move??"))
     if command.upper() == "D":
          if px == 3:
               print("cannot go forward!!")
          else:
               px += 1
     elif command.upper() == "S":
          if py == 3:
               print("cannot go down!!")
          else:
               py += 1
     elif command.upper() == "A":
          if py == 3:
               print("cannot go backward!!")
          else:
               px -= 1
     elif command.upper() == "W":
          if py == 3:
               print("cannot go down!!")
          else:
               py -= 1
     #hack
     elif command.lower() == "bachdeptraivl":
          px = 1
          py = 3
          bx = 1
          by = 2
     else:
          print("Try again!!")
     
  
