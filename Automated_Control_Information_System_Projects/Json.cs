using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Automated_Control_Information_System_Projects
{
  class Json
  {
    public static void Serializer(List<Boards.Board> list, string path)
    {
      using (StreamWriter file = File.CreateText(path))
      {
        JsonSerializer serializer = new JsonSerializer();
        serializer.Serialize(file, list);
      }
    }

    public static List<Boards.Board> Deserializer(List<Boards.Board> boards, string path)
    {
      if (!File.Exists(path))
        return null;
      using (StreamReader file = File.OpenText(path))
      {
        JsonSerializer deserializer = new JsonSerializer();
        boards = (List<Boards.Board>)deserializer.Deserialize(file, typeof(List<Boards.Board>));
        return boards;
      }

    }
  }
}
