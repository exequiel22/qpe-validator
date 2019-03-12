using System;
using System.Collections.Generic;

namespace QPE.Validator
{
    public class Validator
    {
        private readonly List<IRule> _rules;

        public event EventHandler<EventArgs> Validating;

        public event EventHandler<EventArgs> Validated;

        private List<ValidatorError> Errors => new List<ValidatorError>();

        public Validator()
        {
            _rules = new List<IRule>();
        }

        public IRule this[string name] => _rules.Find(r => r.Name == name);

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
            Errors.Clear();
            Validating?.Invoke(this, new EventArgs());
            bool isValid = _rules.TrueForAll(rule =>
             {
                 bool res = Validate(value, rule);

                 if (!res)//Is Error
                     Errors.Add(new ValidatorError(rule.ErrorMessage));

                 return res;
             });
            Validated?.Invoke(this, new EventArgs());
            return isValid;
        }

        public static bool Validate(object value, IRule rule)
        {
            return rule.IsValid(value);
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

        public IEnumerable<ValidatorError> GetErrors()
        {
            return Errors;
        }
    }
}