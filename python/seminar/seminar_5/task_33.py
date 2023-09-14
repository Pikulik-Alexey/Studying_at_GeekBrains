# Задача №33. Решение в группах
# Хакер Василий получил доступ к классному журналу и хочет заменить все свои минимальные оценки на максимальные. Напишите программу, которая заменяет оценки Василия, но наоборот: все максимальные – на минимальные.
# Input: 5 -> 1 3 3 3 4
# Output: 1 3 3 3 1

import random


marks = [random.randint(1, 5) for _ in range(random.randint(5, 10))]
print(marks)
min_num = marks[0]
max_num = marks[0]

for mark in marks[1:]:
    if mark > max_num:
        max_num = mark
    elif mark < min_num:
        min_num = mark

for i in range(len(marks)):
    if marks[i] == max_num:
        marks[i] = min_num

print(marks)
