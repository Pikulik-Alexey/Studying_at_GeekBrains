# Напишите функцию f, которая на вход принимает два числа a и b, и возводит число a в целую степень b с помощью рекурсии.

# Функция не должна ничего выводить, только возвращать значение.

# Пример:
# a = 3; b = 5 -> 243 (3⁵)
# a = 2; b = 3 -> 8

def degree(a, b):
    if a > 0 and b != 0:
        return a ** b
    return 0


a = int(input("Введите число: "))
b = int(input("Введите число: "))
print(degree(a, b))


# 2 Способ
# def f(a, b):
#   if b == 0:
#     return 1
#   return f(a, b - 1) * a
