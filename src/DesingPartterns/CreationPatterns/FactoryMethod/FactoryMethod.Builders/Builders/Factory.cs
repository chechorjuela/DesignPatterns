using FactoryMethod.Builders.Builders.Base;

namespace FactoryMethod.Builders.Builders
{
    public class Factory : Building
    {
        public override void CloseDoor()
        {
            Console.WriteLine("Close door factory");
        }
        public override void OpenDoor()
        {
            Console.WriteLine("Open door factory");
        }
        public override void CloseWindow()
        {
            Console.WriteLine("Close window factory");
        }
        public override void OpenWindow()
        {
            Console.WriteLine("Open window factory");
        }
    }
}