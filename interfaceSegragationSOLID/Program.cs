using System;

namespace interfaceSegragationSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    interface IMessage
    {
        void Send();
        string ToAddress { get; set; }
        string FromAddress { get; set; }
    }

    interface ITextMessage : IMessage
    {
        string Text { get; set; }

    }
    interface IEmailMessage : ITextMessage
    {
        string Subject { get; set; }
    }

    class EmailMessage : IEmailMessage
    {
        public string Text { get; set; }
        public string ToAddress { get; set; }
        public string FromAddress { get; set; }
        public string Subject { get; set; }

        public void Send()
        {
            Console.WriteLine($"Отправка по Email сообщение: {Text}");
        }
    }
    class SmsMessage : ITextMessage
    {
        public string Text { get; set; }
        public string ToAddress { get; set; }
        public string FromAddress { get; set; }
        public void Send()
        {
            Console.WriteLine($"Отправка по SMS сообщение: {Text}");
        }
    }
}
