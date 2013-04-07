using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace TestingSignalR.MyTest
{
    public class MyTestHub : Hub
    {
        public void Test(string message) {

            //Clients.Others.messageSended(string message);

        }
    }
}