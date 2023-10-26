using hm16_task3;

List<Student> list = new List<Student>()
{
    new Student("Jack", 21, "MIT"),
    new Student("Alan", 26, "MIT"),
    new Student("Peter", 25, "Oxford"),
    new Student("Annette", 21, "Oxford"),
    new Student("Georg", 18, "MIT"),
    new Student("Jessica", 19, "MIT"),
    new Student("Victoria", 23, "Oxford"),
    new Student("Boris", 18, "Oxford"),
    new Student("Rowan", 24, "MIT"),
    new Student("Marina", 22, "MIT"),
    new Student("Albert", 22, "MIT"),
    new Student("Mark", 25, "Oxford"),
    new Student("Jeffrey", 21, "Oxford"),
    new Student("Samanta", 19, "MIT"),
    new Student("Boris", 22, "MIT"),
    new Student("Nick", 19, "Oxford"),
    new Student("Ashly", 21, "MIT"),
    new Student("Kira", 18, "MIT"),
};

string searchName = "Boris";
string contains = "Je";
int olderThen = 19;
int youngerThen = 23;
string studyInMIT = "MIT";
string studyInOxford = "Oxford";

Console.WriteLine("Students:\n");
foreach (Student student in list)
{
    Console.WriteLine(student);
}
Console.WriteLine("------------------------");

Console.WriteLine($"Students with name {searchName}:\n");
foreach (var student in list.Where(student => student.Name == searchName).ToList())
{
    Console.WriteLine(student);
}
Console.WriteLine("------------------------");

Console.WriteLine($"Students with {contains} in name:\n");
foreach (var student in list.Where(student => student.Name.StartsWith(contains)).ToList())
{
    Console.WriteLine(student);
}
Console.WriteLine("------------------------");

Console.WriteLine($"Students that are older then {olderThen}:\n");
foreach (var student in list.Where(student => student.Age > olderThen).ToList())
{
    Console.WriteLine(student);
}
Console.WriteLine("------------------------");

Console.WriteLine($"Students that are older then {olderThen} and younger then {youngerThen}:\n");
foreach (var student in list.Where(student =>
student.Age > olderThen && student.Age < youngerThen).ToList())
{
    Console.WriteLine(student);
}
Console.WriteLine("------------------------");

Console.WriteLine($"Students that are studying in {studyInMIT}:\n");
foreach (var student in list.Where(student => student.University == studyInMIT).ToList())
{
    Console.WriteLine(student);
}
Console.WriteLine("------------------------");

Console.WriteLine($"Students that are studying in {studyInOxford}:\n");
foreach (var student in list.Where(student => student.University == studyInOxford).ToList())
{
    Console.WriteLine(student);
}
Console.WriteLine("------------------------");

Console.WriteLine($"Students older then {olderThen} by descending:\n");
foreach (var student in list.Where(student => student.Age > olderThen)
    .OrderByDescending(student => student.Age)
    .ToList())
{
    Console.WriteLine(student);
}
Console.WriteLine("------------------------");