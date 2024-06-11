namespace FazendaUrbana.Forms.BaseObjects
{
    public class KeyDescriptionValue<T>
    {
        public T? Enum { get; set; }
        public string? Value { get; set; }
        public string? Description { get; set; }

        public KeyDescriptionValue() { }

        public KeyDescriptionValue(T @enum, string description, string value)
        {
            Enum = @enum;
            Value = value;
            Description = description;
        }
    }
}
