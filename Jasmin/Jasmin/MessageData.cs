namespace Jasmin
{
    internal class MessageData
    {
<<<<<<< HEAD
        public string Message { get; set; }
        public string Name { get; set; }
        public bool Shoutout { get; set; }
=======
        public long Id { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }
        public bool Shoutout { get; set; }
        public bool Equals(MessageData obj)
        {
            if(this.Message==obj.Message && this.Id==obj.Id && this.Name==obj.Name && this.Shoutout==obj.Shoutout)
            return true;
            return false;
        }
>>>>>>> upstream/master
    }
}