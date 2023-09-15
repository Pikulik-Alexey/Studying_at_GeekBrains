# Задача 30:  Заполните массив элементами арифметической прогрессии. Её первый элемент, разность и количество элементов нужно ввести с клавиатуры. Формула для получения n-го члена прогрессии: an = a1 + (n-1) * d.
# Каждое число вводится с новой строки.
import random


def arithmetic_progression(first_el, step, quantity):
    if first_el > 0:
        for i in range(quantity):
            print(first_el + (i - 1) * step, end=" ")


first_el = int(input("Введите первый элемент: "))
step = int(input("Введите шаг: "))
quantity = int(input("Введите кол-во элементов: "))

arithmetic_progression(first_el, step, quantity)


# Задача 32: Определить индексы элементов массива (списка), значения которых принадлежат заданному диапазону (т.е. не меньше заданного минимума и не больше заданного максимума)

size_1 = random.randint(10, 20)
first_list = [random.randint(-20, 20) for _ in range(size_1)]
print(first_list)
second_list = []
max_num = int(input("Введите максимальный диапазон: "))
min_num = int(input("Введите минимальный диапазон: "))

for i in range(len(first_list)):
    if min_num <= first_list[i] <= max_num:
        second_list.append(i)
print(second_list)
