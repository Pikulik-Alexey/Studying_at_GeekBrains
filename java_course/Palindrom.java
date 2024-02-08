// 📌 Напишите метод, который принимает на вход строку (String) и определяет является ли строка палиндромом (возвращает boolean значение).

package java_course;

public class Palindrom {
    public static void main(String[] args) {
        String str = "довод";
        System.out.println(isPalindrom(str));
    }

    static boolean isPalindrom(String str) {
        int left = 0;
        int right = str.length() - 1;
        while (left < right) {
            if (str.charAt(left) != str.charAt(right)) {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }

}
