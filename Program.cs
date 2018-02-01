using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CodeCamp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bai1();
            //Bai2();
            Bai3();
        }

        static void Bai1()
        {
            Random random = new Random();
            int value = random.Next(-100, 100);
            int guess =0;
            int count = 1;
            Console.WriteLine("Hay doan mot so trong khoang -100 va 100");
            
            while(guess != value)
            {
                Console.WriteLine("Hay doan 1 so bat ki");
                try {
                    guess = Convert.ToInt32(Console.ReadLine());
                    if (guess < value)
                    {
                        Console.WriteLine("So ban doan nho hon so can tim. Hay doan lai");
                        count++;
                    } else if (guess > value)
                        {
                            Console.WriteLine("So ban doan lon hon so can tim. Hay doan lai");
                            count++;
                        }

                    
                }
                catch (System.FormatException) {
                    Console.WriteLine("Ban chi duoc nhap vao 1 so. Hay choi lai game va doan mot so khac");
                    break;
                }
                
                if (guess == value)
                {
                    Console.WriteLine ("Ban da doan dung voi {0} luot doan. So chinh xac la {1}",count, value);
                    break;
                }

            }       
        }


        static void Bai3()
        {
            Console.WriteLine("Ban muon nhap mot mang co bao nhieu so");
            int input = Convert.ToInt32(Console.ReadLine());
           
            int[] arr = new int[input];
            string output= "";
            int i;
            for (i=0; i< input; i++)
            {
                Console.WriteLine("Nhap so");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                output += arr[i] + " ";
               
            }
            Console.WriteLine("Mang da nhap la {0}", output);
            string check=" ";
            if(arr[0] < arr[1])
            {
                for (int k=0; k<arr.Length-1; k++)
                {
                    if (arr[k] +1 == arr[k+1])
                    {
                        
                        check = "Day la day so lien tiep";
                    } else {
                        check = "Day khong phai la chuoi so lien tiep";
                        break;
                    }
                    
                }
            } else {
                for (int j=0; j<arr.Length-1; j++)
                {
                    if (arr[j] -1 == arr[j+1])
                    {
                        check = "Day la day so lien tiep";
            
                    } else {
                        check = "Day khong phai la chuoi so lien tiep";
                        break;
                    }
                }
            }
            System.Console.WriteLine(check);
        
        }

        
    }
}
