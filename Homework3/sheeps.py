sizes = [5,7,300,90,24,50,75]

for i in range(1,4):
    print("Hello, my name is Hiep and these are my sheeps' sizes:")
    print(sizes)
    print("MONTH", i)
    print("One month has passed and here is the size of my new flock")
    print(sizes)
    print("Now my biggest sheep has the size", max(sizes),",let's shear it")
    index = sizes.index(max(sizes))
    sizes[index]=8
    print("After shearing, here is my flock")
    print(sizes)
    sizes = [x+50 for x in sizes]
    print("")

total_size = sum(sizes)
print("My flock has size in total",total_size)
money = total_size * 2
print("I would get", str(total_size), "* 2% =",  str(money)+"$")
