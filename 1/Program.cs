string[] textArray = new string[] { "df", "dfgtt", "555", "5t", "j,-p", "t68ggg", "ghi888gg" };
int NewArrayLength = 0;
    for (int i = 0; i < textArray.GetLength(0); i++)
    {
       if (textArray[i].Length >= 3 )
       {
        NewArrayLength++;
       }
    }
string [] threeAndLessArray = new string [NewArrayLength];
int newArrayIndex = 0;
    for (int i = 0; i < textArray.GetLength(0); i++)
    {
       if (textArray[i].Length <= 3 )
       {
        threeAndLessArray[newArrayIndex] = textArray[i];
        newArrayIndex++;
       }
    }
    for (int i = 0; i < threeAndLessArray.GetLength(0); i++)
    {
      Console.WriteLine(threeAndLessArray[i]);
    }