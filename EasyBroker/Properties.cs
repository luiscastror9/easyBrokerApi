namespace EasyBroker
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Content
    {
        public string public_id { get; set; }
        public string title { get; set; }
        public string title_image_full { get; set; }
        public string title_image_thumb { get; set; }
        public string location { get; set; }
        public List<Operation> operations { get; set; }
        public int? bedrooms { get; set; }
        public int? bathrooms { get; set; }
        public int? parking_spaces { get; set; }
        public string property_type { get; set; }
        public double lot_size { get; set; }
        public double construction_size { get; set; }
        public DateTime updated_at { get; set; }
        public string agent { get; set; }
        public bool show_prices { get; set; }
    }

    public class Operation
    {
        public string type { get; set; }
        public double amount { get; set; }
        public string currency { get; set; }
        public string formatted_amount { get; set; }
        public string unit { get; set; }
    }

    public class Pagination
    {
        public int limit { get; set; }
        public int page { get; set; }
        public int total { get; set; }
        public string next_page { get; set; }
    }

    public class Properties
    {
        public Pagination pagination { get; set; }
        public List<Content> content { get; set; }
    }

   
}