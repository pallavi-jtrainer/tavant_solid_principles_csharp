using Solid_EmployeeManagmentSystem.Controllers;
using Solid_EmployeeManagmentSystem.Interfaces;
using Solid_EmployeeManagmentSystem.Services;

public class Program {

    static void Main() {
        IEmployeeService service = new EmployeeService();
        var controller = new EmployeeController(service);

        controller.Run();
    }
}