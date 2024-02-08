// 📌 Заполнить список десятью случайными числами.
// 📌 Отсортировать список методом sort() и вывести его на экран.

package java_course;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Random;

public class SortedList {
    public static void main(String[] args) {
        int size = 10;
        // int min = 0;
        int max = 100;
        List<Integer> numbers = getRand(size, max);

        Collections.sort(numbers);
        System.out.println(numbers);
    }

    private static List<Integer> getRand(int size, int max) {
        List<Integer> numbers = new ArrayList<>();
        Random rand = new Random();
        for (int i = 0; i < size; i++) {
            numbers.add(rand.nextInt(max));
        }
        System.out.println(numbers);
        return numbers;
    }
}