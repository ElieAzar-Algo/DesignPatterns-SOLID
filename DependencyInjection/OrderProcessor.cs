namespace DependencyInjection;

class OrderProcessor
{
    private readonly ILogger _logger;
    public OrderProcessor(ILogger logger)
    {
        this._logger = logger;
    }

    public void ProccessOrder(string orderId)
    {
        this._logger.Log($"Processing Order Number {orderId}");
    }
}