Action foo = null;

for (int i = 0; i < 3; i++)
{
    if (i < 2)
    {
        foo = () => Console.WriteLine(i);
    }
}

foo();
