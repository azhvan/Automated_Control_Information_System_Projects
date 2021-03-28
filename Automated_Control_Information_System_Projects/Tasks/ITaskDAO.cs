namespace Automated_Control_Information_System_Projects.Tasks
{
    interface ITaskDAO
    {
        void Create(Task task);

        void Delete(Task task);

        void DeleteById(int id);

        Task Find(Task task);

        Task FindById(int id);

        void Update(string name, Task task);

        void UpdateById(string name, int id);
    }
}
