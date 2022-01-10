namespace Entity
{
    public class Users
    {
        #region "Consteractor"
        public Users()
        { }
        public Users(string _User, string _Pass)
        {
            User = _User;
            Pass = _Pass;
        }
        #endregion

        #region "Property"
        public string User { get; set; }
        public string Pass { get; set; }
        #endregion

    }
}
