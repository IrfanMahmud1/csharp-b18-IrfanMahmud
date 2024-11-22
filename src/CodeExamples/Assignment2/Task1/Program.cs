//22 7 50

string[] input = Console.ReadLine().Trim().Split();

int a =  int.Parse(input[0].ToString());
int b =  int.Parse(input[1].ToString());
int c =  int.Parse(input[2].ToString());

string ans = "";
while (c >= 0)
{
    ans += a / b;
    if (ans.Length == 1)
    {
        ans += '.';
    }
    int x = a % b;
    a = x < b ? x * 10 : x;
    c--;
}
foreach (char s in ans)
{
    Console.Write(s);
}
