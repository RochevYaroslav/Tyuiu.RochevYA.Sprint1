using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RochevYA.Sprint1.Task6.V10.Lib
{
    public class DataService : ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string text)
        {
            var ls = text.Split(" ");
            var resultList = new List<string>();

            foreach (var word in ls)
            {
                if (word.Length % 2 == 1 && word.Length > 1)
                {
                    int middleIndex = word.Length / 2;
                    string newWord = word.Substring(0, middleIndex) + word.Substring(middleIndex + 1);
                    resultList.Add(newWord);
                }
                else
                {
                    resultList.Add(word);
                }
            }
            return string.Join(" ", resultList);
        }
    }
}