from turtle import *

x = int(input("x:"))
y = int(input("y:"))
length = int(input("length:"))

def draw_star(x, y, length):
     penup()
     forward(x)
     left(90)
     forward(y)
     right(90)
     pendown()
     left(36)
     for i in range(5):
          forward(length)
          left(144)
draw_star(x, y, length)
