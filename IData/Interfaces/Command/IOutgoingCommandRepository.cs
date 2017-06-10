﻿using Crud.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IData.Interfaces.Command
{
    public interface IOutGoingCommandRepository
    {
        void AddEditOutgoing(Outgoing outgoing);
        void DeleteOutgoing(int id);
    }
}
