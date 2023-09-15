# Задача №43. Решение в группах
# Дан список чисел. Посчитайте, сколько в нем пар элементов, равных друг другу. Считается, что любые
# два элемента, равные друг другу образуют одну пару, которую необходимо посчитать. Вводится список чисел. Все числа списка находятся на разных
# строках.
# Ввод: Вывод:
# 1 2 3 2 3 2

from random import randint


size = randint(5, 10)
first_list = [randint(0, 5) for _ in range(size)]
print(first_list)
count = 0

for i in range(size-1):
    for j in range(i + 1, size):
        if first_list[i] == first_list[j]:
            count += 1
print(count)
