# Задача №39. Решение в группах
# Даны два массива чисел. Требуется вывести те элементы первого массива (в том порядке, в каком они идут в первом
# массиве), которых нет во втором массиве. Пользователь вводит число N - количество элементов в первом массиве, затем N
# чисел - элементы массива. Затем число M - количество элементов во втором массиве. Затем элементы второго массива
# Ввод: Вывод:
# 7 3 3 2 12
# 3 1 3 4 2 4 12
# 6
# 4 15 43 1 15 1 (каждое число вводится с новой строки)

import random
import time


size_1 = random.randint(5, 10)
first_list = [random.randint(0, 20) for _ in range(size_1)]
print(first_list)
size_2 = random.randint(5, 10)
second_list = [random.randint(0, 20) for _ in range(size_2)]

print(second_list)
for num in first_list:
    if num not in second_list:
        print(num)
        time.sleep(2)
