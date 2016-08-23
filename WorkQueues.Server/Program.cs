﻿using System;

namespace WorkQueues.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting RabbitMQ queue processor");
            Console.WriteLine();
            Console.WriteLine();

            var queueProcessor = new RabbitConsumer();
            queueProcessor.CreateQueue();
            queueProcessor.Start();
            Console.ReadLine();
        }
    }
}