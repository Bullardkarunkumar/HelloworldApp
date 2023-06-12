
namespace HelloworldApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // 7. The namespace should be logical grouping of classes with specific pattern
            //<CompanyName>.< ProductName >.< ModuleName >
            //Example: ABC.SchoolManagement.BusinessLayer ABC.SchoolManagement.DataAccessLayer ABC.SchoolManagement.WebUI

            BusinessLayer.EmployeeBusiness employeeBusiness =new BusinessLayer.EmployeeBusiness();
        }

    } 
   

}