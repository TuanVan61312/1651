using DemoStrategy;

Class GCH1001 = new Class (new SortByName());
GCH1001.AddStudent(new Student("john", 20, 3.5)) ;
GCH1001.AddStudent(new Student("sdq", 15, 6.5)) ;
GCH1001.AddStudent(new Student("abc", 20, 9.0)) ;
GCH1001.AddStudent(new Student("zxc", 17, 5.4)) ;

GCH1001.Show();
Console.WriteLine("==========================");
Console.WriteLine(" ");

Console.WriteLine("-------Sort by Name-------");
GCH1001.ChangeSorter(new SortByName());
GCH1001.Show();

Console.WriteLine("-------Sort by Age-------");
GCH1001.ChangeSorter(new SortByAge());
GCH1001.Show();

Console.WriteLine("-------Sort by GPA-------");
GCH1001.ChangeSorter(new SortByGPA());
GCH1001.Show();