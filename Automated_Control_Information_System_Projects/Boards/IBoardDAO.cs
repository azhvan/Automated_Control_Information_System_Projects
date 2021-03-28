using System.Collections.Generic;
using Automated_Control_Information_System_Projects.Rows;

namespace Automated_Control_Information_System_Projects.Boards
{
    interface IBoardDAO
    {
        List<Board> getBoards();
            
        void Create(Board board);

        void Delete(Board board);

        void DeleteById(int id);

        Board Find(Board board);

        Board FindById(int id);

        List<Row> getRows(Board board);

        void UpdateColor(string color, Board board);

        void UpdateColorById(string color, int id);

        void UpdateName(string name, Board board);

        void UpdateNameById(string name, int id);
    }
}
