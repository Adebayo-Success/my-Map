// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

mapAlphabetToWord();
void mapAlphabetToWord()
{
    
    Dictionary<char, string> mapAlphabet = new Dictionary<char, string>()
    {
        {'A',"Ant"},
       {'B' , "Bat"},
       {'C', "Cat"},
       {'D', "Dog"},
        {'E', "Elephant"},
        {'F', "Fox"},
        {'G', "Goat"},
        {'H', "Hyena"},
        {'I', "Iglow"},
        {'J', "Jaguar"},
        {'K', "Kangaroo"},
      { 'L',"Leopard"},
      {'M', "Monkey"},
      {'N', "NeedleFish"},
      {'O', "Owl"},
      {'P', "Pig"},
      {'Q', "Quail"},
      {'R', "Rat"},
      {'S', "Shark"},
      {'T', "Turtle"},
      {'U', "Umbrellabird"},
      {'V', "Vulture"},
      {'W', "Whale"},
      {'X', "Xema"},
      {'Y', "Yak"},
      {'Z', "Zebra"}
    };
    int count = 0;
    foreach (var c in mapAlphabet)
    {
        count++;
        System.Console.Write($" {count}.  {c.Key} ");
        System.Console.WriteLine($"for {c.Value}");
    }
}

