namespace OOPPrinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Engineer engineer = new Engineer("Bukenya Raihan", "TO", 25, 100000);
            Controller controller = new Controller("Buyinza Mathius", 30, 150000, "ATMO");

            engineer.DoWork();
            Console.WriteLine("-------------------------------------");

            engineer.DoAppraisal();

            Console.WriteLine("#########################################");
            Console.WriteLine();

            controller.DoWork();
            Console.WriteLine("-------------------------------------");

            controller.DoAppraisal();
            Console.WriteLine("-------------------------------------");

            controller.TakeLeave();


            var overTime = controller.CalculateOvertime(8);
            var aisOfficer = new AISOfficer("KIzza", 35, 10000, "AIMO");



            List<int> numbers = new List<int>() { 1, 2, 3, };
            List<Employee> employees = new List<Employee>();

            List<Controller> controllers = new List<Controller>();

            List<IOvertime> overtimeWorkers = new List<IOvertime>();
            overtimeWorkers.Add(controller);
            overtimeWorkers.Add(aisOfficer);

            
            foreach(var worker in overtimeWorkers)
            {
                worker.CalculateOvertime(10);
            }

            Console.WriteLine(controller is IOvertime);
            Console.WriteLine(aisOfficer is IOvertime);
            Console.WriteLine(engineer is IOvertime);


        }
    }
}