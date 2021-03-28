using System.Collections.Generic;
using Automated_Control_Information_System_Projects.Rows;

namespace Automated_Control_Information_System_Projects.Boards
{
    interface IBoardService
    {
        List<Board> getBoards();

        bool ChangeColor(string color,Board board);
        
        bool ChangeName(string name,Board board);
        
        bool ChangeColorById(string color,int id);
        
        bool ChangeNameById(string name, int id);

        Board Create(string name,string color);

        bool Delete(Board board);

        bool DeleteById(int id);

        List<Row> PrintAllRows(Board board);
    }
}
