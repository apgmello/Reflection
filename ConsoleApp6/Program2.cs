using ConsoleApp6.Operations;
using System.Reflection;

namespace ConsoleApp6
{
    internal class Program2
    {
        static void Main2(string[] args)
        {
            var operations = new Dictionary<string, IMathOperation>();

            var types = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var type in types)
            {
                if (type.IsAssignableTo(typeof(IMathOperation)) && type.IsClass && !type.IsAbstract)
                {
                    var instance = (IMathOperation)Activator.CreateInstance(type);
                    var sign = instance.GetOperationSign();

                    operations.Add(sign, instance);
                }
            }

            Console.WriteLine("Digite o símbolo da operação:");
            var operationSign = Console.ReadLine();

            Console.WriteLine("Digite o número a:");
            var a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número b:");
            var b = double.Parse(Console.ReadLine());

            if (operations.TryGetValue(operationSign, out var mathOperation))
            {
                var result = mathOperation.Execute(a, b);
                Console.WriteLine($"O resultado da operação é: {result}");
            }
        }
    }
}