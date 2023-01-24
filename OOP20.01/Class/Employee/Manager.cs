namespace Works;

public class Manager: IManagementLevelEmployee, IEvaluatedEmployee {
    public string Name {
        get;
        set;
    }
    public string Designation {
        get;
        set;
    }
    public int KPI {
        get;
        set;
    }
    public IEvaluatedEmployee EvaluateSubordinate(IEvaluatedEmployee evaluatedemployee) {
        Random random = new Random();
        evaluatedemployee.KPI = random.Next(40, 100);
        return evaluatedemployee;
    }
}