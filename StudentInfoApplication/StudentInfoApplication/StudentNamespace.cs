namespace StudentNamespace
{
    public class StudentInfo
    {
        private string studentID;
        private string lastName;
        private string firstName;

        public StudentInfo()
        {
            this.studentID = "";
            this.lastName = "";
            this.firstName = "";
        }

        public StudentInfo(string studentID, string lastName, string firstName)
        {
            this.studentID = studentID;
            this.lastName = lastName;
            this.firstName = firstName;
        }

        public string StudentID
        {
            get 
            {
                return this.studentID; 
            }
            set 
            { 
                this.studentID = value;
            }
        }

        public string LastName
        {
            get 
            { 
                return this.lastName; 
            }
            set 
            { 
                this.lastName = value; 
            }
        }

        public string FirstName
        {
            get 
            {
                return this.firstName; 
            }
            set 
            { 
                this.firstName = value; 
            }
        }
    }
}
