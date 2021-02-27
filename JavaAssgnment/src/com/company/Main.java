package com.company;

import java.util.Scanner;

public class Main
{

    public static void main(String[] args) {
        char option;
        Calculator c = null;
        Scanner in = new Scanner(System.in);

        System.out.println("Ayubo Leisure (Pvt) Ltd");

        System.out.println("If you want to Hire Enter H if you want to Rent Enter R: ");
        option = in.next().charAt(0);

        if(option == 'H'){
            c = new Rent();
        } else if(option == 'R'){
            c= new Hire();
        } else {
            System.out.println("Sorry wrong Input try again.");
        }

        if(c != null)
        System.out.println("Your total is " + c.calculate());
    }
}

