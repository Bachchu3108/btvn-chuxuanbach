from turtle import *
length = int(input("length:"))
square_color = input("color:")


def draw_square(length, square_color):
     color(str(square_color))
     for i in range(4):
          forward(length)
          left(90)
draw_square(length, square_color)
