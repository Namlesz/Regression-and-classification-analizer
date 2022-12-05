namespace EksploracjaDanych.Models;

public class ClassificationModel
{
    private double Tp { get; set; }
    private double Tn { get; set; }
    private double Fp { get; set; }
    private double Fn { get; set; }

    private double Auc { get; set; }

    public double GetAuc()
    {
        return Auc;
    }
    
    public void SetAuc(double auc)
    {
        Auc = auc;
    }
    
    public double GetTp()
    {
        return Tp;
    }

    public double GetTn()
    {
        return Tn;
    }

    public double GetFp()
    {
        return Fp;
    }

    public double GetFn()
    {
        return Fn;
    }

    public void AddTruePositive()
    {
        Tp++;
    }

    public void AddTrueNegative()
    {
        Tn++;
    }

    public void AddFalsePositive()
    {
        Fp++;
    }

    public void AddFalseNegative()
    {
        Fn++;
    }

    public double Accuracy()
    {
        return (Tp + Tn) / (Tp + Tn + Fp + Fn);
    }

    public double Precision()
    {
        return Tp / (Tp + Fp);
    }

    public double Sensitivity()
    {
        return Tp / (Tp + Fn);
    }

    public double Specificity()
    {
        return Tn / (Tn + Fp);
    }

    public double F1Score()
    {
        return 2 * (Precision() * Sensitivity()) / (Precision() + Sensitivity());
    }

    public void Reset()
    {
        Tp = 0;
        Tn = 0;
        Fp = 0;
        Fn = 0;
    }
}