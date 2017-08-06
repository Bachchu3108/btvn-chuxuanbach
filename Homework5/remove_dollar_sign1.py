_string = str(input("string:"))
def remove_dollar_sign(_string):
     removed_string = _string.replace("$", "")
     print(removed_string)
     return removed_string

remove_dollar_sign(_string)
