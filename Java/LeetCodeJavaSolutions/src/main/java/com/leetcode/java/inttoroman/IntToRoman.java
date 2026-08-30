package com.leetcode.java.inttoroman;

import java.util.HashMap;
import java.util.Map;

public class IntToRoman {
    public String intToRoman(int num) {
        Map<Integer, String> map = new HashMap<>();
        map.put(1, "I");
        map.put(5, "V");
        map.put(10, "X");
        map.put(50, "L");
        map.put(100, "C");
        map.put(500, "D");
        map.put(1000, "M");

        StringBuilder result = new StringBuilder("");

        String n = String.valueOf(num);

        for(int i = 0;i < n.length();i++) {
            int current = Integer.parseInt(n.charAt(i) + "");

            if (i + 1 < n.length()) {
                int next = Integer.parseInt(n.charAt(i + 1) + "");
                if(current < next) {
                    result.append(map.get(current));
                } else {
                    result.append(map.get(current));
                }
            } else {
                result.append(map.get(current));
            }
        }
        return result.toString();
    }
}
