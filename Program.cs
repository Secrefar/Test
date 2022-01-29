string[] array = {"8ddkk", "wd5", "=7bw", "q", "86+", "hs10", "#4=", "g5", "-="};

int sizeNewArray = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) sizeNewArray++;
}

string[] newarray = new string[sizeNewArray];

int a = 0;
int n = 0;

while (a < array.Length)
{
    if (array[a].Length <= 3) 

    {   
        newarray[n] = array[a];
        Console.WriteLine(newarray[n]);
        a++;
        n++;
    }

    else a++;
}
