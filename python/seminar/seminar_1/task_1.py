# Задача №1. Решение в группах
# За день машина проезжает n километров. Сколько дней нужно, чтобы проехать маршрут длиной m километров? При решении этой задачи нельзя пользоваться условной инструкцией if и циклами.
# Input:
# n = 700
# m = 750
# Output:
# 2
n = 700
m = 701

d = int((m / n) + 1)
print(f"Чтобы проехать {m} километров понадобится {d} дня")

# a = (m + n - 1) // n
# print(a)

# d = ((m//-n))
# print(-d)

# m // n + m % n
