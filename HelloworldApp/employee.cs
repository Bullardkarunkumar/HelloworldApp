using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloworldApp
{
    /// <summary>
    /// 1. Use Pascal conventions for defining class name
    /// </summary>
    /// 8. File Name - Filename should match with class name i.e. Pascal name

    public class employee:IEmployee
    {      
        private readonly IEmployee empService = new employee();
        private UserRole usrRole;
        private UserGroup usrGrp;
        //New
        private IEmployee _employeeService = null;
        private UserRole userRole;
        private UserGroup userGroup;

        /* 6. Boolean variables - Prefix Boolean variables with “is” or some */
        private bool accepted;
        private bool finished;
        private bool isFinished;
        //New
        private bool _isAccepted;
        private bool _isFinished;


/// <summary>
///
/// </summary>
/// <param name="firstName"></param>
/// <param name="secondName"></param>
/// <returns></returns>
        public string addNumbers(string firstName, string secondName)
        {
            /*
           4. Local Variables - (NOT WORKING) * Use Hungarian Meaningful, descriptive words to name variables. Donot use abbreviations
             * */
            string fName = firstName;
            string name = secondName;
            string _firstName = secondName;

            return fName + " " + secondName;
        }

        public static string AddNumbers1(string firstName, string secondName, string firstName1, string secondName1, string firstName2, string secondName2, string firstName3, string secondName3, string secondName4, string secondName5)
        {
            /*
           4. Local Variables - (NOT WORKING) * Use Hungarian Meaningful, descriptive words to name variables. Donot use abbreviations
             * */
            string fName = firstName;
            string name = secondName;
            string _firstName = secondName;

            return firstName + " " + secondName;
        }

        /*         */
        public void getData()
        {
            
        }

        public int sendData()
        {
           
            return 10+30;
        }
    }
}
