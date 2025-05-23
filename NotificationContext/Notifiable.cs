namespace SAP.NotificationContext
{
    public abstract class Notifiable
    {
        public List<Notification> Notifications { get; set; }
        public bool isInvalid => Notifications.Any();
        public Notifiable()
        {
            Notifications = new List<Notification>();
        }
        public void AddNotification(Notification notification)
        {
            Notifications.Add(notification);
        }
        public void AddNotifications(IEnumerable<Notification> notifications)
        {
            Notifications.AddRange(notifications);
        }
    }
}