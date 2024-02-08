// 📌 Создать список типа ArrayList<String>.
// 📌 Поместить в него как строки, так и целые числа.
// 📌 Пройти по списку, найти и удалить целые числа.

package java_course;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Iterator;
import java.util.List;

public class ArrayOnlyString {

    static boolean isNumber(String str) {
        try {
            Integer.parseInt(str);
            return true;
        } catch (Exception e) {
            return false;
        }
    }

    public static void main(String[] args) {
        List<String> listStrings = new ArrayList<>(Arrays.asList("10", "Black", "20", "White", "30", "Pink"));
        Iterator<String> iterator = listStrings.iterator();
        while (iterator.hasNext()) {
            String temp = iterator.next();
            // Varian 3
            // if (temp.matches("\\d+")) {
            // iterator.remove();
            // }
            if (isNumber(temp)) {
                iterator.remove();
            }
        }
        // Variant 2
        // List<String> listStrings2 = new ArrayList<>();
        // for (String element : listStrings) {
        // if (!element.matches("\\d+")) {
        // listStrings2.add(element);
        // }
        // }
        System.out.println(listStrings);
    }
}