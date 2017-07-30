from turtle import *

penup()
backward(125)
pendown()
speed(-1)

colors = ["red","blue","brown","yellow","grey"]

for i in range(0,5):
    begin_fill()
    color(colors[i])
    for i in range(2):
        forward(50)
        left(90)
        forward(100)
        left(90)
    forward(50)
    end_fill()
