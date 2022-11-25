using System;
using System.Reflection;
namespace HW7
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int i = 1;

            Assembly namesp = Assembly.Load(@"MyClassLibrary");

            Console.WriteLine("This dll has classes:");
            foreach (Type member in namesp.GetTypes())
            {
                if (member.IsClass && member.IsVisible)
                {

                    Console.WriteLine($"{i}) {member.Name}");
                    i++;
                    Console.WriteLine("______________________________________________________");

                    foreach (PropertyInfo prop in member.GetProperties())
                    {

                        Console.Write($"    {prop.PropertyType} {prop.Name} {{");
                        if (prop.CanRead) Console.Write("get;");
                        if (prop.CanWrite) Console.Write("set;");
                        Console.WriteLine("}");
                    }

                    foreach (ConstructorInfo prop in member.GetConstructors())
                    {
                        string modificator = "";

                        if (prop.IsPublic)
                            modificator += "public";
                        if (prop.IsPrivate)
                            modificator += "private";
                        if (prop.IsAssembly)
                            modificator += "internal";
                        if (prop.IsFamily)
                            modificator += "protected";
                        if (prop.IsFamilyAndAssembly)
                            modificator += "private protected";
                        if (prop.IsFamilyOrAssembly)
                            modificator += "protected internal";

                        Console.Write($"    {modificator} {member.Name} (");
                        ParameterInfo[] parameters = prop.GetParameters();
                        for (int j = 0; j < parameters.Length; j++)
                        {
                            var param = parameters[j];
                            Console.Write($"{param.ParameterType.Name} {param.Name}");
                            if (j < parameters.Length - 1)
                                Console.Write(", ");
                        }
                        Console.WriteLine(")");
                    }

                    foreach (MethodInfo meth in member.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly))
                    {
                        string modificator = "";

                        if (meth.IsPublic)
                            modificator += "public";
                        if (meth.IsPrivate)
                            modificator += "private";
                        if (meth.IsAssembly)
                            modificator += "internal";
                        if (meth.IsFamily)
                            modificator += "protected";
                        if (meth.IsFamilyAndAssembly)
                            modificator += "private protected";
                        if (meth.IsFamilyOrAssembly)
                            modificator += "protected internal";
                        if (meth.IsStatic)
                            modificator += " static";
                        if (meth.IsAbstract)
                            modificator += " abstract";
                        if (meth.IsVirtual)
                            modificator += " virtual";

                        Console.Write($"    {modificator} {meth.ReturnType} {meth.Name} (");
                        ParameterInfo[] parameters = meth.GetParameters();
                        for (int j = 0; j < parameters.Length; j++)
                        {
                            var param = parameters[j];
                            Console.Write($"{param.ParameterType.Name} {param.Name}");
                            if (j < parameters.Length - 1)
                                Console.Write(", ");
                        }
                        Console.WriteLine(")");
                    }
                    Console.WriteLine("\n______________________________________________________");
                }
            }

            Type? t = namesp.GetType("MyClassLibrary.Class1");

            if (t != null)
            {
                Object cl = Activator.CreateInstance(t, new object[] { 7, "World" });
                MethodInfo? menthod = t.GetMethod("Method1");
                menthod?.Invoke(cl, null);
                menthod = t.GetMethod("Method2");
                object? result = menthod?.Invoke(cl, new object[] { "Hello" });
                Console.WriteLine(result);
            }
        }
    }
}