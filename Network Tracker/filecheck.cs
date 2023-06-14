using System;
using System.Diagnostics;
using System.IO;

namespace Network_King
{
    class filecheck
    {


        public void CheckDir(string config,string ipsearch,string logs)
        {
            a:if(Directory.Exists(config))
            {
                b:if (Directory.Exists(ipsearch))
                {
                    c:if(Directory.Exists(logs))
                    {

                    }
                    else
                    {
                        Directory.CreateDirectory(logs);
                        goto c;
                    }                       
                }
                else
                {
                    Directory.CreateDirectory(ipsearch);
                    goto b;
                }
            }
            else
            {
                Directory.CreateDirectory(config);
                goto a;
            }
        }



        public void CheckFile(string file)
        {
            a:if(File.Exists(file))
            {

            }
            else
            {
                StreamWriter sw = new StreamWriter(file);
                sw.WriteLine("0");
                sw.Flush();
                sw.Close();
                goto a;
            }
        }
    }
}
