using System;
using System.Text;

namespace _12425TN_11225359_NguyenThienNhan_HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            string name, address, sSalary;
            Person[] Array_person;
            while (true)
            {
                try
                {
                    Console.Write("Number of people wishing to enter: ");
                    string number = Console.ReadLine();
                    if (number.Trim() == "")
                    {
                        Console.WriteLine("Invalid number, please re-enter.");
                        continue;
                    }
                    else
                    {
                        int test = int.Parse(number);
                        Array_person = new Person[test];
                        Console.Clear();
                        for (int i = 0; i < test; i++)
                        {
                            while (true)
                            {
                                Console.WriteLine("=====Management Person programer=====");
                                Console.WriteLine("Input Information of Person");
                                Console.Write("Please input name: ");
                                name = Console.ReadLine();
                                Console.Write("Please input address: ");
                                address = Console.ReadLine();
                                Console.Write("Please input salary: ");
                                sSalary = Console.ReadLine();

                                try
                                {
                                    Person p = new Person();
                                    Array_person[i] = p.inputPersonInfo(name, address, sSalary);
                                    break;
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }
                        }
                        try
                        {
                            Person sorter = new Person();
                            Array_person = sorter.sortBySalary(Array_person);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        Console.WriteLine("-------------------------------------------");
                        for (int i = 0; Array_person.Length > i; i++)
                        {
                            Person p = Array_person[i];
                            p.displayPersonInfo(Array_person[i]);
                            Console.WriteLine("");
                        }
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid number, please re-enter.");
                    continue;
                }
            }
        }

        class Person
        {
            private string name, address;
            private double salary;
            public Person()
            {
                name = "";
                address = "";
                salary = 0.0;
            }
            public Person(string name, string address, double salary)
            {
                this.name = name;
                this.address = address;
                this.salary = salary;
            }

            public Person inputPersonInfo(string name, string address, string sSalary)
            {
                string kt_name = name.Trim(), kt_address = address.Trim(), kt_sSalary = sSalary.Trim();
                if (kt_name == "")
                {
                    throw new Exception("You must input Name.");
                }
                else if (kt_address == "")
                {
                    throw new Exception("You must input Address.");
                }
                else if (kt_sSalary == "")
                {
                    throw new Exception("You must input Salary.");
                }
                else
                {
                    // Tách riêng việc kiểm tra số để không bị catch nhầm lỗi số âm
                    double kiemtra;
                    if (!double.TryParse(kt_sSalary, out kiemtra))
                    {
                        throw new Exception("You must input digit.");
                    }

                    if (kiemtra <= 0)
                    {
                        // Khớp chính xác thông báo lỗi của đề bài (không có dấu chấm ở cuối)
                        throw new Exception("Salary is greater than zero");
                    }

                    return new Person(kt_name, kt_address, kiemtra);
                }
            }
            public void displayPersonInfo(Person person)
            {
                Console.WriteLine("Information of Person you have entered:");
                Console.WriteLine($"Name:{person.name}");
                Console.WriteLine($"Address:{person.address}");
                Console.WriteLine($"Salary:{person.salary}");
            }
            public Person[] sortBySalary(Person[] person)
            {
                if (person == null)
                {
                    throw new Exception("Can't Sort Person");
                }
                int n = person.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (person[j].salary > person[j + 1].salary)
                        {
                            Person temp = person[j];
                            person[j] = person[j + 1];
                            person[j + 1] = temp;
                        }
                    }
                }
                return person;
            }
        }
    }
}