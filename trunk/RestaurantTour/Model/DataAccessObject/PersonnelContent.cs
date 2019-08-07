namespace RestaurantTour.Model.DataAccessObject
{
    internal class PersonnelContent
    {
        internal string Key { get; set; }
        internal string JobNumber { get; set; }
        internal string ChineseName { get; set; }

        private string _EnglicshName = string.Empty;
        internal string EnglicshName
        {
            get { return _EnglicshName; }
            set
            {
                if (value.Length == 9 && value.IndexOf("9") == 0)
                {
                    _EnglicshName = "0" + value;
                }
                else
                {
                    _EnglicshName = value;
                }
            }
        }
        internal string CardNumber { get; set; }
        internal string Alias { get; set; }
        internal string Voice { get; set; }
        internal string TEL { get; set; }

        private string _Phone = string.Empty;
        internal string Phone
        {
            get { return _Phone; }
            set
            {
                if (value.Length == 9 && value.IndexOf("9") == 0)
                {
                    _Phone = "0" + value;
                }
                else
                {
                    _Phone = value;
                }
            }
        }
    }
}