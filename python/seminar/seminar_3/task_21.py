# Задача №21. Решение в группах
# Напишите программу для печати всех уникальных значений в словаре.
# Input:[{"V": "S001"}, {"V": "S002"}, {"VI": "S001", "V":"S009"}, {"VI": "S005"}, {"VII": "S005"}, {"V" :"S009"}, {" VIII":" S007"}]
# Output: {'S005', 'S002', 'S007', 'S001', 'S009'}
# Примечание: Список словарей задан изначально. Пользователь его не вводит

lst = [{"V": "S001"}, {"V": "S002"}, {"VI": "S001", "V": "S009"}, {
    "VI": "S005"}, {"VII": "S005"}, {"V": "S009"}, {" VIII": " S007"}]

print("Original List: ", lst)
res_set = set()

for cur_dict in lst:
    for key in cur_dict:
        res_set.add(cur_dict[key])

print(res_set)

# Второй вариант

# for cur_dict in lst:
#     res_set.update(cur_dict.values())

# print(*res_set, sep='\n')
# res_set.update("2342346")
# print(res_set)
