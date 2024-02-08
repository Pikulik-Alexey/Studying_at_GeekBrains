// Напишите метод, который составит строку, состоящую из 100повторений слова TEST и метод, который запишет эту строку впростой текстовый файл, обработайте исключения.

package java_course;

import java.io.FileWriter;
import java.io.IOException;

public class CreateString {
    public static void main(String[] args) {
        String text = createRepeatWord("TEST", 100);
        writeToFile(text, "testFile.txt");
    }

    public static String createRepeatWord(String word, int repeat) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < repeat; i++) {
            sb.append(word);
        }
        return sb.toString();
    }

    public static void writeToFile(String str, String fileName) {
        try (FileWriter sWriter = new FileWriter(fileName)) {
            sWriter.write(str);
            System.out.println("Данные успешно записаны в файл!!!!");
        } catch (IOException e) {
            System.err.println("Ошибка записи в файл!");
        }
    }
}