/*
    This class is made for reading a file and storing its contents into "database"
    You can choose if the database will be formatted or not
    This class relies on StrModifier.cs class, which is responsible for formatting the records 
*/

namespace Task9
{
    class FileRead
    {
        private string _path;
        private int _dataLength;
        private char _divider;
        private List<string[]> _database;

        public string Path
        {
            get { return _path; }
        }

        public List<string[]> Database
        {
            get { return this._database; }
        }

        public FileRead(string path, int dataLength, char divider)
        {
            this._path = path;
            this._dataLength = dataLength;
            this._divider = divider;
            this._database = new List<string[]>(ReadFile(path, dataLength, divider)); //Creates database
        }

        //Static methods
        static List<string[]> ReadFile(string path, int dataLength, char divider) //Method for reading a .csv file
        {
            //Variables
            List<string[]> record = new List<string[]>(); //For storing and returning values  
            string[] readLine; //One line of data

            //Initializing StreamReader class
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null) //Reading one line
                {
                    readLine = s.Split(divider); //Splitting the string by the division character
                    if (readLine.Length == dataLength)
                    {
                        record.Add(readLine); //Add to database
                    }
                }
                return record;
            }
        }
    }
}
