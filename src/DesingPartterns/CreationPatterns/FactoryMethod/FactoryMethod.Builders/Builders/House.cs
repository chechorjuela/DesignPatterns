using FactoryMethod.Builders.Builders.Base;

namespace FactoryMethod.Builders.Builders
{
    public class House : Building
    {
        public override void CloseDoor()
        {
            Console.WriteLine("Close door House");
        }
        public override void OpenDoor()
        {
            Console.WriteLine("Open door House");
        }
        public override void CloseWindow()
        {
            Console.WriteLine("Close window House");
        }
        public override void OpenWindow()
        {
            Console.WriteLine("Open window House");
        }
    }
}