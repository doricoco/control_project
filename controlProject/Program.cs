string[] wordsArray = { "water", "handler", "some", "cringe", "gb", "sun", "god" };

string[] resultArray = new string[wordsArray.Length];

for(int i = 0; i < wordsArray.Length; i++)
{
    if (wordsArray[i].Length <= 3)
        resultArray[i] = wordsArray[i];
}