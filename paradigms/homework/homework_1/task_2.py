# Задача 2: Поиск наименьшего числа в списке. Напишите программу, которая находит наименьшее число в заданном списке с помощью цикла.

n = int(input("Введите длину списка: "))
list = []
i = 0
while i < n:
    list.append(input("Введите число: "))
    i += 1
# print(list)

min_num = list[0]
for i in list:
    if i < min_num:
        min_num = i
print(f"Наименьшее число из списка {list} равно {min_num}")
