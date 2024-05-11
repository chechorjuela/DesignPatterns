using FactoryMethod.Builders.Builders.Base;

namespace FactoryMethod.Builders.Builders
{
    public class School : Building
    {
        public override void CloseDoor()
        {
            Console.WriteLine("Close door School");
        }
        public override void OpenDoor()
        {
            Console.WriteLine("Open door School");
        }
        public override void CloseWindow()
        {
            Console.WriteLine("Close window School");
        }
        public override void OpenWindow()
        {
            Console.WriteLine("Open window School");
        }
    }
}