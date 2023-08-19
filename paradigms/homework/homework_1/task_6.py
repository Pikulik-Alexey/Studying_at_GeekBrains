# Задача 6: Упорядочивание списка. Напишите программу, которая сортирует список чисел в порядке возрастания с использованием пузырьковой сортировки или другого метода сортировки.

n = int(input("Введите длину списка: "))
list = []
i = 0
while i < n:
    list.append(int(input("Введите число: ")))
    i += 1
print(list)


def bubble_sort(list):

    for i in range(0, len(list)-1):
        for j in range(len(list)-1):
            if (list[j] > list[j+1]):

                list[j], list[j+1] = list[j+1], list[j]
    return list


print(bubble_sort(list))
