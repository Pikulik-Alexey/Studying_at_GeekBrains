# Задача №37. Решение в группах
# Дано натуральное число N и последовательность из N элементов.
# Требуется вывести эту последовательность в обратном порядке.
# Примечание. В программе запрещается объявлять массивы и использовать циклы (даже для ввода и вывода).
# Input: 2 -> 3 4
# Output: 4 3

def input_numbers(size):
    if size == 0:
        return ""
    n = input("Введите число: ")
    size -= 1
    return input_numbers(size) + " " + n


size = int(input("Введите размер: "))
print(input_numbers(size).strip())
