prices = {
          "banana" : 4,
          "apple" : 2,
          "orange" : 1.5,
          "pear" : 3
          }

purchased_items = {
          "banana" : 5,
          "orange" : 3
          }
total = 0

purchased_items_list = list(purchased_items.items())

for purchased_item in purchased_items_list:
    print("{0}, quantity: {1}, unit price: {2}".format(purchased_item[0],
                                                       purchased_item[1],
                                                       prices[purchased_item[0]]))
    money = purchased_item[1] * prices[purchased_item[0]]
    print("Money: ", money)
    print()
    total += money
print("Total: ", total)
