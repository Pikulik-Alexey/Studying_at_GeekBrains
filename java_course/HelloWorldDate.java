package java_course;
// Настроить проект, вывести в консоль "Hello World"

import java.time.LocalDateTime;

// Вывести в консоль системные дату и время

public class HelloWorldDate {
    public static void main(String[] args) {
        System.out.println("Hello, World!");
        System.out.println(LocalDateTime.now());

        // int num = 45654;
        // double dNum = 5.84;
        // String str = "Hello";
        // char ch = 'g';
        // boolean b = 5 > 3;

        // while (b) {
        // break
        // }

        // for (int i = 0; i < args.length; i++) {

        // }

        // int[] array = new int[8]; // пустой массив
        int[] array1 = { 5, 8, 9, 15, 140, 2 }; // массив с данными
        for (int item : array1) {
            System.out.print(item + " ");
        }
    }
}
