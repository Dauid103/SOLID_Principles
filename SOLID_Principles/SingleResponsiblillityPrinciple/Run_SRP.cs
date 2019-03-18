using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.SingleResponsiblillityPrinciple
{
    public class Run_SRP
    {

        public static void Run()
        {
            var report = new WorkReport();

            report.AddEntry(new WorkReportEntry { ProjectCode = "12345", ProjectName = "Project1", SpentHours = 8 });
            report.AddEntry(new WorkReportEntry { ProjectCode = "67890", ProjectName = "Project2", SpentHours = 32 });


            var scheduler = new Scheduler();

            scheduler.AddEntry(new ScheduleTask { TaskId = 1, Content = "Content for TaskId 1", ExecuteOn = DateTime.Now.AddDays(5) });
            scheduler.AddEntry(new ScheduleTask { TaskId = 1, Content = "Content for TaskId 1", ExecuteOn = DateTime.Now.AddDays(5) });

            Console.WriteLine(report.ToString());
            Console.WriteLine(scheduler.ToString());

            var saver = new SaveFile();
            saver.SaveToFile(@"Reports", "WorkReport.txt", report);
            saver.SaveToFile(@"Schedulers", "Schedule.txt", scheduler);

            Console.Read();
        }

    }
}
