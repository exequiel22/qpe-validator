using System;
using System.Text.RegularExpressions;

namespace QPE.Validator
{
    /*
Accepted
Active URL
After (Date)
After Or Equal (Date)
Alpha
Alpha Dash
Alpha Numeric
Array
Bail
Before (Date)
Before Or Equal (Date)
Between
Boolean
Confirmed
Date
Date Equals
Date Format
Different
Digits
Digits Between
Dimensions (Image Files)
Distinct
E-Mail
Exists (Database)
File
Filled
Greater Than
Greater Than Or Equal
Image (File)
In
In Array
Integer
IP Address
JSON
Less Than
Less Than Or Equal
Max
MIME Types
MIME Type By File Extension
Min
Not In
Not Regex
Nullable
Numeric
Present
Regular Expression
Required
Required If
Required Unless
Required With
Required With All
Required Without
Required Without All
Same
Size
Starts With
String
Timezone
Unique (Database)
URL
UUID
         
         */
    public static class Rules
    {
        public static IRule Required =  new Required();
        public static IRule RequiredIf(Func<bool> conditionalFunc) => new RequiredIf(conditionalFunc);
        public static IRule Numeric() => new Numeric();
        public static IRule As(Type type) => new As(type);
        public static IRule BeforeDate(DateTime date) => new BeforeDate(date);
        public static IRule BeforeOrEqualDate(DateTime date) => new BeforeOrEqualDate(date);
        public static IRule EMail() => new Email();
        public static IRule InArray(params object[] values) => new InArray(values);
        public static IRule Regex(Regex regex) => new RegexRule(regex);
        public static IRule NotRegex(Regex regex) => new NotRegex(regex);
        public static IRule Different() => new Different();


    }
}
