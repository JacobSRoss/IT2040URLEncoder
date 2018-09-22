using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT2040URLEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            String projectName = "";
            String activityName = "";
            String newProjectName = "";
            String newActivityName = "";
            Boolean restart = true;
            String answerString = "";

            while(restart == true){
                Console.WriteLine("Welcome to the URL Encoder!");
                Console.WriteLine("Project Name?: ");
                projectName = Console.ReadLine();
                Console.WriteLine("Activity Name?: ");
                activityName = Console.ReadLine();
                newProjectName = URLEncode(projectName);
                newActivityName = URLEncode(activityName);
                Console.WriteLine(newProjectName);
                Console.WriteLine(newActivityName);
                Console.WriteLine("Your URL is: ");
                Console.WriteLine("https://companyserver.com/content/"+newProjectName+"/files/"+newActivityName+"/"+newActivityName+"Report.pdf");
                Console.WriteLine("");
                while(restart){
                    Console.WriteLine("Would you like to create another URL? Please answer 'Yes' or 'No': ");
                    answerString = Console.ReadLine();
                    if(answerString == "No"){
                        restart = false;
                    } else if (answerString == "Yes"){
                        break;
                    }
                }
            }
        }
        public bool CheckControl(String str){
            return true;
        }
        static String URLEncode(String str){
           String URL = "";

            foreach(char c in str){
                switch(c){
                    case ' ':
                        URL += "%20";
                        break;
                    case '<':
                        URL += "%3C";
                        break;
                    case '>':
                        URL +="%3E";
                        break;
                    case '#':
                        URL +="%23";
                        break;
                    case '%':
                        URL +="%25";
                        break;
                    case '"':
                        URL +="%22";
                        break;
                    case ';':
                        URL +="%3B";
                        break;
                    case '/':
                        URL += "%2F";
                        break;
                    case '?':
                        URL +="%3F";
                        break;
                    case ':':
                        URL +="%3A";
                        break;
                    case '@':
                        URL +="%40";
                        break;
                    case '&':
                        URL +="%26";
                        break;
                    case '=':
                        URL +="%3D";
                        break;
                    case '+':
                        URL +="%2B";
                        break;
                    case '$':
                        URL +="%24";
                        break;
                    case ',':
                        URL +="%2C";
                        break;
                    case '{':
                        URL +="%7B";
                        break;
                    case '}':
                        URL +="%7D";
                        break;
                    case '|':
                        URL +="%7C";
                        break;
                    case '\\':
                        URL +="%5C";
                        break;
                    case '^':
                        URL +="%5E";
                        break;
                    case '[':
                        URL +="%5B";
                        break;
                    case ']':
                        URL +="%5D";
                        break;
                    case '`':
                        URL +="%60";
                        break;
                    default:
                        URL += c;
                        break;


                }
            }
            return URL;
        
        }
    }

    
    
    
}

