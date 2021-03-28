using System.Collections.Generic;

namespace Automated_Control_Information_System_Projects.Rows
{
    public class Row:IRow
    {
        string  name;
        int id;
        List<Tasks.Task> tasks;

        public int ID { get => id; }
        public string Name { get => name; set => name = value; }
        public List<Tasks.Task> Tasks { get => tasks; set => tasks = value; }

        public Row(string name)
        {
            Tasks = new List<Tasks.Task>();
            this.id = RandomID.GetInstance().IdForRow();
            this.name = name;
        }

        public List<Tasks.Task> getTasks()
        {
            return Tasks;
        }
        public void addTask(Tasks.Task task)
        {
            Tasks.Add(task);
        }
    }
}