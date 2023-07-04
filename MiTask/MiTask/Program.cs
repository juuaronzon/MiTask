class Program
{
    static void Main()
    {
        Thread thread1 = new Thread(Tarea1);
        Thread thread2 = new Thread(Tarea2);
        Thread thread3 = new Thread(Tarea3);

        thread1.Start();
        thread2.Start();
        thread3.Start();
    }

    static void Tarea1()
    {
        for (int vuelta = 1; vuelta <= 4; vuelta++)
        {
            Console.WriteLine("Tarea 1 - Tareas realizadas: " + vuelta);
        }
    }

    static void Tarea2()
    {
        for (int vuelta = 1; vuelta <= 5; vuelta++)
        {
            Console.WriteLine("Tarea 2 - Tarea realizada con exito! " + vuelta);
        }
    }

    static void Tarea3()
    {
        for (int vuelta = 1; vuelta <= 3; vuelta++)
        {
            Console.WriteLine("Tarea 3 -  Muchas tareas al mismo tiempo, " + vuelta);
        }
    }
}