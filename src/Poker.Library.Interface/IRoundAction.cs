using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Library.Interface;

public interface IRoundAction
{
    bool GameCanEndAfter { get; }
}
