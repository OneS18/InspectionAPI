namespace InspectionAPI
{
    public class Status
    {
        public int Id { get; set; }

        [stringLength(20)]
        public string StatusOption { get; set; } = string.Empty;
    }
}
