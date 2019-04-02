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
            //Config = config ?? new ValidatorConfig();
            rulesFor = new List<RuleFor>();
        }

        //public ValidatorConfig Config { get; }
        public IEnumerable<RuleError> Errors { get; private set; }

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

        public IEnumerable<RuleError> ValidateAll(object obj)
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

        public Task<IEnumerable<RuleError>> ValidateAllAsync(object obj)
        {
            return Task.Run(() => ValidateAll(obj));
        }
    }
}