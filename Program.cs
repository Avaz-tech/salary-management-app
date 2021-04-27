// This is  c#  programm for Salary management 
//Developed  BY: Ravshanov Avazbek
//ID: 18012741
//Student of Computer Science and Engineering
//Date: 2020.06.19
using System;

//Base Class

public class SMSystem
{

    // Declaration of array of string & array of int  to store employe information and salary details
    public static string[,] employee = new string[100, 5];
    public static int[,] payment = new int[100, 7];

    public static int c = 0, c2 = 0;

    public static string[] department = new string[15];




    //function for printing Welcome 
    public void output()
    {

        Console.WriteLine("                 |||||  Welcome to salary management system!  ||||||\n");


    }

    // function for creating Department
    public void Department()
    {


        Console.WriteLine(" Create a Department :");



        department[c2] = Console.ReadLine();

        c2++;

    }
    //function for printing all departments available
    public void Deplist()
    {


        Console.WriteLine("       Departments !      ");
        //using for loop to print Departments
        for (int i = 0; i < c2; i++)

        {

            Console.Write($"     {i + 1}.");

            Console.WriteLine(department[i]);

        }

    }



    // for adding employee forr departments
    public void addEmployee()
    {

        Console.WriteLine(" Enter Employee information :");

        c++;

        int j = c - 1;



        for (int k = 0; k < 5; k++)

        {

            if (k == 0)
            {
                Console.Write("Name: ");
                employee[j, k] = Console.ReadLine();
            }
            if (k == 1)
            {
                Console.Write("Surname: ");
                employee[j, k] = Console.ReadLine();
            }
            if (k == 2)
            {
                Console.Write("Birth date: ");
                employee[j, k] = Console.ReadLine();
            }
            if (k == 3)
            {
                Console.Write("Address: ");
                employee[j, k] = Console.ReadLine();
            }
            if (k == 4)
            {
                Console.Write("ID: ");
                employee[j, k] = Console.ReadLine();
            }

        }



    }
    //function for printing all employees using nested for loop
    public void emplolist()
    {

        Console.WriteLine(" |    Name    |      Surname      |      Birth      |                     Address                    |     ID       |\n");


        for (int j = 0; j < c; j++)

        {
            Console.Write($"{j + 1}.  ");
            for (int k = 0; k < 5; k++)
            {
                Console.Write(employee[j, k]);

                Console.Write("             ");

            }
            Console.WriteLine("\n");

        }

    }

    //function for calculating deducted money
    public void Deduction(int d)
    {
        Console.WriteLine("Enter deduction amount: ");
        int ded = 0;
        ded = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Deducted:  {ded}");
        payment[d, 0] = ded;
        payment[d, 6] -= ded;

    }
    //function for calculating extrday work payment
    public void OverloadPay(int o)
    {
        Console.WriteLine("Enter extrday activities : ");
        int extrday = 0;
        int extrpay = 0;
        extrday = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Extrday work:  {extrday}  days");
        extrpay = (payment[o, 5] / 30) * extrday;
        payment[o, 1] = extrpay;
        Console.WriteLine($"Extrday work:  {extrpay}  ");
        payment[o, 6] += extrpay;


    }
    //function for calculating payment which is given in Advance
    public void AdvancePay(int a)
    {
        Console.WriteLine("Enter the payment that is given in Advance :  ");
        int inadpay = 0;
        //taking user input for inadvance payment
        inadpay = Convert.ToInt32(Console.ReadLine());
        payment[a, 2] = inadpay;
        Console.WriteLine("The payment that is given in Advance :  ");
        payment[a, 6] -= inadpay;


    }
    //function for calculating payment for transport
    public void Conveyance(int c)
    {
        Console.WriteLine("Enter the payment that is given for transport :  ");
        int trnspay = 0;
        trnspay = Convert.ToInt32(Console.ReadLine());
        payment[c, 3] = trnspay;
        Console.WriteLine("The payment that is given for transport:  ");
        payment[c, 6] += trnspay;



    }
    //function for calculating given bonus for Festivals 
    public void Festival(int f)
    {
        Console.WriteLine("Enter the bonus that is given for Festivals :  ");
        int bonus = 0;
        bonus = Convert.ToInt32(Console.ReadLine());
        payment[f, 4] = bonus;
        Console.WriteLine("Bonus that is given for holidays or festivals:  ");
        payment[f, 6] += bonus;

    }
    //function for assigning Actual Salary for Employee
    public void Salary(int s)
    {
        Console.WriteLine("Enter the Salary that is given for one month work :  ");
        int sal = 0;
        sal = Convert.ToInt32(Console.ReadLine());
        //assigning Actual Salary
        payment[s, 5] = sal;
        //assigning salary which should be paid at the end of the month
        payment[s, 6] = sal;


    }
    public void payslip(int p)
    {
        Console.WriteLine($"This month's payslip inf:\n");
        Console.WriteLine($"Actual Salary for a month:{payment[p, 5]}");
        Console.WriteLine($"Deduction: {payment[p, 0]}");
        Console.WriteLine($"Extrday payment: {payment[p, 1]}");
        Console.WriteLine($"Advance payment: {payment[p, 2]}");
        Console.WriteLine($"Transport payment: {payment[p, 3]}");
        Console.WriteLine($"Festival payment: {payment[p, 4]}");
        // Showing Salary including all Deductions and Extra payments
        Console.WriteLine($"Salary  for this month: {payment[p, 6]}");
    }

}





