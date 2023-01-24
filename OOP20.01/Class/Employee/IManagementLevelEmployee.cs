namespace Works;
public interface IManagementLevelEmployee: IEmployee {
    IEvaluatedEmployee EvaluateSubordinate(IEvaluatedEmployee employee);
}