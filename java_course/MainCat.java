package java_course;

import java.util.Arrays;
import java.util.HashSet;
import java.util.Set;

public class MainCat {
    public static void main(String[] args) {
        Cat cat1 = new Cat(100, "Мурзик", 3, "Белый");
        Cat cat2 = new Cat(101, "Васька", 5, "Рыжий");
        Cat cat3 = new Cat(102, "Мурка", 2, "Серый");

        Cat cat4 = new Cat(100, "Мурзик", 3, "Белый");
        Cat cat5 = new Cat(101, "Васька", 5, "Рыжий");
        Cat cat6 = new Cat(102, "Мурка", 2, "Серый");

        Set<Cat> clinicDB = new HashSet<>(Arrays.asList(cat1, cat2, cat3, cat4, cat5, cat6));
        for (Cat cat : clinicDB) {
            System.out.println(cat);
        }
    }
}
