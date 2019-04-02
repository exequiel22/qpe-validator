using System;

namespace QPE.Validator
{
    public static class Utils
    {
        public static IRule GetRuleByExpression(string expression)
        {
            //Required
            //GraterOrEqual 12|324

            try
            {
                string[] array = expression.Split(' ');
                object[] parameters = null;

                string name = array[0];
                var method = typeof(Rules).GetMethod(name);
                var paramsInfo = method.GetParameters();
                if (array.Length > 1)
                {
                    parameters = array[1].Split('|');
                    if (paramsInfo.Length == parameters.Length)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            parameters[i] = Convert.ChangeType(parameters[i], paramsInfo[i].ParameterType);
                        }
                    }

                }



                return (IRule)method.Invoke(null, parameters);
            }
            catch (Exception ex)
            {
                throw new InvalidRuleExpressionException(ex.Message);
            }
        }
    }
}