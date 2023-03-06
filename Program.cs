using NLog;

 // See https://aka.ms/new-console-template for more information
 string path = Directory.GetCurrentDirectory() + "//nlog.config";

 // create instance of Logger
 var logger = LogManager.LoadConfiguration(path).GetCurrentClassLogger();
 logger.Info("Program started");

string file = "tickets.csv";
string choice;
bool addTicket = false;

StreamWriter sw0 = new StreamWriter(file);
sw0.WriteLine("TicketID, Summary, Status, Priority, Assigned, Submitter, Watching");
sw0.Close();
