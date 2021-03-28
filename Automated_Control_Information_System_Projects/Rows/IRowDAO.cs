using System.Collections.Generic;

namespace Automated_Control_Information_System_Projects.Rows
{
    interface IRowDAO
    {
        void Create(Row row);

        void Delete(Row row);

        void DeleteById(int id);

        Row Find(Row row);

        Row FindById(int id);

        List<Tasks.Task> getTask(Row row);

        List<Row> getRows();

        void Update(string name, Row row);

        void UpdateById(string name, int id);
    }
}
