# Задача №25. Решение в группах
# Напишите программу, которая принимает на вход строку, и отслеживает, сколько раз каждый символ уже встречался. Количество повторов добавляется к символам с помощью постфикса формата _n.
# Input: a a a b c a a d c d d
# Output: a a_1 a_2 b c a_3 a_4 d c_1 d_1 d_2
# Для решения данной задачи используйте функцию .split()

# list_1 = "a a a b c a a d c d d"
# list_1 = list_1.split()
# print(list_1)
# new_dict = {}

# for letter in list_1:
#     if letter in new_dict:
#         new_dict[letter] += 1
#         print(letter + '_' + str(new_dict[letter]), end=" ")
#     else:
#         new_dict[letter] = 0
#         print(letter, end=" ")
