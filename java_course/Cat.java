// 1. Реализуйте 1 из вариантов класса Cat из предыдущего задания, можно использовать не все придуманные поля и методы. Создайте несколько экземпляров этого класса, выведите их в консоль.
// 2. Добейтесь того, чтобы при выводе в консоль объекта типа Cat, выводилась его кличка, цвет и возраст (или другие параметры на ваше усмотрение).

package java_course;

import java.util.Objects;

public class Cat {
    private int id;
    private String name;
    private int age;
    private String color;

    public Cat(int id, String name, int age, String color) {
        this.id = id;
        this.name = name;
        this.age = age;
        this.color = color;
    }

    public int getId() {
        return id;
    }

    public String getName() {
        return name;
    }

    public int getAge() {
        return age;
    }

    public String getColor() {
        return color;
    }

    public void setId(int id) {
        this.id = id;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public void setColor(String color) {
        this.color = color;
    }

    @Override
    public String toString() {

        // return String.format("ID: %d, Кличка: %s, Возраст: %d, Окрас: %s", id, name,
        // age, color);
        return ("ID: " + id + ", Кличка: " + name + ", Возраст: " + age + ", Окрас: " + color);
    }

    @Override
    public boolean equals(Object obj) {
        if (this == obj) {
            return true;
        }

        if (obj == null || getClass() != obj.getClass()) {
            return false;
        }

        Cat c = (Cat) obj;
        return id == c.id && name.equals(c.name) && age == c.age && color.equals(c.color);
    }

    @Override
    public int hashCode() {
        return Objects.hash(id, name, color, age);
    }
}