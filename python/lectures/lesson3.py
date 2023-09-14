# Задание: Необходимо создать функцию sumNumbers(n), которая будет считать сумму всех элементов от 1 до n
# 1. Необходимо создать функцию:
def sumNumbers(n):
    # 2. Реализовать решение задачи внутри функции
    summa = 0
    for i in range(1, n + 1):
        summa += i
    print(summa)


# 3. Спросим у пользователя число
n = int(input("Введите число: "))  # 5
sumNumbers(n)  # 15

# Программный код, который мы написали прекрасно справляется с поставленной
# задачей. Давайте изменим наш код и добавим в него return. НО перед этим давайте вспомним, что делает return:
# 1. Завершает работу функции
# 2. Возвращает значение


def sumNumbers(n):
    summa = 0
    for i in range(1, n + 1):
        summa += i
    return summa


n = int(input("Введите число: "))  # 5
print(sumNumbers(n))  # 15

# Задача: Пользователь вводит число n. Необходимо вывести n - первых членов последовательности Фибоначчи.
# Напоминание: Последовательно Фибоначчи, это такая последовательность, в которой каждое последующее число равно сумму 2-ух предыдущих


def fib(n):
    if n in [1, 2]:  # базис
        return 1  # базис
    return fib(n - 1) + fib(n - 2)


list_1 = []
for i in range(1, 10):
    list_1.append(fib(i))

print(list_1)  # [1, 1, 2, 3, 5, 8, 13, 21, 34]

# Быстрая сортировка
# Два друга решили поиграть в игру: один загадывает число от 1 до 100, другой должен отгадать.


def quicksort(array):
    if len(array) < 2:
        return array
    else:
        pivot = array[0]
        less = [i for i in array[1:] if i <= pivot]
        greater = [i for i in array[1:] if i > pivot]
        return quicksort(less) + [pivot] + quicksort(greater)


print(quicksort([10, 5, 2, 3]))

# Сортировка слиянием


def merge_sort(nums):
    if len(nums) > 1:
        mid = len(nums) // 2  # середина
        left = nums[:mid]
        right = nums[mid:]
        merge_sort(left)
        merge_sort(right)
        i = j = k = 0
        while i < len(left) and j < len(right):
            if left[i] < right[j]:
                nums[k] = left[i]
                i += 1
            else:
                nums[k] = right[j]
                j += 1
            k += 1
        while i < len(left):
            nums[k] = left[i]
            i += 1
            k += 1
        while j < len(right):
            nums[k] = right[j]
            j += 1
            k += 1


nums = [38, 27, 43, 3, 9, 82, 10]
merge_sort(nums)
print(nums)
