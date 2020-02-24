namespace System
{
    public static class StringExtensions
    {
        public static string cut(this string thisObj)
        {
            if (thisObj.Length > 10)
            {
                return thisObj.Substring(0, 10) + "...";
            }

            return thisObj;
        }
    }
}