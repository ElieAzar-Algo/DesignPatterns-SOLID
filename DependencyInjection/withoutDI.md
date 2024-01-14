## Without using the Dependency Injection this logging project will be as below:

```
        using System;

        public class Logger
        {
            public void Log(string message)
            {
                Console.WriteLine($"Logging: {message}");
            }
        }

        public class OrderProcessor
        {
            private readonly Logger _logger;

            public OrderProcessor()
            {
                _logger = new Logger();
            }

            public void ProcessOrder(string order)
            {

                // Log the order processing
                _logger.Log($"Order processed: {order}");
            }
        }

        public class Program
        {
            public static void Main()
            {
                OrderProcessor op = new OrderProcessor();
                op.ProcessOrder("12345");
            }
        }
```