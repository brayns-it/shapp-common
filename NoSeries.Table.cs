namespace Brayns.Common
{
    public class NoSeries : Table<NoSeries>
    {
        public Fields.Code Code { get; } = new("Code", Label("Code"), 10);
        public Fields.Text Description { get; } = new("Description", Label("Description"), 30);

        public NoSeries()
        {
            UnitName = "No. series";
            UnitCaption = Label("No. series");
            TablePrimaryKey.Add(Code);
        }
    }
}
