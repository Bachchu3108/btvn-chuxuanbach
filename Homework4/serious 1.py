inventory = {
    'gold' : 500,
    'pouch' : ['flint', 'twine', 'gemstone'],
    'backpack' : ['xylophone', 'dagger', 'bedroll', 'bread loaf']
    }
print("Inventory :", inventory)
print()

inventory["pocket"] = ["seashell", "strange berry", "lint"]
print("Pocket: ", inventory["pocket"])
print()

inventory["backpack"].sort()
print("Backpack: ", inventory["backpack"])
print()

del inventory["backpack"][inventory["backpack"].index('dagger')]
print("Backpack: ", inventory["backpack"])
print()

inventory["gold"] += 50
print("Gold: ", inventory["gold"])
print()

