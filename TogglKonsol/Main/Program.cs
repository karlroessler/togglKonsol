using System;
using System.Collections.Generic;
using TogglKonsolDate;

namespace TogglKonsol
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadCommandLineArguments readCommandLineArguments = new ReadCommandLineArguments(
                checkDateExist: new CheckDateExist());
            bool help = readCommandLineArguments.ReadHelp(args);
            bool entries = readCommandLineArguments.ReadEntries(args);
            string write = readCommandLineArguments.ReadWrite(args);
            DateTime startDate = readCommandLineArguments.ReadStartDate(args);
            DateTime endDate = readCommandLineArguments.ReadEndDate(args);
            string timearea = readCommandLineArguments.ReadTimeArea(args);

            ConvertTimeAreaWord convertTimeAreaWord= new ConvertTimeAreaWord(
                dateTimeHelper: new DateTimeHelper());




            ReadListApiKey readListApiKey = new ReadListApiKey(
               readJsonData: new ReadJsonData(),
               convertJsonToList: new ConvertJsonStringToListUsers()
               );
            List<Users> userlist = readListApiKey.Execute();

            if (args.Length == 0)
            {
                WriteUserApiKeyConsol writeUserApiKeyConsol = new WriteUserApiKeyConsol(
                   formatTextForConsol: new FormatUserTextForConsol(),
                   writeConsol: new WriteConsol()
                   );
                writeUserApiKeyConsol.WriteConsol(userlist);
            }

            if (timearea != null)
            {
                TimeDate date = convertTimeAreaWord.ConvertTimeAreaWordToTimeArea(timearea);
                startDate = date.StartDate;
                endDate = date.EndDate;
            }


            if (help == true)
            {
                WriteHelpConsol writeHelpConsol = new WriteHelpConsol(
                    formatHelpTextForConsol: new FormatHelpTextForConsol(),
                    writeConsol: new WriteConsol());
                writeHelpConsol.WriteHelp();
            }
            

            if (entries == true)
            {
                ReadAllDataFromAllUsers readAllDataFromAllUsers = new ReadAllDataFromAllUsers(
                getConnectionToggl: new GetConnectionToggl()
                );
                List<Item> allInfoList = readAllDataFromAllUsers.ReadAll(userlist);

                ReadAllTime_Entries readAllTime_Entries = new ReadAllTime_Entries(
                    getConnectionToggl: new GetConnectionToggl()
                    );
                List<Time_entriesItem> timeList = readAllTime_Entries.ReadAll(userlist, startDate: startDate, endDate: endDate);

                ReadAllProjects readAllProjects = new ReadAllProjects(
                    getConnectionToggl: new GetConnectionToggl()
                    );
                List<ProjectsItem> projectsList = readAllProjects.ReadAll(userlist, timeList);

                ReadAllClients readAllClients = new ReadAllClients(
                    getConnectionToggl: new GetConnectionToggl()
                    );
                List<ClientsItem> clientsList = readAllClients.ReadClients(userlist, projectsList);

                if (write != null)
                {
                    WriteAllDataFromAllUserCSVFile writeAllDataFromAllUserCSVFile = new WriteAllDataFromAllUserCSVFile(
                    convertListToCSV: new ConvertListToCSV(),
                    writeFile: new WriteFile(),
                    writeConsol: new WriteConsol());
                    writeAllDataFromAllUserCSVFile.SaveData(allInfoList, timeList, projectsList, clientsList, write);
                }
                else
                {
                    WriteTime_EntriesConsol writeTime_EntriesConsol = new WriteTime_EntriesConsol(
                        formatTime_EntriesForConsol: new FormatTime_EntriesForConsol(),
                        writeConsol: new WriteConsol());
                    writeTime_EntriesConsol.WriteTime(timeList);
                }
            }
            Console.ReadLine();
        }

    }
}