// Driver class
public class driver
{



    public static void Main(string[] args)
    {

        //Creating objects of class 

        SMSystem t = new SMSystem();

        t.output();




        Console.WriteLine("           ######-OPTIONS-######:");

        //using while loop for  executing the code continiously until it is stopped by user
        while (true)
        {

            Console.WriteLine("           1. Add Department:\n           2. Departments:\n");


            Console.WriteLine("Enter the option which you want:");
            //taking user input for switch loop
            char v1 = Convert.ToChar(Console.ReadLine());

            //nested switch condition for selecting option you want 
            //it checks which option you choose and goes to next switch accordingly
            switch (v1)
            {



                case '1':
                    //calling function of base class using object of that dclass
                    t.Department();
                    break;
                case '2':
                    t.Deplist();
                    Console.WriteLine("Choose the number of Department that you want to modify: or Press 'b' to go back!");
                    SMSystem t2 = new SMSystem();

                    char v2 = Convert.ToChar(Console.ReadLine());
                    //secodn switch condition for creating next option menu for employee details 
                    switch (v2)
                    {
                        case '1':
                            while (true)
                            {
                                Console.WriteLine("\t1. Add Employee:\n\t2. Employee list:\n\tb.BACK\n");
                                Console.WriteLine("Choose the option: or Press 'b' to go back!");
                                char v3 = Convert.ToChar(Console.ReadLine());
                                //3rd switch for checking whether you want to add new employee or to see employee list and modify it accordingly
                                switch (v3)
                                {
                                    case '1':
                                        t2.addEmployee();
                                        break;
                                    case '2':
                                        t2.emplolist();
                                        Console.WriteLine(" Select the Employee number whose salary you want to modify: or Press 'b' to go back!");
                                        char v5 = Convert.ToChar(Console.ReadLine());
                                        while (true)
                                        {
                                            Console.WriteLine("\t1.Salary:\n\t2.Deduction:\n\t3.OverloadPay:\n\t4.AdvancePay:\n\t5.Conveyance:\n\t6.Festival:\n\t7.Payslipinfo\n\tb.BACK\n");
                                            Console.WriteLine("Choose the option: or Press 'b' to go back!");
                                            char v4 = Convert.ToChar(Console.ReadLine());
                                            //4th switch for creating Salary management menu option and modify them accordingly
                                            switch (v4)
                                            {
                                                case '1':
                                                    t2.Salary(0);
                                                    break;
                                                case '2':
                                                    t2.Deduction(0);
                                                    break;
                                                case '3':
                                                    t2.OverloadPay(0);
                                                    break;
                                                case '4':
                                                    t2.AdvancePay(0);
                                                    break;
                                                case '5':
                                                    t2.Conveyance(0);
                                                    break;
                                                case '6':
                                                    t2.Festival(0);
                                                    break;
                                                case '7':
                                                    t2.payslip(0);
                                                    break;
                                                case 'b':
                                                    //using goto to go back to previous menu
                                                    goto a;
                                                    break;

                                                default:
                                                    Console.WriteLine("Unknown option!");
                                                    break;
                                            }
                                        }
                                    a:
                                        break;
                                    case 'b':
                                        goto m;
                                }
                            }
                        m:
                            break;
                        case '2':
                            while (true)
                            {
                                Console.WriteLine("\t1. Add Employee:\n\t2. Employee list:\n\tb.BACK\n");
                                Console.WriteLine("Choose the option: or Press 'b' to go back!");
                                char v31 = Convert.ToChar(Console.ReadLine());
                                switch (v31)
                                {
                                    case '1':
                                        t2.addEmployee();
                                        break;
                                    case '2':
                                        t2.emplolist();
                                        Console.WriteLine(" Select the Employee number whose salary you want to modify: or Press 'b' to go back!");
                                        char v51 = Convert.ToChar(Console.ReadLine());
                                        while (true)
                                        {
                                            Console.WriteLine("\t1.Salary:\n\t2.Deduction:\n\t3.OverloadPay:\n\t4.AdvancePay:\n\t5.Conveyance:\n\t6.Festival:\n\t7.Payslipinfo\n\tb.BACK\n");
                                            Console.WriteLine("Choose the option: or Press 'b' to go back!");
                                            char v41 = Convert.ToChar(Console.ReadLine());
                                            switch (v41)
                                            {
                                                case '1':
                                                    t2.Salary(1);
                                                    break;
                                                case '2':
                                                    t2.Deduction(1);
                                                    break;
                                                case '3':
                                                    t2.OverloadPay(1);
                                                    break;
                                                case '4':
                                                    t2.AdvancePay(1);
                                                    break;
                                                case '5':
                                                    t2.Conveyance(1);
                                                    break;
                                                case '6':
                                                    t2.Festival(1);
                                                    break;
                                                case '7':
                                                    t2.payslip(1);
                                                    break;
                                                case 'b':
                                                    goto b;
                                                    break;

                                                default:
                                                    Console.WriteLine("Unknown option!");
                                                    break;
                                            }
                                        }
                                    b:
                                        break;
                                    case 'b':
                                        goto n;
                                }
                            }
                        n:
                            break;
                        case '3':
                            while (true)
                            {
                                Console.WriteLine("\t1. Add Employee:\n\t2. Employee list:\n\tb.BACK\n");
                                Console.WriteLine("Choose the option: or Press 'b' to go back!");
                                char v32 = Convert.ToChar(Console.ReadLine());
                                switch (v32)
                                {
                                    case '1':
                                        t2.addEmployee();
                                        break;
                                    case '2':
                                        t2.emplolist();
                                        Console.WriteLine(" Select the Employee number whose salary you want to modify: or Press 'b' to go back!");
                                        char v52 = Convert.ToChar(Console.ReadLine());
                                        while (true)
                                        {
                                            Console.WriteLine("\t1.Salary:\n\t2.Deduction:\n\t3.OverloadPay:\n\t4.AdvancePay:\n\t5.Conveyance:\n\t6.Festival:\n\t7.Payslipinfo\n\tb.BACK\n");
                                            Console.WriteLine("Choose the option: or Press 'b' to go back!");
                                            char v42 = Convert.ToChar(Console.ReadLine());
                                            switch (v42)
                                            {
                                                case '1':
                                                    t2.Salary(2);
                                                    break;
                                                case '2':
                                                    t2.Deduction(2);
                                                    break;
                                                case '3':
                                                    t2.OverloadPay(2);
                                                    break;
                                                case '4':
                                                    t2.AdvancePay(2);
                                                    break;
                                                case '5':
                                                    t2.Conveyance(2);
                                                    break;
                                                case '6':
                                                    t2.Festival(2);
                                                    break;
                                                case '7':
                                                    t2.payslip(2);
                                                    break;
                                                case 'b':
                                                    goto c;
                                                    break;

                                                default:
                                                    Console.WriteLine("Unknown option!");
                                                    break;
                                            }
                                        }
                                    c:
                                        break;
                                    case 'b':
                                        goto o;
                                }
                            }
                        o:
                            break;
                        case '4':
                            while (true)
                            {
                                Console.WriteLine("\t1. Add Employee:\n\t2. Employee list:\n\tb.BACK\n");
                                Console.WriteLine("Choose the option: or Press 'b' to go back!");
                                char v33 = Convert.ToChar(Console.ReadLine());
                                switch (v33)
                                {
                                    case '1':
                                        t2.addEmployee();
                                        break;
                                    case '2':
                                        t2.emplolist();
                                        Console.WriteLine(" Select the Employee number whose salary you want to modify: or Press 'b' to go back!");
                                        char v53 = Convert.ToChar(Console.ReadLine());
                                        while (true)
                                        {
                                            Console.WriteLine("\t1.Salary:\n\t2.Deduction:\n\t3.OverloadPay:\n\t4.AdvancePay:\n\t5.Conveyance:\n\t6.Festival:\n\t7.Payslipinfo\n\tb.BACK\n");
                                            Console.WriteLine("Choose the option: or Press 'b' to go back!");
                                            char v43 = Convert.ToChar(Console.ReadLine());
                                            switch (v43)
                                            {
                                                case '1':
                                                    t2.Salary(3);
                                                    break;
                                                case '2':
                                                    t2.Deduction(3);
                                                    break;
                                                case '3':
                                                    t2.OverloadPay(3);
                                                    break;
                                                case '4':
                                                    t2.AdvancePay(3);
                                                    break;
                                                case '5':
                                                    t2.Conveyance(3);
                                                    break;
                                                case '6':
                                                    t2.Festival(3);
                                                    break;
                                                case '7':
                                                    t2.payslip(3);
                                                    break;
                                                case 'b':
                                                    goto d;
                                                    break;

                                                default:
                                                    Console.WriteLine("Unknown option!");
                                                    break;
                                            }
                                        }
                                    d:
                                        break;
                                    case 'b':
                                        goto p;
                                }
                            }
                        p:
                            break;
                        case '5':
                            while (true)
                            {
                                Console.WriteLine("\t1. Add Employee:\n\t2. Employee list:\n\tb.BACK\n");
                                Console.WriteLine("Choose the option: or Press 'b' to go back!");
                                char v34 = Convert.ToChar(Console.ReadLine());
                                switch (v34)
                                {
                                    case '1':
                                        t2.addEmployee();
                                        break;
                                    case '2':
                                        t2.emplolist();
                                        Console.WriteLine(" Select the Employee number whose salary you want to modify: or Press 'b' to go back!");
                                        char v54 = Convert.ToChar(Console.ReadLine());
                                        while (true)
                                        {
                                            Console.WriteLine("\t1.Salary:\n\t2.Deduction:\n\t3.OverloadPay:\n\t4.AdvancePay:\n\t5.Conveyance:\n\t6.Festival:\n\t7.Payslipinfo\n\tb.BACK\n");
                                            Console.WriteLine("Choose the option: or Press 'b' to go back!");
                                            char v44 = Convert.ToChar(Console.ReadLine());
                                            switch (v44)
                                            {
                                                case '1':
                                                    t2.Salary(4);
                                                    break;
                                                case '2':
                                                    t2.Deduction(4);
                                                    break;
                                                case '3':
                                                    t2.OverloadPay(4);
                                                    break;
                                                case '4':
                                                    t2.AdvancePay(4);
                                                    break;
                                                case '5':
                                                    t2.Conveyance(4);
                                                    break;
                                                case '6':
                                                    t2.Festival(4);
                                                    break;
                                                case '7':
                                                    t2.payslip(4);
                                                    break;
                                                case 'b':
                                                    goto e;
                                                    break;

                                                default:
                                                    Console.WriteLine("Unknown option!");
                                                    break;
                                            }
                                        }
                                    e:
                                        break;
                                    case 'b':
                                        goto r;
                                }
                            }
                        r:
                            break;
                        case '6':
                            while (true)
                            {
                                Console.WriteLine("\t1. Add Employee:\n\t2. Employee list:\n\tb.BACK\n");
                                Console.WriteLine("Choose the option: or Press 'b' to go back!");
                                char v35 = Convert.ToChar(Console.ReadLine());
                                switch (v35)
                                {
                                    case '1':
                                        t2.addEmployee();
                                        break;
                                    case '2':
                                        t2.emplolist();
                                        Console.WriteLine(" Select the Employee number whose salary you want to modify: or Press 'b' to go back!");
                                        char v55 = Convert.ToChar(Console.ReadLine());
                                        while (true)
                                        {
                                            Console.WriteLine("\t1.Salary:\n\t2.Deduction:\n\t3.OverloadPay:\n\t4.AdvancePay:\n\t5.Conveyance:\n\t6.Festival:\n\t7.Payslipinfo\n\tb.BACK\n");
                                            Console.WriteLine("Choose the option: or Press 'b' to go back!");
                                            char v45 = Convert.ToChar(Console.ReadLine());
                                            switch (v45)
                                            {
                                                case '1':
                                                    t2.Salary(5);
                                                    break;
                                                case '2':
                                                    t2.Deduction(5);
                                                    break;
                                                case '3':
                                                    t2.OverloadPay(5);
                                                    break;
                                                case '4':
                                                    t2.AdvancePay(5);
                                                    break;
                                                case '5':
                                                    t2.Conveyance(5);
                                                    break;
                                                case '6':
                                                    t2.Festival(5);
                                                    break;
                                                case '7':
                                                    t2.payslip(5);
                                                    break;
                                                case 'b':
                                                    goto f;
                                                    break;

                                                default:
                                                    Console.WriteLine("Unknown option!");
                                                    break;
                                            }
                                        }
                                    f:
                                        break;
                                    case 'b':
                                        goto s;
                                }
                            }
                        s:
                            break;
                        case '7':
                            while (true)
                            {
                                Console.WriteLine("\t1. Add Employee:\n\t2. Employee list:\n\tb.BACK\n");
                                Console.WriteLine("Choose the option: or Press 'b' to go back!");
                                char v36 = Convert.ToChar(Console.ReadLine());
                                switch (v36)
                                {
                                    case '1':
                                        t2.addEmployee();
                                        break;
                                    case '2':
                                        t2.emplolist();
                                        Console.WriteLine(" Select the Employee number whose salary you want to modify: or Press 'b' to go back!");
                                        char v56 = Convert.ToChar(Console.ReadLine());
                                        while (true)
                                        {
                                            Console.WriteLine("\t1.Salary:\n\t2.Deduction:\n\t3.OverloadPay:\n\t4.AdvancePay:\n\t5.Conveyance:\n\t6.Festival:\n\t7.Payslipinfo\n\tb.BACK\n");
                                            Console.WriteLine("Choose the option: or Press 'b' to go back!");
                                            char v46 = Convert.ToChar(Console.ReadLine());
                                            switch (v46)
                                            {
                                                case '1':
                                                    t2.Salary(6);
                                                    break;
                                                case '2':
                                                    t2.Deduction(6);
                                                    break;
                                                case '3':
                                                    t2.OverloadPay(6);
                                                    break;
                                                case '4':
                                                    t2.AdvancePay(6);
                                                    break;
                                                case '5':
                                                    t2.Conveyance(6);
                                                    break;
                                                case '6':
                                                    t2.Festival(6);
                                                    break;
                                                case '7':
                                                    t2.payslip(6);
                                                    break;
                                                case 'b':
                                                    goto g;
                                                    break;

                                                default:
                                                    Console.WriteLine("Unknown option!");
                                                    break;
                                            }
                                        }
                                    g:
                                        break;
                                    case 'b':
                                        goto u;
                                }
                            }
                        u:
                            break;
                        case '8':
                            while (true)
                            {
                                Console.WriteLine("\t1. Add Employee:\n\t2. Employee list:\n\tb.BACK\n");
                                Console.WriteLine("Choose the option: or Press 'b' to go back!");
                                char v37 = Convert.ToChar(Console.ReadLine());
                                switch (v37)
                                {
                                    case '1':
                                        t2.addEmployee();
                                        break;
                                    case '2':
                                        t2.emplolist();
                                        Console.WriteLine(" Select the Employee number whose salary you want to modify: or Press 'b' to go back!");
                                        char v57 = Convert.ToChar(Console.ReadLine());
                                        while (true)
                                        {
                                            Console.WriteLine("\t1.Salary:\n\t2.Deduction:\n\t3.OverloadPay:\n\t4.AdvancePay:\n\t5.Conveyance:\n\t6.Festival:\n\t7.Payslipinfo\n\tb.BACK\n");
                                            Console.WriteLine("Choose the option: or Press 'b' to go back!");
                                            char v47 = Convert.ToChar(Console.ReadLine());
                                            switch (v47)
                                            {
                                                case '1':
                                                    t2.Salary(7);
                                                    break;
                                                case '2':
                                                    t2.Deduction(7);
                                                    break;
                                                case '3':
                                                    t2.OverloadPay(7);
                                                    break;
                                                case '4':
                                                    t2.AdvancePay(7);
                                                    break;
                                                case '5':
                                                    t2.Conveyance(7);
                                                    break;
                                                case '6':
                                                    t2.Festival(7);
                                                    break;
                                                case '7':
                                                    t2.payslip(7);
                                                    break;
                                                case 'b':
                                                    goto l;
                                                    break;

                                                default:
                                                    Console.WriteLine("Unknown option!");
                                                    break;
                                            }
                                        }
                                    l:
                                        break;
                                    case 'b':
                                        goto v;
                                }
                            }
                        v:
                            break;
                        case '9':
                            while (true)
                            {
                                Console.WriteLine("\t1. Add Employee:\n\t2. Employee list:\n\tb.BACK\n");
                                Console.WriteLine("Choose the option: or Press 'b' to go back!");
                                char v38 = Convert.ToChar(Console.ReadLine());
                                switch (v38)
                                {
                                    case '1':
                                        t2.addEmployee();
                                        break;
                                    case '2':
                                        t2.emplolist();
                                        Console.WriteLine(" Select the Employee number whose salary you want to modify: or Press 'b' to go back!");
                                        char v58 = Convert.ToChar(Console.ReadLine());
                                        while (true)
                                        {
                                            Console.WriteLine("\t1.Salary:\n\t2.Deduction:\n\t3.OverloadPay:\n\t4.AdvancePay:\n\t5.Conveyance:\n\t6.Festival:\n\t7.Payslipinfo\n\tb.BACK\n");
                                            Console.WriteLine("Choose the option: or Press 'b' to go back!");
                                            char v48 = Convert.ToChar(Console.ReadLine());
                                            switch (v48)
                                            {
                                                case '1':
                                                    t2.Salary(8);
                                                    break;
                                                case '2':
                                                    t2.Deduction(8);
                                                    break;
                                                case '3':
                                                    t2.OverloadPay(8);
                                                    break;
                                                case '4':
                                                    t2.AdvancePay(8);
                                                    break;
                                                case '5':
                                                    t2.Conveyance(8);
                                                    break;
                                                case '6':
                                                    t2.Festival(8);
                                                    break;
                                                case '7':
                                                    t2.payslip(8);
                                                    break;
                                                case 'b':
                                                    goto h;
                                                    break;

                                                default:
                                                    Console.WriteLine("Unknown option!");
                                                    break;
                                            }
                                        }
                                    h:
                                        break;
                                    case 'b':
                                        goto x;
                                }
                            }
                        x:
                            break;
                        case 'b':
                            break;
                        default:
                            Console.WriteLine("Unknown option!");
                            break;
                    }

                    break;
                case 'b':
                    break;
                default:
                    Console.WriteLine("Unknown option!");
                    break;

            }



        }

    }

}
