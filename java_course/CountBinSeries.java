// Дан массив двоичных чисел, например [1,1,0,1,1,1], вывести максимальное количество подряд идущих 1.

package java_course;

public class CountBinSeries {
    public static void main(String[] args) {
        int[] numsArr = { 1, 1, 0, 1, 1, 1 };

        int onesCounter = 0;
        int counterMax = 0;

        for (int num : numsArr) {
            if (num == 1) {
                onesCounter++;
                // counterMax = counterMax > onesCounter ? counterMax : onesCounter;
                counterMax = Math.max(counterMax, onesCounter);
            } else {

                onesCounter = 0;
            }
        }
        System.out.println(counterMax);
    }
}

// Сзздаем метод
// public class CountBinSeries {
// public static void main(String[] args) {
// int[] numsArr = { 1, 1, 0, 1, 1, 1 };

// int counterMax = getCounterMax(numsArr);
// System.out.println(counterMax);
// }

// private static int getCounterMax(int[] numsArr) {
// int onesCounter = 0;
// int counterMax = 0;

// for (int num : numsArr) {
// if (num == 1) {
// onesCounter++;
// // counterMax = counterMax > onesCounter ? counterMax : onesCounter;
// counterMax = Math.max(counterMax, onesCounter);
// } else {

// onesCounter = 0;
// }
// }
// return counterMax;
// }
// }
