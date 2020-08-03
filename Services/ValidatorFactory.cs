using System;

public class ValidatorFactory
{
    public static IValidator createValidator(string type)
    {
        if (type == "application/json")
        {
            return new JSONSerializer();
        }
        else if (type == "application/xml")
        {
            return new XMLValidator();
        }
        else
        {
            throw new Exception("Unsupported request data");
        }
    }
}