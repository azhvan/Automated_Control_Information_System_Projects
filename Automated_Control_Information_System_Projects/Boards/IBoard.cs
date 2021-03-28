namespace Automated_Control_Information_System_Projects.Boards
{
    interface IBoard
    {
        int ID { get; }
        string Color { get; set; }
        string Name { get; set; }
    }
}