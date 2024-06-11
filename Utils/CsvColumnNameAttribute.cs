namespace FazendaUrbana.Forms.Utils
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CsvColumnNameAttribute : Attribute
    {
        public string Name { get; }

        public CsvColumnNameAttribute(string name)
        {
            Name = name;
        }
    }
}
