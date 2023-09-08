namespace Brayns.Common
{
    public class NoSeriesLine : Table<NoSeriesLine>
    {
        public Fields.Code NoSeriesCode { get; } = new("Code", Label("Code"), 10);
        public Fields.Integer LineNo { get; } = new("Line no.", Label("Line no."));
        public Fields.Date StartingDate { get; } = new("Starting date", Label("Starting date"));
        public Fields.Code LastNo { get; } = new("Last no.", Label("Last no."), 20);

        public NoSeriesLine()
        {
            UnitName = "No. series line";
            UnitCaption = Label("No. series line");
            TablePrimaryKey.Add(NoSeriesCode, LineNo);

            AddRelation<NoSeries>(NoSeriesCode);
        }
    }
}
