
string[] cities =
{
"Andorra la Vella", "Tirana", "Vilnius", "Vienna", "Baku", "Minsk", "Brussels", "Sarajevo",
"Sofia", "Zagreb", "Nicosia", "Prague", "Copenhagen", "Tallinn", "Helsinki", "Paris",
"Tbilisi", "Berlin", "Athens", "Budapest", "Reykjavik", "Dublin", "Rome", "Astana", "Pristina",
"Riga", "Vaduz", "Vilnius", "Luxembourg", "Skopje", "Valletta", "Chisinau", "Monaco", "Podgorica",
"Amsterdam", "Oslo", "Warsaw", "Lisbon", "Bucharest", "Bratislava", "Ljubljana", "Madrid",
"Stockholm", "Bern", "Ankara", "Kyiv", "London"
};

int nameLenght = 4;
char startsWith = 'V';
char endsWith = 'a';
string contains = "Du";

Console.WriteLine($"Capital Cities of Europe: {string.Join(", ", cities)}\n");

Console.WriteLine($"Cities with '{nameLenght}' letters in name: {string.Join(", ",
    cities.Where(i => i.Length == nameLenght))}\n");

Console.WriteLine($"Cities that starts with '{startsWith}': {string.Join(", ",
    cities.Where(i => i.StartsWith(startsWith)))}\n");

Console.WriteLine($"Cities that ends with '{endsWith}': {string.Join(", ",
    cities.Where(i => i.EndsWith(endsWith)))}\n");

Console.WriteLine($"Cities that starts with '{startsWith}' ends with '{endsWith}': {string.Join(", ",
    cities.Where(i => i.StartsWith(startsWith) && i.EndsWith(endsWith)))}\n");

Console.WriteLine($"Cities that cointains '{contains}': {string.Join(", ",
    cities.Where(i => i[0] == contains[0] && i[1] == contains[1]))}\n");