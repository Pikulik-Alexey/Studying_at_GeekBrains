# Задача №23. Решение в группах
# Дан массив, состоящий из целых чисел. Напишите программу, которая подсчитает количество элементов массива, больших предыдущего (элемента с предыдущим номером)
# Input: [0, -1, 5, 2, 3]
# Output: 2 (-1 < 5, 2 < 3)
# Примечание: Пользователь может вводить значения списка или список задан изначально.

from random import randint

my_list = [randint(1, 10) for _ in range(3, randint(4, 15))]
print(my_list)
result = [my_list[i]
          for i in range(1, len(my_list)) if my_list[i] > my_list[i - 1]]
print(result)
print(len(result))
# count = 0
# for i in range(1, len(my_list)):
#     if my_list[i] > my_list[i - 1]:
#         count += 1
# print(count)
