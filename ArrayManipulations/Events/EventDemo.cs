using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulations.Events
{
    public class Publisher
    {
        //Create a delegate for event
        public delegate void HandleEvent(string args);

        //create an event
        public event HandleEvent OnDoSomethig;
        public virtual void RaiseEvent()
        {
            OnDoSomethig("The event is raised");
        }
    }

    public class Subscriber
    {
        Publisher publisher = new Publisher();

        public void Manage()
        {
            //registering the event
            publisher.OnDoSomethig += OnDoSomethig;

            publisher.RaiseEvent();
        }

        private void OnDoSomethig(string args)
        {
            Console.WriteLine(args);
        }
    }
    internal class EventDemo
    {

        public static void Mainxxx(string[] args)
        {
            var s1 = new Subscriber();
            s1.Manage();
            
            Console.ReadKey();
        }

    }
}
