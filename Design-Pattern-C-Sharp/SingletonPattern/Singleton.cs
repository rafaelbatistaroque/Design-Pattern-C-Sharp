namespace Design_Pattern_C_Sharp.SingletonPattern
{
    public sealed class Singleton
    {
        private static Singleton _intancia = null;

        public static Singleton Instancia => ObterInstancia();

        private static Singleton ObterInstancia()
        {
            return _intancia ??= new Singleton();
        }
    }
}
