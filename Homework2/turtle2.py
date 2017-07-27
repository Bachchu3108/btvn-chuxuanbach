from turtle import*

speed(-1)

for n in range (3,7):
    for i in range (n):
        if n %2 == 0:
            color("red")
        else:
            color("blue")
        forward(100)
        left(360/n)
