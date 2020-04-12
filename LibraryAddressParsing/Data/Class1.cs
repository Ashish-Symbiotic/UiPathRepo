using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryAddress
{
    public class Class1
    {
        public  string Read(string addresses)
        {

            string zip = "", res = "";
            string street2 = "", street1 = "", state = "";
            // String[] addresses = { "1031 E 17TH ST Apt 13 <br> HIALEAH, FL 33010-3317", "MARTHA LEONARDSON \r\n 3n440 COULTER LN \r\n ST CHARLES, IL 60175", " 1159 PHEASANT RUN <br> QUAKERTOWN &nbsp <br>  PA 18951", " 8049 Gilleland Drive ,ROSEVILLE, CA 95747", "21802 ENCINO COMMONS ,SAN ANTONIO, TX 78259-2794", "7800 NW 5TH AVE APT 7E,MIAMI, FL 33150" };
            Console.WriteLine(addresses.Length);


            if (addresses.Contains("&nbsp"))
            {
                Console.WriteLine("Replacing the String");
                System.Text.RegularExpressions.Regex.Replace(addresses, @"&nbsp;", "", System.Text.RegularExpressions.RegexOptions.Multiline);
            }
            if (addresses.Contains("<br>"))
            {
                res = getAddress("<br>", addresses);
            }
            if (addresses.Contains("\r\n"))
            {
                res = getAddress("\r\n", addresses);
            }

            if (!(addresses.Contains("\r\n")) && !(addresses.Contains("<br>")))
            {
                state = "";
                street1 = "";
                street2 = "";
                Console.WriteLine("Entering in else");

                String[] newAddress = addresses.Split(',');

                int length = newAddress.Length;

                String[] CityMain = newAddress[length - 2].Split(',');

                string city = CityMain[CityMain.Length - 1];

                String[] zip1 = newAddress[length - 1].Split(' ');
                zip = zip1[zip1.Length - 1];
                state = zip1[1];

                String[] Lines = newAddress[0].Split(' ');

                for (int k = 0; k < Lines.Length; k++)
                {
                    if (Lines[k].Contains("APT") || Lines[k].Contains("Apt"))
                    {
                        street2 = Lines[k] + " " + Lines[k + 1];
                        Lines[k] = Lines[k + 1] = "";
                    }
                    else
                    {
                        street1 = street1 + " " + Lines[k];
                    }

                }
                Console.WriteLine("################");
                //city1 = city;
                res = city + zip + state + street1 + street2;
                Console.WriteLine("This is City {0} ", city);
                Console.WriteLine("This is zip {0} ", zip);
                Console.WriteLine("This is state {0} ", state);
                Console.WriteLine("This is street1 {0} ", street1);
                Console.WriteLine("This is Street2 {0} ", street2);
                Console.WriteLine("#######%%%%%%%%%");
                Console.WriteLine("Leaving Else");

            }
            Console.ReadLine();
            return res;
        }
        public  String getAddress(string delimeter, string data)
        {
            string zip = "", street1 = "", street2 = "", city = "", state = "";

            String[] first_array = System.Text.RegularExpressions.Regex.Split(data, delimeter);
            Console.WriteLine("##########");
            if (first_array.Length == 3)
            {
                if (first_array[first_array.Length - 1].Contains(','))
                {
                    String[] array_for_zip = first_array[first_array.Length - 1].Split(',');
                    String[] newArray = array_for_zip[array_for_zip.Length - 1].Split(' ');
                    zip = newArray[newArray.Length - 1];
                    state = newArray[1];
                    city = array_for_zip[0];
                    String[] Lines = first_array[1].Split(' ');

                    for (int k = 0; k < Lines.Length; k++)
                    {
                        if (Lines[k].Contains("APT") || Lines[k].Contains("Apt"))
                        {
                            street2 = Lines[k] + " " + Lines[k + 1];
                            Lines[k] = Lines[k + 1] = "";
                        }
                        else
                        {
                            street1 = street1 + " " + Lines[k];
                        }

                    }
                    street1 = first_array[0] + street1 + " ";

                }
                else
                {
                    string trimmed = first_array[first_array.Length - 1].Trim();
                    String[] newArray = trimmed.Split(' ');
                    zip = newArray[newArray.Length - 1];
                    state = newArray[newArray.Length - 2];
                    city = first_array[first_array.Length - 2];
                    String[] Lines = first_array[0].Split(' ');

                    for (int k = 0; k < Lines.Length; k++)
                    {
                        if (Lines[k].Contains("APT") || Lines[k].Contains("Apt"))
                        {
                            street2 = Lines[k] + " " + Lines[k + 1];
                            Lines[k] = Lines[k + 1] = "";
                        }
                        else
                        {
                            street1 = street1 + " " + Lines[k];
                        }

                    }


                }
            }

            if (first_array.Length == 2)
            {
                if (first_array[first_array.Length - 1].Contains(','))
                {
                    String[] array_for_zip = first_array[first_array.Length - 1].Split(',');
                    String[] newArray = array_for_zip[array_for_zip.Length - 1].Split(' ');
                    zip = newArray[newArray.Length - 1];
                    state = newArray[1];
                    city = array_for_zip[0];
                    String[] Lines = first_array[0].Split(' ');

                    for (int k = 0; k < Lines.Length; k++)
                    {
                        if (Lines[k].Contains("APT") || Lines[k].Contains("Apt"))
                        {
                            street2 = Lines[k] + " " + Lines[k + 1];
                            Lines[k] = Lines[k + 1] = "";
                        }
                        else
                        {
                            street1 = street1 + " " + Lines[k];
                        }

                    }


                }
                else
                {
                    string trimmed = first_array[first_array.Length - 1].Trim();
                    String[] newArray = trimmed.Split(' ');
                    zip = newArray[newArray.Length - 1];
                    state = newArray[newArray.Length - 2];
                    city = first_array[first_array.Length - 2];
                    String[] Lines = first_array[0].Split(' ');

                    for (int k = 0; k < Lines.Length; k++)
                    {
                        if (Lines[k].Contains("APT") || Lines[k].Contains("Apt"))
                        {
                            street2 = Lines[k] + " " + Lines[k + 1];
                            Lines[k] = Lines[k + 1] = "";
                        }
                        else
                        {
                            street1 = street1 + " " + Lines[k];
                        }

                    }


                }
            }
            Console.WriteLine("This is City {0} ", city);
            Console.WriteLine("This is zip {0} ", zip);
            Console.WriteLine("This is state {0} ", state);
            Console.WriteLine("This is street1 {0} ", street1);
            Console.WriteLine("This is Street2 {0} ", street2);
            Console.WriteLine("##########");
            return city + zip + state + street1 + street2;
        }
    }
}
