using CommandPattern.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class RemoteController
    {
        private TVCommand _displayCmd;
        private TVCommand _moveNextCmd;
        private TVCommand _movePreCmd;

        public RemoteController(TVCommand displayCommand,
            TVCommand moveNextCommand, TVCommand movePreCommand)
        {
            this._displayCmd = displayCommand;
            this._moveNextCmd = moveNextCommand;
            this._movePreCmd = movePreCommand;
        }

        public void Display()
        {
            _displayCmd.Execute();
        }

        public void MoveNextChannel()
        {
            _moveNextCmd.Execute();
        }

        public void MovePreviousChannel()
        {
            _movePreCmd.Execute();
        }
    }
}
