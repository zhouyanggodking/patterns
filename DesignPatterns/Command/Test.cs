using CommandPattern.Commands;
using CommandPattern.Factory;
using CommandPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    class Test
    {
        static void Main(string[] args)
        {
            TV sonyTV = new SonyTVFactory().Create();

            TVCommand disCmd = new DisplayCommand(sonyTV);
            TVCommand moveNextCmd = new MoveNextCommand(sonyTV);
            TVCommand movePreCmd = new MovePreviousCommand(sonyTV);

            TV philipsTv = new PhilipsTVFactory().Create();
            TVCommand movePreCmd_philips = new MovePreviousCommand(philipsTv);

            RemoteController rc = new RemoteController(disCmd, moveNextCmd, movePreCmd_philips);

            rc.Display();
            rc.MoveNextChannel();
            rc.MovePreviousChannel();
        }
    }
}
