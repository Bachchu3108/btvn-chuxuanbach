from turtle import*

speed(-1)
color("red")

left(120)

for i in range(4):
    for n in range(0,4):
        forward(100)
        if n%2==0:
            right(60)
        else:
            right(120)
    right(90)  
