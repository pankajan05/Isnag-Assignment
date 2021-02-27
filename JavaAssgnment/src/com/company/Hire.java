package com.company;

import java.util.Scanner;

public class Hire implements Calculator{
    private double package_100 = 10000.00;
    private double package_200 = 25000.00;
    private double extra_km = 1000.00;
    Scanner in = new Scanner(System.in);


    private double over_night_charge = 1000.00;
    private double waiting_charge = 1000.00;
    private double night_park_rate = 100.00;

    public double getOver_night_charge() {
        return over_night_charge;
    }

    public void setOver_night_charge(double over_night_charge) {
        this.over_night_charge = over_night_charge;
    }

    public double getWaiting_charge() {
        return waiting_charge;
    }

    public void setWaiting_charge(double waiting_charge) {
        this.waiting_charge = waiting_charge;
    }

    public double getNight_park_rate() {
        return night_park_rate;
    }

    public void setNight_park_rate(double night_park_rate) {
        this.night_park_rate = night_park_rate;
    }

    public double getPackage_100() {
        return package_100;
    }

    public void setPackage_100(double package_100) {
        this.package_100 = package_100;
    }

    public double getPackage_200() {
        return package_200;
    }

    public void setPackage_200(double package_200) {
        this.package_200 = package_200;
    }

    public double getExtra_km() {
        return extra_km;
    }

    public void setExtra_km(double extra_km) {
        this.extra_km = extra_km;
    }

    @Override
    public double calculate() {
        int km;
        System.out.println("Enter your 1 for hire 100 km package" +
                " \n Enter 2 for hire 200 km package \n" +
                " other number for omit package: ");
        km = in.nextInt();
        double total = 0.0;
        if(km == 1){
            total += package_100;
        }
        else if(km == 2){
            total += package_200;
        }

        System.out.println("Enter extra_km : ");
        km = in.nextInt();

        total += km *extra_km;

        int days;
        System.out.println("Enter the days: ");
        days = in.nextInt();

        if(days >= 2){
            total += this.over_night_charge + this.night_park_rate * days;
        }

        total += waiting_charge;

        System.out.println("Total cost is " + total);

        return total;
    }
}
