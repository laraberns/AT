//using System;

//namespace AT.Delegates
//{
//    public class MulticastDelegates
//    {
//        public void LogToConsole(string message)
//        {
//            Console.WriteLine($"[Console] {message}");
//        }

//        public void LogToFile(string message)
//        {
//            Console.WriteLine($"[File] {message}");
//        }

//        public void LogToDatabase(string message)
//        {
//            Console.WriteLine($"[Database] {message}");
//        }

//        static void Main(string[] args)
//        {
//            MulticastDelegates logger = new MulticastDelegates();

//            Action<string> logDelegate = null;
//            logDelegate += logger.LogToConsole;
//            logDelegate += logger.LogToFile;
//            logDelegate += logger.LogToDatabase;

//            string mensagem = "Reserva criada com sucesso para o cliente Lara!";

//            logDelegate?.Invoke(mensagem);
//        }
//    }
//}
