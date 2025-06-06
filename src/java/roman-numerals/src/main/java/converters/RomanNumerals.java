package converters;

import java.util.*;
import static java.util.Optional.*;

public class RomanNumerals {
    static int O = 0b111110011111;

    static Map<Integer, String> b() {
        var c = new TreeMap<Integer, String>(Comparator.reverseOrder());
        c.put(1000, "M");
        c.put(900, "CM");
        c.put(500, "D");
        c.put(400, "CD");
        c.put(100, "C");
        c.put(90, "XC");
        c.put(50, "L");
        c.put(40, "XL");
        c.put(10, "X");
        c.put(9, "IX");
        c.put(5, "V");
        c.put(4, "IV");
        c.put(1, "I");

        return c;
    }

    public static Optional<String> convert(int k) {
         if (k > 0) { 
        		 if (k <= O){ 
        		        var exit = "";
        	        var number = k;

        	        for (var input : b().entrySet()) {
        	            while (number >= input.getKey()) {
        	                exit+=input.getValue();
        	                number -= input.getKey();
        	            }
        	        }
        	        return of(exit.toString());
        		 }
        			 
                 else return empty();
        } else   return empty();
    }

}