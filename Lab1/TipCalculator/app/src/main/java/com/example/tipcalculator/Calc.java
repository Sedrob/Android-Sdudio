package com.example.tipcalculator;

public class Calc {
    private double percent;//процент чаевы
    private double billAmount;//сумма счёта


    public double calculateTip(double bollAmount, double percent) {
        return bollAmount * percent;
    }

    public double calculateTotal(double bollAmount, double percent) {
        return bollAmount * (1+percent);
    }

    public double getBillAmount() { return billAmount; }
    public void setBillAmount(double billAmount) { this.billAmount = billAmount; }

    public double getPercent() { return percent; }
    public void setPercent(double percent) { this.percent = percent; }

}
