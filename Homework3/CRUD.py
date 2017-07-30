clothes = ['T-Shirt', 'Sweater', 'Jeans']

while True:
    
    command = str(input("Welcome to our shop, what do you you want (C, R, U, D)?"))

    if (command.upper() == 'C'):
        new_item = str(input("Enter new item"))
        clothes.append(new_item)
        print("Our items", clothes)
    elif (command.upper() == 'R'):
        print("Our items", clothes)
    elif (command.upper() == 'U'):
        update_position = int(input("Update position?"))
        new_item = str(input("New item?"))
        clothes[update_position - 1] = new_item
        print("Our items", clothes)
    elif (command.upper() == 'D'):
        delete_position = int(input("Delete position?"))
        del clothes[delete_position - 1]
        print("Our items", clothes)
    else:
        print("Try again he he =)))")
    

