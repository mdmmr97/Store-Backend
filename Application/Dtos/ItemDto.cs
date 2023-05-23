namespace Store_Backend.Application.Dtos
{
    public class ItemDto: IDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }
        public byte[] Image { get; set; }
        public long CategoryId { get; set; }
        public long CategoryName { get; set; }
    }
}
