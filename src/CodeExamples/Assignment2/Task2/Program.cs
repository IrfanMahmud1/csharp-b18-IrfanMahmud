// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string num1 = Console.ReadLine().Trim();
string num2 = Console.ReadLine().Trim();
string ans = "";
int len1 = num1.Length, len2 = num2.Length;
int a = 0, b = 0, sum = 0, carry = 0;
for (int i = num1.Length - 1, j = num2.Length - 1; i >= 0 || j >= 0; i--, j--)
{
    if (i >= 0)
    {
        a = int.Parse(num1[i].ToString());
    }
    if (j >= 0)
    {
        b = int.Parse((num2[j].ToString()));
    }
    if (i >= 0 && j >= 0)
    {
        sum = a + b + carry;
    }
    else if (j < 0)
    {
        sum = a + carry;
    }
    else
    {
        sum = b + carry;
    }
    ans += sum >= 10 ? sum - 10 : sum;
    carry = sum >= 10 ? 1 : 0;
}
char[] result = ans.ToCharArray();
for (int i = 0, j = result.Length - 1; i < j; i++, j--)
{
    char c = result[i];
    result[i] = result[j];
    result[j] = c;
}
foreach (char c in result)
{
    Console.Write(c);
}