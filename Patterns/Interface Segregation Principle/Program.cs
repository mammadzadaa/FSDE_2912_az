using System;

namespace Interface_Segregation_Principle
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
        public string Sender { get; set; }
        public string Recipiant { get; set; }
        void Send();
    }

    interface ITextMessage : IMessage
    {
        public string Text { get; set; }
    }

    interface IVoiceMessage : IMessage
    {
        public byte[] VoiceRecording { get; set; }
    }

    interface IEmailMessage : ITextMessage
    {
        public string Subject { get; set; }
    }

    class Email : IEmailMessage
    {
        public string Subject { get; set; }
        public string Text { get; set; }
        public string Sender { get; set; }
        public string Recipiant { get; set; }

        public void Send()
        {
            Console.WriteLine("Send");
        }
    }

    class VoiceMessage : IVoiceMessage
    {
        public byte[] VoiceRecording { get; set; }
        public string Sender { get; set; }
        public string Recipiant { get; set; }

        public void Send()
        {
            Console.WriteLine("Send");
        }
    }

    class SMS : ITextMessage
    {
        public string Text { get; set; }
        public string Sender { get; set; }
        public string Recipiant { get; set; }
        public void Send()
        {
            Console.WriteLine("Send");
        }
    }

    //interface IMessage
    //{
    //    public string Text { get; set; }
    //    public string Subject { get; set; }
    //    public string Sender { get; set; }
    //    public string Recipiant { get; set; }
    //    void Send();
    //}

    //class Email : IMessage
    //{
    //    public string Text { get; set; }
    //    public string Subject { get; set; }
    //    public string Sender { get; set; }
    //    public string Recipiant { get; set; }
    //    public void Send()
    //    {
    //        Console.WriteLine("Sending Email");
    //    }
    //}

    //class SMS : IMessage
    //{
    //    public string Text { get; set; }

    //    public string Sender { get; set; }
    //    public string Recipiant { get; set; }
    //    public string Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    //    public void Send()
    //    {
    //        Console.WriteLine("Sending SMS");
    //    }
    //}
}
