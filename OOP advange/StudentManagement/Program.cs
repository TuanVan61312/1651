using StudentManagement;

bool running = true;
School gw = new School();
while(running)
{
    gw.PrintMenu();
    int choice = gw.GetChoice();
    gw.Process(choice);
    running = (choice != 0);
}
