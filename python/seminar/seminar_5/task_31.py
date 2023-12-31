# Задача №31. Решение в группах
# Последовательностью Фибоначчи называется последовательность чисел a0, a1, ..., an, ..., где a0 = 0, a1 = 1, ak = ak-1 + ak-2 (k > 1).
# Требуется найти N-е число Фибоначчи
# Input: 7
# Output: 21
# Задание необходимо решать через рекурсию

def fib(x):
    if x == 1 or x == 2:
        return 1
    return fib(x - 1) + fib(x - 2)


n = int(input("Введите число: "))
print(fib(n))
