using System;
using System.Collections.Generic;

namespace QPE.Validator
{
    internal class RuleFor
    {
        private string displayName;
        public string Name { get; set; }
        public string DisplayName { get => string.IsNullOrEmpty(displayName) ? Name : displayName; set => displayName = value; }
        public ICollection<IRule> Rules { get; set; }
        internal Delegate Getter { get; set; }

        public RuleFor(string name, Delegate getter, params IRule[] rules)
        {
            Rules = new List<IRule>();
            Name = name;
            Getter = getter;
            for (int i = 0; i < rules.Length; i++)
                Rules.Add(rules[i]);
        }
    }
}