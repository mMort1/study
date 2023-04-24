string sentence = "Приклад умовного речення для тесту";

string[] words = sentence.Split(' ');

Array.Sort(words, (x, y) => y.Length.CompareTo(x.Length));

foreach (string word in words)

{

Console.Write(word + " ");

}
