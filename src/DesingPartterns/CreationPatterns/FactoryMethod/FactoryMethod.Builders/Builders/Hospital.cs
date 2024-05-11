using FactoryMethod.Builders.Builders.Base;

namespace FactoryMethod.Builders.Builders
{
    public class Hospital : Building
    {
        public override void CloseDoor()
        {
            Console.WriteLine("Close door Hospital");
        }
        public override void OpenDoor()
        {
            Console.WriteLine("Open door Hospital");
        }
        public override void CloseWindow()
        {
            Console.WriteLine("Close window Hospital");
        }
        public override void OpenWindow()
        {
            Console.WriteLine("Open window Hospital");
        }
    }
}