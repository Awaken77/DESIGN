using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_v2
{
    public class EmailSender : INotificationSender
    {
        public void SendNotification(int userId, Notification notification)
        {
            Console.WriteLine($"Sending e-mail notification, to:{userId}, Title:{notification.Title}, Body:{notification.Body}");
        }
    }
}
