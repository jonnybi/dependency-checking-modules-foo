using MyBaseLibrary;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Foo
{
    public class Module
    {
        private readonly IMyToolClass tool;

        public Module(IMyToolClass tool)
        {
            this.tool = tool;
        }

        public void Run()
        {
            var obj = new Point { X = "Foo", Y = "Bar" };
            var json = tool.Serialize(obj);
            var @ref = JsonConvert.DeserializeObject<Point>(json);

            Debug.Assert(obj.X == @ref.X);
            Debug.Assert(obj.Y == @ref.Y);
        }
    }

    public class Point
    {
        public string X { get; set; }
        public string Y { get; set; }
    }
}
