namespace HairSalon.Models
{
  public class CategoryItem
    {       
        public int StylistClientId { get; set; }
        public int ClientId { get; set; }
        public int StylistId { get; set; }
        public virtual Client Client { get; set; }
        public virtual Stylist Stylist { get; set; }
    }
}