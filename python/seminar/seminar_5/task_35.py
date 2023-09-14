# Задача №35. Решение в группах
# Напишите функцию, которая принимает одно число и проверяет, является ли оно простым
# Напоминание: Простое число - это число, которое имеет 2 делителя: 1 и n(само число)
# Input: 5
# Output: yes

def is_prime(n):
    if n % 2 == 0 and n != 0:
        return "no"
    for i in range(3, int(n ** 0.5) + 1, 2):
        if n % i == 0:
            return "no"
    return "yes"


number = int(input("Введите число: "))
print(is_prime(number))
