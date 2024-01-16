# Задача №9. Решение в группах
# По данному целому неотрицательному n вычислите значение n!. N! = 1 * 2 * 3 * … * N (произведение всех чисел от 1 до N) 0! = 1 Решить задачу используя цикл while
# Input: 5
# Output: 120

# n = input("Введите число: ")
# # Проверка на число
# while not n.isdigit() or n == '0':
#     print("Некоректный ввод")
#     n = input("Введите число: ")

# n = int(n)

# total = 1
# i = 1

# while i <= n:
#     total = i * total
#     i += 1
# print(total)

# # решение 2

# n = int(n)
# total = 1

# while n > 1:
#     total, n = total*n, n - 1

# print(total)

# Задача №11. Решение в группах
# Дано натуральное число A > 1. Определите, каким по счету числом Фибоначчи оно является, то есть выведите такое число n, что φ(n)=A. Если А не является числом Фибоначчи, выведите число -1.
# Input: 5
# Output: 6
# Ряд чисел Фибоначчи:
# 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, …

# a = input("Введите число: ")

# # Проверка на число
# while not a.isdigit() or a in ('0', '1'):
#     # while not a.isdigit() or a == "0" or a == "1":
#     print("Некоректный ввод")
#     a = input("Введите число: ")

# a = int(a)

# pos = 3
# pred = 1
# pred_2 = 1

# while pred < a:
#     pred, pred_2 = pred + pred_2, pred
#     pos += 1

# # Вариант 2

# pos = 3
# pred = 1
# pred_2 = 1

# while pred < a:
#     temp = pred
#     pred = pred + pred_2
#     pred_2 = temp
#     pos += 1

# if pred != a:
#     print(-1)
# else:
#     print(pos)

# Задача №13. Решение в группах
# Уставшие от необычно теплой зимы, жители решили узнать, действительно ли это самая длинная оттепель за всю историю наблюдений за погодой. Они обратились к синоптикам, а те, в свою очередь, занялись исследованиями статистики за прошлые годы. Их интересует, сколько дней длилась самая длинная оттепель. Оттепелью они называют период, в который среднесуточная температура ежедневно превышала 0 градусов Цельсия. Напишите программу, помогающую синоптикам в работе.
# Пользователь вводит число N – общее количество рассматриваемых дней (1 ≤ N ≤ 100). В следующих строках располагается N целых чисел.
# Каждое число – среднесуточная температура в соответствующий день. Температуры – целые числа и лежат в диапазоне от –50 до 50
# Input:    6 -> -20 30 -40 50 10 -10
# Output: 2

# import random

# days_num = int(input("Введите кол-во дней: "))

# max_thaw_days = 0
# thaw_days = 0

# for i in range(days_num):
#     temperature = random.randint(-50, 50)
#     print(temperature, end=" ")
#     if temperature > 0:
#         thaw_days += 1
#     else:
#         if thaw_days > max_thaw_days:
#             max_thaw_days = thaw_days
#         thaw_days = 0

# if thaw_days > max_thaw_days:
#     max_thaw_days = thaw_days

# print()
# print(f"{max_thaw_days=}")

# Вариант 2

# days_num = int(input("Введите кол-во дней: "))

# max_thaw_days = 0
# thaw_days = 0

# for i in range(days_num):
#     temperature = random.randint(-50, 50)
#     print(temperature, end=" ")
#     if temperature > 0:
#         thaw_days += 1
#         if thaw_days > max_thaw_days:
#             max_thaw_days = thaw_days
#     else:
#         thaw_days = 0

# print()
# print(f"{max_thaw_days = }")

# Задача №15. Решение в группах
# 15. Иван Васильевич пришел на рынок и решил купить два арбуза: один для себя, а другой для тещи. Понятно, что для себя нужно выбрать арбузпотяжелей, а для тещи полегче. Но вот незадача: арбузов слишком много и он не знает как же выбрать самый легкий и самый тяжелый арбуз? Помогите ему! Пользователь вводит одно число N – количество арбузов. Вторая строка содержит N чисел,
# записанных на новой строчке каждое. Здесь каждое число – это масса соответствующего арбуза
# Пользователь вводит одно число N. Далее идут N чисел, записанных на новой строке каждое. Вывести мкаксимальное и минимальное
# Input: 5 -> 5 1 6 5 9
# Output: 1 9

# num = int(input("Введите число: "))
# min_weight = 1000
# max_weight = 0

# for _ in range(num):
#     weight = int(input("Введите вес: "))

#     if weight > max_weight:
#         max_weight = weight

#     if weight < min_weight:
#         min_weight = weight

# print(min_weight, max_weight)

# Вариант 2

from random import randint

num = randint(1, 20)
weight = randint(5, 15)
print(weight, end=" ")
min_weight = weight
max_weight = weight

for _ in range(num - 1):
    weight = randint(5, 15)
    print(weight, end=" ")
    max_weight = max(max_weight, weight)
    min_weight = min(min_weight, weight)

print()
print(min_weight, max_weight)
