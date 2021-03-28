using System.Collections.Generic;

namespace Automated_Control_Information_System_Projects.Rows
{
    interface IRowService
    {
        bool ChangeName(string name,Row row);

        bool ChangeNameById(string name,int id);

        Row Create(string name);

        bool Delete(Row row);

        bool DeleteById(int id);

        List<Row> getRows();

        List<Tasks.Task> PrintAllTask(Row row);
    }
}
