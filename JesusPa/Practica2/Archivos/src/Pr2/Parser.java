package Pr2;
import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Parser {
    private static String DELIMITER;

    public Parser(String delimiter) {
        DELIMITER = "[" + delimiter + "]+";
    }

    public List<List<String>> fileReader(String filename) {
        try (Scanner sc = new Scanner(new File(filename))) {
            return fileReader(sc);
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
        return null;
    }

    private List<List<String>> fileReader(Scanner sc) {
        List<List<String>> attributes = new ArrayList<>();
        while (sc.hasNextLine()) {
            attributes.add(parseLines(sc.nextLine()));
        }
        return attributes;
    }

    private List<String> parseLines(String line) {
        List<String> attributes = new ArrayList<>();
        try (Scanner sc = new Scanner(line)) {
            sc.useDelimiter(DELIMITER);
            while (sc.hasNext()) {
                attributes.add(sc.next());
            }
        }
        return attributes;
    }
}