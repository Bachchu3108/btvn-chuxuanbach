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
speed(0)
color('blue')
for i in range(100):
    import random
    x = random.randint(-300, 300)
    y = random.randint(-300, 300)
    length = random.randint(3, 10)
    draw_star(x, y, length)
# the random.randint() statement will choose a random value for x, y, and length

