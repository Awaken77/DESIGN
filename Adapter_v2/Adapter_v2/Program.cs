using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            INotificationSender notificationSender = new SmsSenderAdapter();
            notificationSender.SendNotification(1, new Notification() { Title = "Test", Body = "Body" });
        }
    }
}
