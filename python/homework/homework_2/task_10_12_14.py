# Задача 10: На столе лежат n монеток. Некоторые из них лежат вверх решкой, а некоторые – гербом. Определите минимальное число
# монеток, которые нужно перевернуть, чтобы все монетки были повернуты вверх одной и той же стороной. Выведите минимальное
# количество монет, которые нужно перевернуть.
# 5 -> 1 0 1 1 0
# 2

n = int(input("Введите число: "))
list_num = []
i = 0
while i < n:
    list_num.append(input("Введите числа от 0 до 1: "))
    i += 1
# print(list_num)

num_0 = 0
num_1 = 0

for el in list_num:
    if int(el) > 0:
        num_1 += 1
    else:
        num_0 += 1

if num_1 > num_0:
    print(num_0)
elif num_1 == num_0:
    print("Поровну")
else:
    print(num_1)


# Задача 12: Петя и Катя – брат и сестра. Петя – студент, а Катя – школьница. Петя помогает Кате по математике. Он задумывает два натуральных числа X и Y (X,Y≤1000), а Катя должна их отгадать. Для этого Петя делает две подсказки. Он называет сумму этих чисел S и их произведение P. Помогите Кате отгадать задуманные Петей числа.
# 4 4 -> 2 2
# 5 6 -> 2 3

sum_num = int(input("Введите сумму чисел (меньше 1000) => "))
mult_num = int(input("Введите произведение чисел (меньше 1000) => "))

for x in range(sum_num):
    for y in range(mult_num):
        if (sum_num == x + y) and (mult_num == x * y):
            print(x, y)


# Задача 14: Требуется вывести все целые степени двойки (т.е. числа вида 2k), не превосходящие числа N.
# 10 -> 1 2 4 8

number = int(input("Введите число: "))
i = 0
while 2 ** i < number:
    print(2 ** i, end=" ")
    i += 1
