""" Linear Search Algorithm
    pre-condition: list, value
    post-condition: index or -1 if element isn't there"""
def linear_search(list, value):
    #loop through the list
    for i in range(len(list)):
        #check the value is equal to the particular array element
        print("check", list[i])
        if list[i] == value:
            #return the index
            print("element found at ", i)
            return i
    #element not found so return -1
    return -1

#create a list
list = [12,34, 55, 22, 6, 32, 12]

#find the index of the value and print
print(linear_search(list, 22))