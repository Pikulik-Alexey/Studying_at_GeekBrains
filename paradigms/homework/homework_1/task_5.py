# Задача 5: Поиск простых чисел. Напишите программу, которая находит все простые числа в заданном диапазоне от 1 до N.

n = int(input("Введите число: "))
a = []

for el in range(2, n + 1):
    k = 0
    for j in range(1, el + 1):
        if el % j == 0:
            k += 1
    if k == 2:
        a.append(el)

print(a)
