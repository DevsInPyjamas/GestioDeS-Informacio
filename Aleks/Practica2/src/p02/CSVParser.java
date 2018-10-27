package p02;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;


public class CSVParser {
    private static String DELIMITER;

    public CSVParser(String delimiter) {
        DELIMITER = "[" + delimiter + "]+";
    }

    public List<List<String>> fileReader(String fileName) {
        try(Scanner sc = new Scanner(new File(fileName))) {
            return fileReader(sc);
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
        return null;
    }

    private List<List<String>> fileReader(Scanner sc) {
        List<List<String>> allAttributes = new ArrayList<>();
        while(sc.hasNextLine()) {
            allAttributes.add(parseLines(sc.nextLine()));
        }
        return allAttributes;
    }

    private List<String> parseLines(String line) {
        List<String>  attributes = new ArrayList<>();
        try(Scanner sc = new Scanner(line)) {
            sc.useDelimiter(DELIMITER);
            while(sc.hasNext()) {
                attributes.add(sc.next());
            }
        }
        return attributes;
    }
}
