from itertools import zip_longest
import random
# Разбиение массива на подмассивы:
# __
# Описание: Имеется массив чисел. Необходимо разбить его на подмассивы так, чтобы сумма чисел в каждом подмассиве была меньше или равна заданному значению X.
# Почему это процедурное программирование: Можно создать процедуру, которая будет принимать массив и значение X, а затем последовательно формировать подмассивы, следуя определенной логике. Это позволяет выделить процесс создания каждого подмассива в отдельную подпрограмму, делая основной код более чистым и понятным.

x = int(input("Введите искомое число: "))
lis = [random.randint(1, 8) for _ in range(10)]
print(lis)


def findSublists(lis, x):

    for i in range(len(lis)):
        sum_so_far = 0
        for j in range(i, len(lis)):
            sum_so_far += lis[j]
            if sum_so_far == x:
                print(lis[i:j+1])


findSublists(lis, x)