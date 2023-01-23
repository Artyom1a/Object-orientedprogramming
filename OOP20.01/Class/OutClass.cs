#region Default
// public class OutClass<T, K>
// {
//     private T PropertyT;
//     private K PropertyK;
//     public OutClass(T propertyT, K propertyK)
//     {
//         if (propertyT == null) throw new ArgumentNullException(nameof(propertyT));

//         if (propertyK == null) throw new ArgumentNullException(nameof(propertyK));
//         PropertyT = propertyT;
//         PropertyK = propertyK;
//     }

//     public void Show()
//     {
//         System.Console.WriteLine($"{PropertyT.ToString()} {PropertyK.ToString()}");
//     }
//     public T GetPropertyT()
//     {
//         return PropertyT;
//     }
//     public void SetPropertyT(T propertyT)
//     {
//         PropertyT = propertyT;
//     }
//     public K GetPropertyK()
//     {
//         return PropertyK;
//     }

//     public void SetPropertyK(K propertyK)
//     {
//         PropertyK = propertyK;
//     }

// }
#endregion

#region Struct
// public class OutClass<T> where T : struct  
// {
//     private T PropertyT;

//     public OutClass(T propertyT) 
//     {

//         PropertyT = propertyT;

//     }

//     public void Show()
//     {
//         System.Console.WriteLine($"{PropertyT.ToString()} "); 
//     }
//     public T GetPropertyT()
//     {
//         return PropertyT;
//     }
//     public void SetPropertyT(T propertyT)
//     {
//         PropertyT = propertyT;
//     }


// }
#endregion

#region Class

public class OutClass<T> where T : class
{
    private T PropertyT;

    public OutClass(T propertyT)
    {
        if (propertyT == null)
        {
            throw new ArgumentNullException(nameof(propertyT));
        }
        PropertyT = propertyT;

    }

    public void Show()
    {
        PropertyT.
        System.Console.WriteLine($"{PropertyT.ToString()} ");
    }
    public T GetPropertyT()
    {
        return PropertyT;
    }
    public void SetPropertyT(T propertyT)
    {
        PropertyT = propertyT;
    }


}
#endregion