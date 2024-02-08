// Написать программу, которая запросит пользователя ввести <Имя> в консоли.
// Получит введенную строку и выведет в консоль сообщение “Привет, <Имя>!”

package java_course;

import java.util.Scanner;

public class HelloName {
    public static void main(String[] args) {
        System.out.print("Представьтесь, пожалуйста: ");
        Scanner scanner = new Scanner(System.in, "ibm866");
        String name = scanner.nextLine();
        System.out.println("Привет, " + name + "!");
        System.out.printf("Привет, %s!", name); // форматированный вывод
        scanner.close();
    }
}