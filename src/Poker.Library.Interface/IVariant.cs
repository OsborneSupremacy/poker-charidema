﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Library.Interface;

public interface IVariant
{
    string Name { get; }

    List<IRoundAction> RoundActions { get; }
}