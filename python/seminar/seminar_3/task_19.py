# Задача №19. Решение в группах
# Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность (сдвиг - циклический) на K элементов вправо, K –положительное число.
# Input: [1, 2, 3, 4, 5] k = 3
# Output: [4, 5, 1, 2, 3]
# Примечание: Пользователь может вводить значения списка или список задан изначально

from random import randint

# Создание списка и заполнение его рандомными числами
# size = randint(5, 10)
# numbers = [randint(0, 30) for _ in range(size)]
# k = randint(1, 20) % size
# numbers = [1, 2, 3, 4, 5]
# k = 3
# print(numbers)
# print(k)

# numbers_2 = []
# for num in numbers[-k:]:
#     numbers_2.append(num)
# for num in numbers[:-k]:
#     numbers_2.append(num)

# print(numbers_2)

# Вариант 2

size = randint(5, 10)
numbers = [randint(0, 30) for _ in range(size)]
k = randint(1, 20) % size

print(numbers)
print(k)

numbers_2 = [numbers[-k:] + numbers[:-k]]

print(numbers_2)

# Вариант 3

# list_1 = [1, 2, 3, 4, 5]
# k = 8
# k = k % len(list_1)
# list_result = list()

# for i in range(k, len(list_1)):
#     list_result.append(list_1[i])

# for i in range(k):
#     list_result.append(list_1[i])
# print(list_result)

# Вариант 4

# lst = [1, 2, 3, 4, 5]
# k = 8
# k = k % len(lst)
# for _ in range(k):
#     num = lst.pop()
#     lst.insert(0, num)
# print(lst)
