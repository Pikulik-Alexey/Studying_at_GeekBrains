// Напишите метод, который находит самую длинную строку общего префикса среди массива строк.
// Если общего префикса нет, вернуть пустую строку ""

// String[] str = {"flower", "flow", "flight"}; //fl

package java_course;

public class FindPref {
    public static void main(String[] args) {
        String[] str = { "flower", "flow", "flight" };

        System.out.println(maxPrefix(str));
    }

    static String maxPrefix(String[] wordArr) {
        String pref = wordArr[0];

        for (int i = 1; i < wordArr.length; i++) {
            while (wordArr[i].indexOf(pref) != 0) {
                pref = pref.substring(0, pref.length() - 1);
                if (pref.isEmpty()) {
                    return pref;
                }
            }
        }
        return pref;
    }

}
