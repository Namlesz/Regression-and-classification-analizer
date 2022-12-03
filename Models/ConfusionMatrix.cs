namespace EksploracjaDanych.Models;

public class ConfusionMatrix
{
    private double TP { get; set; }
    private double TN { get; set; }
    private double FP { get; set; }
    private double FN { get; set; }

    public double GetTP()
    {
        return TP;
    }

    public double GetTN()
    {
        return TN;
    }

    public double GetFP()
    {
        return FP;
    }

    public double GetFN()
    {
        return FN;
    }

    public void AddTruePositive()
    {
        TP++;
    }

    public void AddTrueNegative()
    {
        TN++;
    }

    public void AddFalsePositive()
    {
        FP++;
    }

    public void AddFalseNegative()
    {
        FN++;
    }

    public double Accuracy()
    {
        return (TP + TN) / (TP + TN + FP + FN);
    }

    public double Precision()
    {
        return TP / (TP + FP);
    }

    public double Sensitivity()
    {
        return TP / (TP + FN);
    }

    public double Specificity()
    {
        return TN / (TN + FP);
    }
    
    public double F1Score()
    {
        return 2 * (Precision() * Sensitivity()) / (Precision() + Sensitivity());
    }
}