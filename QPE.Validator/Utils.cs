using System;

namespace QPE.Validator
{
    public static class Utils
    {
        public static IRule GetRuleByExpression(string expression)
        {
            try
            {
                System.Collections.ArrayList arrayList = new System.Collections.ArrayList();

                string[] array = expression.Split(' ');
                string[] parameters = null;

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
                            arrayList.Add(Convert.ChangeType(parameters[i], paramsInfo[i].ParameterType));
                        }
                    }
                }

                return (IRule)method.Invoke(null, arrayList.ToArray());
            }
            catch (Exception ex)
            {
                throw new InvalidRuleExpressionException(ex.Message);
            }
        }
    }
}