# qpe-validator



## Validator rules
* Required
* Numeric
* GreaterThan value
* GreaterOrEqual value
* LessThan value
* LessOrEqual value
* Regex
* NotRegex
* Date

### Example
```csharp
    Validator v = new Validator();
    v.AddRuleFor<Order>("OrderId", f => f.OrderId, Rules.Required(), Rules.Numeric());
    v.AddRuleFor<Order>("Item", f => f.Item, Rules.Required(), Rules.Numeric());
    v.AddRuleFor<Order>("Quantity", f => f.Quantity, "Required", "GreaterOrEqual 123");
```
