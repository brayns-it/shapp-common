namespace Brayns.Common
{
    public class NoSeriesManagement : Codeunit
    {
        public string GetNo(string code, DateTime? date = null)
        {
            if (date == null)
                date = DateTime.Now;

            var serline = new NoSeriesLine();
            serline.NoSeriesCode.SetRange(code);
            serline.StartingDate.SetFilter("<={0}", date);
            if (!serline.FindLast())
                throw serline.ErrorNotFound();

            serline.LastNo.Test();
            serline.LastNo.Value = Functions.Increment(serline.LastNo.Value);
            serline.Modify();

            return serline.LastNo.Value;
        }
    }
}
