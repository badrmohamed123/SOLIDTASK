namespace SOLIDTASK
{
    public class OrderProcessor
    {
        private readonly OrderValidator orderValidator;
        private readonly IOrderSaver[] orderSaver;
        private readonly OrderNotificationSender orderNotificationSender;

        public OrderProcessor(OrderValidator orderValidator, IOrderSaver[] orderSaver , OrderNotificationSender orderNotificationSender )
        {
            this.orderValidator = orderValidator;
            this.orderSaver = orderSaver;
            this.orderNotificationSender = orderNotificationSender;
        }
        public void process()
        {
            orderValidator.Validate();
            foreach (var item in orderSaver)
            {
                item.Save(null);
            }
            orderNotificationSender.SendNotification();
        }


    }
}

public class OrderValidator
{
    public void Validate()
    {

    }
}
public interface IOrderSaver
{
    void Save(String order);
}
public interface IOrderDeleter
{
    void Delete(int id);
}
public interface IOrderReader
{
    String Read(int id);
}



public class DbOrderSaver : IOrderSaver
{
    public void Save(string order) { }

    

    void IOrderSaver.Save(string order)
    {
        throw new NotImplementedException();
    }

    //public void SaveCach (String  order) { }
}

public class CachOrderSaver : IOrderSaver
{
    public void Save(string order)
    {
        throw new NotImplementedException();
    }
    void IOrderSaver.Save(string order)
    {
        throw new NotImplementedException();
    }
}

public class OrderNotificationSender() 
{
    public void SendNotification()
    {

    }

}
