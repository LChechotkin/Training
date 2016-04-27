using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson12_WhiteBlack_List
{
   public  class ReadWriteFile
    {

       public HashSet<string> ReadFile(string filePath)
       {
           HashSet<string> tmpHashSet = new HashSet<string>();
           string line;
           

           using (StreamReader tmpFile = new StreamReader(filePath))
           {
               
               while ((line = tmpFile.ReadLine()) != null)
               {
                   tmpHashSet.Add(line);
                   
               }
           }
           
           return tmpHashSet;
       }

       public void WriteFile(HashSet<string> hashSetFile, string outputfile)
       {
           
              using (StreamWriter writer = new StreamWriter (outputfile))

                {
                  foreach (string inline in hashSetFile)
                    {
                        writer.WriteLine(inline);

                    }

                }
                        
       }

       public void PrintFile(string filePath)
       {
           HashSet<string> tmpHashSet = new HashSet<string>();
           string line;
           Console.WriteLine(filePath+":");

           using (StreamReader tmpFile = new StreamReader(@filePath))
           {

               while ((line = tmpFile.ReadLine()) != null)
               {
                   Console.WriteLine(line);

               }
           }

       }


    } 


    class FilteringMethods : ReadWriteFile
    {
     
      public void WhiteFilter(string inputfile, string outputfile, string whitelist)
            {
                
                HashSet<string> inputHSet = new HashSet<string>();
                HashSet<string> outputHSet = new HashSet<string>();
                HashSet<string> whiteList = new HashSet<string>();
                
          //Read content from files to HashSets

                inputHSet = ReadFile(inputfile);
                whiteList= ReadFile(whitelist);
            
          // Compare WhiteList with InputFile and add to output HSet if need
            
                foreach (string inline in inputHSet)
                {
                    foreach (string wline in whiteList)  
                    {
                        if (wline==inline)
                        {
                            outputHSet.Add(inline);
                            break;
                        }
                    }
                }
                WriteFile(outputHSet, outputfile);

            }


      public void BlackFilter(string inputfile, string outputfile, string blacklist)
            {


                HashSet<string> inputHSet = new HashSet<string>();
                HashSet<string> outputHSet = new HashSet<string>();
                HashSet<string> blackList = new HashSet<string>();

                //Read content from files to HashSets

                inputHSet = ReadFile(inputfile);
                blackList = ReadFile(blacklist);

                // Compare BlackList with InputFile
                foreach (string inline in inputHSet)
                {
                    bool passed = true;
                  
                    foreach (string bline in blackList)
                    {
                        if (bline == inline)
                        {
                            passed=false;
                            break;
                        }
                    }
                    // if passed=True -> add value to output HSet
                    if (passed)
                    {
                        outputHSet.Add(inline);

                    }
                }

                WriteFile(outputHSet, outputfile);

            }

        

        }

       
}
