namespace ConsoleApp.Classes.Abstract;

internal class UseCase1
{
    public static void TestUseCase1()
    {
        Entity1 entity = new();
        entity.Id = 123;
        entity.Guid = Guid.NewGuid();
    }
}
