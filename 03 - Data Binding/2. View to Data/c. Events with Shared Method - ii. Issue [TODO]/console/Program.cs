Action foo = null;

for (int i = 0; i < 3; i++)
{
    //int j = i;
    foo = () => Console.WriteLine(j);
}

foo(); // Return 1 ???
