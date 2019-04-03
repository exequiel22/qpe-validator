using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QPE.Validator
{
    public class Validator
    {
        private readonly List<RuleFor> rulesFor;

        public Validator()
        {
            rulesFor = new List<RuleFor>();
        }

        public void AddRuleFor<T>(string name, Func<T, object> getter, params IRule[] rules)
        {
            this.rulesFor.Add(new RuleFor(name, getter, rules));
        }

        public void AddRuleFor<T>(string name, Func<T, object> getter, params string[] ruleExpressions)
        {
            foreach (var r in ruleExpressions)
                this.rulesFor.Add(new RuleFor(name, getter, Rules.ByExpression(r)));
        }

        public void Clear()
        {
            this.rulesFor.Clear();
        }

        public IEnumerable<RuleError> Validate<T>(T obj, string fieldName)
            where T : class
        {
            var all = rulesFor.FindAll(r => r.Name == fieldName);
            foreach (var rf in all)
            {
                object value = rf.Getter.DynamicInvoke(obj);

                foreach (var r in rf.Rules)
                {
                    if (!r.IsValid(value))
                    {
                        yield return new RuleError(this, rf, r);
                    }
                }
            }
        }

        public IEnumerable<RuleError> ValidateAll<T>(T obj)
            where T : class
        {
            foreach (var rf in rulesFor)
            {
                object value = rf.Getter.DynamicInvoke(obj);

                foreach (var r in rf.Rules)
                {
                    if (!r.IsValid(value))
                    {
                        yield return new RuleError(this, rf, r);
                    }
                }
            }
        }

        public Task<IEnumerable<RuleError>> ValidateAllAsync<T>(T obj)
            where T : class
        {
            return Task.Run(() => ValidateAll(obj));
        }
    }
}