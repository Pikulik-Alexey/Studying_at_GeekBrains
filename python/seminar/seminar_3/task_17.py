# Задача №17. Решение в группах
# Дан список чисел. Определите, сколько в нем встречается различных чисел.
# Input: [1, 1, 2, 0, -1, 3, 4, 4]
# Output: 6
# Примечание: Пользователь может вводить значения списка или список задан изначально.

import random

# size = int(input("Введите размер списка "))
# numbers = []

# for _ in range(size):
#     number = int(input("Введите число: "))
#     numbers.append(number)

# print(len(set(numbers)))

# Второй вариант

size = random.randint(5, 10)
numbers = [random.randint(0, 100) for _ in range(size)]
unique = [numbers[0]]
count = 1
print(numbers)

for num in numbers[1:]:
    if num in unique:
        unique.append(num)
        count += 1
print(count)

# Третий вариант

unique_2 = [num for num in numbers if num in unique]
count_2 = len(unique_2)
print(count_2)

unique_3 = [num if num in unique else 0 for num in numbers]
