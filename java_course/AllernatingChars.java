// 📌 Дано четное число N (>0) и символы c1 и c2.
// 📌 Написать метод, который вернет строку длины N, которая состоит из чередующихся символов c1 и c2, начиная с c1.

package java_course;

public class AllernatingChars {
    public static void main(String[] args) {
        int n = 500;
        char c1 = 'a';
        char c2 = 'z';

        long start = System.currentTimeMillis();
        allernatingCharsString(n, c1, c2);
        System.out.println(System.currentTimeMillis() - start);

        System.out.println();

        start = System.currentTimeMillis();
        allernatingCharsSb(n, c1, c2);
        System.out.println(System.currentTimeMillis() - start);
    }

    public static String allernatingCharsString(int n, char c1, char c2) {
        String str = "";

        for (int i = 0; i < n / 2; i++) {
            // str += c1 + c2;
            str += Character.toString(c1) + Character.toString(c2);
        }
        return str;
    }

    // Получение строки с помощью стрингбилдинг (StringBuilder)
    public static String allernatingCharsSb(int n, char c1, char c2) {
        StringBuilder sb = new StringBuilder(n); // размер строки

        for (int i = 0; i < n / 2; i++) {
            sb.append(c1).append(c2);
        }
        return sb.toString();
    }
}
