# Задача №13. Решение в группах
# Уставшие от необычно теплой зимы, жители решили узнать, действительно ли это самая длинная оттепель за всю историю
# наблюдений за погодой. Они обратились к синоптикам, а те, в свою очередь, занялись исследованиями статистики за
# прошлые годы. Их интересует, сколько дней длилась самая длинная оттепель. Оттепелью они называют период, в
# который среднесуточная температура ежедневно превышала 0 градусов Цельсия. Напишите программу, помогающую
# синоптикам в работе. Пользователь вводит число N – общее количество рассматриваемых дней (1 ≤ N ≤ 100). В следующих строках
# располагается N целых чисел. Каждое число – среднесуточная температура в соответствующий день. Температуры – целые числа и лежат в диапазоне от –50 до 50
# Input: 6 -> -20 30 -40 50 10 -10
# Output: 2

n = int(input("Введите число от 1 до 10: "))
count = 0
max_c = 0

# for el in range(n):
#     num = int(input("Введите числа: "))
#     if num > 0:
#         count += 1
#     elif count > max_c:
#         max_c = count
#         count = 0
#     else:
#         count = 0
# if count > max_c:
#     max_c = count
# print(max_c)

for el in range(n):
    num = int(input("Введите числа: "))
    if num > 0:
        count += 1
        if count > max_c:
            max_c = count
    else:
        count = 0

print(max_c)
