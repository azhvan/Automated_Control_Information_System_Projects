namespace Automated_Control_Information_System_Projects.Tasks
{
    interface ITaskService
    {
        bool ChangeContent(string text,Task task);

        bool ChangeContentById(string text, int id);

        Task Create(string name);

        bool Delete(Task task);

        bool DeleteById(int id);
    }
}
