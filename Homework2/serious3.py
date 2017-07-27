column = 10
row = 10

for i in range(int(column)):
    print("*", end="")

print()
print()
print()

for i in range(int(column/2)):
    print("x", end="")
    print("*", end="")

print()
print()
print()

for i in range(int(row)):
    if row % 2 == 0:
        for j in range(int(column/2)):
            print("x ", end="")
            print("* ", end="")
        print()
    else:
        for j in range(int(column/2)):
            print("* ", end="")
            print("x ", end="")
        print()
    row = row + 1

