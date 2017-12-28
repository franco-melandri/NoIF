namespace OnlyOne
{
    public class Instance
    {
        public Instance (string message) {
            this.message = message;
        }

        public string message {get; private set;}    
    }
}
