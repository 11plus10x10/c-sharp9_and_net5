namespace PacktLibrary
{
    public class Thing
    {
        // Field.
        public object Data = default(object);

        
        public string Process(object input)
        {
            // if (Data == input)
            // {
            //     return "Data and input are the same.";
            // }
            // else
            // {
            //     return "Data and input are NOT the same.";
            // }
            return Data == input ? "Data and input are the same." : "Data and input are not the same.";
        }
    }
}