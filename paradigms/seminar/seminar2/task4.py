def factorial(n):
    if n <= 1:
        return 1
    else:
        result = 1
        for i in range(2, n + 1):
            result *= i
        return result


number = 5
print(f"Факториал {number} = {factorial(number)}")

###############################


def fibonacci(f):
    if f <= 1:
        return f
    else:
        return fibonacci(f - 1) + fibonacci(f - 2)


number = 10
print(f"{number}-e число Фибоначчи = {fibonacci(number)}")

##############################


def gcd(a, b):
    while b:
        a, b = b, a % b
    return a


num1 = 56
num2 = 98
print(f"Наибольший общий делитель(НОД)({num1}, {num2} = {gcd(num1, num2)})")

#############################


def fast_pow(base, exponent):
    if exponent == 0:
        return 1
    elif exponent % 2 == 1:
        return fast_pow(base, exponent - 1) * base
    else:
        half_pow = fast_pow(base, exponent // 2)
        return half_pow * half_pow


base = 2
exponent = 10
print(f"{base} в степени {exponent} = {fast_pow(base, exponent)}")
