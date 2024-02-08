// 📌 Напишите метод, который сжимает строку.
// 📌 Пример: вход aaaabbbcdd.
// результат a4b3c1d2.

package java_course;

public class StringShrinker {
    static String shrinkString(String str) {
        StringBuilder sb = new StringBuilder();
        int counter = 1;
        char previousChar = str.charAt(0);
        for (int i = 1; i < str.length(); i++) {
            if (previousChar == str.charAt(i)) {
                counter++;
            } else {
                sb.append(previousChar);
                sb.append(counter);
                counter = 1;
                previousChar = str.charAt(i);
            }
        }

        sb.append(previousChar);
        sb.append(counter);

        return sb.toString();
    }

    public static void main(String[] args) {
        String inputStr = "aaaabbbcdd";
        System.out.println(shrinkString(inputStr));
    }
}