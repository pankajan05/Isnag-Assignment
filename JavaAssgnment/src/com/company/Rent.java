package com.company;

import java.util.Scanner;

public class Rent implements Calculator{
    private double weekly_rent = 3000.00;
    private double daily_rent = 200.00;
    private double daliy_driver_cost = 100.00;
    Scanner in = new Scanner(System.in);

    public double getWeekly_rent() {
        return weekly_rent;
    }

    public void setWeekly_rent(double weekly_rent) {
        this.weekly_rent = weekly_rent;
    }

    public double getDaily_rent() {
        return daily_rent;
    }

    public void setDaily_rent(double daily_rent) {
        this.daily_rent = daily_rent;
    }

    public double getDaliy_driver_cost() {
        return daliy_driver_cost;
    }

    public void setDaliy_driver_cost(double daliy_driver_cost) {
        this.daliy_driver_cost = daliy_driver_cost;
    }

    @Override
    public double calculate() {
        int days;
        System.out.println("Enter the days: ");
        days = in.nextInt();

        double total = this.weekly_rent * (int) (days/7) + this.daily_rent * (int)(days%7) + days * this.daliy_driver_cost;
        System.out.println("Total cost is " + total);

        return total;
    }
}
