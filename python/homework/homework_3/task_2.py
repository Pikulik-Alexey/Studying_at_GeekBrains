# Требуется найти в массиве list_1 самый близкий по величине элемент к заданному числу k и вывести его.
list_1 = [1, 4, 3, 7, 8, 9, 2]
k = 8
# max_num = 0

# for el in list_1:
#     if el > max_num:
#         max_num = el
#         # if max_num < k:

# print(max_num)


# list_1 = [1, 2, 3, 4, 5, 6, 7]
# k = 6
for i in range(len(list_1)):
    if list_1[i] < k:
        nearest_num = -k
    else:
        nearest_num = nearest_num + 0
    if list_1[i] >= k and list_1[i] - k <= nearest_num - k:
        nearest_num = list_1[i]
    elif list_1[i] <= k and nearest_num - k <= list_1[i] - k:
        nearest_num = list_1[i]
print(nearest_num)
