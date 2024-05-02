namespace sitglerdiet;

public class CalculateResult
{
    public int Variables { get; set; }
    public int Constraints { get; set; }
    public AnnualFoods Foods { get; set; }
    public double OptimalAnnualPrice { get; set; }
    public NutrientsPerDay Nutrients { get; set; }
    public AdvancedUsage Advanced { get; set; }
}

public class AdvancedUsage
{
    public double SolvedTime { get; set; }
    public long SolvedIterations { get; set; }
}

public class AnnualFoods : CalculateResult
{
    public string? Name { get; set; }
    public double Price { get; set; }
}

public class NutrientsPerDay : CalculateResult
{
    public double Calories { get; set; }
    public double CaloriesMin { get; set; }
    public double Protein { get; set; }
    public double ProteinMin { get; set; }
    public double Carbohydrates { get; set; }
    public double CarbohydratesMin { get; set; }
    public double Fat { get; set; }
    public double FatMin { get; set; }
    public double Fiber { get; set; }
}
/*
variables
constraints
Annual foods
   Food1
    Food2
Optimal annual price
Nutrients per day
    Calories value + min value
    Protein
    Carbohydrates
    Fat
    Fiber
Problem
    solved in x seconds
    solved in x iterations*/