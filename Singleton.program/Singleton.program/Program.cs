public class Singleton
{
    private static Singleton instance;
    public string mensaje = "Hola mundo";

    private Singleton() { }

    public static Singleton ObtenerInstancia()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }
}

