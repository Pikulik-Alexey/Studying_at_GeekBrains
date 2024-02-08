// Дан массив nums = [3,2,2,3] и число val = 3.
// Если в массиве есть числа, равные заданному, нужно перенести эти элементы в конец массива.
// Таким образом, первые несколько (или все) элементов массива должны быть отличны от заданного, а остальные - равны ему.

package java_course;

import java.util.Arrays;

public class SortNums {
    public static void main(String[] args) {
        // int[] array = { 3, 2, 2, 3 };
        int[] array1 = { 1, 2, 3, 4, 5, 3, 6, 7, 3, 3, 8, 9, 3 };
        int val = 3;
        int right = array1.length - 1;

        while (array1[right] == val) {
            right--;
        }

        for (int left = 0; left < right; left++) {
            if (array1[left] == val) {
                array1[left] = array1[right];
                array1[right] = val;
                right--;
            }
        }
        System.out.println(Arrays.toString(array1));
    }
}
