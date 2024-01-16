# Задача №17. Решение в группах
# Дан список чисел. Определите, сколько в нем встречается различных чисел.
# Input: [1, 1, 2, 0, -1, 3, 4, 4]
# Output: 6

# from random import randint

# # создали список пустой
# num_list = []
# # длина списка
# list_lenght = randint(5, 10)
# print(f'{list_lenght = }')

# # заполняем список
# # for _ in range(list_lenght):
# #     num_list.append(randint(0, 5))
# #     # # или
# #     # new_num = randint(0, 5)
# #     # num_list.append(new_num)
# #     # print(num_list)

# # лист компликаншин
# num_list_2 = [randint(0, 5) for _ in range(list_lenght)]

# # print(num_list)
# print(num_list_2)
# unique = set(num_list_2)
# print(unique)
# print(f'{len(unique) = }')

# Вариант 2

# from random import randint

# list_lenght = randint(5, 10)
# num_list_2 = [randint(0, 5) for _ in range(list_lenght)]
# print(f'{list_lenght = }')
# print(num_list_2)

# new_list = []

# for num in num_list_2:
#     if num not in new_list:
#         new_list.append(num)
# print(f'{new_list = }')
# print(f'{len(new_list) = }')

# Задача №19. Решение в группах
# Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность (сдвиг - циклический) на K элементов вправо, K – положительное число.
# Input: [1, 2, 3, 4, 5] k = 3
# Output: [4, 5, 1, 2, 3]

# from random import randint

# k = 3
# new_list = [randint(0, 5) for _ in range(randint(5, 10))]
# print(new_list)
# res_list = new_list[-k:] + new_list[:-k]
# print(res_list)

# Вариант 2

# from random import randint

# k = 4
# new_list = [randint(0, 5) for _ in range(randint(5, 10))]
# print(new_list)

# for shift in range(k):
#     shifter_num = new_list.pop()
#     new_list.insert(0, shifter_num)
# print(new_list)

# Задача №21. Решение в группах
# Напишите программу для печати всех уникальных значений в словаре.
# Input: [{"V": "S001"}, {"V": "S002"}, {"VI": "S001"}, {"VI": "S005"}, {"VII": " S005 "}, {" V ":" S009 "}, {" VIII ":" S007 "}]
# Output: {'S005', 'S002', 'S007', 'S001', 'S009'}

# list_dicts = [{"V": "S001"}, {"V": "S002"}, {"VI": "S001"}, {"VI": "S005"}, {"VII": " S005 "},
#               {" V ": "S009"}, {" VIII ": " S007 "}]

# my_set = set()

# for curr_dict in list_dicts:
#     for val in curr_dict.values():
#         my_set.add(val.strip())

# print(my_set)

# Задача №23. Решение в группах
# Дан массив, состоящий из целых чисел. Напишите программу, которая подсчитает количество элементов массива, больших предыдущего (элемента с предыдущим номером)
# Input: [0, -1, 5, 2, 3]
# Output: 2 (-1 < 5, 2 < 3)

data_list = [0, -1, 5, 2, 3]
count = 0

for i in range(len(data_list) - 1):
    if data_list[i] < data_list[i + 1]:
        count += 1

print(f'{count = }')

# # если есть только if
# new_list = [1 for i in range(len(data_list) - 1)
#             if data_list[i] < data_list[i + 1]]
# # когда кроме if есть и else
# new_list = [1 if data_list[i] < data_list[i + 1]
#             else 0 for i in range(len(data_list) - 1)]

# print(sum(new_list))
