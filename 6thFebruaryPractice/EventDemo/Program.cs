using System;

namespace EventDemo
{
    public class Program
    {
        public static void Main()
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            // register with an event
            bl.ProcessCompleted += b2_ProcessCompleted;
            bl.ProcessCompleted += bl_ProcessCompleted;
            bl.ProcessStarted += b3_ProcessStarted;
            bl.ProcessStarted += bl_ProcessCompleted;
            bl.StartProcess();
            //deregistering events
            bl.ProcessStarted -= bl_ProcessCompleted;
            bl.ProcessCompleted -= b2_ProcessCompleted;
            bl.StartProcess();
            Console.ReadLine();
        }

        // event handlers
        public static void bl_ProcessCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Inside bl, Process Completed!");
        }

        public static void b2_ProcessCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Inside b2, Process Completed");
        }

        public static void b3_ProcessStarted(object sender, int[] num)
        {
            Console.WriteLine("Process started in B3 and nums are : ");
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
        }
        public static void bl_ProcessCompleted(object sender, int[] num)
        {
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Process Completed!");
        }

    }

    public class ProcessBusinessLogic
    {
        public event EventHandler ProcessCompleted; // event
        public event EventHandler<int[] > ProcessStarted; //event which takes int array
        public event EventHandler Process = null; //null event


        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
           
            try
            {
                //Creating int array
                int[] num = { 10, 20, 30, 40 };
                //Sending int array as arg
                OnProcessStarted(num);
            } catch (Exception e)
            {
                Console.WriteLine("Exception e: " + e.Message);
            }
            OnProcessCompleted(EventArgs.Empty);

        }


        protected virtual void OnProcessCompleted(EventArgs e)
        {
            //The statmenet ProcessCompleted?.Invoke(this,e)
            if(ProcessCompleted != null)
            {
                ProcessCompleted.Invoke(this, e);
            }
            else
            {
                Console.WriteLine("ProcessCompleted is null");
            }
            try
            {
                //If process is not defined or null, then it throws error,
                //which is why we check if it's null using ?(nullable) operator
                Process.Invoke(this, e); 
            }
            catch(Exception exp)
            {
                Console.WriteLine("Exception at Process: " + exp.Message);
            }

        }

        protected virtual void OnProcessStarted(int[] num)
        {
          
            ProcessStarted?.Invoke(this, num);

        }
    }
}