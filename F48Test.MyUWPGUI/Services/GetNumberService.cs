using F48Test.MyLib.Services;

namespace F48Test.MyUWPGUI.Services
{
    public class GetNumberService : IGetNumberService
    {
        private int _number;

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public GetNumberService(int number)
        {
            Number = number;
        }


        public int GetNumber()
        {
            return _number;
        }
    }
}
