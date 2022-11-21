using demoStatic;

Student john = new Student("john", 20);
Student paul = new Student("paul", 21);

john.ShowInfo();
paul.ShowInfo();

Student.School = "Greenwich Vietnam";

john.ShowInfo();
paul.ShowInfo();
