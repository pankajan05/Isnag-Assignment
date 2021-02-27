"""Binary Search Algorithm
    pre-conditon = list, value
    post-condition = index or -1 if element isn't there"""
def binary_search(list, value):
    low = 0
    high = len(list) - 1
    mid = 0

    while low <= high:
        print("low ", low, " high ", high, " mid ", mid, " current mid ", list[mid])
        mid = (high + low) // 2
        # If x is greater, ignore left half
        if list[mid] < value:
            low = mid + 1
        # If x is smaller, ignore right half
        elif list[mid] > value:
            high = mid - 1
        # means x is present at mid
        else:
            return mid

    # If we reach here, then the element was not present
    return -1


arr = [2, 3, 4, 10, 40, 56, 78, 86, 111, 123, 345, 567]
x = 348

# Function call
print(binary_search(arr, x))