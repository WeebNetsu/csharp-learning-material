string strAge = "34";
int age = Convert.ToInt32(strAge); // convert a string to an int

Console.WriteLine(age.GetType()); // GetType returns the type of the variable

long longAge = Convert.ToInt64(strAge); // will convert to long, note that the string does not require 'L' to specify it is a long
double doubleAge = Convert.ToDouble(strAge); // convert to double etc.
float floatAge = Convert.ToSingle(strAge); // note it is to single and not to float
decimal decimalAge = Convert.ToDecimal(strAge);