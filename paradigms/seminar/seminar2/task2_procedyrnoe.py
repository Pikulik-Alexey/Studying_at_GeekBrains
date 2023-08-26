def say_hello():    # это подпрограмма
    print("Привет! ")


###################################


def show_message(message):  # это процедура
    print(message)


show_message("Это сообщение")

####################################


def add(a, b):   # это функция
    return a + b


resalt = add(3, 4)
print(resalt)


#####################################

class Dog:
    def __init__(self, name):
        self.name = name

    def bark(self):     # это метод
        print(f"{self.name} говорит: Гав!")


dog = Dog("Бобик")
dog.bark()
