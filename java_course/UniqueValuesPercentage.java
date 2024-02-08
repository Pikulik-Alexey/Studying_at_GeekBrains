package java_course;

// import java.util.Arrays;
import java.util.HashSet;
import java.util.Random;
import java.util.Set;

public class UniqueValuesPercentage {
    static int[] makeRandomNumbersArray(int size, int maxVal) {
        Random rand = new Random();
        int[] numbersArr = new int[size];

        for (int i = 0; i < size; i++) {
            numbersArr[i] = rand.nextInt(maxVal);
        }

        return numbersArr;
    }

    static double calcUniquePercentage(int[] arr) {
        Set<Integer> uniqueNumbers = new HashSet<>();

        for (Integer num : arr) {
            uniqueNumbers.add(num);
        }

        int arrSize = arr.length;
        int uniqueSize = uniqueNumbers.size();

        return (double) (uniqueSize * 100) / arrSize;
    }

    public static void main(String[] args) {
        int size = 1000;
        int maxVal = 25;

        int[] randNumsArr = makeRandomNumbersArray(size, maxVal);
        double res = calcUniquePercentage(randNumsArr);
        System.out.println(res);
    }
}
