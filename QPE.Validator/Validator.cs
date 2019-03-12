using System;
using System.Collections.Generic;

namespace QPE.Validator
{
    public class Validator
    {
        private readonly List<IRule> _rules;

        public event EventHandler<IRule> Validating;

        public event EventHandler<object> Validated;

        public Validator()
        {
            _rules = new List<IRule>();
        }

        public IRule this[string name]
        {
            get
            {
                return _rules.Find(r => r.Name == name);
            }
        }

        public void AddRule(IRule rule)
        {
            if (!_rules.Exists(r => r.Name == rule.Name))
                _rules.Add(rule);
            else
                throw new Exception($"the rule \"{rule.Name}\" is already exist");
        }

        public void RemoveRule(IRule rule)
        {
            _rules.Remove(rule);
        }

        public void ClearRules()
        {
            _rules.Clear();
        }

        public bool ValidateAll(object value)
        {
            return _rules.TrueForAll(r => Validate(value, r));
        }

        public static bool Validate(object value, IRule rule)
        {
            bool isValid = rule.IsValid(value);
            if (!isValid)
            {

            }
            return isValid;
        }

        public static bool Validate(object value, IEnumerable<IRule> rules)
        {
            foreach (IRule r in rules)
                if (!Validate(value, r))
                    return false;
            return true;
        }
        public static bool Validate(object value, params IRule[] rules)
        {
            return Validate(value, (IEnumerable<IRule>)rules);
        }
    }
}